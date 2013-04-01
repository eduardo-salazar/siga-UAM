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
    public partial class AulaTipoForm : UserControl,Funciones 
    {
        Conexion db = null;
        BindingSource AulaTiposBindingSource = null;
        public AulaTipoForm()
        {
            InitializeComponent();
            db = new Conexion();
            AulaTiposBindingSource = new BindingSource();
            cargarDataGrid();
            this.txtId.DataBindings.Add("Text", AulaTiposBindingSource, "Id");
            this.txtDescripcion.DataBindings.Add("Text",AulaTiposBindingSource,"Descripcion");
            edicion(false);
            this.dgAulaTipos.ReadOnly = true;
            
        }
        private void cargarDataGrid()
        {
            AulaTiposBindingSource.DataSource = db.getAulaTipos();
            this.dgAulaTipos.DataSource = AulaTiposBindingSource;
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
            this.dgAulaTipos.Enabled=false;
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
        private bool insertAulaEstado(AulaTipo AulaEstado)
        {
            
            try
            {
                db.insertAulaTipo(AulaEstado);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            return true;
        }
        private bool actualizarAulaTipo(AulaTipo AulaTipo)
        {

            try
            {
                db.actualizarAulaTipo(AulaTipo);
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
                    AulaTipo AulaTipo = new AulaTipo();
                    AulaTipo.Descripcion = this.txtDescripcion.Text;
                    insertAulaEstado(AulaTipo);
                    this.dgAulaTipos.Enabled = true;
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
                    AulaTipo AulaTipo = new AulaTipo();
                    AulaTipo.Id = Convert.ToInt32(this.txtId.Text);
                    AulaTipo.Descripcion = this.txtDescripcion.Text;
                    actualizarAulaTipo(AulaTipo);
                    this.dgAulaTipos.Enabled = true;
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
            this.dgAulaTipos.Enabled = false;
            edicion(true);
        }

        public void Borrar()
        {
            AulaTipo AulaTipo = new AulaTipo();
            AulaTipo.Id = Convert.ToInt32(this.txtId.Text);
            db.borrarAulaTipo(AulaTipo);
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
