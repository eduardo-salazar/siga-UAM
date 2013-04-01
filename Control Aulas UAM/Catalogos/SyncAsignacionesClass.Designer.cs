namespace Control_Aulas_UAM.Catalogos
{
    partial class SyncAsignacionesClass
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSync = new DevComponents.DotNetBar.ButtonX();
            this.btnSeleccionarTodo = new DevComponents.DotNetBar.ButtonX();
            this.dgAsignacionesClass = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCantidadAsignaciones = new DevComponents.DotNetBar.LabelX();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsignacionesClass)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSync);
            this.groupBox1.Controls.Add(this.btnSeleccionarTodo);
            this.groupBox1.Controls.Add(this.dgAsignacionesClass);
            this.groupBox1.Location = new System.Drawing.Point(20, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 328);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sin sincronizar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSync
            // 
            this.btnSync.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSync.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSync.Location = new System.Drawing.Point(349, 23);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(75, 23);
            this.btnSync.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSync.TabIndex = 2;
            this.btnSync.Text = "Sync";
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // btnSeleccionarTodo
            // 
            this.btnSeleccionarTodo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSeleccionarTodo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSeleccionarTodo.Location = new System.Drawing.Point(430, 23);
            this.btnSeleccionarTodo.Name = "btnSeleccionarTodo";
            this.btnSeleccionarTodo.Size = new System.Drawing.Size(116, 23);
            this.btnSeleccionarTodo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSeleccionarTodo.TabIndex = 1;
            this.btnSeleccionarTodo.Text = "Seleccionar Todo";
            // 
            // dgAsignacionesClass
            // 
            this.dgAsignacionesClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAsignacionesClass.Location = new System.Drawing.Point(6, 52);
            this.dgAsignacionesClass.Name = "dgAsignacionesClass";
            this.dgAsignacionesClass.Size = new System.Drawing.Size(539, 270);
            this.dgAsignacionesClass.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbCantidadAsignaciones
            // 
            // 
            // 
            // 
            this.lbCantidadAsignaciones.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbCantidadAsignaciones.Location = new System.Drawing.Point(473, 342);
            this.lbCantidadAsignaciones.Name = "lbCantidadAsignaciones";
            this.lbCantidadAsignaciones.Size = new System.Drawing.Size(75, 23);
            this.lbCantidadAsignaciones.TabIndex = 2;
            this.lbCantidadAsignaciones.Text = "NINGUNO";
            // 
            // SyncAsignacionesClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 379);
            this.Controls.Add(this.lbCantidadAsignaciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "SyncAsignacionesClass";
            this.Text = "SyncAsignacionesClass";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAsignacionesClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnSync;
        private DevComponents.DotNetBar.ButtonX btnSeleccionarTodo;
        private System.Windows.Forms.DataGridView dgAsignacionesClass;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.LabelX lbCantidadAsignaciones;
    }
}