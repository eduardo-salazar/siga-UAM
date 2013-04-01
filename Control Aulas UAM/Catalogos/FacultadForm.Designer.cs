namespace Control_Aulas_UAM.Catalogos
{
    partial class FacultadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacultadForm));
            this.lbId = new DevComponents.DotNetBar.LabelX();
            this.lbDescripcion = new DevComponents.DotNetBar.LabelX();
            this.txtId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDescripcion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgFacultades = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.colorPickerButton1 = new DevComponents.DotNetBar.ColorPickerButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgFacultades)).BeginInit();
            this.SuspendLayout();
            // 
            // lbId
            // 
            // 
            // 
            // 
            this.lbId.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(96, 70);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(75, 23);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "ID:";
            this.lbId.TextAlignment = System.Drawing.StringAlignment.Far;
            this.lbId.Click += new System.EventHandler(this.lbId_Click);
            // 
            // lbDescripcion
            // 
            // 
            // 
            // 
            this.lbDescripcion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.Location = new System.Drawing.Point(96, 99);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(75, 23);
            this.lbDescripcion.TabIndex = 1;
            this.lbDescripcion.Text = "Descripción:";
            this.lbDescripcion.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // 
            // 
            this.txtId.Border.Class = "TextBoxBorder";
            this.txtId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.Location = new System.Drawing.Point(177, 72);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(61, 23);
            this.txtId.TabIndex = 2;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDescripcion.Border.Class = "TextBoxBorder";
            this.txtDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.Location = new System.Drawing.Point(177, 101);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(192, 85);
            this.txtDescripcion.TabIndex = 3;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(177, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(179, 23);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "Catálogo de Facultades";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // dgFacultades
            // 
            this.dgFacultades.AllowUserToAddRows = false;
            this.dgFacultades.AllowUserToDeleteRows = false;
            this.dgFacultades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgFacultades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFacultades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnDescripcion,
            this.ColumnColor});
            this.dgFacultades.Location = new System.Drawing.Point(42, 215);
            this.dgFacultades.MultiSelect = false;
            this.dgFacultades.Name = "dgFacultades";
            this.dgFacultades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFacultades.Size = new System.Drawing.Size(406, 150);
            this.dgFacultades.TabIndex = 5;
            this.dgFacultades.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgFacultades_CellPainting);
            // 
            // ColumnID
            // 
            this.ColumnID.DataPropertyName = "ID";
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            // 
            // ColumnDescripcion
            // 
            this.ColumnDescripcion.DataPropertyName = "Descripcion";
            this.ColumnDescripcion.HeaderText = "Descripción";
            this.ColumnDescripcion.Name = "ColumnDescripcion";
            this.ColumnDescripcion.ReadOnly = true;
            // 
            // ColumnColor
            // 
            this.ColumnColor.DataPropertyName = "Color";
            this.ColumnColor.HeaderText = "Color";
            this.ColumnColor.Name = "ColumnColor";
            this.ColumnColor.ReadOnly = true;
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(3, 41);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(495, 23);
            this.line1.TabIndex = 6;
            this.line1.Text = "line1";
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.colorPickerButton1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.colorPickerButton1.Image = ((System.Drawing.Image)(resources.GetObject("colorPickerButton1.Image")));
            this.colorPickerButton1.Location = new System.Drawing.Point(244, 72);
            this.colorPickerButton1.Name = "colorPickerButton1";
            this.colorPickerButton1.SelectedColorImageRectangle = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.colorPickerButton1.Size = new System.Drawing.Size(37, 23);
            this.colorPickerButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.colorPickerButton1.TabIndex = 7;
            // 
            // FacultadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.colorPickerButton1);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.dgFacultades);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbId);
            this.Name = "FacultadForm";
            this.Size = new System.Drawing.Size(501, 400);
            ((System.ComponentModel.ISupportInitialize)(this.dgFacultades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lbId;
        private DevComponents.DotNetBar.LabelX lbDescripcion;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtId;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDescripcion;
        private System.Windows.Forms.DataGridView dgFacultades;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.ColorPickerButton colorPickerButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnColor;
    }
}
