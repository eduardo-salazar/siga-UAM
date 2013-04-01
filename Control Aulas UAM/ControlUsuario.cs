using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Control_Aulas_UAM.Clases;
using Encriptacion;

namespace Control_Aulas_UAM
{
    public partial class ControlUsuario : UserControl,Funciones
    {
        BindingSource bs=null;
        Boolean n = false;
        Conexion db = null;
        public ControlUsuario()
        {
            InitializeComponent();

            db = new Conexion();
            bs = new BindingSource();
            bs.DataError += new BindingManagerDataErrorEventHandler(handleDate);
            cargarDataGrid();
            txtCodUsuario.DataBindings.Add("Text", bs, "Cod_Usua");
            txtNombre.DataBindings.Add("Text", bs, "Nombre");
            txtEmail.DataBindings.Add("Text", bs, "Email");
            txtTelefono.DataBindings.Add("Text", bs, "Telefono");
            txtUser.DataBindings.Add("Text", bs, "User");
            txtPassword.DataBindings.Add("Text", bs, "Password");
            chkActivo.DataBindings.Add("Checked", bs, "Active");
            chkAdmin.DataBindings.Add("Checked", bs, "Admin");
            dgvUsuarios.Columns["Password"].Visible = false;
            dgvUsuarios.Columns["Email"].Visible = false;
            dgvUsuarios.Columns["Picture"].Visible = false;
            dgvUsuarios.Columns["Telefono"].Visible = false;
            dgvUsuarios.Columns["Cod_Usua"].HeaderText = "Código";
            dgvUsuarios.Columns["Nombre"].HeaderText = "Nombre";
            dgvUsuarios.Columns["Admin"].HeaderText = "Administrador";
            dgvUsuarios.Columns["User"].HeaderText = "Usuario";
            dgvUsuarios.Columns["Active"].HeaderText = "Activo";
        }
        private void cargarDataGrid()
        {
            bs.DataSource = db.getUsuario();
            this.dgvUsuarios.DataSource = bs;
        }

        private void lectura() {
            txtNombre.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtTelefono.ReadOnly = true;
            txtUser.ReadOnly = true;
            btnResetPassword.Enabled = false;
            txtPassword.Enabled = false;
            chkActivo.Enabled = false;
            chkAdmin.Enabled = false;
            dgvUsuarios.Enabled = true;
            dgvUsuarios.Focus();
            txtPassword.Enabled = false;
            txtNombre.FocusHighlightEnabled = false;
            txtEmail.FocusHighlightEnabled = false;
            txtTelefono.FocusHighlightEnabled = false;
            txtUser.FocusHighlightEnabled = false;

            valUsuario.ClearFailedValidations();
        }

        private void edicion() {
            txtPassword.Enabled = true;
            txtPassword.ReadOnly = false;
            txtNombre.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtTelefono.ReadOnly = false;
            txtUser.ReadOnly = false;
            btnResetPassword.Enabled = true;
            chkActivo.Enabled = true;
            chkAdmin.Enabled = true;
            dgvUsuarios.Enabled=false;

            txtNombre.FocusHighlightEnabled=true;
            txtEmail.FocusHighlightEnabled = true;
            txtTelefono.FocusHighlightEnabled = true;
            txtUser.FocusHighlightEnabled = true;
            if (n)
            {
                btnResetPassword.Enabled = false;
            }
            oldPass = txtPassword.Text;
        }
        String oldPass;
        private void resetPassword(Control c)
        {
            c.Text = "1234";
        }

        public bool Guardar() {
            Boolean guardado = false;
            if (valUsuario.Validate()) {
                try
                {
                    Usuario user=new Usuario();
                    if(!this.txtCodUsuario.Text.Equals(""))
                        user.Cod_Usua=Convert.ToInt32(this.txtCodUsuario.Text);
                    user.Nombre=this.txtNombre.Text;
                    user.Email=this.txtEmail.Text;
                    user.Telefono=this.txtTelefono.Text;
                    user.Admin=this.chkAdmin.Checked;
                    user.User=this.txtUser.Text.TrimEnd();
                    if (oldPass.Trim() != txtPassword.Text.Trim())
                    {
                        user.Password = Encriptacion.EncryptPassphraseAlgorithm.EncryptSHA1(txtPassword.Text.Trim());
                    }
                    else
                    {
                        user.Password = oldPass;
                    }
                    user.Active = this.chkActivo.Checked;
                    if (!n) {
                        db.actualizarUsuario(user);
                    }
                    else
                    {
                       db.insertUsuario(user,user.Password);
                    }
                    MessageBox.Show("Guardado");
                    cargarDataGrid();
                    lectura();
                    guardado = true;
                }
                catch (Exception ex) {
                    guardado = false;
                }
                finally {
                    n = false;
                }
            }
            return guardado;
        }

/*        public bool guardar()
        {
            Boolean g=false;
            if (valUsuario.Validate())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = udta.Connection;
                try
                {
                    String cod_usua = txtCodUsuario.Text.Trim();
                    String nombre = "'" + txtNombre.Text.Trim() + "'";
                    String email = "NULL";
                    String telf = "NULL";
                    String admin = "0";
                    String fech_inic = "NULL";
                    String fech_sali = "NULL";
                    String usuario = "'" + txtUser.Text.Trim() + "'";
                    String password = "'" + txtPassword.Text.Trim() + "'";
                    String activo = "0";

                    if (txtEmail.Text.Trim().Length != 0)
                        email = "'" + txtEmail.Text.Trim() + "'";
                    if (txtTelefono.Text.Trim().Length != 0)
                        telf = "'" + txtTelefono.Text.Trim() + "'";
                    if (chkAdmin.Checked)
                        admin = "1";
                    if (!txtFechInic.Text.Equals("  /  /"))
                        fech_inic = "" + txtFechInic.Text.Trim() + "";
                    if (!txtFechSali.Text.Equals("  /  /"))
                        fech_sali = "" + txtFechSali.Text.Trim() + "";
                    if (chkActivo.Checked)
                        activo = "1";
                    if (!n)
                    {
                        String sql = "UPDATE Usuario SET ";
                        sql += "nombre = " + nombre + " , ";
                        sql += "email = " + email + " , ";
                        sql += "telf = " + telf + " , ";
                        sql += "admin = " + admin + " , ";
                        sql += "fech_inic = " + fech_inic + " , ";
                        sql += "fech_sali = " + fech_sali + " , ";
                        sql += "usuario = " + usuario + " , ";
                        sql += "password = " + password + " , ";
                        sql += "activo = " + activo;
                        sql += " WHERE cod_usua = " + cod_usua;
                        cmd.Connection.Open();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        String sql = "INSERT INTO Usuario (nombre, email, telf, admin, fech_inic, fech_sali, usuario, password, activo) VALUES ( ";
                        sql += nombre + " , " + email + " , " + telf + " , " + admin + " , " + fech_inic + " , " + fech_sali + " , " + usuario + " , " + password + " , " + activo + " )";
                        cmd.Connection.Open();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                    }
                    bs.EndEdit();
                    udt = udta.GetData();
                    MessageBox.Show("Guardado");
                    udt = udta.GetData();
                    reloadData();
                    lectura();
                    g= true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    g= false;
                }
                finally
                {
                    cmd.Connection.Close();
                    n = false;
                }
            }
            return g;
        }*/

        public void Nuevo()
        {
            n = true;
            bs.AddNew();
            bs.MoveLast();
            edicion();
            resetPassword(txtPassword);
        }

        public void Imprimir() {
            MessageBox.Show("En Construccion");
        }

        public void Cancelar()
        {
            bs.CancelEdit();
            lectura();
            n = false;
        }

        public void Editar()
        {
            edicion();
        }

        public void Borrar()
        {
            Usuario user = new Usuario();
            if (!this.txtCodUsuario.Text.Equals(""))
                user.Cod_Usua = Convert.ToInt32(this.txtCodUsuario.Text);
            try
            {
                db.borrarUsuario(user);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Hubo un problema al eliminar el registro");
            }
            finally
            {
            }
            cargarDataGrid();
           
        }

        public void IrPrimero()
        {
            bs.MoveFirst();
        }

        public void Anterior()
        {
            bs.MovePrevious();
        }

        public void Siguiente()
        {
            bs.MoveNext();
        }

        public void IrFinal()
        {
            bs.MoveLast();
        }

        public bool vacio() {
            if (bs.Count == 0)
                return true;
            else
                return false;
        }

        private void handleDate(Object sender, EventArgs e) {
            DataRowView d = (DataRowView)bs.Current;
            DateTime dt;
            bool chk;
            try
            {
                dt = (DateTime)d["fech_inic"];
            }
            catch
            {
                d["fech_inic"] = new DateTime(); 
            } 
            try
            {
                dt = (DateTime)d["fech_sali"];
            }
            catch
            {
                d["fech_sali"] = new DateTime(); 
            }
            try
            {
                chk = (bool)d["admin"];
            }
            catch (Exception ex)
            {
                d["admin"] = false;
            } 
            try
            {
                chk = (bool)d["activo"];
            }
            catch (Exception ex)
            {
                d["activo"] = false;
            }
        }

        private void btnMarcarSalida_Click(object sender, EventArgs e)
        {
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            resetPassword(txtPassword);
            MessageBox.Show("Contraseña reseteada a 1234");
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            txtUser.SelectAll();
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.SelectAll();
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            txtTelefono.SelectAll();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            txtUser.SelectAll();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            MessageBox.Show(bs.IndexOf(bs.Current).ToString());
        }

        private void txtFechInic_Enter(object sender, EventArgs e)
        {
        }

        public void Buscar() {
            //FormBusqueda cub = new FormBusqueda(this.udt, bs);
            //object[] items = { "cod_usua", "nombre", "email", "telf", "usuario", "fech_inic"};
            //object[] columnNames = { "Código de Usuario", "Nombre", "Email", "Telefono", "Username", "fech_inic"};
            //cub.setMembers(columnNames, items);
            //cub.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        
        public void Filtrar()
        {/*
            //object[] items = { "cod_usua", "nombre", "email", "telf", "admin", "fech_inic", "fech_sali", "usuario", "activo" };
            //FormularioFiltroBusqueda.showFormularioFiltroBusqueda(bs, items);
            FormularioFiltroBusqueda.showFormularioFiltroBusqueda(bs);*/
        }

        public void Reportes() {
            //FormularioReportes.showReport(bs, "Usuario");
        }
        

        public void RealizarPago()
        {
            throw new NotImplementedException();
        }
    }
}
