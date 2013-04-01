using Control_Aulas_UAM.Clases;
using Encriptacion;
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
    public partial class ChangePassword : Form
    {
        String old;
        public String newPass;
        public Boolean c = false;
        public Boolean match = false;
        private Conexion db;
        private Usuario user;

        public ChangePassword(Usuario user)
        {
            InitializeComponent();
            old = user.Password;
            this.user = user;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (old.Equals(EncryptPassphraseAlgorithm.EncryptSHA1(txtOldPass.Text.Trim())))
            {
                match = true;
                newPass =EncryptPassphraseAlgorithm.EncryptSHA1(txtNewPass.Text.Trim());
                try
                {
                    db = new Conexion();
                    user.Password = newPass;
                    db.actualizarUsuario(user);
                    MessageBox.Show("Contraseña Cambiada");
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un Error al Cambiar Contraseña. Contactar al administrador. Error: "+ex.Message);
                }

            }
            else {
                MessageBox.Show("Las contraseñas no coinciden");
            }
        }
    }
}
