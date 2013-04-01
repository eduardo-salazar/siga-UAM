using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Aulas_UAM
{
    public partial class AsignacionControl : UserControl
    {
        public AsignacionControl()
        {
            InitializeComponent();

            
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
                labelTiempo.Text = text;
            }
            else
            {
                labelTiempo.Text = "";
            }
        }

        private void checkBoxRepetir_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = checkBoxRepetir.Checked;
            checkBoxLunes.Enabled = isChecked;
            checkBoxMartes.Enabled = isChecked;
            checkBoxMiercoles.Enabled = isChecked;
            checkBoxJueves.Enabled = isChecked;
            checkBoxViernes.Enabled = isChecked;
            checkBoxSabado.Enabled = isChecked;
            checkBoxDomingo.Enabled = isChecked;
        }

    }
}
