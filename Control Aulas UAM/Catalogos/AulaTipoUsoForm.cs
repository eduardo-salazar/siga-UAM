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
    public partial class AulaTipoUsoForm : UserControl,Funciones 
    {
        Conexion db = null;
        BindingSource AulaTiposBindingSource = null;
        public AulaTipoUsoForm()
        {
            InitializeComponent();
            db = new Conexion();
            AulaTiposBindingSource = new BindingSource();
            cargarDataGrid();
            this.txtId.DataBindings.Add("Text", AulaTiposBindingSource, "Id");
            this.txtDescripcion.DataBindings.Add("Text",AulaTiposBindingSource,"Descripcion");
            edicion(false);
            this.dgAulaTipoUsos.ReadOnly = true;
            
        }
        private void cargarDataGrid()
        {
            AulaTiposBindingSource.DataSource = db.getAulaTipoUso();
            this.dgAulaTipoUsos.DataSource = AulaTiposBindingSource;
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
            this.dgAulaTipoUsos.Enabled=false;
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
        private bool insertAulaTipoUso(AulaTipoUso AulaTipoUso)
        {
            
            try
            {
                db.insertAulaTipoUso(AulaTipoUso);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            return true;
        }
        private bool actualizarAulaTipoUso(AulaTipoUso AulaTipoUso)
        {

            try
            {
                db.actualizarAulaTipoUso(AulaTipoUso);
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
                    AulaTipoUso AulaTipoUso = new AulaTipoUso();
                    AulaTipoUso.Descripcion = this.txtDescripcion.Text;
                    insertAulaTipoUso(AulaTipoUso);
                    this.dgAulaTipoUsos.Enabled = true;
                    cargarDataGrid();
                    this.txtId.DataBindings.Add("Text", AulaTiposBindingSource, "Id");
                    this.txtDescripcion.DataBindings.Add("Text", AulaTiposBindingSource, "Descripcion");
                    this.AulaTiposBindingSource.MoveLast();
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
                    AulaTipoUso AulaTipoUso = new AulaTipoUso();
                    AulaTipoUso.Id = Convert.ToInt32(this.txtId.Text);
                    AulaTipoUso.Descripcion = this.txtDescripcion.Text;
                    actualizarAulaTipoUso(AulaTipoUso);
                    this.dgAulaTipoUsos.Enabled = true;
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
            this.AulaTiposBindingSource.ResetCurrentItem();
        }

        public void Editar()
        {
            this.txtDescripcion.Select();
            this.dgAulaTipoUsos.Enabled = false;
            edicion(true);
        }

        public void Borrar()
        {
            AulaTipoUso AulaTipoUso = new AulaTipoUso();
            AulaTipoUso.Id = Convert.ToInt32(this.txtId.Text);
            db.borrarAulaTipoUso(AulaTipoUso);
            cargarDataGrid();
            edicion(false);
        }

        public void IrPrimero()
        {
            this.AulaTiposBindingSource.MoveFirst();
        }

        public void Anterior()
        {
            this.AulaTiposBindingSource.MovePrevious();
        }

        public void Siguiente()
        {
            this.AulaTiposBindingSource.MoveNext();
        }

        public void IrFinal()
        {
            this.AulaTiposBindingSource.MoveLast();
        }

        public bool vacio()
        {
            int cant=db.cantAulaTipos();
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
            form.buscarGenerico1.cbInput.DataSource = this.AulaTiposBindingSource;
            form.buscarGenerico1.cbInput.DisplayMember = "Descripcion";
            form.buscarGenerico1.Grid = this.AulaTiposBindingSource;
            form.ShowDialog();
        }

        private void lbId_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgAulaTipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
