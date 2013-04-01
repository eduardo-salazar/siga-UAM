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
using Control_Aulas_UAM.Catalogos;
using System.Data.SqlClient;

namespace Control_Aulas_UAM.Catalogos
{
    public partial class AsignaturasForm : UserControl,Funciones
    {
        Conexion db = null;
        BindingSource AsignaturasBindingSource = null;
        List<Facultad> facultades = null;
        List<AsignaturaCategoria> categorias = null;
        
        List<Grupo> grupos = null;
        GruposForm gruposForm = null;
        Boolean nuevo = false;
        public AsignaturasForm()
        {
            InitializeComponent();
            db = new Conexion();
            AsignaturasBindingSource = new BindingSource();

            if (!vacio())
            {
                cargarDataGrid();
                cargarDataGridGrupos();
                //
                //Enlazar id y nombre
                //
                this.txtId.DataBindings.Add("Text", AsignaturasBindingSource, "Referencia");
                this.txtNombre.DataBindings.Add("Text", AsignaturasBindingSource, "Nombre");
                //

                //
                //Ocultar ids
                //
                this.dgAsignaturas.Columns["IdFacultad"].Visible = false;
                this.dgAsignaturas.Columns["IdCategoria"].Visible = false;
                this.dgAsignaturas.Columns["Id"].Visible = false;
                this.dgAsignaturas.Columns["NombreCompleto"].Visible = false;
            }
            
            //Mostrar valores de los combos
            //
            facultades = db.getFacultades();
            this.cbFacultad.DataSource = facultades;
            this.cbFacultad.DisplayMember = "Descripcion";
            this.cbFacultad.ValueMember = "Id";
            categorias = db.getAsignaturaCategorias();
            this.cbCategoria.DataSource = categorias;
            this.cbCategoria.DisplayMember = "Descripcion";
            this.cbCategoria.ValueMember = "Id";

            sincronizarCombos();

            if (facultades.Count == 0 || categorias.Count == 0)
            {
                MessageBox.Show("Se requieren que ciertos catalogos no esten vacios");
            }
            
            //Manejador del evento del binding
            this.AsignaturasBindingSource.PositionChanged+=AsignaturasBindingSource_PositionChanged;
            
            edicion(false);
            this.dgAsignaturas.ReadOnly = true;

            //Manejador de evento del datagrid de Grupos
            this.dgGrupos.DoubleClick+=new EventHandler(dgGrupos_DoubleClick);

            /*------EVENTOS DEL FORM GRUPOS--------------*/
            this.gruposForm = new GruposForm();
            this.gruposForm.editar(false);
            this.gruposForm.btnAgregar.Click+=new EventHandler(btnAgregar_Click);
            this.gruposForm.btnEditar.Click+=new EventHandler(btnEditar_Click);
            this.gruposForm.btnBorrar.Click+=new EventHandler(btnBorrar_Click);

            /*------FIN DEL FORM GRUPOS--------------*/
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                Grupo grupo = this.gruposForm.Grupo;
                db.borrarGrupo(grupo);
                gruposForm.Hide();
                cargarDataGridGrupos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //GUARDAR
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Grupo grupo = this.gruposForm.Grupo;
                grupo.Docente.Id = Convert.ToInt32(this.gruposForm.cbDocente.SelectedValue);
                grupo.Periodo.Id = Convert.ToInt32(this.gruposForm.cbPeriodo.SelectedValue);
                grupo.CantidadEstudiantes = Convert.ToInt32(this.gruposForm.txtInscritos.Text);
                db.actualizarGrupo(grupo);
                gruposForm.Hide();
                cargarDataGridGrupos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Grupo grupo = new Grupo();
                Asignatura asignatura = new Asignatura();
                asignatura.Id = Convert.ToInt32(gruposForm.cbAsignatura.SelectedValue);
                grupo.Asignatura = asignatura;
                Docente docente = new Docente();
                docente.Id = Convert.ToInt32(gruposForm.cbDocente.SelectedValue);
                grupo.Docente = docente;
                if(gruposForm.txtInscritos.Text.Equals(""))
                {   
                    grupo.CantidadEstudiantes=0;
                }
                else
                {
                    grupo.CantidadEstudiantes = Convert.ToInt32(gruposForm.txtInscritos.Text);
                }
                Periodo periodo = new Periodo();
                periodo.Id = Convert.ToInt32(gruposForm.cbPeriodo.SelectedValue);
                grupo.Periodo = periodo;
                db.insertGrupo(grupo);
                gruposForm.Hide();
                cargarDataGridGrupos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        

        private void dgGrupos_DoubleClick(object sender, EventArgs e)
        {
            Grupo grupo=grupos[dgGrupos.SelectedRows[0].Index];
            List<Asignatura> asignaturas = new List<Asignatura>();
            asignaturas.Add((Asignatura)AsignaturasBindingSource.Current);
            List<Docente> docentes = db.getDocentes();
            List<Periodo> periodos = db.getPeriodos();
            gruposForm.asignarAsignatura(asignaturas);
            gruposForm.Grupo = grupo;
            gruposForm.asignarDocentes(docentes);
            gruposForm.asignarPeriodo(periodos);

            foreach (Docente a in docentes)
            {
                if (a.Id == grupo.Docente.Id)
                {
                    gruposForm.cbDocente.SelectedIndex = docentes.IndexOf(a);
                }
            }
            foreach (Periodo a in periodos)
            {
                if (a.Id == grupo.Periodo.Id)
                {
                    gruposForm.cbPeriodo.SelectedIndex = periodos.IndexOf(a);
                }
            }
            gruposForm.txtId.Text = grupo.NumeroGrupo.ToString();
            gruposForm.txtId.Enabled = false;
            gruposForm.txtInscritos.Text = grupo.CantidadEstudiantes.ToString();

            gruposForm.btnAgregar.Visible = false;
            gruposForm.btnBorrar.Visible = true;
            gruposForm.btnEditar.Visible = true;
            gruposForm.ShowDialog();
        }
        private void sincronizarCombos()
        {
            Asignatura asignatura = (Asignatura)this.AsignaturasBindingSource.Current;
            int idFacultad = asignatura.IdFacultad;
            int idCategoria = asignatura.IdCategoria;

            //asignar index correspondiente
            foreach(Facultad f in facultades)
            {
                if (f.Id.Equals(idFacultad))
                {
                    this.cbFacultad.SelectedIndex = facultades.IndexOf(f);
                    break;
                }
            }
            foreach (AsignaturaCategoria cat in categorias)
            {
                if (cat.Id.Equals(idCategoria))
                {
                    this.cbCategoria.SelectedIndex = categorias.IndexOf(cat);
                    break;
                }
            }
        }

        private void AsignaturasBindingSource_PositionChanged(object sender, EventArgs e)
        {
            sincronizarCombos();
            cargarDataGridGrupos();
        }
        List<Asignatura> asignaturas;
        private void cargarDataGrid()
        {
            asignaturas = db.getAsignaturas();
            AsignaturasBindingSource.DataSource = asignaturas;
            this.dgAsignaturas.DataSource = AsignaturasBindingSource;
            this.dgAsignaturas.Columns["Referencia"].HeaderText = "ID";
        }
        private void cargarDataGridGrupos()
        {
            grupos = db.getGrupos((Asignatura)AsignaturasBindingSource.Current);
            this.dgGrupos.DataSource = grupos;
            this.dgGrupos.Columns["Asignatura"].Visible = false;
            this.dgGrupos.Columns["Docente"].Visible = false;
            this.dgGrupos.Columns["Periodo"].Visible = false;
            this.dgGrupos.Columns["NombreDocente"].HeaderText = "Docente";
            this.dgGrupos.Columns["NombrePeriodo"].HeaderText = "Periodo";
            this.dgGrupos.Columns["CantidadEstudiantes"].HeaderText = "Inscritos";
            this.dgGrupos.Columns["Id"].Visible = false;
            this.dgGrupos.Columns["NumeroGrupo"].HeaderText = "Grupo";
        }
        private void edicion(bool e)
        {
            if (e)
            {
                this.txtNombre.Enabled = true;
                this.cbFacultad.Enabled = true;
                this.cbCategoria.Enabled = true;
                this.txtId.Enabled = true;
            }
            else
            {
                this.txtId.Enabled = false;
                this.txtNombre.Enabled = false;
                this.cbFacultad.Enabled = false;
                this.cbCategoria.Enabled = false;
            }
        }

        public void Nuevo()
        {
            //Limpiar todos los controles y quitar el enlace a los datos
            this.dgAsignaturas.Enabled=false;
            if (!vacio())
            {
                this.txtNombre.DataBindings.RemoveAt(0);
                this.txtId.DataBindings.RemoveAt(0);
            }
            this.txtId.Clear();
            this.txtNombre.Clear();
            this.cbFacultad.ResetText();
            this.cbCategoria.ResetText();
            edicion(true);
            this.nuevo = true;
        }

        public void Imprimir()
        {
            throw new NotImplementedException();
        }
        private bool insertAsignatura(Asignatura Asignatura)
        {
            
            try
            {
                db.insertAsignatura(Asignatura);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            return true;
        }
        private bool actualizarAsignatura(Asignatura Asignatura)
        {

            try
            {
                db.actualizarAsignatura(Asignatura);
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
            if (this.nuevo)
            {
                /*------------INSERTAR FACULTAD----------------*/
                if (this.txtNombre.Text != "")
                {
                    Asignatura Asignatura = new Asignatura();
                    Asignatura.IdFacultad = Convert.ToInt32(this.cbFacultad.SelectedValue);
                    Asignatura.IdCategoria = Convert.ToInt32(this.cbCategoria.SelectedValue);
                    Asignatura.Nombre= this.txtNombre.Text;
                    Asignatura.Referencia = this.txtId.Text;
                    insertAsignatura(Asignatura);
                    this.dgAsignaturas.Enabled = true;
                    cargarDataGrid();
                    this.txtId.DataBindings.Add("Text", AsignaturasBindingSource, "Referencia");
                    this.txtNombre.DataBindings.Add("Text", AsignaturasBindingSource, "Nombre");
                    this.AsignaturasBindingSource.MoveLast();
                    this.nuevo = false;
                    return true;
                }
                else
                {
                    MessageBox.Show("Descripción no puede estar vacio.", "Error", MessageBoxButtons.OK);
                    return false;
                }
                
                /*---------FIN INSERTAR FACULTAD----------------*/
                this.gruposForm.editar(false);

            }
            else
            {
                
                /*------------Actualizar FACULTAD----------------*/
                if (this.txtNombre.Text != "")
                {
                    Asignatura Asignatura = new Asignatura();
                    Asignatura.Id = ((Asignatura)AsignaturasBindingSource.Current).Id;
                    Asignatura.IdFacultad = Convert.ToInt32(this.cbFacultad.SelectedValue);
                    Asignatura.IdCategoria = Convert.ToInt32(this.cbCategoria.SelectedValue);
                    Asignatura.Nombre = this.txtNombre.Text;
                    Asignatura.Referencia = this.txtId.Text;
                    actualizarAsignatura(Asignatura);
                    this.dgAsignaturas.Enabled = true;
                    cargarDataGrid();
                    return true;
                }
                else
                {
                    MessageBox.Show("Descripción no puede estar vacio","Error",MessageBoxButtons.OK);
                    return false;
                }
                /*---------FIN Actualizar FACULTAD----------------*/
                this.gruposForm.editar(false);
            }
            
            
        }

        public void Cancelar()
        {
            this.AsignaturasBindingSource.ResetCurrentItem();
            this.gruposForm.editar(false);
        }

        public void Editar()
        {
            this.txtId.Focus();
            this.dgAsignaturas.Enabled = false;
            edicion(true);
            gruposForm.editar(true);
        }

        public void Borrar()
        {
            Asignatura Asignatura = new Asignatura();
            Asignatura.Id = Convert.ToInt32(this.txtId.Text);
            try
            {
                db.borrarAsignatura(Asignatura);
            }
            catch (SqlException e)
            {
                MessageBox.Show("No se puede Borrar Asignatura porque existen Grupos asignados a este registro");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede Borrar Asignatura porque existen Grupos asignados a este registro");
            }
            cargarDataGrid();
            edicion(false);
        }

        public void IrPrimero()
        {
            this.AsignaturasBindingSource.MoveFirst();
        }

        public void Anterior()
        {
            this.AsignaturasBindingSource.MovePrevious();
        }

        public void Siguiente()
        {
            this.AsignaturasBindingSource.MoveNext();
        }

        public void IrFinal()
        {
            this.AsignaturasBindingSource.MoveLast();
        }

        public bool vacio()
        {
            int cant=db.cantAsignaturas();
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
            form.buscarGenerico1.cbInput.DataSource = this.AsignaturasBindingSource;
            form.buscarGenerico1.cbInput.DisplayMember = "NombreCompleto";
            form.buscarGenerico1.Grid = this.AsignaturasBindingSource;
            form.ShowDialog();
        }

        private void AsignaturasForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            List<Asignatura> asignaturas = new List<Asignatura>();
            asignaturas.Add((Asignatura)AsignaturasBindingSource.Current);
            List<Docente> docentes = db.getDocentes();
            List<Periodo> periodos = db.getPeriodos();
            gruposForm.asignarAsignatura(asignaturas);
            gruposForm.asignarDocentes(docentes);
            gruposForm.asignarPeriodo(periodos);
            //Ocultar el id
            gruposForm.txtId.Visible = false;
            gruposForm.lbId.Visible = false;
            //ocultar botoner de editar y borrar
            gruposForm.btnBorrar.Visible = false;
            gruposForm.btnEditar.Visible = false;
            gruposForm.btnAgregar.Visible = true;

            gruposForm.ShowDialog();
        }

    }
}
