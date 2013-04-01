using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Control_Aulas_UAM.Clases;
using Control_Aulas_UAM.Clases.Db;
using System.Data.SqlClient;

namespace Control_Aulas_UAM
{
    public partial class BuscarGupoControl : UserControl
    {
        Conexion conexion;
        List<Docente> docentes;
        List<Asignatura> asignaturas;
        List<Aula> aulas;
        List<Grupo> grupos;
        List<AsignacionEncontrada> asignacionesEncontradas;
        List<Aula> aulasFiltradas;
        public static int INVALID_ID = -1;
        public List<Aula> Aulas { get { return aulas; } set { aulas = value; } }
        public BuscarGupoControl()
        {
            InitializeComponent();
            try
            {
                dataGridViewResultado.AutoGenerateColumns = false;
                docentes = new List<Docente>();
                asignaturas = new List<Asignatura>();
                docentes.Add(new Docente());
                asignaturas.Add(new Asignatura());
                conexion = new Conexion();
                //aulas = conexion.getAulas();
                docentes.AddRange(conexion.getDocentes());
                asignaturas.AddRange(conexion.getAsignaturasConGrupo());
                comboBoxDocente.DataSource = docentes;
                comboBoxDocente.DisplayMember = "nombre";
                comboBoxDocente.ValueMember = "id";
                comboBoxAsignatura.DataSource = asignaturas;
                comboBoxAsignatura.DisplayMember = "nombre";
                comboBoxAsignatura.ValueMember = "id";
                dateTimeInputInicio.Value = DateTime.Today;
                dateTimeInputFin.Value = DateTime.Today.AddDays(1);

                ColumnAula.DataPropertyName = "Aula";
                ColumnDocente.DataPropertyName = "Docente";
                ColumnAsignatura.DataPropertyName = "Asignatura";
                ColumnGrupo.DataPropertyName = "Grupo";
                ColumnInicio.DataPropertyName = "Inicio";
                ColumnFin.DataPropertyName = "Fin";
            }
            catch (Exception ex) { }
        }

        private void BuscarGupoControl_Load(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            buscar();
        }

        void buscar() {
            Docente docente = (Docente)comboBoxDocente.SelectedItem;
            aulasFiltradas = filtrarAulas();
        }

        private void checkBoxInicio_CheckedChanged(object sender, EventArgs e)
        {
            dateTimeInputInicio.Enabled = checkBoxInicio.Checked;
        }

        private void checkBoxFin_CheckedChanged(object sender, EventArgs e)
        {
            dateTimeInputFin.Enabled = checkBoxFin.Checked;
        }

        private void checkBoxDocente_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxDocente.Enabled = checkBoxDocente.Checked;
        }

        private void checkBoxAsignatura_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxAsignatura.Enabled = checkBoxAsignatura.Checked;
            checkBoxGrupo.Enabled = checkBoxAsignatura.Checked;
            checkBoxGrupo.Checked = checkBoxAsignatura.Checked;
        }

        private void checkBoxGrupo_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxGrupo.Enabled = checkBoxGrupo.Checked;
        }

        private void handleGrupos()
        {
            Asignatura asignatura = (Asignatura)comboBoxAsignatura.SelectedItem;
            if (asignatura != null)
            {
                grupos = conexion.getGrupos(asignatura);
                comboBoxGrupo.DataSource = grupos;
                comboBoxGrupo.DisplayMember = "NumeroGrupo";
            }
            else
            {
                grupos = null;
                comboBoxGrupo.DataSource = grupos;
            }
            //handleDocente();
            //superValidator.Validate();
        }

        private void comboBoxAsignatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            handleGrupos();
        }

        private void comboBoxAsignatura_Leave(object sender, EventArgs e)
        {
            handleGrupos();
        }

        public List<Aula> filtrarAulas()
        {
            List<Aula> aulasEncontradas=null;
            DateTime? inicio = null;
            DateTime? fin = null;
            String docente = null;
            String asignatura = null;
            int id_grupo = INVALID_ID;
            if (checkBoxInicio.Checked)
            {
                inicio = dateTimeInputInicio.Value;
            }
            if (checkBoxFin.Checked)
            {
                fin = dateTimeInputFin.Value;
            }
            if (checkBoxDocente.Checked)
            { 
                /*Docente docente = (Docente)comboBoxDocente.SelectedItem;
                if (docente != null) {
                    id_docente=docente.Id;
                }*/
                docente = comboBoxDocente.Text;
            }
            if (checkBoxAsignatura.Checked)
            {
                /*Asignatura asignatura = (Asignatura)comboBoxAsignatura.SelectedItem;
                if (asignatura != null)
                {
                    id_asignatura = asignatura.Id;
                }*/
                asignatura = comboBoxAsignatura.Text;
            }
            if (checkBoxGrupo.Checked)
            {
                Grupo grupo = (Grupo)comboBoxGrupo.SelectedItem;
                if (grupo != null)
                {
                    id_grupo = grupo.Id;
                }
            }
            aulasEncontradas = filtrarAulas(aulas, inicio, fin, docente, asignatura, id_grupo);
            dataGridViewResultado.DataSource = asignacionesEncontradas;
            for (int i = 0; i < dataGridViewResultado.Rows.Count; i++)
                dataGridViewResultado["ColumnCheck", i].Value = false;
            return aulasEncontradas;
        }

        public List<Aula> filtrarAulas(List<Aula> aulas, DateTime? inicio, DateTime? fin, String docente, String asignatura, int id_grupo)
        {
            List<Aula> aulasFiltradas = null;
            SqlConnection sqlConnection = null;
            SqlCommand sqlCommand = null;
            try
            {
                sqlConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ScheduleTesting.Properties.Settings.uam_agendaConnectionString"].ToString()); ;
                sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT au.id_aula as id_aula, au.referencia as aula, do.nombre as docente,asig.nombre as asignatura," +
                "gr.id_grupo as grupo, ac.inicio as inicio, ac.fin as fin"+
                    " FROM asignacion_clase as ac " +
                    " INNER JOIN grupo as gr on gr.id_grupo=ac.id_grupo " +
                    " INNER JOIN aula as au on au.id_aula=ac.id_aula " +
                    " INNER JOIN docente as do on do.id_docente=gr.id_docente " +
                    " INNER JOIN asignatura as asig on asig.id_asignatura=gr.id_asignatura ";
                String conc=" WHERE ";
                if (inicio != null) {
                    sqlCommand.CommandText += conc+ " ac.inicio >= @inicio ";
                    sqlCommand.Parameters.Add(new SqlParameter("@inicio", SqlDbType.DateTime));
                    sqlCommand.Parameters["@inicio"].Value = inicio;
                    conc = " AND ";
                }
                if (fin != null)
                {
                    sqlCommand.CommandText += conc + " ac.fin <= @fin ";
                    sqlCommand.Parameters.Add(new SqlParameter("@fin", SqlDbType.DateTime));
                    sqlCommand.Parameters["@fin"].Value = fin;
                    conc = " AND ";
                }
                if (docente != null)
                {
                    sqlCommand.CommandText += conc + " do.nombre LIKE(@docente) ";
                    sqlCommand.Parameters.Add(new SqlParameter("@docente", SqlDbType.VarChar));
                    sqlCommand.Parameters["@docente"].Value = "%"+docente+"%";
                    conc = " AND ";
                }
                if (asignatura != null)
                {
                    sqlCommand.CommandText += conc + " asig.nombre LIKE(@asignatura) ";
                    sqlCommand.Parameters.Add(new SqlParameter("@asignatura", SqlDbType.VarChar));
                    sqlCommand.Parameters["@asignatura"].Value = "%"+asignatura+"%";
                    conc = " AND ";
                }
                if (id_grupo > INVALID_ID)
                {
                    sqlCommand.CommandText += conc + " gr.id_grupo=@id_grupo ";
                    sqlCommand.Parameters.Add(new SqlParameter("@id_grupo", SqlDbType.Int));
                    sqlCommand.Parameters["@id_grupo"].Value = id_grupo;
                    conc = " AND ";
                }
                sqlCommand.Connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    asignacionesEncontradas = new List<AsignacionEncontrada>();
                    aulasFiltradas = new List<Aula>();
                    while (sqlDataReader.Read())
                    {
                        int id = (int)sqlDataReader["id_aula"];
                        Aula foundedAula = aulas.Find(element => element.Id == id);
                        aulasFiltradas.Add(foundedAula);
                        AsignacionEncontrada asignacionEncontrada = new AsignacionEncontrada();
                        asignacionEncontrada.Id_Aula = id;
                        asignacionEncontrada.Aula = sqlDataReader["aula"].ToString();
                        asignacionEncontrada.Docente = sqlDataReader["docente"].ToString();
                        asignacionEncontrada.Asignatura = sqlDataReader["asignatura"].ToString();
                        asignacionEncontrada.Grupo = sqlDataReader["grupo"].ToString();
                        asignacionEncontrada.Inicio = (DateTime)sqlDataReader["inicio"];
                        asignacionEncontrada.Fin = (DateTime)sqlDataReader["fin"];
                        asignacionesEncontradas.Add(asignacionEncontrada);
                    }
                }
                else {
                    asignacionesEncontradas = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return aulasFiltradas;
        }

        internal List<Aula> getAulasSeleccionadas()
        {
            List<Aula> aulasSeleccionadas = new List<Aula>();
            for (int i = 0; i < dataGridViewResultado.Rows.Count; i++)
            {
                if ((bool)dataGridViewResultado["ColumnCheck", i].Value)
                {
                    int id_aula = asignacionesEncontradas[i].Id_Aula;
                    Aula aula = aulas.Find(element=>element.Id==id_aula);
                    if (aula != null)
                    {
                        if (!aulasSeleccionadas.Contains(aula))
                        {
                            aulasSeleccionadas.Add(aula);
                        }
                    }
                }
            }
            if (aulasSeleccionadas.Count == 0)
                aulasSeleccionadas = null;
            return aulasSeleccionadas;
        }
    }

    class AsignacionEncontrada {
        int id_aula;
        String aula;
        String docente;
        String asignatura;
        String grupo;
        DateTime inicio;
        DateTime fin;

        public int Id_Aula { get { return id_aula; } set { id_aula = value; } }
        public String Aula {get{return aula;} set{aula=value;}}
        public String Docente{get {return docente;} set{docente=value;}}
        public String Asignatura{get {return asignatura;} set{asignatura=value;}}
        public String Grupo{get{return grupo;} set{grupo=value;}}
        public DateTime Inicio{get{return inicio;} set{inicio=value;}}
        public DateTime Fin {get{return fin;} set{fin=value;}}
    }
}
