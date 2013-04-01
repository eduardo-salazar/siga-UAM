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
    public partial class AsignacionVariosControl : UserControl
    {
        Conexion conexion;
        List<Aula> aulas;
        public List<AulaTipoUso> tipoUso;
        bool readOnly;
        public bool ReadOnly { get { return readOnly; } set { readOnly = value; HandleControls(); } }
        
        public List<Aula> Aulas { get { return aulas; } set { aulas = value; comboBoxLugar.DataSource = aulas; } }
        

        public DateTime Inicio { get { return dateTimeInputInicio.Value; } set { dateTimeInputInicio.Value = value; } }
        public DateTime Fin { get { return dateTimeInputFin.Value; } set { dateTimeInputFin.Value = value; } }
        public Aula Aula { get { return (Aula)comboBoxLugar.SelectedItem; } set { if(value!=null)comboBoxLugar.SelectedItem = aulas.Find(element=>element.Id==value.Id); } }
        public AulaTipoUso TipoUso { get { return (AulaTipoUso)comboBoxTipoUso.SelectedItem; } set { try { comboBoxLugar.SelectedItem = tipoUso.Find(element => element.Id == value.Id); } catch { } } }
        public String Observaciones { get { return textBoxObservaciones.Text; } set { textBoxObservaciones.Text = value; } }

        public AsignacionVariosControl()
        {
            InitializeComponent();
            try
            {
                conexion = new Conexion();
                aulas = conexion.getAulas();
                comboBoxLugar.DisplayMember = "Referencia";
                tipoUso = conexion.getAulaTipoUso();
                comboBoxTipoUso.DataSource = tipoUso;
                comboBoxTipoUso.DisplayMember = "descripcion";
                comboBoxTipoUso.SelectedIndex = 0;
            }
            catch { }
        }

        void HandleControls()
        {
            bool enabled = !readOnly;
            dateTimeInputInicio.Enabled = enabled;
            dateTimeInputFin.Enabled = enabled;
            comboBoxTipoUso.Enabled = enabled;
            textBoxObservaciones.Enabled = enabled;
            comboBoxLugar.Enabled = enabled;
        }

        private void dateTimeInput_ValueChanged(object sender, EventArgs e)
        {
            DateTime inicio = dateTimeInputInicio.Value;
            DateTime fin = dateTimeInputFin.Value;
            if (DateTime.Compare(inicio, fin) == -1)
            {
                TimeSpan offset = fin.Subtract(inicio);
                String text = "Duración: ";
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
        }

        public void EnableEdit(bool enable)
        {
            dateTimeInputInicio.Enabled = enable;
            dateTimeInputFin.Enabled = enable;
            comboBoxLugar.Enabled = enable;
            comboBoxTipoUso.Enabled = enable;
            textBoxObservaciones.Enabled = enable;
            if(!enable)
                textBoxObservaciones.Clear();
        }

        public bool ValidateControls()
        {
            return superValidator.Validate();
        }
    }
}
