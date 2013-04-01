using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DevComponents.Schedule.Model;
using DevComponents.DotNetBar.SuperGrid;
using Control_Aulas_UAM.Clases;
using Control_Aulas_UAM.Clases.Db;

namespace Control_Aulas_UAM
{
    public partial class AsignacionMultipleControl : UserControl,Funciones
    {
        DevComponents.DotNetBar.Controls.CheckBoxX[] checkBoxGroup;
        public List<Asignacion> Asignaciones { get { return asignaciones.ToList<Asignacion>(); }  }
        public List<Serie> Series { get { return series; } }
        SortableBindingList<Asignacion> asignaciones;
        List<Asignatura> asignaturas;
        List<Grupo> grupos;
        List<Aula> aulas;
        List<PeriodoTiempo> fechas;
        List<Serie> series;
        Conexion conexion;

        public AsignacionMultipleControl()
        {
            InitializeComponent();
            checkBoxGroup = new DevComponents.DotNetBar.Controls.CheckBoxX[7];
            checkBoxGroup[0] = checkBoxDomingo;
            checkBoxGroup[1] = checkBoxLunes;
            checkBoxGroup[2] = checkBoxMartes;
            checkBoxGroup[3] = checkBoxMiercoles;
            checkBoxGroup[4] = checkBoxJueves;
            checkBoxGroup[5] = checkBoxViernes;
            checkBoxGroup[6] = checkBoxSabado;
            Clear();
            this.customValidatorValidateGrupo.ValidateValue+=customValidatorValidateGrupo_ValidateValue;
            superValidator.Validate();
        }

        public void Clear() {
            try
            {
            comboBoxAsignacion.SelectedIndex = 0;
            radioButtonRepeticiones.Checked = true;
            checkBoxRepetir.Checked = false;
            asignaciones = new SortableBindingList<Asignacion>();
            //fechas = new SortableBindingList<PeriodoTiempo>();
            //dataGridViewFechas.DataSource = fechas;
            dataGridViewFechas.AutoGenerateColumns = false;
            dataGridViewFechas.DataSource = asignaciones;
            series = new List<Serie>();
                conexion = new Conexion();
                if (asignaturas == null)
                {
                    asignaturas = conexion.getAsignaturasConGrupo();
                    comboBoxAsignatura.DataSource = asignaturas;
                    comboBoxAsignatura.DisplayMember = "Nombre";
                    comboBoxAsignatura.ValueMember = "Id";
                }
                aulas = conexion.getAulas();
                comboBoxTipoUso.DataSource = conexion.getAulaTipoUso();
                comboBoxTipoUso.DisplayMember = "Descripcion";
                comboBoxTipoUso.ValueMember = "Id";
                comboBoxAula.DataSource = aulas;
                comboBoxAula.DisplayMember = "referencia";
                comboBoxAula.ValueMember = "Id";
                comboBoxAula.AutoCompleteSource = AutoCompleteSource.ListItems;
                DateTime now=DateTime.Now;
                DateTime inicialDate = new DateTime(now.Year, now.Month, now.Day, 8, 0, 0);
                setInitialDates(inicialDate,inicialDate.AddHours(2));
            }
            catch { }
        }

        private void dateTimeInput_ValueChanged(object sender, EventArgs e)
        {
            DateTime inicio=dateTimeInputInicio.Value;
            DateTime fin=dateTimeInputFin.Value;
            if (DateTime.Compare(inicio,fin)==-1)
            {
                TimeSpan offset = fin.Subtract(inicio) ;
                String text="Duración: ";
                if (offset.Days > 0)
                    text += offset.Days+" dias ";
                if (offset.Hours > 0)
                    text += offset.Hours + " horas ";
                if (offset.Minutes > 0)
                    text += " " + offset.Minutes + " minutos ";
                labelTiempo.Text = text;
            }
            /*else {
                fin = inicio.AddHours(1);
                dateTimeInputFin.Value = fin;
            }*/
            if (dateTimeInputFinRepeticiones.Value<fin) {
                dateTimeInputFinRepeticiones.Value = fin.AddMinutes(1);
            }
            superValidator.Validate();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (superValidator.Validate())
            {
                if (dateTimeInputInicio.Value < dateTimeInputFin.Value)
                    try
                    {
                        if (checkBoxRepetir.Checked)
                        {
                            DateTime inicio = dateTimeInputInicio.Value;
                            DateTime fin = dateTimeInputFin.Value;
                            bool finalizar = false;
                            DateTime currentDateTime = inicio;
                            int i = 0;
                            Serie serie = null;
                            if (checkBoxAgruparSerie.Checked) {
                                serie = new Serie();
                                serie.Descripcion = textBoxTituloSerie.Text;
                                series.Add(serie);
                            }
                            do
                            {
                                int currentDay = (int)currentDateTime.DayOfWeek;

                                if (checkBoxGroup[currentDay].Checked)
                                {
                                    Asignacion asignacion = createAsignacion();
                                    asignacion.Inicio=currentDateTime;
                                    asignacion.Fin=fin.AddDays(currentDateTime.Subtract(inicio).Days);
                                    
                                    asignacion.Serie = serie;
                                    
                                    asignaciones.Add(asignacion);

                                    
                                    //PeriodoTiempo dateRange = new PeriodoTiempo();
                                    //dateRange.Inicio = currentDateTime;
                                    //dateRange.Fin = fin.AddDays(currentDateTime.Subtract(inicio).Days);
                                    //fechas.Add(dateRange);
                                    i++;
                                }
                                if (radioButtonFecha.Checked)
                                {
                                    if (currentDateTime.Date >= dateTimeInputFinRepeticiones.Value.Date)
                                       finalizar = true;
                                }
                                else
                                {
                                    if (i > integerInputRepeticiones.Value - 1)
                                        finalizar = true;
                                }
                                currentDateTime = currentDateTime.AddDays(1);
                            } while (!finalizar);
                        }
                        else{
                            Asignacion asignacion = createAsignacion();
                            asignacion.Inicio = dateTimeInputInicio.Value;
                            asignacion.Fin = dateTimeInputFin.Value;
                            asignaciones.Add(asignacion);
                            //PeriodoTiempo dateRange = new PeriodoTiempo();
                            //dateRange.Inicio = dateTimeInputInicio.Value;
                            //dateRange.Fin = dateTimeInputFin.Value;
                            //fechas.Add(dateRange);
                        }
                        if (asignaciones.Count > 0)
                            buttonLimpiar.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        if (asignaciones.Count < 1)
                            buttonLimpiar.Visible = false;
                    }
                dataGridViewFechas.Sort(dataGridViewFechas.Columns[ColumnInicio.Index], ListSortDirection.Ascending);
            }
        }

        private Asignacion createAsignacion() {
            Asignacion asignacion = null;
            if (comboBoxAsignacion.SelectedIndex == 0)
            {
                AsignacionClase asignacionClase = new AsignacionClase();
                asignacionClase.Grupo = (Grupo)comboBoxGrupo.SelectedItem;
                asignacion = asignacionClase;
            }
            else
            {
                AsignacionVarios asignacionVarios = new AsignacionVarios();
                asignacionVarios.TipoUso = (AulaTipoUso)comboBoxTipoUso.SelectedItem;
                asignacionVarios.Observaciones = textBoxObservaciones.Text;
                asignacion = asignacionVarios;
            }
            asignacion.Aula = (Aula)comboBoxAula.SelectedItem;
            return asignacion;
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            asignaciones.Clear();
        }

        private void checkBoxRepetir_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = checkBoxRepetir.Checked;
            checkBoxLunes.Enabled = isChecked;
            checkBoxMartes.Enabled = isChecked;
            checkBoxMiercoles.Enabled = isChecked;
            checkBoxJueves.Enabled = isChecked;
            checkBoxViernes.Enabled = isChecked;
            checkBoxSabado.Enabled = isChecked;
            checkBoxDomingo.Enabled = isChecked;
            radioButtonRepeticiones.Enabled = isChecked;
            radioButtonFecha.Enabled = isChecked;
            if (isChecked)
            {
                integerInputRepeticiones.Enabled = radioButtonRepeticiones.Checked;
                dateTimeInputFinRepeticiones.Enabled = radioButtonFecha.Checked;
            }
            else {
                integerInputRepeticiones.Enabled = isChecked;
                dateTimeInputFinRepeticiones.Enabled = isChecked;
            }
        }

        private void comboBoxAsignacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            superTabControlAsignacion.SelectedTabIndex = comboBoxAsignacion.SelectedIndex;
            asignarNombreSerie();
        }

        private void radioButtonRepeticiones_CheckedChanged(object sender, EventArgs e)
        {
            integerInputRepeticiones.Enabled = radioButtonRepeticiones.Checked;
        }

        private void radioButtonFecha_CheckedChanged(object sender, EventArgs e)
        {
            dateTimeInputFinRepeticiones.Enabled = radioButtonFecha.Checked;
        }

        private void customValidatorDateValid_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            bool isValid=false;
            if (checkBoxRepetir.Checked && radioButtonFecha.Checked)
            {
                if (dateTimeInputInicio.Value < dateTimeInputFinRepeticiones.Value)
                    isValid = true;
            }
            else
                isValid = true;
            e.IsValid = isValid;
        }

        private void customValidatorDiasSeleccionados_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            bool isValid = false;
            if (checkBoxRepetir.Checked)
            {
                for (int i = 0; i < checkBoxGroup.Length && !isValid; i++)
                {
                    if (checkBoxGroup[i].Checked)
                        isValid = true;
                }
            }
            else
                isValid = true;
            e.IsValid = isValid;
        }


        void customValidatorValidateGrupo_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            bool isValid = false;
            if (comboBoxAsignacion.SelectedIndex == 0)
            {
                Grupo grupo = (Grupo)comboBoxGrupo.SelectedItem;
                if (grupo != null)
                {
                    isValid = true;
                }
            }
            else {
                isValid = true;
            }
            e.IsValid = isValid;
        }

        private void comboBoxAsignatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*grupos = conexion.getGrupos((Asignatura)comboBoxAsignatura.SelectedItem);
            comboBoxGrupo.DataSource = grupos;
            comboBoxGrupo.DisplayMember = "NumeroGrupo";
            comboBoxGrupo.ValueMember = "Id";
            asignarNombreSerie();
            superValidator.Validate();*/
            superValidator.Validate();
            handleGrupos();
        }


        public List<Asignacion> Aceptar() { 
            int tipoAsignacion=comboBoxAsignacion.SelectedIndex;
            List<Asignacion> asignaciones=new List<Asignacion>();
            foreach (PeriodoTiempo periodoTiempo in fechas)
            {
                Asignacion asignacion = new Asignacion();
                switch (tipoAsignacion)
                {
                    case 0:
                        {
                            AsignacionClase asignacionClase = new AsignacionClase();
                            asignacionClase.Grupo = (Grupo)comboBoxGrupo.SelectedItem;
                            asignacion=asignacionClase;
                        } break;
                    case 1:
                        {
                            AsignacionVarios asignacionVarios = new AsignacionVarios();
                            asignacionVarios.TipoUso = (AulaTipoUso)comboBoxTipoUso.SelectedItem;
                            asignacionVarios.Observaciones = textBoxObservaciones.Text;
                            asignacion = asignacionVarios;
                        } break;
                }
                asignacion.Inicio = periodoTiempo.Inicio;
                asignacion.Fin = periodoTiempo.Fin;
                asignacion.Aula = (Aula)comboBoxAula.SelectedItem;
                asignaciones.Add(asignacion);
            }
            return asignaciones;
        }


        public bool setInitialDates(DateTime inicio, DateTime fin) {
            bool done = false;
            if (fin < inicio)
            {
                fin = inicio.AddHours(2);
            }
            this.dateTimeInputInicio.Value = inicio;
            this.dateTimeInputFin.Value = fin;
            return done;
        }

        public void Nuevo()
        {
            Clear();
            EnableToEdit(true);
        }

        public void Imprimir()
        {
        }

        public bool Guardar()
        {
            bool guardado = false;
            if (asignaciones != null)
            {
                if (asignaciones.Count > 0)
                {
                    if(asignaciones.ToList<Asignacion>().FindAll(element => element.Aula == null).Count>0)
                    {
                        MessageBox.Show("Ha ocurrido un error:\nLas asignaciones deben de estar asignadas un aula.");
                    }
                    else
                    {
                        try
                        {
                            List<Serie> insertedSeries = new List<Serie>();
                            for (int i = 0; i < series.Count; i++) {
                                if (asignaciones.ToList().FindAll(element => element.SerieDescripcion == series[i].Descripcion).Count > 0)
                                {
                                    Serie serie = series[i];
                                    conexion.insertSerie(ref serie);
                                    insertedSeries.Add(serie);
                                }
                            }

                            for (int i = 0; i < asignaciones.Count; i++)
                            {
                                Asignacion asignacion = asignaciones[i];
                                asignacion.Serie = insertedSeries.Find(element => element.Descripcion == asignacion.SerieDescripcion);
                                conexion.insertAsignacion(ref asignacion);
                            }
                            MessageBox.Show("Las asignaciones fueron guardadas correctamente");
                            guardado = true;
                            Clear();
                        }
                        catch
                        {
                            MessageBox.Show("Ha ocurrido un error al intentar agregar las asignaciones");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay ninguna asignacion que guardar");
                }
            }
            EnableToEdit(false);
            return guardado;
        }

        public void Cancelar()
        {
            Clear();
            EnableToEdit(false);
        }

        public void Editar()
        {
            Clear();
            EnableToEdit(true);
        }

        void EnableToEdit(Boolean enable) {
            comboBoxAula.Enabled = enable;
            dateTimeInputInicio.Enabled = enable;
            dateTimeInputFin.Enabled = enable;
            checkBoxRepetir.Enabled = enable;
            if (!enable)
            {
                checkBoxRepetir.Checked = enable;
                checkBoxAgruparSerie.Checked = enable;
            }
            buttonAdd.Enabled = enable;
            buttonLimpiar.Enabled = enable;
            checkBoxAgruparSerie.Enabled = enable;
            comboBoxAsignatura.Enabled = enable;
            comboBoxAsignacion.Enabled = enable;
            comboBoxAsignatura.Enabled = enable;
            comboBoxGrupo.Enabled = enable;
            comboBoxTipoUso.Enabled = enable;
            textBoxObservaciones.Enabled = enable;
        }

        public void Borrar()
        {
        }

        public void IrPrimero()
        {
        }

        public void Anterior()
        {
        }

        public void Siguiente()
        {
        }

        public void IrFinal()
        {
        }

        public bool vacio()
        {
            return false;
        }

        public void Reportes()
        {
        }

        public void RealizarPago()
        {
        }

        public void Filtrar()
        {
        }

        private void checkBoxAgruparSerie_CheckedChanged(object sender, EventArgs e)
        {
            textBoxTituloSerie.Enabled = true;
            asignarNombreSerie();
        }

        private void asignarNombreSerie() {
            if (checkBoxAgruparSerie.Checked)
            {
                if (comboBoxAsignacion.SelectedIndex == 0)
                {
                    Grupo grupo = ((Grupo)comboBoxGrupo.SelectedItem);
                    if (grupo != null)
                    {
                        textBoxTituloSerie.Text = " P:" + grupo.Periodo.Descripcion + " A:" + grupo.Asignatura.Nombre + " G:" + grupo.NumeroGrupo;
                    }
                }
            }
            else {
                textBoxTituloSerie.Clear();
            }
        }

        private void comboBoxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            asignarNombreSerie();
            superValidator.Validate();
        }

        private void customValidator_Asignatura_Exists_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            try
            {
                String text = comboBoxAsignatura.Text;
                Asignatura foundAsignatura = asignaturas.Find(element => element.Nombre.Equals(text) || element.NombreCompleto.Equals(text));
                if (foundAsignatura != null)
                {
                    e.IsValid = true;
                }
                else
                {
                    e.IsValid = false;
                }
            }
            catch (Exception ex) { }
        }

        private void handleGrupos()
        {
            Asignatura asignatura = (Asignatura)comboBoxAsignatura.SelectedItem;
            if (asignatura != null)
            {
                grupos = conexion.getGrupos(asignatura);
                comboBoxGrupo.DataSource = grupos;
                comboBoxGrupo.DisplayMember = "NumeroGrupo";
            }
            else
            {
                grupos = null;
                comboBoxGrupo.DataSource = grupos;
            }
            handleDocente();
            superValidator.Validate();
        }

        void handleDocente()
        {
            String docente = "";
            Grupo grupo = (Grupo)comboBoxGrupo.SelectedItem;
            if (grupo != null ? grupo.Docente != null : false)
            {
                docente = grupo.Docente.Nombre;
            }
            textBoxDocente.Text = docente;
        }

        private void comboBoxAsignatura_Leave(object sender, EventArgs e)
        {
            superValidator.Validate();
            handleGrupos();
        }
    }
}
