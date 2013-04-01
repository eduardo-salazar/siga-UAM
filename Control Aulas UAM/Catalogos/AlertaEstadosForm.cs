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
    public partial class AlertaEstadosForm : UserControl,Funciones 
    {
        Conexion db = null;
        BindingSource AlertaEstados = null;
        public AlertaEstadosForm()
        {
            InitializeComponent();
            db = new Conexion();
            AlertaEstados = new BindingSource();
            cargarDataGrid();
            this.txtId.DataBindings.Add("Text", AlertaEstados, "Id");
            this.txtDescripcion.DataBindings.Add("Text",AlertaEstados,"Descripcion");
            edicion(false);
            this.dgAlertaEstados.ReadOnly = true;
            
        }
        private void cargarDataGrid()
        {
            try
            {
                AlertaEstados.DataSource = db.getAlertaEstado();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            this.dgAlertaEstados.DataSource = AlertaEstados;
        }
        private void edicion(bool e)
        {
            if (e)
            {
                this.txtDescripcion.Enabled = true;
            }
            else
            {
                this.txtId.Enabled = false;
                this.txtDescripcion.Enabled = false;
            }
        }

        public void Nuevo()
        {
            //Limpiar todos los controles y quitar el enlace a los datos
            this.dgAlertaEstados.Enabled=false;
            this.txtDescripcion.DataBindings.RemoveAt(0);
            this.txtId.DataBindings.RemoveAt(0);
            this.txtDescripcion.Focus();
            this.txtId.Clear();
            this.txtDescripcion.Clear();

            edicion(true);
        }

        public void Imprimir()
        {
            throw new NotImplementedException();
        }
        private bool insertAlertaEstado(AlertaEstado AlertaEstado)
        {
            
            try
            {
                db.insertAlertaEstado(AlertaEstado);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            return true;
        }
        private bool actualizarAlertaEstado(AlertaEstado AlertaEstado)
        {

            try
            {
                db.actualizarAlertaEstado(AlertaEstado);
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
                    AlertaEstado AlertaEstado = new AlertaEstado();
                    AlertaEstado.Descripcion = this.txtDescripcion.Text;
                    insertAlertaEstado(AlertaEstado);
                    this.dgAlertaEstados.Enabled = true;
                    cargarDataGrid();
                    this.txtId.DataBindings.Add("Text", AlertaEstados, "Id");
                    this.txtDescripcion.DataBindings.Add("Text", AlertaEstados, "Descripcion");
                    this.AlertaEstados.MoveLast();
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
                    AlertaEstado AlertaEstado = new AlertaEstado();
                    AlertaEstado.Id = Convert.ToInt32(this.txtId.Text);
                    AlertaEstado.Descripcion = this.txtDescripcion.Text;
                    actualizarAlertaEstado(AlertaEstado);
                    this.dgAlertaEstados.Enabled = true;
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
            this.AlertaEstados.ResetCurrentItem();
        }

        public void Editar()
        {
            this.txtDescripcion.Select();
            this.dgAlertaEstados.Enabled = false;
            edicion(true);
        }

        public void Borrar()
        {
            AlertaEstado AlertaEstado = new AlertaEstado();
            AlertaEstado.Id = Convert.ToInt32(this.txtId.Text);
            try
            {
                db.borrarAlertaEstado(AlertaEstado);
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
            this.AlertaEstados.MoveFirst();
        }

        public void Anterior()
        {
            this.AlertaEstados.MovePrevious();
        }

        public void Siguiente()
        {
            this.AlertaEstados.MoveNext();
        }

        public void IrFinal()
        {
            this.AlertaEstados.MoveLast();
        }

        public bool vacio()
        {
            try
            {
                int cant = db.cantAlertaEstados();
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
            form.buscarGenerico1.cbInput.DataSource = this.AlertaEstados;
            form.buscarGenerico1.cbInput.DisplayMember = "Descripcion";
            form.buscarGenerico1.Grid = this.AlertaEstados;
            form.ShowDialog();
        }

        private void lbId_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void AlertaEstadosForm_Load(object sender, EventArgs e)
        {

        }
    }
}
