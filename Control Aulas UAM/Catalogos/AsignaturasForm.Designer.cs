namespace Control_Aulas_UAM.Catalogos
{
    partial class AsignaturasForm
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
            this.lbCategoria = new DevComponents.DotNetBar.LabelX();
            this.lbFacultad = new DevComponents.DotNetBar.LabelX();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.dgAsignaturas = new System.Windows.Forms.DataGridView();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtNombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbNombre = new DevComponents.DotNetBar.LabelX();
            this.lbId = new DevComponents.DotNetBar.LabelX();
            this.cbFacultad = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbCategoria = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new DevComponents.DotNetBar.ButtonX();
            this.dgGrupos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsignaturas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCategoria
            // 
            // 
            // 
            // 
            this.lbCategoria.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.Location = new System.Drawing.Point(214, 72);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(82, 23);
            this.lbCategoria.TabIndex = 26;
            this.lbCategoria.Text = "Categoría:";
            this.lbCategoria.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lbFacultad
            // 
            // 
            // 
            // 
            this.lbFacultad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbFacultad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacultad.Location = new System.Drawing.Point(-1, 69);
            this.lbFacultad.Name = "lbFacultad";
            this.lbFacultad.Size = new System.Drawing.Size(82, 23);
            this.lbFacultad.TabIndex = 25;
            this.lbFacultad.Text = "Facultad:";
            this.lbFacultad.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(13, 40);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(564, 23);
            this.line1.TabIndex = 24;
            this.line1.Text = "line1";
            // 
            // dgAsignaturas
            // 
            this.dgAsignaturas.AllowUserToAddRows = false;
            this.dgAsignaturas.AllowUserToDeleteRows = false;
            this.dgAsignaturas.AllowUserToOrderColumns = true;
            this.dgAsignaturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAsignaturas.Location = new System.Drawing.Point(6, 101);
            this.dgAsignaturas.MultiSelect = false;
            this.dgAsignaturas.Name = "dgAsignaturas";
            this.dgAsignaturas.RowHeadersVisible = false;
            this.dgAsignaturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAsignaturas.Size = new System.Drawing.Size(519, 150);
            this.dgAsignaturas.TabIndex = 23;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(201, 11);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(192, 23);
            this.labelX1.TabIndex = 22;
            this.labelX1.Text = "Catálogo de Asignaturas";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // 
            // 
            this.txtNombre.Border.Class = "TextBoxBorder";
            this.txtNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(87, 47);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(336, 22);
            this.txtNombre.TabIndex = 21;
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
            this.txtId.Location = new System.Drawing.Point(87, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(77, 23);
            this.txtId.TabIndex = 20;
            // 
            // lbNombre
            // 
            // 
            // 
            // 
            this.lbNombre.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(6, 46);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(75, 23);
            this.lbNombre.TabIndex = 19;
            this.lbNombre.Text = "Nombre:";
            this.lbNombre.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lbId
            // 
            // 
            // 
            // 
            this.lbId.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(6, 19);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(75, 23);
            this.lbId.TabIndex = 18;
            this.lbId.Text = "ID:";
            this.lbId.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cbFacultad
            // 
            this.cbFacultad.DisplayMember = "Text";
            this.cbFacultad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFacultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFacultad.FormattingEnabled = true;
            this.cbFacultad.ItemHeight = 14;
            this.cbFacultad.Location = new System.Drawing.Point(87, 72);
            this.cbFacultad.Name = "cbFacultad";
            this.cbFacultad.Size = new System.Drawing.Size(145, 20);
            this.cbFacultad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbFacultad.TabIndex = 27;
            // 
            // cbCategoria
            // 
            this.cbCategoria.DisplayMember = "Text";
            this.cbCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.ItemHeight = 14;
            this.cbCategoria.Location = new System.Drawing.Point(302, 75);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 20);
            this.cbCategoria.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCategoria.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbId);
            this.groupBox1.Controls.Add(this.cbCategoria);
            this.groupBox1.Controls.Add(this.dgAsignaturas);
            this.groupBox1.Controls.Add(this.lbNombre);
            this.groupBox1.Controls.Add(this.cbFacultad);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.lbCategoria);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lbFacultad);
            this.groupBox1.Location = new System.Drawing.Point(29, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 261);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignatura";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.dgGrupos);
            this.groupBox2.Location = new System.Drawing.Point(29, 336);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(531, 204);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grupos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAgregar.Location = new System.Drawing.Point(416, 175);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.Text = "Abrir Grupo";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // dgGrupos
            // 
            this.dgGrupos.AllowUserToAddRows = false;
            this.dgGrupos.AllowUserToDeleteRows = false;
            this.dgGrupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGrupos.Location = new System.Drawing.Point(30, 19);
            this.dgGrupos.MultiSelect = false;
            this.dgGrupos.Name = "dgGrupos";
            this.dgGrupos.RowHeadersVisible = false;
            this.dgGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgGrupos.Size = new System.Drawing.Size(461, 150);
            this.dgGrupos.TabIndex = 23;
            // 
            // AsignaturasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.labelX1);
            this.Name = "AsignaturasForm";
            this.Size = new System.Drawing.Size(582, 570);
            this.Load += new System.EventHandler(this.AsignaturasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAsignaturas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgGrupos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lbCategoria;
        private DevComponents.DotNetBar.LabelX lbFacultad;
        private DevComponents.DotNetBar.Controls.Line line1;
        private System.Windows.Forms.DataGridView dgAsignaturas;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNombre;
        private DevComponents.DotNetBar.Controls.TextBoxX txtId;
        private DevComponents.DotNetBar.LabelX lbNombre;
        private DevComponents.DotNetBar.LabelX lbId;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbFacultad;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCategoria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgGrupos;
        private DevComponents.DotNetBar.ButtonX btnAgregar;
    }
}
