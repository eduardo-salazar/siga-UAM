using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_Aulas_UAM.Clases;
using Control_Aulas_UAM.Clases.Db;
using DevComponents.DotNetBar.Controls;

namespace Control_Aulas_UAM
{
    public partial class MainCalendarViewControl : UserControl, Funciones
    {
        List<Aula> aulas;
        List<Asignatura> asignaturas;
        bool editing;
        Asignacion currentAsignacion;
        Usuario usuario;
        public Usuario Usuario { get { return usuario; } set { usuario = value; HandleEvents(); } }

        public MainCalendarViewControl()
        {
            InitializeComponent();
            calendarControl.OnBuscarClick += calendarControl_OnBuscarClick;
            calendarControl.OnNotificarClick += calendarControl_OnNotificarClick;
            HandleEvents();
            Conexion conexion = new Conexion();
            aulas=conexion.getAulas();
            asignaturas = conexion.getAsignaturasConGrupo();
            asignacionClaseControl.Aulas = aulas;
            asignacionVariosControl.Aulas = aulas; ;
            asignacionClaseControl.Asignaturas = asignaturas;
            calendarControl.AddAulas(aulas.ToArray());

            List<AsignacionVarios> asignacionesVarios = conexion.getAsignacionesVarios();
            foreach (AsignacionVarios asignacionVarios in asignacionesVarios) {
                calendarControl.calendarView.SelectedOwner = asignacionVarios.Aula.Referencia;
                calendarControl.AddAsignacion(asignacionVarios);
            }

            List<AsignacionClase> asignacionesClase = conexion.getAsignacionesClase();
            foreach (AsignacionClase asignacionClase in asignacionesClase)
            {
                calendarControl.calendarView.SelectedOwner = asignacionClase.Aula.Referencia;
                calendarControl.AddAsignacion(asignacionClase);
            }
            calendarControl.calendarView.SelectedView = DevComponents.DotNetBar.Schedule.eCalendarView.Week;
        }

        void HandleEvents() {
            bool readOnly = true ;
            if (usuario != null)
            {
                if (usuario.Admin)
                {
                    calendarControl.OnAgregarClick += calendarControl1_OnAgregarClick;
                    asignacionClaseControl.dateTimeInputInicio.ValueChanged += dateTimeInputInicio_ValueChanged;
                    asignacionClaseControl.dateTimeInputFin.ValueChanged += dateTimeInputFin_ValueChanged;
                    asignacionClaseControl.comboBoxLugar.SelectedIndexChanged += comboBoxLugar_SelectedIndexChanged;
                    asignacionVariosControl.dateTimeInputInicio.ValueChanged += dateTimeInputInicio_ValueChanged;
                    asignacionVariosControl.dateTimeInputFin.ValueChanged += dateTimeInputFin_ValueChanged;
                    asignacionVariosControl.comboBoxLugar.SelectedIndexChanged += comboBoxLugar_SelectedIndexChanged;
                    calendarControl.calendarView.DateSelectionStartChanged += calendarView_DateSelectionStartChanged;
                    calendarControl.calendarView.DateSelectionEndChanged += calendarView_DateSelectionEndChanged;
                    calendarControl.OnDeleteClick += calendarControl_OnDeleteClick;
                    calendarControl.OnReprogramadaCheckedChanged += calendarControl_OnReprogramadaCheckedChanged;
                    calendarControl.ReadOnly = false;
                    asignacionClaseControl.ReadOnly = false;
                    asignacionVariosControl.ReadOnly = false;
                    readOnly = false;
                }
                else {
                    expandablePanel1.Visible = false;
                }
            }
            asignacionVariosControl.ReadOnly = readOnly;
            asignacionClaseControl.ReadOnly = readOnly;
            buttonAceptar.Enabled = !readOnly;
            buttonAddSerie.Enabled = !readOnly;
            calendarControl.calendarView.SelectedOwnerChanged += calendarView_SelectedOwnerChanged;
            calendarControl.calendarView.DisplayedOwnersChanged += calendarView_DisplayedOwnersChanged;
            calendarControl.OnTabClick += calendarControl_OnTabClick;
            calendarControl.OnViewClick += calendarControl_OnContentClick;
            calendarControl.OnVerClick += calendarControl_OnVerClick;
        }

        void calendarControl_OnNotificarClick(object sender, EventArgs e)
        {
            NotificarForm notificarForm = new NotificarForm();
            notificarForm.controlNotificar1.Aula = calendarControl.SelectedAula;
            DateTime? inicio=calendarControl.calendarView.DateSelectionStart.Value;
            DateTime? fin = calendarControl.calendarView.DateSelectionEnd;
            if (inicio != null)
            {
                notificarForm.controlNotificar1.Inicio = inicio.Value;
            }
            if (fin != null)
            {
                notificarForm.controlNotificar1.Fin = fin.Value;
            }
            notificarForm.controlNotificar1.Usuario = this.Usuario;
            notificarForm.ShowDialog();
        }

        void calendarControl_OnBuscarClick(object sender, EventArgs e)
        {
            ShowFormBuscar();
        }

        void calendarControl_OnVerClick(object sender, EventArgs e)
        {
            bool reprogramada = false ;
            expandablePanel1.Visible = true;
            expandablePanel1.Expanded = true;
            editing = true;
            currentAsignacion = (Asignacion)sender;
            Aula currentAula=aulas.Find(element=>element.Id==currentAsignacion.Aula.Id);
            if (currentAsignacion is AsignacionClase)
            {
                AsignacionClase asignacionClase = (AsignacionClase)currentAsignacion;
                if (asignacionClase.Reprogramada)
                {
                    reprogramada = true;
                }
                comboBoxTipoAsignacion.SelectedIndex = 0;
                asignacionClaseControl.dateTimeInputInicio.Value = currentAsignacion.Inicio;
                asignacionClaseControl.dateTimeInputFin.Value = currentAsignacion.Fin;
                asignacionClaseControl.comboBoxLugar.SelectedItem = currentAula;
                asignacionClaseControl.comboBoxAsignatura.SelectedItem = asignaturas.Find(element => element.Id == asignacionClase.Grupo.Asignatura.Id);
            }
            else
            {
                AsignacionVarios asignacionVarios = (AsignacionVarios)currentAsignacion;
                comboBoxTipoAsignacion.SelectedIndex = 1;
                asignacionVariosControl.Inicio = currentAsignacion.Inicio;
                asignacionVariosControl.Fin = currentAsignacion.Fin;
                asignacionVariosControl.Aula = currentAula;
                asignacionVariosControl.TipoUso = asignacionVarios.TipoUso;
                asignacionVariosControl.Observaciones = asignacionVarios.Observaciones;

            }
            comboBoxTipoAsignacion.Enabled = false;
            if (!usuario.Admin || reprogramada)
            {
                asignacionClaseControl.ReadOnly = true;
            }
            else
            {
                asignacionClaseControl.ReadOnly = false;
            }
        }

        void calendarControl_OnDeleteClick(object sender, EventArgs e)
        {
            Asignacion asignacion = sender as Asignacion;
            Conexion conexion = new Conexion();
            conexion.borrarAsignacion(asignacion);
            MessageBox.Show("Asignacion Eliminada");
            //ButtonItem bi = sender as ButtonItem;
            //AppointmentView view = bi.Parent.Tag as AppointmentView;
            //if (view != null)
            //    calendarView1.CalendarModel.Appointments.Remove(view.Appointment);
        }

        void calendarControl_OnContentClick(object sender, EventArgs e)
        {
            if (editing) {
                expandablePanel1.Expanded = false;
            }

            if (usuario.Admin)
            {
                editing = false;
                asignacionClaseControl.ReadOnly = false;
                asignacionVariosControl.ReadOnly = false;
                if (((MouseEventArgs)e).Button != MouseButtons.Right)
                {
                    comboBoxTipoAsignacion.Enabled = true;
                }
                else
                {
                    comboBoxTipoAsignacion.Enabled = false;
                }
            }
            else
            {
                expandablePanel1.Expanded = false;
                expandablePanel1.Visible = false;
                asignacionClaseControl.ReadOnly = true;
                asignacionVariosControl.ReadOnly = true;
            }
        }

        void calendarControl_OnTabClick(object sender, EventArgs e)
        {
            expandablePanel1.Expanded = false;
        }

        void calendarView_DisplayedOwnersChanged(object sender, EventArgs e)
        {
            //expandablePanel1.Expanded = false;
        }

        void calendarView_SelectedOwnerChanged(object sender, DevComponents.DotNetBar.Schedule.SelectedOwnerChangedEventArgs e)
        {
            asignacionClaseControl.comboBoxLugar.SelectedItem = calendarControl.SelectedAula;
            asignacionVariosControl.comboBoxLugar.SelectedItem = calendarControl.SelectedAula;
        }

        void comboBoxLugar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Aula selectedAula = (Aula)((ComboBoxEx)sender).SelectedItem;
                DateTime? SelectionStart = calendarControl.calendarView.GetSelectedView().DateSelectionStart;
                DateTime? SelectionEnd = calendarControl.calendarView.GetSelectedView().DateSelectionEnd;
                calendarControl.calendarView.GetSelectedView().DateSelectionStart = null;
                calendarControl.calendarView.GetSelectedView().DateSelectionEnd = null;
                if (calendarControl.calendarView.DisplayedOwners.Contains(selectedAula.Referencia))
                {
                    calendarControl.calendarView.SelectedOwner = selectedAula.Referencia;
                }
                else
                {
                    calendarControl.calendarView.DisplayedOwners[calendarControl.calendarView.SelectedOwnerIndex] = selectedAula.Referencia;
                }
                calendarControl.calendarView.GetSelectedView().DateSelectionStart = SelectionStart;
                calendarControl.calendarView.GetSelectedView().DateSelectionEnd = SelectionEnd;
            }
            catch { }
            
        }

        void calendarView_DateSelectionEndChanged(object sender, DevComponents.DotNetBar.Schedule.DateSelectionEventArgs e)
        {
            try
            {
                asignacionClaseControl.Fin = calendarControl.calendarView.DateSelectionEnd.Value;
                asignacionVariosControl.Fin = calendarControl.calendarView.DateSelectionEnd.Value;
            }
            catch { }
        }

        void calendarView_DateSelectionStartChanged(object sender, DevComponents.DotNetBar.Schedule.DateSelectionEventArgs e)
        {
            try
            {
                asignacionClaseControl.Inicio = calendarControl.calendarView.DateSelectionStart.Value;
                asignacionVariosControl.Inicio = calendarControl.calendarView.DateSelectionStart.Value;
            }
            catch { }
        }

        void dateTimeInputFin_ValueChanged(object sender, EventArgs e)
        {
            DateTime fin=((DevComponents.Editors.DateTimeAdv.DateTimeInput)sender).Value;
            //calendarControl.calendarView.GetSelectedView().DateSelectionEnd = fin;
            calendarControl.calendarView.DateSelectionEnd = fin;
        }

        void dateTimeInputInicio_ValueChanged(object sender, EventArgs e)
        {
            DateTime inicio = ((DevComponents.Editors.DateTimeAdv.DateTimeInput)sender).Value;
            //calendarControl.calendarView.GetSelectedView().DateSelectionStart = inicio;
            calendarControl.calendarView.DateSelectionStart = inicio;
        }

        void calendarControl1_OnAgregarClick(object sender, EventArgs e)
        {
            expandablePanel1.Visible = true;
            expandablePanel1.Expanded = true;
            comboBoxTipoAsignacion.Enabled = true;
            DateTime inicio = calendarControl.calendarView.DateSelectionStart.Value;
            DateTime fin = calendarControl.calendarView.DateSelectionEnd.Value;
            asignacionClaseControl.Inicio = inicio;
            asignacionClaseControl.Fin = fin;
            asignacionVariosControl.Inicio = inicio;
            asignacionVariosControl.Fin = fin;
        }

        private void comboBoxExTipoAsignacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            superTabControl.SelectedTabIndex = comboBoxTipoAsignacion.SelectedIndex;
        }

        private void AsignacionSimpleControl_Load(object sender, EventArgs e)
        {
            comboBoxTipoAsignacion.SelectedIndex = 0;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            expandablePanel1.Expanded = false;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            int tipoAsignacion = comboBoxTipoAsignacion.SelectedIndex;
            DateTime oInicio = DateTime.Now; 
            DateTime oFin = DateTime.Now ;
            bool flag=false;
            switch (tipoAsignacion)
            {
                case 0:
                    {
                        if(asignacionClaseControl.ValidateControls()){
                            AsignacionClase asignacionClase;
                            if (!editing)
                            {
                                asignacionClase = new AsignacionClase();
                            }
                            else
                            {
                                asignacionClase = (AsignacionClase)currentAsignacion;
                            }
                            oInicio = asignacionClase.Inicio;
                            oFin = asignacionClase.Fin;
                            asignacionClase.Aula = asignacionClaseControl.Aula;
                            asignacionClase.Grupo = asignacionClaseControl.Grupo;
                            asignacionClase.Inicio = asignacionClaseControl.Inicio;
                            asignacionClase.Fin= asignacionClaseControl.Fin;
                            currentAsignacion = asignacionClase;
                            flag = true;
                        }
                    } break;
                case 1:
                    {
                        if(asignacionVariosControl.ValidateControls()){
                            AsignacionVarios asignacionVarios;
                            if (!editing)
                            {
                                asignacionVarios = new AsignacionVarios();
                            }
                            else {
                                asignacionVarios = (AsignacionVarios)currentAsignacion;
                            }
                            oInicio = asignacionVarios.Inicio;
                            oFin = asignacionVarios.Fin;
                            asignacionVarios.Aula = asignacionVariosControl.Aula;
                            asignacionVarios.TipoUso = asignacionVariosControl.TipoUso;
                            asignacionVarios.Observaciones = asignacionVariosControl.Observaciones;
                            asignacionVarios.Inicio = asignacionClaseControl.Inicio;
                            asignacionVarios.Fin = asignacionVariosControl.Fin;
                            currentAsignacion = asignacionVarios;
                            flag=true;
                        }
                    } break;
            }
            if (currentAsignacion != null && flag)
            {
                expandablePanel1.Expanded = false;
                try
                {
                    Conexion conexion = new Conexion();
                    if (!editing)
                    {
                        conexion.insertAsignacion(ref currentAsignacion);
                        calendarControl.AddAsignacion(currentAsignacion);
                    }
                    else
                    {
                        if (currentAsignacion.Serie != null)
                        {
                            List<Asignacion> asignaciones;
                            if(currentAsignacion is AsignacionClase)
                                asignaciones = conexion.getAsignacionesClase("serie="+currentAsignacion.Serie.ID).ToList<Asignacion>();
                            else
                                asignaciones = conexion.getAsignacionesVarios("serie=" + currentAsignacion.Serie.ID).ToList<Asignacion>();
                            EditarSerieForm editarSerieForm = new EditarSerieForm();
                            editarSerieForm.setAsignaciones(asignaciones);
                            editarSerieForm.setCurrentAsignacion(currentAsignacion);
                            DialogResult result = editarSerieForm.ShowDialog();
                            if (result == DialogResult.OK)
                            {
                                EditarSerieForm.Option selectedOption = editarSerieForm.getSelectedOption();
                                if(selectedOption==EditarSerieForm.Option.CurrentEvent)
                                {
                                            conexion.actualizarAsignacion(currentAsignacion);
                                            calendarControl.updateAsignacion(currentAsignacion);
                                }
                                else {
                                        TimeSpan InicioOffset;
                                        TimeSpan FinOffset;
                                        InicioOffset = currentAsignacion.Inicio.Subtract(oInicio);
                                        FinOffset = currentAsignacion.Fin.Subtract(oFin);
                                        
                                        List<Asignacion> asignacionesSeleccionadas = editarSerieForm.getAsignacionesSeleccionadas();
                                        if (asignacionesSeleccionadas != null)
                                        {
                                            for (int i = 0; i < asignacionesSeleccionadas.Count; i++)
                                            {
                                                Asignacion asignacion = asignacionesSeleccionadas[i];
                                                asignacion.Inicio = new DateTime(asignacion.Inicio.Year, asignacion.Inicio.Month, asignacion.Inicio.Day, currentAsignacion.Inicio.Hour, currentAsignacion.Inicio.Minute, 0);
                                                asignacion.Fin = new DateTime(asignacion.Fin.Year, asignacion.Fin.Month, asignacion.Fin.Day, currentAsignacion.Fin.Hour, currentAsignacion.Fin.Minute, 0);
                                                if (InicioOffset.Days != 0)
                                                    asignacion.Inicio= asignacion.Inicio.AddDays(InicioOffset.Days);
                                                if (FinOffset.Days != 0)
                                                    asignacion.Fin= asignacion.Fin.AddDays(FinOffset.Days);
                                                asignacion.Aula = currentAsignacion.Aula;
                                                if (currentAsignacion is AsignacionClase)
                                                {
                                                    ((AsignacionClase)asignacion).Grupo = ((AsignacionClase)currentAsignacion).Grupo;
                                                }
                                                else if (currentAsignacion is AsignacionVarios)
                                                {
                                                    ((AsignacionVarios)asignacion).TipoUso = ((AsignacionVarios)currentAsignacion).TipoUso;
                                                    ((AsignacionVarios)asignacion).Observaciones = ((AsignacionVarios)currentAsignacion).Observaciones;
                                                }
                                                conexion.actualizarAsignacion(asignacion);
                                                calendarControl.updateAsignacion(asignacion);
                                            }
                                        }
                                }
                                    
                            }

                        }
                        else
                        {
                            conexion.actualizarAsignacion(currentAsignacion);
                            calendarControl.updateAsignacion(currentAsignacion);
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Ha ocurrido un problema al intentar insertar la asignación"); }
            }
        }

        public void Nuevo()
        {
        }

        public void Imprimir()
        {
        }

        public bool Guardar()
        {
            return true;
        }

        public void Cancelar()
        {
        }

        public void Editar()
        {
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

        private void buttonAddSerie_Click(object sender, EventArgs e)
        {
            DateTime? inicio=null;
            DateTime? fin = null;
            try
            {
                inicio = calendarControl.calendarView.DateSelectionStart.Value;
                fin = calendarControl.calendarView.DateSelectionEnd.Value;
            }catch{}
            calendarControl.calendarView.DateSelectionStart = null;
            calendarControl.calendarView.DateSelectionEnd = null;
            expandablePanel1.Expanded = false;
            try
            {
                AsignacionMultipleForm asignacionMultipleForm = new AsignacionMultipleForm();
                if (inicio != null && fin != null)
                {
                    asignacionMultipleForm.setInitialDates(inicio.Value, fin.Value);
                }
                DialogResult dialogResult = asignacionMultipleForm.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    List<Asignacion> asignaciones = asignacionMultipleForm.Asignaciones;
                    if(asignaciones.FindAll(element=>element.Aula==null).Count>0){
                        MessageBox.Show("Ha ocurrido un error:\nLas asignaciones deben de estar asignadas un aula.");
                    }
                    else{
                        Conexion conexion = new Conexion();

                        List<Serie> series = asignacionMultipleForm.Series;
                        
                        List<Serie> insertedSeries = new List<Serie>();
                        for (int i = 0; i < series.Count; i++)
                        {
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
                            calendarControl.AddAsignacion(asignacion);
                        }
                    }
                }
            }
            catch { }
            //expandablePanel1.Expanded = false;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            ShowFormBuscar();
        }

        void ShowFormBuscar() {
            BuscarForm buscarForm = new BuscarForm();
            buscarForm.Aulas = aulas;
            DialogResult result = buscarForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (buscarForm.AulasSeleccionadas != null)
                {
                    if (buscarForm.AulasSeleccionadas.Count > 0)
                    {
                        calendarControl.calendarView.DisplayedOwners.Clear();
                        foreach (Aula a in buscarForm.AulasSeleccionadas)
                        {
                            calendarControl.calendarView.DisplayedOwners.Add(a.Referencia);
                        }
                    }
                }
            }
        }

        void calendarControl_OnReprogramadaCheckedChanged(object sender, EventArgs e)
        {
            AsignacionClase asignacion =(AsignacionClase) sender;
            new Conexion().actualizarAsignacion(asignacion);
            calendarControl.updateAsignacion(asignacion);
            calendarControl.Refresh();
        }
    }
}
