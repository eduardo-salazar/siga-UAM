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

namespace Control_Aulas_UAM.Catalogos
{
    public partial class FacultadForm : UserControl,Funciones 
    {
        Conexion db = null;
        BindingSource FacultadesBindingSource = null;
        public FacultadForm()
        {
            InitializeComponent();
            db = new Conexion();
            FacultadesBindingSource = new BindingSource();
            cargarDataGrid();
            this.txtId.DataBindings.Add("Text", FacultadesBindingSource, "Id");
            this.txtDescripcion.DataBindings.Add("Text",FacultadesBindingSource,"Descripcion");
            this.colorPickerButton1.DataBindings.Add("SelectedColor",FacultadesBindingSource,"color");
            edicion(false);
            this.dgFacultades.ReadOnly = true;
            ColumnColor.DefaultCellStyle.BackColor = Color.Black;
            ColumnColor.DefaultCellStyle.SelectionBackColor = Color.Black;
        }
        private void cargarDataGrid()
        {
            FacultadesBindingSource.DataSource = db.getFacultades();
            this.dgFacultades.DataSource = FacultadesBindingSource;
        }
        private void edicion(bool e)
        {
            if (e)
            {
                this.txtDescripcion.Enabled = true;
                colorPickerButton1.Enabled = true;
            }
            else
            {
                this.txtId.Enabled = false;
                this.txtDescripcion.Enabled = false;
                colorPickerButton1.Enabled = false;
            }
        }

        public void Nuevo()
        {
            //Limpiar todos los controles y quitar el enlace a los datos
            this.dgFacultades.Enabled=false;
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
        private bool insertFacultad(Facultad fac)
        {
            
            try
            {
                db.insertFacultad(fac);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            return true;
        }
        private bool actualizarFacultad(Facultad fac)
        {

            try
            {
                db.actualizarFacultad(fac);
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
                    Facultad fac = new Facultad();
                    fac.Descripcion = this.txtDescripcion.Text;
                    fac.Color = colorPickerButton1.SelectedColor;
                    insertFacultad(fac);
                    this.dgFacultades.Enabled = true;
                    cargarDataGrid();
                    this.txtId.DataBindings.Add("Text", FacultadesBindingSource, "Id");
                    this.txtDescripcion.DataBindings.Add("Text", FacultadesBindingSource, "Descripcion");
                    this.FacultadesBindingSource.MoveLast();
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
                    Facultad fac = new Facultad();
                    fac.Id = Convert.ToInt32(this.txtId.Text);
                    fac.Descripcion = this.txtDescripcion.Text;
                    fac.Color = this.colorPickerButton1.SelectedColor;
                    actualizarFacultad(fac);
                    this.dgFacultades.Enabled = true;
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
            this.FacultadesBindingSource.ResetCurrentItem();
        }

        public void Editar()
        {
            this.txtDescripcion.Select();
            this.dgFacultades.Enabled = false;
            edicion(true);
        }

        public void Borrar()
        {
            Facultad fac = new Facultad();
            fac.Id = Convert.ToInt32(this.txtId.Text);
            db.borrarFacultad(fac);
            cargarDataGrid();
            edicion(false);
        }

        public void IrPrimero()
        {
            this.FacultadesBindingSource.MoveFirst();
        }

        public void Anterior()
        {
            this.FacultadesBindingSource.MovePrevious();
        }

        public void Siguiente()
        {
            this.FacultadesBindingSource.MoveNext();
        }

        public void IrFinal()
        {
            this.FacultadesBindingSource.MoveLast();
        }

        public bool vacio()
        {
            int cant=db.cantFacultades();
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
            form.buscarGenerico1.cbInput.DataSource = this.FacultadesBindingSource;
            form.buscarGenerico1.cbInput.DisplayMember = "Descripcion";
            form.buscarGenerico1.Grid = this.FacultadesBindingSource;
            form.ShowDialog();
        }

        private void lbId_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgFacultades_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == dgFacultades.Columns["ColumnColor"].Index && e.RowIndex>=0) {
                Color color = (Color)dgFacultades[e.ColumnIndex, e.RowIndex].Value;
                e.CellStyle.BackColor = color;
                e.CellStyle.SelectionBackColor = color;
                e.CellStyle.ForeColor = color;
                e.CellStyle.SelectionForeColor = color;
            }
        }

    }
}
