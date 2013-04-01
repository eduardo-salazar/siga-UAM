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
    public partial class EdificiosForm : UserControl,Funciones 
    {
        Conexion db = null;
        BindingSource EdificiosBindingSource = null;
        public EdificiosForm()
        {
            InitializeComponent();
            db = new Conexion();
            EdificiosBindingSource = new BindingSource();
            cargarDataGrid();
            this.txtId.DataBindings.Add("Text", EdificiosBindingSource, "Id");
            this.txtDescripcion.DataBindings.Add("Text",EdificiosBindingSource,"Descripcion");
            edicion(false);
            this.dgEdificios.ReadOnly = true;
            
        }
        private void cargarDataGrid()
        {
            EdificiosBindingSource.DataSource = db.getEdificios();
            this.dgEdificios.DataSource = EdificiosBindingSource;
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
            this.dgEdificios.Enabled=false;
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
        private bool insertEdificio(Edificio edificio)
        {
            
            try
            {
                db.insertEdificio(edificio);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            return true;
        }
        private bool actualizarEdificio(Edificio edificio)
        {

            try
            {
                db.actualizarEdificio(edificio);
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
                    Edificio edificio = new Edificio();
                    edificio.Descripcion = this.txtDescripcion.Text;
                    insertEdificio(edificio);
                    this.dgEdificios.Enabled = true;
                    cargarDataGrid();
                    this.txtId.DataBindings.Add("Text", EdificiosBindingSource, "Id");
                    this.txtDescripcion.DataBindings.Add("Text", EdificiosBindingSource, "Descripcion");
                    this.EdificiosBindingSource.MoveLast();
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
                    Edificio edificio = new Edificio();
                    edificio.Id = Convert.ToInt32(this.txtId.Text);
                    edificio.Descripcion = this.txtDescripcion.Text;
                    actualizarEdificio(edificio);
                    this.dgEdificios.Enabled = true;
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
            this.EdificiosBindingSource.ResetCurrentItem();
        }

        public void Editar()
        {
            this.txtDescripcion.Select();
            this.dgEdificios.Enabled = false;
            edicion(true);
        }

        public void Borrar()
        {
            Edificio edificio = new Edificio();
            edificio.Id = Convert.ToInt32(this.txtId.Text);
            db.borrarEdificio(edificio);
            cargarDataGrid();
            edicion(false);
        }

        public void IrPrimero()
        {
            this.EdificiosBindingSource.MoveFirst();
        }

        public void Anterior()
        {
            this.EdificiosBindingSource.MovePrevious();
        }

        public void Siguiente()
        {
            this.EdificiosBindingSource.MoveNext();
        }

        public void IrFinal()
        {
            this.EdificiosBindingSource.MoveLast();
        }

        public bool vacio()
        {
            int cant=db.cantEdificios();
            if (cant > 0)
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
            form.buscarGenerico1.cbInput.DataSource = this.EdificiosBindingSource;
            form.buscarGenerico1.cbInput.DisplayMember = "Descripcion";
            form.buscarGenerico1.Grid = this.EdificiosBindingSource;
            form.ShowDialog();
        }

        private void lbId_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
