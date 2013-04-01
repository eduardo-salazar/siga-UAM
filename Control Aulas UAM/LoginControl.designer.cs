namespace Control_Aulas_UAM
{
    partial class LoginControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelUsuario = new DevComponents.DotNetBar.LabelX();
            this.textBoxUsuario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelPassword = new DevComponents.DotNetBar.LabelX();
            this.buttonIngresar = new DevComponents.DotNetBar.ButtonX();
            this.circularProgress = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.buttonCancelar = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelUsuario
            // 
            this.labelUsuario.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelUsuario.Location = new System.Drawing.Point(8, 8);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(100, 29);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuario:";
            // 
            // textBoxUsuario
            // 
            // 
            // 
            // 
            this.textBoxUsuario.Border.Class = "TextBoxBorder";
            this.textBoxUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(8, 43);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.textBoxUsuario.MaxLength = 25;
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.PreventEnterBeep = true;
            this.textBoxUsuario.Size = new System.Drawing.Size(228, 29);
            this.textBoxUsuario.TabIndex = 1;
            this.textBoxUsuario.WatermarkText = "Usuario";
            this.textBoxUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUsuario_KeyPress);
            // 
            // textBoxPassword
            // 
            // 
            // 
            // 
            this.textBoxPassword.Border.Class = "TextBoxBorder";
            this.textBoxPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(8, 120);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.textBoxPassword.MaxLength = 25;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PreventEnterBeep = true;
            this.textBoxPassword.Size = new System.Drawing.Size(228, 29);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.WatermarkText = "Contraseña";
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassword_KeyPress);
            // 
            // labelPassword
            // 
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelPassword.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPassword.Location = new System.Drawing.Point(8, 85);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(100, 29);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Contraseña:";
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonIngresar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonIngresar.Location = new System.Drawing.Point(8, 191);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(75, 29);
            this.buttonIngresar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonIngresar.TabIndex = 3;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // circularProgress
            // 
            this.circularProgress.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.circularProgress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.circularProgress.Location = new System.Drawing.Point(85, 197);
            this.circularProgress.Margin = new System.Windows.Forms.Padding(20);
            this.circularProgress.Name = "circularProgress";
            this.circularProgress.Size = new System.Drawing.Size(75, 23);
            this.circularProgress.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circularProgress.TabIndex = 6;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonCancelar.Location = new System.Drawing.Point(161, 191);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 29);
            this.buttonCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.circularProgress);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.labelUsuario);
            this.MinimumSize = new System.Drawing.Size(245, 230);
            this.Name = "LoginControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(245, 230);
            this.Load += new System.EventHandler(this.LoginControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelUsuario;
        private DevComponents.DotNetBar.LabelX labelPassword;
        public DevComponents.DotNetBar.Controls.CircularProgress circularProgress;
        public DevComponents.DotNetBar.ButtonX buttonIngresar;
        public DevComponents.DotNetBar.ButtonX buttonCancelar;
        public DevComponents.DotNetBar.Controls.TextBoxX textBoxUsuario;
        public DevComponents.DotNetBar.Controls.TextBoxX textBoxPassword;
    }
}
