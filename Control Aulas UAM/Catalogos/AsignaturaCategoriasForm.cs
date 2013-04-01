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
    public partial class AsignaturaCategoriasForm : UserControl,Funciones 
    {
        Conexion db = null;
        BindingSource AsignaturaCategoriasBindingSource = null;
        public AsignaturaCategoriasForm()
        {
            InitializeComponent();
            db = new Conexion();
            AsignaturaCategoriasBindingSource = new BindingSource();
            cargarDataGrid();
            this.txtId.DataBindings.Add("Text", AsignaturaCategoriasBindingSource, "Id");
            this.txtDescripcion.DataBindings.Add("Text",AsignaturaCategoriasBindingSource,"Descripcion");
            edicion(false);
            this.dgAsignaturaCategorias.ReadOnly = true;
            
        }
        private void cargarDataGrid()
        {
            AsignaturaCategoriasBindingSource.DataSource = db.getAsignaturaCategorias();
            this.dgAsignaturaCategorias.DataSource = AsignaturaCategoriasBindingSource;
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
            this.dgAsignaturaCategorias.Enabled=false;
            this.txtDescripcion.DataBindings.RemoveAt(0);
            this.txtId.DataBindings.RemoveAt(0);

            this.txtId.Clear();
            this.txtDescripcion.Clear();

            edicion(true);
        }

        public void Imprimir()
        {
            throw new NotImplementedException();
        }
        private bool insertAsignaturaCategoria(AsignaturaCategoria fac)
        {
            
            try
            {
                db.insertAsignaturaCategoria(fac);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            return true;
        }
        private bool actualizarAsignaturaCategoria(AsignaturaCategoria fac)
        {

            try
            {
                db.actualizarAsignaturaCategoria(fac);
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
                /*------------INSERTAR AsignaturaCategoria----------------*/
                if (this.txtDescripcion.Text != "")
                {
                    AsignaturaCategoria fac = new AsignaturaCategoria();
                    fac.Descripcion = this.txtDescripcion.Text;
                    insertAsignaturaCategoria(fac);
                    this.dgAsignaturaCategorias.Enabled = true;
                    cargarDataGrid();
                    this.txtId.DataBindings.Add("Text", AsignaturaCategoriasBindingSource, "Id");
                    this.txtDescripcion.DataBindings.Add("Text", AsignaturaCategoriasBindingSource, "Descripcion");
                    this.AsignaturaCategoriasBindingSource.MoveLast();
                    return true;
                }
                else
                {
                    MessageBox.Show("Descripción no puede estar vacio.", "Error", MessageBoxButtons.OK);
                    return false;
                }
                
                /*---------FIN INSERTAR AsignaturaCategoria----------------*/
                

            }
            else
            {
                
                /*------------Actualizar AsignaturaCategoria----------------*/
                if (this.txtDescripcion.Text != "")
                {
                    AsignaturaCategoria fac = new AsignaturaCategoria();
                    fac.Id = Convert.ToInt32(this.txtId.Text);
                    fac.Descripcion = this.txtDescripcion.Text;
                    actualizarAsignaturaCategoria(fac);
                    this.dgAsignaturaCategorias.Enabled = true;
                    cargarDataGrid();
                    return true;
                }
                else
                {
                    MessageBox.Show("Descripción no puede estar vacio","Error",MessageBoxButtons.OK);
                    return false;
                }
                /*---------FIN Actualizar AsignaturaCategoria----------------*/
                
            }
            
            
        }

        public void Cancelar()
        {
            this.AsignaturaCategoriasBindingSource.ResetCurrentItem();
        }

        public void Editar()
        {
            this.txtDescripcion.Select();
            this.dgAsignaturaCategorias.Enabled = false;
            edicion(true);
        }

        public void Borrar()
        {
            AsignaturaCategoria fac = new AsignaturaCategoria();
            fac.Id = Convert.ToInt32(this.txtId.Text);
            db.borrarAsignaturaCategoria(fac);
            cargarDataGrid();
            edicion(false);
        }

        public void IrPrimero()
        {
            this.AsignaturaCategoriasBindingSource.MoveFirst();
        }

        public void Anterior()
        {
            this.AsignaturaCategoriasBindingSource.MovePrevious();
        }

        public void Siguiente()
        {
            this.AsignaturaCategoriasBindingSource.MoveNext();
        }

        public void IrFinal()
        {
            this.AsignaturaCategoriasBindingSource.MoveLast();
        }

        public bool vacio()
        {
            int cant=db.cantAsignaturaCategorias();
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
            form.buscarGenerico1.cbInput.DataSource = this.AsignaturaCategoriasBindingSource;
            form.buscarGenerico1.cbInput.DisplayMember = "Descripcion";
            form.buscarGenerico1.Grid = this.AsignaturaCategoriasBindingSource;
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
