using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using System.Configuration;
using Control_Aulas_UAM;
using Control_Aulas_UAM.Clases;

namespace Control_Aulas_UAM
{
    public partial class LoginForm : Form
    {
        Point controlPoint;
        DevComponents.DotNetBar.Controls.CircularProgress circularProgress;
        Thread startLogin;
        delegate void threadCallBack();
        Usuario usuario;
        Conexion db=null;
        public LoginForm()
        {
            InitializeComponent();
            db=new Conexion();
            controlPoint = new Point();
            circularProgress = loginControl.circularProgress;
            loginControl.OnLogin += loginControl_OnLogin;
            loginControl.OnCancel += loginControl_OnCancel;
            panelLogin.MouseDown += Control_MouseDown;
            panelLogin.MouseMove += Control_MouseMove; 
            loginControl.MouseDown += Control_MouseDown;
            loginControl.MouseMove += Control_MouseMove;
            this.Opacity = 0.95;
        }

        void loginControl_OnCancel(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void loginControl_OnLogin(object sender, EventArgs e)
        {
            ThreadStart threadStart = delegate()
            {
                handleControls();
                List<Usuario> usuarios = db.getUsuario();
                try {
                    
                    String user=loginControl.Username;
                    String pass=Encriptacion.EncryptPassphraseAlgorithm.EncryptSHA1(loginControl.Password);
                    if (usuarios!=null)
                    {
                        Usuario u = usuarios.Find(us => us.User.Equals(user) && us.Password.Equals(pass));
                        if (u != null)
                        {
                            usuario = u;
                            if (u.Active)
                                showEnvironment();
                            else {
                                MessageBox.Show("Usuario inactivo");
                            }
                        }
                        else
                        {
                            MessageBox.Show("El usuario o la contraseña introducidos son incorrectos.");
                        } 
                    }
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show("No se pudo establecer conexión con el servidor.");
                }
                finally {
                    handleControls();
                }
            };
            startLogin = new Thread(threadStart);
            startLogin.IsBackground = true;
            startLogin.Start();
        }

        private void handleControls() {
            try
            {
                if (this.InvokeRequired)
                {
                    threadCallBack c = new threadCallBack(handleControls);
                    this.Invoke(c);
                }
                else
                {
                    circularProgress.IsRunning = !circularProgress.IsRunning;
                    loginControl.buttonIngresar.Enabled = !loginControl.buttonIngresar.Enabled;
                    loginControl.textBoxUsuario.Enabled = !loginControl.textBoxUsuario.Enabled;
                    loginControl.textBoxPassword.Enabled = !loginControl.textBoxPassword.Enabled;
                }
            }
            catch (ObjectDisposedException ex)
            {
            }
        }

        private void showEnvironment() {
            if (this.InvokeRequired)
            {
                threadCallBack c = new threadCallBack(showEnvironment);
                this.Invoke(c);
            }
            else
            {
                this.Hide();
                Entorno entorno = new Entorno(usuario);
                entorno.ShowDialog();
                Application.Exit();
            }
        }

        void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - controlPoint.X;
                this.Top += e.Y - controlPoint.Y;
            }
        }

        void Control_MouseDown(object sender, MouseEventArgs e)
        {
            controlPoint.X = e.X;
            controlPoint.Y = e.Y;
        }

    }
}
