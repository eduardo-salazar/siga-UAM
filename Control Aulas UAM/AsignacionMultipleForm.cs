using Control_Aulas_UAM.Clases;
using Control_Aulas_UAM.Clases.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Aulas_UAM
{
    public partial class AsignacionMultipleForm : Form
    {
        List<Asignacion> asignaciones;
        public List<Asignacion> Asignaciones { get { return asignaciones; } }
        public List<Serie> Series { get { return asignacionMultipleControl1.Series; } }

        public AsignacionMultipleForm()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex) { }
        }

        public void setUsuario(Usuario usuario) {
            asignacionMultipleControl1.setUsuario(usuario);
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            asignaciones = asignacionMultipleControl1.Asignaciones;
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        public bool setInitialDates(DateTime inicio, DateTime fin)
        {
            return asignacionMultipleControl1.setInitialDates(inicio, fin);
        }
    }
}
