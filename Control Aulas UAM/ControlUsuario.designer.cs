namespace Control_Aulas_UAM
{
    partial class ControlUsuario
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlUsuario));
            this.etiNombre = new DevComponents.DotNetBar.LabelX();
            this.txtNombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.etiEmail = new DevComponents.DotNetBar.LabelX();
            this.txtTelefono = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.etiTelefono = new DevComponents.DotNetBar.LabelX();
            this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtUser = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.etiUsuario = new DevComponents.DotNetBar.LabelX();
            this.chkActivo = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txtCodUsuario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.etiCodigoUsuario = new DevComponents.DotNetBar.LabelX();
            this.chkAdmin = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnResetPassword = new DevComponents.DotNetBar.ButtonX();
            this.valUsuario = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.valNombreReq = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Debe ingresar el nombre del usuario");
            this.valEmailInvalid = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.valUsuarioReq = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Debe ingresar un username para el usuario");
            this.valUsuarioError = new System.Windows.Forms.ErrorProvider(this.components);
            this.valUsuarioHighlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.expandabePanelUsuarios = new DevComponents.DotNetBar.ExpandablePanel();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.valUsuarioError)).BeginInit();
            this.expandabePanelUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // etiNombre
            // 
            this.etiNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.etiNombre.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.etiNombre.Location = new System.Drawing.Point(172, 86);
            this.etiNombre.Name = "etiNombre";
            this.etiNombre.Size = new System.Drawing.Size(75, 23);
            this.etiNombre.TabIndex = 0;
            this.etiNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNombre.Border.Class = "TextBoxBorder";
            this.txtNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(260, 89);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(10);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(165, 20);
            this.txtNombre.TabIndex = 2;
            this.valUsuario.SetValidator1(this.txtNombre, this.valNombreReq);
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEmail.Border.Class = "TextBoxBorder";
            this.txtEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(260, 129);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(10);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(165, 20);
            this.txtEmail.TabIndex = 3;
            this.valUsuario.SetValidator1(this.txtEmail, this.valEmailInvalid);
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            // 
            // etiEmail
            // 
            this.etiEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.etiEmail.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.etiEmail.Location = new System.Drawing.Point(172, 126);
            this.etiEmail.Name = "etiEmail";
            this.etiEmail.Size = new System.Drawing.Size(75, 23);
            this.etiEmail.TabIndex = 2;
            this.etiEmail.Text = "Email:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTelefono.Border.Class = "TextBoxBorder";
            this.txtTelefono.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtTelefono.Location = new System.Drawing.Point(260, 169);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(10);
            this.txtTelefono.MaxLength = 20;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(165, 20);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.Enter += new System.EventHandler(this.txtTelefono_Enter);
            // 
            // etiTelefono
            // 
            this.etiTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.etiTelefono.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.etiTelefono.Location = new System.Drawing.Point(172, 166);
            this.etiTelefono.Name = "etiTelefono";
            this.etiTelefono.Size = new System.Drawing.Size(75, 23);
            this.etiTelefono.TabIndex = 4;
            this.etiTelefono.Text = "Teléfono:";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPassword.Border.Class = "TextBoxBorder";
            this.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPassword.Enabled = false;
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(590, 129);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(10);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(165, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(502, 126);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 12;
            this.labelX1.Text = "Contraseña:";
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtUser.Border.Class = "TextBoxBorder";
            this.txtUser.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.Location = new System.Drawing.Point(590, 89);
            this.txtUser.Margin = new System.Windows.Forms.Padding(10);
            this.txtUser.MaxLength = 10;
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(165, 20);
            this.txtUser.TabIndex = 7;
            this.valUsuario.SetValidator1(this.txtUser, this.valUsuarioReq);
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            // 
            // etiUsuario
            // 
            this.etiUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.etiUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.etiUsuario.Location = new System.Drawing.Point(502, 86);
            this.etiUsuario.Name = "etiUsuario";
            this.etiUsuario.Size = new System.Drawing.Size(75, 23);
            this.etiUsuario.TabIndex = 10;
            this.etiUsuario.Text = "Usuario:";
            // 
            // chkActivo
            // 
            this.chkActivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.chkActivo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkActivo.Enabled = false;
            this.chkActivo.Location = new System.Drawing.Point(590, 169);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(100, 23);
            this.chkActivo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkActivo.TabIndex = 9;
            this.chkActivo.Text = "Usuario Activo";
            // 
            // txtCodUsuario
            // 
            this.txtCodUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodUsuario.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCodUsuario.Border.Class = "TextBoxBorder";
            this.txtCodUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCodUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtCodUsuario.Location = new System.Drawing.Point(260, 49);
            this.txtCodUsuario.Margin = new System.Windows.Forms.Padding(10);
            this.txtCodUsuario.Name = "txtCodUsuario";
            this.txtCodUsuario.ReadOnly = true;
            this.txtCodUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtCodUsuario.TabIndex = 1;
            this.txtCodUsuario.TabStop = false;
            // 
            // etiCodigoUsuario
            // 
            this.etiCodigoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.etiCodigoUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.etiCodigoUsuario.Location = new System.Drawing.Point(172, 46);
            this.etiCodigoUsuario.Name = "etiCodigoUsuario";
            this.etiCodigoUsuario.Size = new System.Drawing.Size(75, 23);
            this.etiCodigoUsuario.TabIndex = 17;
            this.etiCodigoUsuario.Text = "Cod_Usuario:";
            // 
            // chkAdmin
            // 
            this.chkAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.chkAdmin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkAdmin.Enabled = false;
            this.chkAdmin.Location = new System.Drawing.Point(590, 206);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(100, 23);
            this.chkAdmin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkAdmin.TabIndex = 10;
            this.chkAdmin.Text = "Administrador";
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnResetPassword.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnResetPassword.Enabled = false;
            this.btnResetPassword.Location = new System.Drawing.Point(768, 129);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(41, 20);
            this.btnResetPassword.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnResetPassword.TabIndex = 19;
            this.btnResetPassword.Text = "Reset";
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // valUsuario
            // 
            this.valUsuario.ContainerControl = this;
            this.valUsuario.ErrorProvider = this.valUsuarioError;
            this.valUsuario.Highlighter = this.valUsuarioHighlighter;
            this.valUsuario.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // valNombreReq
            // 
            this.valNombreReq.ErrorMessage = "Debe ingresar el nombre del usuario";
            this.valNombreReq.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // valEmailInvalid
            // 
            this.valEmailInvalid.EmptyValueIsValid = true;
            this.valEmailInvalid.ErrorMessage = "Ingrese un email válido";
            this.valEmailInvalid.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.valEmailInvalid.ValidationExpression = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9" +
    "})$";
            // 
            // valUsuarioReq
            // 
            this.valUsuarioReq.ErrorMessage = "Debe ingresar un username para el usuario";
            this.valUsuarioReq.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // valUsuarioError
            // 
            this.valUsuarioError.ContainerControl = this;
            this.valUsuarioError.Icon = ((System.Drawing.Icon)(resources.GetObject("valUsuarioError.Icon")));
            // 
            // valUsuarioHighlighter
            // 
            this.valUsuarioHighlighter.ContainerControl = this;
            this.valUsuarioHighlighter.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(376, 13);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(175, 23);
            this.labelX4.TabIndex = 20;
            this.labelX4.Text = "Usuarios";
            // 
            // expandabePanelUsuarios
            // 
            this.expandabePanelUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expandabePanelUsuarios.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandabePanelUsuarios.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.TopToBottom;
            this.expandabePanelUsuarios.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandabePanelUsuarios.Controls.Add(this.dgvUsuarios);
            this.expandabePanelUsuarios.Location = new System.Drawing.Point(0, 235);
            this.expandabePanelUsuarios.Name = "expandabePanelUsuarios";
            this.expandabePanelUsuarios.Size = new System.Drawing.Size(926, 248);
            this.expandabePanelUsuarios.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandabePanelUsuarios.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandabePanelUsuarios.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandabePanelUsuarios.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandabePanelUsuarios.Style.GradientAngle = 90;
            this.expandabePanelUsuarios.TabIndex = 21;
            this.expandabePanelUsuarios.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandabePanelUsuarios.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandabePanelUsuarios.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandabePanelUsuarios.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandabePanelUsuarios.TitleStyle.GradientAngle = 90;
            this.expandabePanelUsuarios.TitleText = "Lista de Usuarios";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 26);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(926, 222);
            this.dgvUsuarios.TabIndex = 2;
            // 
            // ControlUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.expandabePanelUsuarios);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.chkAdmin);
            this.Controls.Add(this.txtCodUsuario);
            this.Controls.Add(this.etiCodigoUsuario);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.etiUsuario);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.etiTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.etiEmail);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.etiNombre);
            this.Name = "ControlUsuario";
            this.Size = new System.Drawing.Size(926, 483);
            ((System.ComponentModel.ISupportInitialize)(this.valUsuarioError)).EndInit();
            this.expandabePanelUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX etiNombre;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNombre;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEmail;
        private DevComponents.DotNetBar.LabelX etiEmail;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTelefono;
        private DevComponents.DotNetBar.LabelX etiTelefono;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUser;
        private DevComponents.DotNetBar.LabelX etiUsuario;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkActivo;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCodUsuario;
        private DevComponents.DotNetBar.LabelX etiCodigoUsuario;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkAdmin;
        private DevComponents.DotNetBar.ButtonX btnResetPassword;
        private DevComponents.DotNetBar.Validator.SuperValidator valUsuario;
        private System.Windows.Forms.ErrorProvider valUsuarioError;
        private DevComponents.DotNetBar.Validator.Highlighter valUsuarioHighlighter;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator valUsuarioReq;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator valNombreReq;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator valEmailInvalid;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.ExpandablePanel expandabePanelUsuarios;
        private System.Windows.Forms.DataGridView dgvUsuarios;
    }
}
