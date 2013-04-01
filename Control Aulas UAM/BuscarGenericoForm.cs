using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control_Aulas_UAM
{
    public partial class BuscarGenericoForm : Form
    {
        public BuscarGenericoForm()
        {
            InitializeComponent();
            this.buscarGenerico1.Disposed+=buscarGenerico1_Disposed;
            Point punto = new Point(100, 100);
            this.Location = punto;
        }

        void buscarGenerico1_Disposed(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buscarGenerico1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void buscarGenerico1_Load(object sender, EventArgs e)
        {

        }
    }
}
