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
using Control_Aulas_UAM.Clases;
using System.Data.SqlClient;
using DevComponents.DotNetBar.Controls;

namespace Control_Aulas_UAM
{
    public partial class BuscarControl : UserControl
    {
        List<Equipo> equipos;
        List<AulaTipo> aulaTipos;
        List<Aula> aulas;
        public List<Aula> Aulas { get { return aulas; } set { aulas = value; } }

        public BuscarControl()
        {
            InitializeComponent();
            try
            {
                equipos = new Conexion().getEquipos();
                ColumnEquipo.DataSource = equipos;
                ColumnEquipo.DisplayMember = "Descripcion";
                ColumnEquipo.ValueMember = "ID";
                comboBoxEquipo.DataSource = equipos;
                comboBoxEquipo.DisplayMember = "Descripcion";
                comboBoxEquipo.ValueMember = "ID";
                aulaTipos = new Conexion().getAulaTipos();
                AulaTipo aulaTipoCualquiera = new AulaTipo();
                aulaTipoCualquiera.Id = 0;
                aulaTipoCualquiera.Descripcion = "Cualquiera";
                aulaTipos.Add(aulaTipoCualquiera);
                comboBoxTipoAula.DataSource = aulaTipos;
                comboBoxTipoAula.DisplayMember = "Descripcion";
                comboBoxTipoAula.ValueMember = "Id";
                comboBoxTipoAula.SelectedValue = 0;
                dataGridViewResultado.AutoGenerateColumns = false;
                ColumnEdificio.DataPropertyName = "NombreEdificio";
                ColumnAula.DataPropertyName = "Referencia";
                ColumnCapacidad.DataPropertyName = "Capacidad";
                ColumnAulaTipo.DataPropertyName = "NombreTipo";
                dateTimeInputInicio.Value = DateTime.Now;
                dateTimeInputFin.Value = DateTime.Now.AddHours(2);
            }
            catch { }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            dataGridViewEquipo.Rows.Add(comboBoxEquipo.SelectedValue,1);
        }

        private void checkBoxCapacidad_CheckedChanged(object sender, EventArgs e)
        {
            integerInputCapacidad.Enabled = checkBoxCapacidad.Checked;
        }

        public List<Aula> filtrarAulas() {
            List<int[]> equipos = new List<int[]>();
            for (int i = 0; i < dataGridViewEquipo.Rows.Count; i++)
            {
                int[] equipoCant = new int[2];
                equipoCant[0] = Convert.ToInt32(dataGridViewEquipo["ColumnEquipo", i].Value);
                equipoCant[1] = Convert.ToInt32(dataGridViewEquipo["ColumnCantidad", i].Value);
                equipos.Add(equipoCant);
            }
            int capacidad = 0;
            if (checkBoxCapacidad.Checked)
            {
                capacidad = integerInputCapacidad.Value;
            }
            List<Aula> aulasEncontradas = filtrarAulas(aulas, dateTimeInputInicio.Value, dateTimeInputFin.Value, (int)comboBoxTipoAula.SelectedValue, capacidad, equipos);
            dataGridViewResultado.DataSource = aulasEncontradas;
            for (int i = 0; i < dataGridViewResultado.Rows.Count; i++)
                dataGridViewResultado["ColumnCheck", i].Value = false;
            return aulasEncontradas;
        }

        public List<Aula> filtrarAulas(List<Aula> aulas, DateTime inicio, DateTime fin, int idAulaTipo, int capacidad, List<int[]> equipos) {
            List<Aula> aulasFiltradas = null;
            SqlConnection sqlConnection = null;
            SqlCommand sqlCommand = null;
            try
            {
                sqlConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ScheduleTesting.Properties.Settings.uam_agendaConnectionString"].ToString()); ;
                sqlCommand=new SqlCommand();
                sqlCommand.Connection=sqlConnection;
                sqlCommand.CommandText = "SELECT AU.id_aula FROM aula AS AU" +
                    " WHERE NOT EXISTS (SELECT * FROM asignacion_clase AS AC WHERE AC.id_aula=AU.id_aula AND ((@inicio between inicio AND fin) OR (@fin between inicio AND fin) OR (@inicio<inicio AND @fin>fin)) AND AC.reprogramada=0 ) " +
                    " AND NOT EXISTS (SELECT * FROM asignacion_varios AS AV WHERE AV.id_aula=AU.id_aula AND ((@inicio between inicio AND fin) OR (@fin between inicio AND fin) OR (@inicio<inicio AND @fin>fin))) ";
                if (capacidad>0)
                {
                    sqlCommand.CommandText += " AND AU.capacidad>@capacidad ";
                    sqlCommand.Parameters.Add(new SqlParameter("@capacidad", SqlDbType.Int));
                    sqlCommand.Parameters["@capacidad"].Value = capacidad;
                }
                if (idAulaTipo != 0)
                {
                    sqlCommand.CommandText += " AND AU.id_tipo=@aula_tipo ";
                    sqlCommand.Parameters.Add(new SqlParameter("@aula_tipo", SqlDbType.Int));
                    sqlCommand.Parameters["@aula_tipo"].Value = idAulaTipo;
                }
                if (equipos != null) {
                    if (equipos.Count > 0) {
                        int i=0;
                        foreach (int[] equipo in equipos)
                        {
                            sqlCommand.CommandText += " AND EXISTS (SELECT * FROM aula_equipo AS AE WHERE AE.id_aula=AU.id_aula AND AE.id_equipo=@id_equipo" + i + " AND AE.cantidad>=@aula_equipo_cant"+i+" ) ";
                            sqlCommand.Parameters.Add("@id_equipo" + i, SqlDbType.Int);
                            sqlCommand.Parameters["@id_equipo" + i].Value = equipo[0];
                            sqlCommand.Parameters.Add("@aula_equipo_cant" + i, SqlDbType.Int);
                            sqlCommand.Parameters["@aula_equipo_cant" + i].Value = equipo[1];
                        }
                    }
                }
                sqlCommand.Parameters.Add(new SqlParameter("@inicio", SqlDbType.DateTime));
                sqlCommand.Parameters.Add(new SqlParameter("@fin", SqlDbType.DateTime));
                sqlCommand.Parameters["@inicio"].Value = inicio;
                sqlCommand.Parameters["@fin"].Value = fin;
                sqlCommand.Connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    aulasFiltradas = new List<Aula>();
                    while (sqlDataReader.Read())
                    {
                        int id = (int)sqlDataReader["id_aula"];
                        Aula foundedAula = aulas.Find(element => element.Id == id);
                        aulasFiltradas.Add(foundedAula);
                    }
                }
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
            return aulasFiltradas;
        }

        public List<Aula> getAulasSeleccionadas() {
            List<Aula> aulasSeleccionadas=new List<Aula>();
            for (int i = 0; i < dataGridViewResultado.Rows.Count; i++) {
                if ((bool)dataGridViewResultado["ColumnCheck", i].Value)
                {
                    List<Aula> aulasFiltradas = (List<Aula>)dataGridViewResultado.DataSource;
                    aulasSeleccionadas.Add(aulasFiltradas[i]);
                }
            }
            if (aulasSeleccionadas.Count == 0)
                aulasSeleccionadas = null;
            return aulasSeleccionadas;
        }
    }
}
