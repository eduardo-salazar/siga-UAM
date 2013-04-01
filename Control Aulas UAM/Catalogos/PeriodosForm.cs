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
    public partial class PeriodosForm : UserControl,Funciones
    {
        Conexion db = null;
        BindingSource PeriodosBindingSource = null;
        public PeriodosForm()
        {
            InitializeComponent();
            db = new Conexion();
            PeriodosBindingSource = new BindingSource();
            cargarDataGrid();
            this.txtId.DataBindings.Add("Text", PeriodosBindingSource, "Id");
            this.dtFechaInicio.DataBindings.Add("Text",PeriodosBindingSource,"FechaInicio");
            this.dtFechaFin.DataBindings.Add("Text",PeriodosBindingSource,"FechaFin");
            this.txtDescripcion.DataBindings.Add("Text",PeriodosBindingSource,"Descripcion");
            edicion(false);
            this.dgPeriodos.ReadOnly = true;
            
        }
        private void cargarDataGrid()
        {
            PeriodosBindingSource.DataSource = db.getPeriodos();
            this.dgPeriodos.DataSource = PeriodosBindingSource;
        }
        private void edicion(bool e)
        {
            if (e)
            {
                this.txtDescripcion.Enabled = true;
                this.dtFechaInicio.Enabled = true;
                this.dtFechaFin.Enabled = true;
            }
            else
            {
                this.txtId.Enabled = false;
                this.txtDescripcion.Enabled = false;
                this.dtFechaInicio.Enabled = false;
                this.dtFechaFin.Enabled = false;
            }
        }

        public void Nuevo()
        {
            //Limpiar todos los controles y quitar el enlace a los datos
            this.dgPeriodos.Enabled=false;
            this.txtDescripcion.DataBindings.RemoveAt(0);
            this.txtId.DataBindings.RemoveAt(0);
            this.dtFechaInicio.DataBindings.RemoveAt(0);
            this.dtFechaFin.DataBindings.RemoveAt(0);
            this.txtId.Clear();
            this.txtDescripcion.Clear();
            this.dtFechaInicio.ResetText();
            this.dtFechaFin.ResetText();
            edicion(true);
        }

        public void Imprimir()
        {
            throw new NotImplementedException();
        }
        private bool insertPeriodo(Periodo Periodo)
        {
            
            try
            {
                db.insertPeriodo(Periodo);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            return true;
        }
        private bool actualizarPeriodo(Periodo Periodo)
        {

            try
            {
                db.actualizarPeriodo(Periodo);
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
                    Periodo Periodo = new Periodo();
                    Periodo.FechaInicio = Convert.ToDateTime(this.dtFechaInicio.Text);
                    Periodo.FechaFin = Convert.ToDateTime(this.dtFechaFin.Text);
                    Periodo.Descripcion= this.txtDescripcion.Text;
                    insertPeriodo(Periodo);
                    this.dgPeriodos.Enabled = true;
                    cargarDataGrid();
                    this.txtId.DataBindings.Add("Text", PeriodosBindingSource, "Id");
                    this.dtFechaInicio.DataBindings.Add("Text", PeriodosBindingSource, "FechaInicio");
                    this.dtFechaFin.DataBindings.Add("Text", PeriodosBindingSource, "FechaFin");
                    this.txtDescripcion.DataBindings.Add("Text", PeriodosBindingSource, "Descripcion");
                    this.PeriodosBindingSource.MoveLast();
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
                    Periodo Periodo = new Periodo();
                    Periodo.Id = Convert.ToInt32(this.txtId.Text);
                    Periodo.FechaInicio = Convert.ToDateTime(this.dtFechaInicio.Text);
                    Periodo.FechaFin = Convert.ToDateTime(this.dtFechaFin.Text);
                    Periodo.Descripcion = this.txtDescripcion.Text;
                    actualizarPeriodo(Periodo);
                    this.dgPeriodos.Enabled = true;
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
            this.PeriodosBindingSource.ResetCurrentItem();
        }

        public void Editar()
        {
            this.txtDescripcion.Select();
            this.dgPeriodos.Enabled = false;
            edicion(true);
        }

        public void Borrar()
        {
            Periodo Periodo = new Periodo();
            Periodo.Id = Convert.ToInt32(this.txtId.Text);
            db.borrarPeriodo(Periodo);
            cargarDataGrid();
            edicion(false);
        }

        public void IrPrimero()
        {
            this.PeriodosBindingSource.MoveFirst();
        }

        public void Anterior()
        {
            this.PeriodosBindingSource.MovePrevious();
        }

        public void Siguiente()
        {
            this.PeriodosBindingSource.MoveNext();
        }

        public void IrFinal()
        {
            this.PeriodosBindingSource.MoveLast();
        }

        public bool vacio()
        {
            int cant=db.cantPeriodos();
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
            form.buscarGenerico1.cbInput.DataSource = this.PeriodosBindingSource;
            form.buscarGenerico1.cbInput.DisplayMember = "Descripcion";
            form.buscarGenerico1.Grid = this.PeriodosBindingSource;
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
