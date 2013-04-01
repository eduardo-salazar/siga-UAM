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

namespace Control_Aulas_UAM
{
    public partial class AsignacionClaseControl : UserControl
    {
        Conexion conexion;
        List<Aula> aulas;
        List<Asignatura> asignaturas;
        bool readOnly;
        public bool ReadOnly { get { return readOnly; } set { readOnly = value; HandleControls(); } }

        public List<Aula> Aulas { get { return aulas; } set { aulas = value; comboBoxLugar.DataSource = aulas; } }
        public List<Asignatura> Asignaturas { get { return asignaturas; } set { asignaturas = value; comboBoxAsignatura.DataSource = asignaturas; } }
        private List<Grupo> Grupos;

        public AsignacionClaseControl()
        {
            InitializeComponent();
            try
            {
                conexion = new Conexion();
                comboBoxAsignatura.DisplayMember = "NombreCompleto";
                comboBoxGrupo.DisplayMember = "NumeroGrupo";
                comboBoxLugar.DisplayMember = "Referencia";
            }catch{}
        }

        void HandleControls() { 
            bool enabled=!readOnly;
            dateTimeInputInicio.Enabled = enabled;
            dateTimeInputFin.Enabled = enabled;
            comboBoxAsignatura.Enabled = enabled;
            comboBoxGrupo.Enabled = enabled;
            comboBoxLugar.Enabled = enabled;
        }

        public DateTime Inicio { get { return dateTimeInputInicio.Value; } set { dateTimeInputInicio.Value = value; } }
        public DateTime Fin { get { return dateTimeInputFin.Value; } set { dateTimeInputFin.Value = value; } }
        public Aula Aula { get { return (Aula)comboBoxLugar.SelectedItem; } set { comboBoxLugar.SelectedItem = value; } }
        public Asignatura Asignatura { get { return (Asignatura)comboBoxAsignatura.SelectedItem; } set { comboBoxAsignatura.SelectedItem = value; } }
        public Grupo Grupo { get { return (Grupo)comboBoxGrupo.SelectedItem; } set { comboBoxGrupo.SelectedItem = value; } }
        

        private void dateTimeInput_ValueChanged(object sender, EventArgs e)
        {
            DateTime inicio = dateTimeInputInicio.Value;
            DateTime fin = dateTimeInputFin.Value;
            if (DateTime.Compare(inicio, fin) == -1)
            {
                TimeSpan offset = fin.Subtract(inicio);
                String text = "";
                if (offset.Days > 0)
                    text += offset.Days + " dias ";
                if (offset.Hours > 0)
                    text += offset.Hours + " horas ";
                if (offset.Minutes > 0)
                    text += " " + offset.Minutes + " minutos ";
                textBoxDuracion.Text = text;
            }
            else
            {
                textBoxDuracion.Text = "Invalido";
            }
            superValidator.Validate();
        }

        private void comboBoxAsignatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            superValidator.Validate();
            handleGrupos();
        }

        private void comboBoxAsignatura_Leave(object sender, EventArgs e)
        {
            superValidator.Validate();
            handleGrupos();
        }

        public void EnableEdit(bool enable) {
            dateTimeInputInicio.Enabled = enable;
            dateTimeInputFin.Enabled = enable;
            comboBoxLugar.Enabled = enable;
            comboBoxAsignatura.Enabled = enable;
            comboBoxGrupo.Enabled = enable;
        }

        public bool ValidateControls()
        {
            return superValidator.Validate();
        }

        private void comboBoxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            handleDocente();
        }

        private void handleGrupos()
        {
            Asignatura asignatura = (Asignatura)comboBoxAsignatura.SelectedItem;
            if (asignatura != null)
            {
                Grupos = conexion.getGrupos(asignatura);
                comboBoxGrupo.DataSource = Grupos;
                comboBoxGrupo.DisplayMember = "NumeroGrupo";
            }
            else {
                Grupos = null;
                comboBoxGrupo.DataSource = Grupos;
            }
            handleDocente();
            superValidator.Validate();
        }

        void handleDocente() {
            String docente = "";
            if (Grupo != null ? Grupo.Docente != null : false)
            {
                docente = Grupo.Docente.Nombre;
            }
            textBoxDocente.Text = docente;
        }

        private void customValidator_Asignatura_Exists_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            String text = comboBoxAsignatura.Text;
            Asignatura foundAsignatura = asignaturas.Find(element => element.Nombre.Equals(text) || element.NombreCompleto.Equals(text));
            if (foundAsignatura != null)
            {
                e.IsValid = true;
            }
            else
            {
                e.IsValid = false;
            }
        }

        
    }
}
