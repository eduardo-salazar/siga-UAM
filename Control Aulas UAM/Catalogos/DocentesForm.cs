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
    public partial class DocentesForm : UserControl,Funciones 
    {
        Conexion db = null;
        BindingSource DocentesBindingSource = null;
        public DocentesForm()
        {
            InitializeComponent();
            db = new Conexion();
            DocentesBindingSource = new BindingSource();
            cargarDataGrid();
            this.txtId.DataBindings.Add("Text", DocentesBindingSource, "Id");
            this.txtNombre.DataBindings.Add("Text",DocentesBindingSource,"Nombre");
            edicion(false);
            this.dgDocentes.ReadOnly = true;
            
        }
        private void cargarDataGrid()
        {
            DocentesBindingSource.DataSource = db.getDocentes();
            this.dgDocentes.DataSource = DocentesBindingSource;
        }
        private void edicion(bool e)
        {
            if (e)
            {
                this.txtNombre.Enabled = true;
            }
            else
            {
                this.txtId.Enabled = false;
                this.txtNombre.Enabled = false;
            }
        }

        public void Nuevo()
        {
            //Limpiar todos los controles y quitar el enlace a los datos
            this.dgDocentes.Enabled=false;
            this.txtNombre.DataBindings.RemoveAt(0);
            this.txtId.DataBindings.RemoveAt(0);

            this.txtId.Clear();
            this.txtNombre.Clear();

            edicion(true);
        }

        public void Imprimir()
        {
            throw new NotImplementedException();
        }
        private bool insertDocente(Docente docente)
        {
            
            try
            {
                db.insertDocente(docente);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            return true;
        }
        private bool actualizarDocente(Docente docente)
        {

            try
            {
                db.actualizarDocente(docente);
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
                if (this.txtNombre.Text != "")
                {
                    Docente docente = new Docente();
                    docente.Nombre= this.txtNombre.Text;
                    insertDocente(docente);
                    this.dgDocentes.Enabled = true;
                    cargarDataGrid();
                    this.txtId.DataBindings.Add("Text", DocentesBindingSource, "Id");
                    this.txtNombre.DataBindings.Add("Text", DocentesBindingSource, "Nombre");
                    this.DocentesBindingSource.MoveLast();
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
                if (this.txtNombre.Text != "")
                {
                    Docente docente = new Docente();
                    docente.Id = Convert.ToInt32(this.txtId.Text);
                    docente.Nombre = this.txtNombre.Text;
                    actualizarDocente(docente);
                    this.dgDocentes.Enabled = true;
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
            this.DocentesBindingSource.ResetCurrentItem();
        }

        public void Editar()
        {
            this.txtNombre.Select();
            this.dgDocentes.Enabled = false;
            edicion(true);
        }

        public void Borrar()
        {
            Docente docente = new Docente();
            docente.Id = Convert.ToInt32(this.txtId.Text);
            db.borrarDocente(docente);
            cargarDataGrid();
            edicion(false);
        }

        public void IrPrimero()
        {
            this.DocentesBindingSource.MoveFirst();
        }

        public void Anterior()
        {
            this.DocentesBindingSource.MovePrevious();
        }

        public void Siguiente()
        {
            this.DocentesBindingSource.MoveNext();
        }

        public void IrFinal()
        {
            this.DocentesBindingSource.MoveLast();
        }

        public bool vacio()
        {
            int cant=db.cantDocentes();
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
            form.buscarGenerico1.cbInput.DataSource = this.DocentesBindingSource;
            form.buscarGenerico1.cbInput.DisplayMember = "Nombre";
            form.buscarGenerico1.Grid = this.DocentesBindingSource;
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
