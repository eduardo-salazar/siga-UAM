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
    public partial class NotificarForm : Form
    {
        public NotificarForm()
        {
            InitializeComponent();
            this.controlNotificar1.Disposed += controlNotificar1_Disposed;
        }

        void controlNotificar1_Disposed(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void controlNotificar1_Load(object sender, EventArgs e)
        {

        }
    }
}
