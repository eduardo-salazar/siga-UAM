namespace Control_Aulas_UAM.Catalogos
{
    partial class GruposForm
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInscritos = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbPeriodo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbDocente = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbAsignatura = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lbId = new DevComponents.DotNetBar.LabelX();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(307, 164);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(73, 27);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInscritos);
            this.groupBox1.Controls.Add(this.cbPeriodo);
            this.groupBox1.Controls.Add(this.cbDocente);
            this.groupBox1.Controls.Add(this.cbAsignatura);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.lbId);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 146);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Grupo";
            // 
            // txtInscritos
            // 
            this.txtInscritos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // 
            // 
            this.txtInscritos.Border.Class = "TextBoxBorder";
            this.txtInscritos.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInscritos.Enabled = false;
            this.txtInscritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInscritos.ForeColor = System.Drawing.Color.Black;
            this.txtInscritos.Location = new System.Drawing.Point(271, 107);
            this.txtInscritos.Name = "txtInscritos";
            this.txtInscritos.Size = new System.Drawing.Size(58, 23);
            this.txtInscritos.TabIndex = 34;
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.DisplayMember = "Text";
            this.cbPeriodo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeriodo.FormattingEnabled = true;
            this.cbPeriodo.ItemHeight = 14;
            this.cbPeriodo.Location = new System.Drawing.Point(87, 109);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Size = new System.Drawing.Size(93, 20);
            this.cbPeriodo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbPeriodo.TabIndex = 33;
            // 
            // cbDocente
            // 
            this.cbDocente.DisplayMember = "Text";
            this.cbDocente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDocente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDocente.FormattingEnabled = true;
            this.cbDocente.ItemHeight = 14;
            this.cbDocente.Location = new System.Drawing.Point(87, 80);
            this.cbDocente.Name = "cbDocente";
            this.cbDocente.Size = new System.Drawing.Size(259, 20);
            this.cbDocente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbDocente.TabIndex = 32;
            // 
            // cbAsignatura
            // 
            this.cbAsignatura.DisplayMember = "Text";
            this.cbAsignatura.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAsignatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAsignatura.FormattingEnabled = true;
            this.cbAsignatura.ItemHeight = 14;
            this.cbAsignatura.Location = new System.Drawing.Point(87, 51);
            this.cbAsignatura.Name = "cbAsignatura";
            this.cbAsignatura.Size = new System.Drawing.Size(259, 20);
            this.cbAsignatura.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbAsignatura.TabIndex = 31;
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
            this.txtId.Location = new System.Drawing.Point(87, 20);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(77, 23);
            this.txtId.TabIndex = 29;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(190, 107);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 23;
            this.labelX4.Text = "Inscritos:";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(6, 106);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 22;
            this.labelX3.Text = "Periodo:";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(6, 77);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 21;
            this.labelX2.Text = "Docente:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(6, 48);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 20;
            this.labelX1.Text = "Asignatura:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lbId
            // 
            // 
            // 
            // 
            this.lbId.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(24, 19);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(57, 23);
            this.lbId.TabIndex = 19;
            this.lbId.Text = "Grupo:";
            this.lbId.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(228, 164);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(73, 27);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Guardar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(149, 164);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(73, 27);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // GruposForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 208);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregar);
            this.Name = "GruposForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnBorrar;
        public System.Windows.Forms.Button btnAgregar;
        public DevComponents.DotNetBar.Controls.TextBoxX txtInscritos;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cbPeriodo;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cbDocente;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cbAsignatura;
        public DevComponents.DotNetBar.Controls.TextBoxX txtId;
        public DevComponents.DotNetBar.LabelX lbId;
    }
}
