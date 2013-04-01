using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_Aulas_UAM.Clases.Db;
using Control_Aulas_UAM.Clases;
using Control_Aulas_UAM;

namespace Control_Aulas_UAM.Catalogos
{
    public partial class AulasForm : UserControl,Funciones
    {
        List<Aula> aulas;
        BindingSource AulasBindingSource;
        List<Edificio> edificios;
        List<AulaTipo> aulatipos;
        List<AulaEstado> estados;
        
        DataTable aulaEquipos;
        DataTable equipos;
        
        


        int cantAulas = 0;
        Conexion db = new Conexion();
        Boolean nuevo = false;
        Usuario user=null;

        public AulasForm(Usuario a)
        {
            user = a;
            InitializeComponent();
            //Cargar Elementos Necesarios
            try
            {
                edificios = db.getEdificios();
                this.cbEdificio.DataSource = edificios;
                this.cbEdificio.DisplayMember = "Descripcion";
                this.cbEdificio.ValueMember = "Id";

                aulatipos = db.getAulaTipos();
                this.cbTipo.DataSource = aulatipos;
                this.cbTipo.DisplayMember = "Descripcion";
                this.cbTipo.ValueMember = "Id";

                estados = db.getAulaEstado();
                this.cbEstado.DataSource = estados;
                this.cbEstado.DisplayMember = "Descripcion";
                this.cbEstado.ValueMember = "Id";

                
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            
            cantAulas = db.cantAulas();
            if (cantAulas!=0)
            { 
                //cargar Lista de Aulas
                aulas = db.getAulas();

                cargarAulasDataGrid();
                this.txtId.DataBindings.Add("Text", AulasBindingSource, "Referencia");
                this.txtCapacidad.DataBindings.Add("Text", AulasBindingSource, "Capacidad");
                this.txtPiso.DataBindings.Add("Text", AulasBindingSource, "Piso");
                this.txtDescripcion.DataBindings.Add("Text", AulasBindingSource, "Nombre");
                
                sincronizarCombos();
                this.dgEquipos.CellEndEdit += dgEquipos_CellEndEdit;
                
                //Evento cuando se mueve el binding
                this.AulasBindingSource.PositionChanged+=new EventHandler(AulasBindingSource_PositionChanged);
                cargarEquipos();
                
            }
            editar(false);
        }

        private void dgEquipos_RowsAdded1(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void cargarEquipos()
        {
            this.dgEquipos.Columns.Clear();
            try
            {
                //Cargar Equipos
                aulaEquipos = listToDataTable(db.getAulasEquipos(((Aula)this.AulasBindingSource.Current).Id));
                equipos = listToDataTable(db.getEquipos());

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            DataSet ds = new DataSet();
            ds.Tables.Add(aulaEquipos);
            ds.Tables.Add(equipos);

            ds.Relations.Add("Id", ds.Tables["Equipos"].Columns["Id"], ds.Tables["AulaEquipo"].Columns["IdEquipo"]);
            DataGridViewComboBoxColumn cb = new DataGridViewComboBoxColumn();
            cb.DisplayMember = "Descripcion";
            cb.ValueMember = "Id";
            cb.DataPropertyName = "IdEquipo";
            cb.DataSource = ds.Tables["Equipos"];
            this.dgEquipos.Columns.Add(cb);
            this.dgEquipos.DataSource = ds.Tables["AulaEquipo"];
            this.dgEquipos.Columns["Id"].Visible = false;
            this.dgEquipos.Columns["DescripcionEquipo"].Visible = false;
            this.dgEquipos.Columns["ObservacionEquipo"].ReadOnly = true;
            this.dgEquipos.Columns["ObservacionEquipo"].HeaderText = "Observacion";
            this.dgEquipos.Columns["ObservacionEquipo"].DefaultCellStyle.BackColor = Color.LightGray;
            
         
        }

        void dgEquipos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                DataGridView cell = (DataGridView)sender;
                int value=Convert.ToInt32(cell.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                this.dgEquipos.Rows[e.RowIndex].Cells["ObservacionEquipo"].Value = findObservacion(value) ;

                //verificar que no este repetido el equipo


                BindingSource bs = new BindingSource();
                bs.DataSource = this.dgEquipos.DataSource;
                DataTable table = (DataTable)(bs.DataSource);
                for(int i=0;i<table.Rows.Count;i++)
                {
                    int c=Convert.ToInt32(table.Rows[i].ItemArray.GetValue(1).ToString());
                    if (c.Equals(value))
                    {
                        MessageBox.Show("El equipo " + table.Rows[i].ItemArray.GetValue(2)+ " ya esta asignado. Verificar tabla");
                        this.dgEquipos.Rows.RemoveAt(e.RowIndex);
                        break;
                    }
                }
                //DataTableReader reader = table.CreateDataReader();
                //int cont = 0;
                //while (reader.Read())
                //{
                //    if (reader["IdEquipo"].ToString().Equals(value))
                //    {
                //        MessageBox.Show("El equipo " + reader["DescripcionEquipo"].ToString() + " ya esta asignado. Verificar tabla");
                //        break;
                //    }
                //}
            }
        }
        private String findObservacion(int value)
        {
            for (int i = 0; i < this.equipos.Rows.Count; i++)
            {
                if (Convert.ToInt32(this.equipos.Rows[i].ItemArray.GetValue(0)) == value)
                {
                    return this.equipos.Rows[i].ItemArray.GetValue(2).ToString();
                }
            }
            return null;
        }
        private DataTable listToDataTable(List<AulaEquipo> a)
        {

            DataTable table = new DataTable("AulaEquipo");
            table.Columns.Add("Id");
            table.Columns.Add("IdEquipo");
            table.Columns.Add("DescripcionEquipo");
            table.Columns.Add("ObservacionEquipo");
            table.Columns.Add("Cantidad");
            table.Columns.Add("Observaciones");
            foreach (AulaEquipo e in a)
            {
                table.Rows.Add(e.Id,e.IdEquipo,e.DescripcionEquipo,e.ObservacionEquipo,e.Cantidad,e.Observaciones);       
            }
            return table;

        }
        private DataTable listToDataTable(List<Equipo> a)
        {

            DataTable table = new DataTable("Equipos");
            table.Columns.Add("Id");
            table.Columns.Add("Descripcion");
            table.Columns.Add("Observacion");
            
            foreach (Equipo e in a)
            {
                table.Rows.Add(e.Id, e.Descripcion, e.Observacion);
            }
            return table;

        }
        private void cargarAulasDataGrid()
        {
            if (AulasBindingSource == null)
            {
                AulasBindingSource = new BindingSource();
            }
            aulas = db.getAulas();
            AulasBindingSource.DataSource = aulas;
            this.dgAulas.DataSource = AulasBindingSource;
            this.dgAulas.Columns["Id"].Visible = false;
            this.dgAulas.Columns["IdTipo"].Visible = false;
            this.dgAulas.Columns["NombreTipo"].Visible = false;
            this.dgAulas.Columns["Nombre"].Visible = false;
            this.dgAulas.Columns["IdEdificio"].Visible = false;
            this.dgAulas.Columns["NombreEdificio"].Visible = false;
            this.dgAulas.Columns["Capacidad"].Visible = false;
            this.dgAulas.Columns["Piso"].Visible = false;
            this.dgAulas.Columns["IdEstado"].Visible = false;
            this.dgAulas.Columns["NombreEstado"].Visible = false;
            this.dgAulas.Font = new Font(new FontFamily("Microsoft Sans Serif"), 15);
        }
        private void editar(Boolean e)
        {
               //modo edicion
                this.txtCapacidad.Enabled = e;
                this.txtDescripcion.Enabled = e;
                this.txtId.Enabled = e;
                this.txtPiso.Enabled = e;
                this.cbEdificio.Enabled = e;
                this.cbEstado.Enabled = e;
                this.cbTipo.Enabled = e;
                this.dgEquipos.ReadOnly = !e;
                
        }
        private void AulasBindingSource_PositionChanged(object sender, EventArgs e)
        {
            sincronizarCombos();
            cargarEquipos();
        }

        private void sincronizarCombos()
        {
            Aula aula = (Aula)this.AulasBindingSource.Current;
            int edificio = aula.IdEdificio;
            int tipo = aula.IdTipo;
            int estado = aula.IdEstado;
            foreach (Edificio e in edificios)
            {
                if (e.Id.Equals(edificio))
                {
                    this.cbEdificio.SelectedIndex = edificios.IndexOf(e);
                }
            }
            foreach (AulaTipo e in aulatipos)
            {
                if (e.Id.Equals(tipo))
                {
                    this.cbTipo.SelectedIndex = aulatipos.IndexOf(e);
                }
            }
            foreach (AulaEstado e in estados)
            {
                if (e.Id.Equals(estado))
                {
                    this.cbEstado.SelectedIndex = estados.IndexOf(e);
                }
            }
        }

        private void lbDescripcion_Click(object sender, EventArgs e)
        {

        }

        public void Nuevo()
        {

            this.txtId.DataBindings.RemoveAt(0);
            this.txtCapacidad.DataBindings.RemoveAt(0);
            this.txtDescripcion.DataBindings.RemoveAt(0);
            this.txtPiso.DataBindings.RemoveAt(0);
            this.txtId.Clear();
            this.txtCapacidad.Clear();
            this.txtDescripcion.Clear();
            this.txtPiso.Clear();
            this.nuevo = true;
            this.dgAulas.Enabled = false;
            editar(true);


        }

        public void Imprimir()
        {
            throw new NotImplementedException();
        }

        public bool Guardar()
        {
            Aula aula = new Aula();
            aula.IdEdificio = Convert.ToInt32(this.cbEdificio.SelectedValue);
            aula.IdEstado = Convert.ToInt32(this.cbEstado.SelectedValue);
            aula.IdTipo = Convert.ToInt32(this.cbTipo.SelectedValue);
            aula.Nombre = this.txtDescripcion.Text;
            aula.Capacidad = Convert.ToInt32(this.txtCapacidad.Text);
            aula.Piso = Convert.ToInt32(this.txtPiso.Text);
            aula.Referencia = this.txtId.Text;
            if (nuevo)
            {
                //Ingresar nueva aula
                try
                {
                    db.insertAula(aula);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
            else
            { 
                //actualizar aula
                aula.Id = ((Aula)AulasBindingSource.Current).Id;
                try
                {
                    db.actualizarAula(aula);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
            //Insertar o actualizar los equipos de las aulas
            BindingSource bs = new BindingSource();
            bs.DataSource = this.dgEquipos.DataSource;
            DataTable table = (DataTable)(bs.DataSource);
            
            DataTableReader reader = table.CreateDataReader();
            int cont = 0;
            while (reader.Read())
            {
                this.dgEquipos.EndEdit();
                AulaEquipo aulaEquipo = new AulaEquipo();
                
                aulaEquipo.IdEquipo = Convert.ToInt32(reader["IdEquipo"].ToString());
                aulaEquipo.Cantidad = Convert.ToInt32(reader["Cantidad"].ToString());
                aulaEquipo.Observaciones = reader["Observaciones"].ToString();
                if (reader["Id"].ToString().Equals(""))
                {
                    //Insertar nuevo AulaEquipo
                    try
                    {
                        aulaEquipo.Id = ((Aula)AulasBindingSource.Current).Id;
                        db.insertAulaEquipo(aulaEquipo);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
                else
                { 
                    //Actualizar AulaEquipo
                    try
                    {
                        aulaEquipo.Id = Convert.ToInt32(reader["Id"].ToString());
                        int idEquipo=Convert.ToInt32(this.aulaEquipos.Columns["IdEquipo"].Table.Rows[cont].ItemArray.GetValue(1));
                        db.actualizarAulaEquipo(aulaEquipo,idEquipo);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
                cont++;
            }

            //Fin de manejo de equipos
            
            this.dgAulas.Enabled = true;
            cargarAulasDataGrid();
            cargarEquipos();
            if (nuevo)
            {
                this.txtId.DataBindings.Add("Text", AulasBindingSource, "Referencia");
                this.txtCapacidad.DataBindings.Add("Text", AulasBindingSource, "Capacidad");
                this.txtPiso.DataBindings.Add("Text", AulasBindingSource, "Piso");
                this.txtDescripcion.DataBindings.Add("Text", AulasBindingSource, "Nombre");
            }
            editar(false);
            return true;
            this.nuevo = false;
        }

        public void Cancelar()
        {
            this.nuevo = false;
            this.AulasBindingSource.ResetCurrentItem();
            this.dgAulas.Enabled = true;
            editar(false);
        }

        public void Editar()
        {
            editar(true);
            this.dgAulas.Enabled = false;
            this.nuevo = false;
        }

        public void Borrar()
        {
            Aula aula = (Aula)AulasBindingSource.Current;
            try
            {
                db.borrarAula(aula);
                cargarAulasDataGrid();
                editar(false);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void IrPrimero()
        {
            this.AulasBindingSource.MoveFirst();
        }

        public void Anterior()
        {
            this.AulasBindingSource.MovePrevious();
        }

        public void Siguiente()
        {
            this.AulasBindingSource.MoveNext();
        }

        public void IrFinal()
        {
            this.AulasBindingSource.MoveLast();
        }

        public bool vacio()
        {
            if (cantAulas != 0)
            {
                return false;
            }
            return true;
        }

        public void Reportes()
        {
            throw new NotImplementedException();
        }

        public void RealizarPago()
        {
            throw new NotImplementedException();
        }

        public void Filtrar()
        {
            BuscarGenericoForm form = new BuscarGenericoForm();
            form.buscarGenerico1.cbInput.DataSource = this.AulasBindingSource;
            form.buscarGenerico1.cbInput.DisplayMember = "Referencia";
            form.buscarGenerico1.Grid = this.AulasBindingSource;
            form.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void AulasForm_Load(object sender, EventArgs e)
        {

        }

        private void switchButton_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelX4_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            //this.NotificacionPanel.Visible = !this.NotificacionPanel.Visible;
        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            //this.NotificacionPanel.Expanded = !this.NotificacionPanel.Expanded;
            NotificarForm form=new NotificarForm();
            form.controlNotificar1.Aula = (Aula)this.AulasBindingSource.Current;
            form.controlNotificar1.Usuario = this.user;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void dateTimeFecha_Click(object sender, EventArgs e)
        {

        }

        private void btnNotificar_Click(object sender, EventArgs e)
        {
            
        }

        

    }
}
