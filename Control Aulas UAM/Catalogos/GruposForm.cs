using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_Aulas_UAM.Clases.Db;
using Control_Aulas_UAM.Catalogos;

namespace Control_Aulas_UAM.Catalogos
{
    public partial class GruposForm : Form
    {
        Grupo grupo = null;

        public Grupo Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }
        public GruposForm()
        {
            InitializeComponent();
        }
        public GruposForm(Grupo g)
        {
            InitializeComponent();
            grupo = g;
        }
        public void asignarAsignatura(List<Asignatura> asignatura)
        {
            cbAsignatura.DataSource = asignatura;
            cbAsignatura.DisplayMember = "Nombre";
            cbAsignatura.ValueMember = "Id";
            //if (asignatura.Count == 0)
            //{
               // this.cbAsignatura.Enabled = false;
            //}
        }
        
        public void asignarDocentes(List<Docente> docentes)
        {
            cbDocente.DataSource = docentes;
            cbDocente.DisplayMember = "Nombre";
            cbDocente.ValueMember = "Id";
        }
        public void asignarPeriodo(List<Periodo> periodos)
        {
            cbPeriodo.DataSource = periodos;
            cbPeriodo.DisplayMember = "Descripcion";
            cbPeriodo.ValueMember = "Id";
        }
        public void editar(Boolean e)
        {
            if (e)
            {
                this.txtId.Enabled = false;
                this.txtInscritos.Enabled = true;
                this.cbAsignatura.Enabled = false;
                this.cbDocente.Enabled = true;
                this.cbPeriodo.Enabled = true;
                this.btnAgregar.Enabled = true;
                this.btnBorrar.Enabled = true;
                this.btnEditar.Enabled = true;
            }
            else
            {
                this.txtId.Enabled = false;
                this.txtInscritos.Enabled = false;
                this.cbAsignatura.Enabled = false;
                this.cbDocente.Enabled = false;
                this.cbPeriodo.Enabled = false;
                this.btnAgregar.Enabled = false;
                this.btnBorrar.Enabled = false;
                this.btnEditar.Enabled = false;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
