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
    public partial class BuscarForm : Form
    {
        List<Aula> aulasSeleccionadas;
        public List<Aula> Aulas { set { try { asignAulas(value); } catch { } } }
        public List<Aula> AulasSeleccionadas { get { return aulasSeleccionadas; } }

        public BuscarForm()
        {
            InitializeComponent();
            comboBoxModoBusqueda.SelectedIndex = 0;
        }

        void asignAulas(List<Aula> aulas){
            buscarControl1.Aulas = aulas;
            buscarGupoControl1.Aulas = aulas;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (comboBoxModoBusqueda.SelectedIndex == 0)
            {
                buscarControl1.filtrarAulas();
            }
            else {
                buscarGupoControl1.filtrarAulas();
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (comboBoxModoBusqueda.SelectedIndex == 0)
            {
                aulasSeleccionadas = buscarControl1.getAulasSeleccionadas();
            }
            else {
                aulasSeleccionadas = buscarGupoControl1.getAulasSeleccionadas();
            }
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        private void comboBoxModo_SelectedIndexChanged(object sender, EventArgs e)
        {
            superTabControlModoBusqueda.SelectedTabIndex=comboBoxModoBusqueda.SelectedIndex;
        }
    }
}
