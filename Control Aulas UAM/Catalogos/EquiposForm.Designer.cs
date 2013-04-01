namespace Control_Aulas_UAM.Catalogos
{
    partial class EquiposForm
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
            this.lbId = new DevComponents.DotNetBar.LabelX();
            this.lbDescripcion = new DevComponents.DotNetBar.LabelX();
            this.txtId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDescripcion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgEquipos = new System.Windows.Forms.DataGridView();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.txtObservacion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dgEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbId
            // 
            // 
            // 
            // 
            this.lbId.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(17, 62);
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
            this.lbDescripcion.Location = new System.Drawing.Point(17, 99);
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
            this.txtId.Location = new System.Drawing.Point(98, 64);
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
            this.txtDescripcion.Location = new System.Drawing.Point(17, 128);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(214, 85);
            this.txtDescripcion.TabIndex = 3;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(112, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(230, 23);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "Catálogo de Equipos";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // dgEquipos
            // 
            this.dgEquipos.AllowUserToAddRows = false;
            this.dgEquipos.AllowUserToDeleteRows = false;
            this.dgEquipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEquipos.Location = new System.Drawing.Point(52, 247);
            this.dgEquipos.MultiSelect = false;
            this.dgEquipos.Name = "dgEquipos";
            this.dgEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEquipos.Size = new System.Drawing.Size(406, 150);
            this.dgEquipos.TabIndex = 5;
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(3, 41);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(495, 23);
            this.line1.TabIndex = 6;
            this.line1.Text = "line1";
            // 
            // txtObservacion
            // 
            this.txtObservacion.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtObservacion.Border.Class = "TextBoxBorder";
            this.txtObservacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.ForeColor = System.Drawing.Color.Black;
            this.txtObservacion.Location = new System.Drawing.Point(267, 128);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(214, 85);
            this.txtObservacion.TabIndex = 8;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(267, 99);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(90, 23);
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = "Observación:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // EquiposForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.dgEquipos);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbId);
            this.Name = "EquiposForm";
            this.Size = new System.Drawing.Size(501, 454);
            ((System.ComponentModel.ISupportInitialize)(this.dgEquipos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lbId;
        private DevComponents.DotNetBar.LabelX lbDescripcion;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtId;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDescripcion;
        private System.Windows.Forms.DataGridView dgEquipos;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtObservacion;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}
