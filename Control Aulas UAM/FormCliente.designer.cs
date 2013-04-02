namespace Control_Aulas_UAM
{
    partial class FormCliente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            this.buttonGuardar = new DevComponents.DotNetBar.ButtonX();
            this.buttonCancelar = new DevComponents.DotNetBar.ButtonX();
            this.textBoxArea = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelArea = new DevComponents.DotNetBar.LabelX();
            this.textBoxNombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelNombre = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBoxId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.superValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Nombre de cliente requerido");
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonGuardar.Location = new System.Drawing.Point(71, 96);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonGuardar.TabIndex = 1;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(169, 96);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonCancelar.TabIndex = 2;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxArea
            // 
            // 
            // 
            // 
            this.textBoxArea.Border.Class = "TextBoxBorder";
            this.textBoxArea.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxArea.Location = new System.Drawing.Point(71, 70);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(173, 20);
            this.textBoxArea.TabIndex = 7;
            // 
            // labelArea
            // 
            // 
            // 
            // 
            this.labelArea.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelArea.Location = new System.Drawing.Point(12, 67);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(53, 23);
            this.labelArea.TabIndex = 6;
            this.labelArea.Text = "Area:";
            this.labelArea.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // textBoxNombre
            // 
            // 
            // 
            // 
            this.textBoxNombre.Border.Class = "TextBoxBorder";
            this.textBoxNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxNombre.Location = new System.Drawing.Point(71, 41);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(173, 20);
            this.textBoxNombre.TabIndex = 5;
            this.superValidator.SetValidator1(this.textBoxNombre, this.requiredFieldValidator);
            // 
            // labelNombre
            // 
            // 
            // 
            // 
            this.labelNombre.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelNombre.Location = new System.Drawing.Point(12, 38);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(53, 23);
            this.labelNombre.TabIndex = 4;
            this.labelNombre.Text = "Nombre:";
            this.labelNombre.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 9);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(53, 23);
            this.labelX1.TabIndex = 8;
            this.labelX1.Text = "Id:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // textBoxId
            // 
            // 
            // 
            // 
            this.textBoxId.Border.Class = "TextBoxBorder";
            this.textBoxId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxId.Location = new System.Drawing.Point(71, 12);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(46, 20);
            this.textBoxId.TabIndex = 9;
            // 
            // superValidator
            // 
            this.superValidator.ContainerControl = this;
            this.superValidator.ErrorProvider = this.errorProvider;
            this.superValidator.Highlighter = this.highlighter;
            this.superValidator.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // requiredFieldValidator
            // 
            this.requiredFieldValidator.ErrorMessage = "Nombre de cliente requerido";
            this.requiredFieldValidator.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            this.highlighter.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // FormCliente
            // 
            this.AcceptButton = this.buttonGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(264, 133);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.textBoxArea);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonGuardar;
        private DevComponents.DotNetBar.ButtonX buttonCancelar;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxArea;
        private DevComponents.DotNetBar.LabelX labelArea;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxNombre;
        private DevComponents.DotNetBar.LabelX labelNombre;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxId;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator;
    }
}