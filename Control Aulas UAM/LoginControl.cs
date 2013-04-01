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
    public partial class LoginControl : UserControl
    {
        public delegate void EventHandler(object sender, EventArgs e);
        public event EventHandler OnLogin;
        public event EventHandler OnCancel;

        public String Username {
            get { return textBoxUsuario.Text; }
        }

        public String Password {
            get { return textBoxPassword.Text; }
        }

        public LoginControl()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            OnLogin(this, e);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            OnCancel(this, e);
        }

        private void LoginControl_Load(object sender, EventArgs e)
        {

        }

        private void textBoxUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)System.Windows.Forms.Keys.Enter)
            {
                textBoxPassword.Focus();
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)System.Windows.Forms.Keys.Enter)
            {
                OnLogin(this, e);
            }
        }
        
    }
}
