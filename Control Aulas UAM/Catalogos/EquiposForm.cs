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

namespace Control_Aulas_UAM.Catalogos
{
    public partial class EquiposForm : UserControl,Funciones 
    {
        Conexion db = null;
        BindingSource Equipos = null;
        public EquiposForm()
        {
            InitializeComponent();
            db = new Conexion();
            Equipos = new BindingSource();
            cargarDataGrid();
            this.txtId.DataBindings.Add("Text", Equipos, "Id");
            this.txtDescripcion.DataBindings.Add("Text",Equipos,"Descripcion");
            this.txtObservacion.DataBindings.Add("Text", Equipos, "Observacion");
            edicion(false);
            this.dgEquipos.ReadOnly = true;
            
        }
        private void cargarDataGrid()
        {
            try
            {
                Equipos.DataSource=db.getEquipos();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            this.dgEquipos.DataSource = Equipos;
        }
        private void edicion(bool e)
        {
            this.txtDescripcion.Enabled = e;
            this.txtId.Enabled = e;
            this.txtObservacion.Enabled = e;
            
        }

        public void Nuevo()
        {
            //Limpiar todos los controles y quitar el enlace a los datos
            this.dgEquipos.Enabled=false;
            this.txtObservacion.DataBindings.RemoveAt(0);
            this.txtDescripcion.DataBindings.RemoveAt(0);
            this.txtId.DataBindings.RemoveAt(0);
            this.txtObservacion.Clear();
            this.txtDescripcion.Focus();
            this.txtId.Clear();
            this.txtDescripcion.Clear();

            edicion(true);
        }

        public void Imprimir()
        {
            throw new NotImplementedException();
        }
        private bool insertEquipo(Equipo Equipo)
        {
            
            try
            {
                db.insertEquipo(Equipo);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            return true;
        }
        private bool actualizarEquipo(Equipo Equipo)
        {

            try
            {
                db.actualizarEquipo(Equipo);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return true;
        }
        public bool Guardar()
        {
            edicion(false);
            if (this.txtId.Text == "")
            {
                /*------------INSERTAR FACULTAD----------------*/
                if (this.txtDescripcion.Text != "")
                {
                    Equipo Equipo = new Equipo();
                    Equipo.Descripcion = this.txtDescripcion.Text;
                    Equipo.Observacion = this.txtObservacion.Text;
                    insertEquipo(Equipo);
                    this.dgEquipos.Enabled = true;
                    cargarDataGrid();
                    this.txtId.DataBindings.Add("Text", Equipos, "Id");
                    this.txtDescripcion.DataBindings.Add("Text", Equipos, "Descripcion");
                    this.txtObservacion.DataBindings.Add("Text",Equipos,"Observacion");
                    this.Equipos.MoveLast();
                    return true;
                }
                else
                {
                    MessageBox.Show("Descripción no puede estar vacio.", "Error", MessageBoxButtons.OK);
                    return false;
                }
                
                /*---------FIN INSERTAR FACULTAD----------------*/
                

            }
            else
            {
                
                /*------------Actualizar FACULTAD----------------*/
                if (this.txtDescripcion.Text != "")
                {
                    Equipo Equipo = new Equipo();
                    Equipo.Id = Convert.ToInt32(this.txtId.Text);
                    Equipo.Descripcion = this.txtDescripcion.Text;
                    Equipo.Observacion = this.txtObservacion.Text;
                    actualizarEquipo(Equipo);
                    this.dgEquipos.Enabled = true;
                    cargarDataGrid();
                    return true;
                }
                else
                {
                    MessageBox.Show("Descripción no puede estar vacio","Error",MessageBoxButtons.OK);
                    return false;
                }
                /*---------FIN Actualizar FACULTAD----------------*/
                
            }
            
            
        }

        public void Cancelar()
        {
            this.Equipos.ResetCurrentItem();
        }

        public void Editar()
        {
            this.txtDescripcion.Select();
            this.dgEquipos.Enabled = false;
            edicion(true);
        }

        public void Borrar()
        {
            Equipo Equipo = new Equipo();
            Equipo.Id = Convert.ToInt32(this.txtId.Text);
            try
            {
                db.borrarEquipo(Equipo);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + ". Referencia esta siendo usada en otros formularios");
            }
            cargarDataGrid();
            edicion(false);
        }

        public void IrPrimero()
        {
            this.Equipos.MoveFirst();
        }

        public void Anterior()
        {
            this.Equipos.MovePrevious();
        }

        public void Siguiente()
        {
            this.Equipos.MoveNext();
        }

        public void IrFinal()
        {
            this.Equipos.MoveLast();
        }

        public bool vacio()
        {
            try
            {
                int cant = db.cantEquipos();
                if (cant > 0)
                {
                    return false;
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
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
            form.buscarGenerico1.cbInput.DataSource = this.Equipos;
            form.buscarGenerico1.cbInput.DisplayMember = "Descripcion";
            form.buscarGenerico1.Grid = this.Equipos;
            form.ShowDialog();
        }

        private void lbId_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void EquiposForm_Load(object sender, EventArgs e)
        {

        }
    }
}
