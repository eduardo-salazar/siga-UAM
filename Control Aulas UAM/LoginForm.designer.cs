namespace Control_Aulas_UAM
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panelLogin = new DevComponents.DotNetBar.PanelEx();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginControl = new Control_Aulas_UAM.LoginControl();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.CanvasColor = System.Drawing.Color.DarkGreen;
            this.panelLogin.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelLogin.Controls.Add(this.pictureBox1);
            this.panelLogin.Controls.Add(this.loginControl);
            this.panelLogin.Location = new System.Drawing.Point(12, 13);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(500, 420);
            this.panelLogin.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelLogin.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelLogin.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelLogin.Style.BorderColor.Color = System.Drawing.Color.LightSteelBlue;
            this.panelLogin.Style.CornerDiameter = 15;
            this.panelLogin.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.panelLogin.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelLogin.Style.GradientAngle = 90;
            this.panelLogin.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Control_Aulas_UAM.Properties.Resources.UAM_logo;
            this.pictureBox1.Location = new System.Drawing.Point(189, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // loginControl
            // 
            this.loginControl.BackColor = System.Drawing.Color.Transparent;
            this.loginControl.Location = new System.Drawing.Point(135, 157);
            this.loginControl.MinimumSize = new System.Drawing.Size(245, 230);
            this.loginControl.Name = "loginControl";
            this.loginControl.Padding = new System.Windows.Forms.Padding(5);
            this.loginControl.Size = new System.Drawing.Size(245, 230);
            this.loginControl.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(525, 447);
            this.ControlBox = false;
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.TransparencyKey = System.Drawing.Color.DarkGreen;
            this.panelLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LoginControl loginControl;
        private DevComponents.DotNetBar.PanelEx panelLogin;
        private System.Windows.Forms.PictureBox pictureBox1;







    }
}