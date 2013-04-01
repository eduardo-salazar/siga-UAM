namespace Control_Aulas_UAM
{
    partial class BuscarGenerico
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
            this.cbInput = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnIrA = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // cbInput
            // 
            this.cbInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbInput.DisplayMember = "Text";
            this.cbInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbInput.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbInput.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbInput.FormattingEnabled = true;
            this.cbInput.ItemHeight = 27;
            this.cbInput.Location = new System.Drawing.Point(0, 0);
            this.cbInput.Name = "cbInput";
            this.cbInput.Size = new System.Drawing.Size(410, 33);
            this.cbInput.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbInput.TabIndex = 0;
            this.cbInput.SelectedIndexChanged += new System.EventHandler(this.cbInput_SelectedIndexChanged);
            this.cbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbInput_KeyPress);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(373, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 36);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Cerrar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIrA
            // 
            this.btnIrA.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnIrA.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnIrA.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnIrA.Location = new System.Drawing.Point(302, 0);
            this.btnIrA.Name = "btnIrA";
            this.btnIrA.Size = new System.Drawing.Size(71, 36);
            this.btnIrA.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnIrA.TabIndex = 2;
            this.btnIrA.Text = "Ir a";
            this.btnIrA.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // BuscarGenerico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnIrA);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbInput);
            this.Name = "BuscarGenerico";
            this.Size = new System.Drawing.Size(410, 36);
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.Controls.ComboBoxEx cbInput;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnIrA;



    }
}
