using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control_Aulas_UAM
{
    public partial class BuscarGenerico : UserControl
    {
        private BindingSource grid;

        public BindingSource Grid
        {
            get { return grid; }
            set { grid = value; }
        }
        public BuscarGenerico()
        {
            InitializeComponent();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxX1_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBoxX1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void cbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void cbInput_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnIrA_Click(object sender, EventArgs e)
        {
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            int index = this.cbInput.SelectedIndex;
            this.grid.Position = index;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
