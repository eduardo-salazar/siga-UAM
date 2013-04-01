namespace Control_Aulas_UAM.Catalogos
{
    partial class AulasForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AulasForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbEstado = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.txtPiso = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.rangeValidator1 = new DevComponents.DotNetBar.Validator.RangeValidator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.lbId = new DevComponents.DotNetBar.LabelX();
            this.txtId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgEquipos = new System.Windows.Forms.DataGridView();
            this.dgAulas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPiso = new DevComponents.DotNetBar.LabelX();
            this.lbEdificio = new DevComponents.DotNetBar.LabelX();
            this.cbEdificio = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtCapacidad = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbCapacidad = new DevComponents.DotNetBar.LabelX();
            this.txtDescripcion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbDescripcion = new DevComponents.DotNetBar.LabelX();
            this.lbTipo = new DevComponents.DotNetBar.LabelX();
            this.cbTipo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAulas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            this.superValidator1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // cbEstado
            // 
            this.cbEstado.DisplayMember = "Text";
            this.cbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cbEstado.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.cbEstado, System.Windows.Forms.ErrorIconAlignment.BottomRight);
            this.cbEstado.ItemHeight = 32;
            this.cbEstado.Location = new System.Drawing.Point(313, 27);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(132, 38);
            this.cbEstado.Sorted = true;
            this.cbEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbEstado.TabIndex = 22;
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            this.highlighter1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // txtPiso
            // 
            this.txtPiso.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // 
            // 
            this.txtPiso.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPiso.ForeColor = System.Drawing.Color.Black;
            this.txtPiso.Location = new System.Drawing.Point(319, 48);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(100, 23);
            this.txtPiso.TabIndex = 11;
            this.superValidator1.SetValidator1(this.txtPiso, this.rangeValidator1);
            // 
            // rangeValidator1
            // 
            this.rangeValidator1.ErrorMessage = "Your error message here.";
            this.rangeValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.rangeValidator1.MaximumValue = "20";
            this.rangeValidator1.MinimumValue = "1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgEquipos);
            this.panel1.Controls.Add(this.dgAulas);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 470);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonX1);
            this.panel2.Controls.Add(this.lbId);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.cbEstado);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(688, 73);
            this.panel2.TabIndex = 12;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(577, 27);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 25;
            this.buttonX1.Text = "Notificar";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click_1);
            // 
            // lbId
            // 
            // 
            // 
            // 
            this.lbId.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbId.Location = new System.Drawing.Point(60, 27);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(76, 23);
            this.lbId.TabIndex = 20;
            this.lbId.Text = "Aula:";
            this.lbId.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // 
            // 
            this.txtId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.Location = new System.Drawing.Point(142, 27);
            this.txtId.MaxLength = 10;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(124, 32);
            this.txtId.TabIndex = 21;
            // 
            // dgEquipos
            // 
            this.dgEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEquipos.Location = new System.Drawing.Point(11, 283);
            this.dgEquipos.Name = "dgEquipos";
            this.dgEquipos.Size = new System.Drawing.Size(457, 157);
            this.dgEquipos.TabIndex = 24;
            // 
            // dgAulas
            // 
            this.dgAulas.AllowUserToAddRows = false;
            this.dgAulas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAulas.BackgroundColor = System.Drawing.Color.White;
            this.dgAulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAulas.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAulas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgAulas.Location = new System.Drawing.Point(474, 79);
            this.dgAulas.Name = "dgAulas";
            this.dgAulas.RowHeadersVisible = false;
            this.dgAulas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAulas.Size = new System.Drawing.Size(178, 363);
            this.dgAulas.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtPiso);
            this.groupBox1.Controls.Add(this.lbPiso);
            this.groupBox1.Controls.Add(this.lbEdificio);
            this.groupBox1.Controls.Add(this.cbEdificio);
            this.groupBox1.Controls.Add(this.txtCapacidad);
            this.groupBox1.Controls.Add(this.lbCapacidad);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.lbDescripcion);
            this.groupBox1.Controls.Add(this.lbTipo);
            this.groupBox1.Controls.Add(this.cbTipo);
            this.groupBox1.Location = new System.Drawing.Point(11, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 200);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // lbPiso
            // 
            // 
            // 
            // 
            this.lbPiso.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbPiso.Location = new System.Drawing.Point(237, 48);
            this.lbPiso.Name = "lbPiso";
            this.lbPiso.Size = new System.Drawing.Size(76, 23);
            this.lbPiso.TabIndex = 10;
            this.lbPiso.Text = "Piso:";
            this.lbPiso.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lbEdificio
            // 
            // 
            // 
            // 
            this.lbEdificio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbEdificio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbEdificio.Location = new System.Drawing.Point(6, 48);
            this.lbEdificio.Name = "lbEdificio";
            this.lbEdificio.Size = new System.Drawing.Size(76, 23);
            this.lbEdificio.TabIndex = 9;
            this.lbEdificio.Text = "Edificio:";
            this.lbEdificio.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cbEdificio
            // 
            this.cbEdificio.DisplayMember = "Text";
            this.cbEdificio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEdificio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbEdificio.FormattingEnabled = true;
            this.cbEdificio.ItemHeight = 17;
            this.cbEdificio.Location = new System.Drawing.Point(88, 48);
            this.cbEdificio.Name = "cbEdificio";
            this.cbEdificio.Size = new System.Drawing.Size(143, 23);
            this.cbEdificio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbEdificio.TabIndex = 8;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // 
            // 
            this.txtCapacidad.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCapacidad.ForeColor = System.Drawing.Color.Black;
            this.txtCapacidad.Location = new System.Drawing.Point(319, 19);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(100, 23);
            this.txtCapacidad.TabIndex = 7;
            // 
            // lbCapacidad
            // 
            // 
            // 
            // 
            this.lbCapacidad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCapacidad.Location = new System.Drawing.Point(237, 19);
            this.lbCapacidad.Name = "lbCapacidad";
            this.lbCapacidad.Size = new System.Drawing.Size(76, 23);
            this.lbCapacidad.TabIndex = 6;
            this.lbCapacidad.Text = "Capacidad:";
            this.lbCapacidad.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // 
            // 
            this.txtDescripcion.Border.Class = "TextBoxBorder";
            this.txtDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.Location = new System.Drawing.Point(102, 91);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(331, 85);
            this.txtDescripcion.TabIndex = 5;
            // 
            // lbDescripcion
            // 
            // 
            // 
            // 
            this.lbDescripcion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDescripcion.Location = new System.Drawing.Point(20, 91);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(76, 23);
            this.lbDescripcion.TabIndex = 4;
            this.lbDescripcion.Text = "Descripción:";
            this.lbDescripcion.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lbTipo
            // 
            // 
            // 
            // 
            this.lbTipo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTipo.Location = new System.Drawing.Point(6, 19);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(76, 23);
            this.lbTipo.TabIndex = 3;
            this.lbTipo.Text = "Tipo:";
            this.lbTipo.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cbTipo
            // 
            this.cbTipo.DisplayMember = "Text";
            this.cbTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.ItemHeight = 17;
            this.cbTipo.Location = new System.Drawing.Point(88, 19);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(143, 23);
            this.cbTipo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbTipo.TabIndex = 0;
            // 
            // AulasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "AulasForm";
            this.Size = new System.Drawing.Size(688, 470);
            this.Load += new System.EventHandler(this.AulasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAulas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RangeValidator rangeValidator1;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.DataGridView dgEquipos;
        private System.Windows.Forms.DataGridView dgAulas;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbEstado;
        private DevComponents.DotNetBar.LabelX lbId;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPiso;
        private DevComponents.DotNetBar.LabelX lbPiso;
        private DevComponents.DotNetBar.LabelX lbEdificio;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbEdificio;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCapacidad;
        private DevComponents.DotNetBar.LabelX lbCapacidad;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDescripcion;
        private DevComponents.DotNetBar.LabelX lbDescripcion;
        private DevComponents.DotNetBar.LabelX lbTipo;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbTipo;
        private DevComponents.DotNetBar.Controls.TextBoxX txtId;
        private System.Windows.Forms.Panel panel2;
    }
}
