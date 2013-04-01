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
    public partial class AulaEstadosForm : UserControl,Funciones 
    {
        Conexion db = null;
        BindingSource AulaEstadosBindingSource = null;
        public AulaEstadosForm()
        {
            InitializeComponent();
            db = new Conexion();
            AulaEstadosBindingSource = new BindingSource();
            cargarDataGrid();
            this.txtId.DataBindings.Add("Text", AulaEstadosBindingSource, "Id");
            this.txtDescripcion.DataBindings.Add("Text",AulaEstadosBindingSource,"Descripcion");
            edicion(false);
            this.dgAulaEstados.ReadOnly = true;
            
        }
        private void cargarDataGrid()
        {
            AulaEstadosBindingSource.DataSource = db.getAulaEstado();
            this.dgAulaEstados.DataSource = AulaEstadosBindingSource;
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
            this.dgAulaEstados.Enabled=false;
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
        private bool insertAulaEstado(AulaEstado AulaEstado)
        {
            
            try
            {
                db.insertAulaEstado(AulaEstado);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            return true;
        }
        private bool actualizarAulaEstado(AulaEstado AulaEstado)
        {

            try
            {
                db.actualizarAulaEstado(AulaEstado);
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
                    AulaEstado AulaEstado = new AulaEstado();
                    AulaEstado.Descripcion = this.txtDescripcion.Text;
                    insertAulaEstado(AulaEstado);
                    this.dgAulaEstados.Enabled = true;
                    cargarDataGrid();
                    this.txtId.DataBindings.Add("Text", AulaEstadosBindingSource, "Id");
                    this.txtDescripcion.DataBindings.Add("Text", AulaEstadosBindingSource, "Descripcion");
                    this.AulaEstadosBindingSource.MoveLast();
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
                    AulaEstado AulaEstado = new AulaEstado();
                    AulaEstado.Id = Convert.ToInt32(this.txtId.Text);
                    AulaEstado.Descripcion = this.txtDescripcion.Text;
                    actualizarAulaEstado(AulaEstado);
                    this.dgAulaEstados.Enabled = true;
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
            this.AulaEstadosBindingSource.ResetCurrentItem();
        }

        public void Editar()
        {
            this.txtDescripcion.Select();
            this.dgAulaEstados.Enabled = false;
            edicion(true);
        }

        public void Borrar()
        {
            AulaEstado AulaEstado = new AulaEstado();
            AulaEstado.Id = Convert.ToInt32(this.txtId.Text);
            db.borrarAulaEstado(AulaEstado);
            cargarDataGrid();
            edicion(false);
        }

        public void IrPrimero()
        {
            this.AulaEstadosBindingSource.MoveFirst();
        }

        public void Anterior()
        {
            this.AulaEstadosBindingSource.MovePrevious();
        }

        public void Siguiente()
        {
            this.AulaEstadosBindingSource.MoveNext();
        }

        public void IrFinal()
        {
            this.AulaEstadosBindingSource.MoveLast();
        }

        public bool vacio()
        {
            int cant=db.cantAulaEstados();
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
            form.buscarGenerico1.cbInput.DataSource = this.AulaEstadosBindingSource;
            form.buscarGenerico1.cbInput.DisplayMember = "Descripcion";
            form.buscarGenerico1.Grid = this.AulaEstadosBindingSource;
            form.ShowDialog();
        }

        private void lbId_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgAulaEstados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
