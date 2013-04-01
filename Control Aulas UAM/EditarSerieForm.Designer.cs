namespace Control_Aulas_UAM
{
    partial class EditarSerieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarSerieForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelDescription = new DevComponents.DotNetBar.LabelX();
            this.radioButtonCurrentEvent = new System.Windows.Forms.RadioButton();
            this.radioButtonNextEvents = new System.Windows.Forms.RadioButton();
            this.radioButtonAllEvents = new System.Windows.Forms.RadioButton();
            this.buttonAccept = new DevComponents.DotNetBar.ButtonX();
            this.buttonCancel = new DevComponents.DotNetBar.ButtonX();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonSelectedEvents = new System.Windows.Forms.RadioButton();
            this.dataGridViewAsignaciones = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ColumnCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnAula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInicio = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.ColumnFin = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.ColumnDuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDescription
            // 
            // 
            // 
            // 
            this.labelDescription.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(82, 12);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(450, 66);
            this.labelDescription.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = "El evento que intenta modificar pertenece a una serie!\r\nSeleccione que eventos de" +
    "sea modificar:";
            // 
            // radioButtonCurrentEvent
            // 
            this.radioButtonCurrentEvent.AutoSize = true;
            this.radioButtonCurrentEvent.Checked = true;
            this.radioButtonCurrentEvent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCurrentEvent.Location = new System.Drawing.Point(6, 19);
            this.radioButtonCurrentEvent.Name = "radioButtonCurrentEvent";
            this.radioButtonCurrentEvent.Size = new System.Drawing.Size(142, 25);
            this.radioButtonCurrentEvent.TabIndex = 1;
            this.radioButtonCurrentEvent.TabStop = true;
            this.radioButtonCurrentEvent.Text = "Sólo este evento";
            this.radioButtonCurrentEvent.UseVisualStyleBackColor = true;
            this.radioButtonCurrentEvent.CheckedChanged += new System.EventHandler(this.radioButtonCurrentEvent_CheckedChanged);
            // 
            // radioButtonNextEvents
            // 
            this.radioButtonNextEvents.AutoSize = true;
            this.radioButtonNextEvents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNextEvents.Location = new System.Drawing.Point(6, 50);
            this.radioButtonNextEvents.Name = "radioButtonNextEvents";
            this.radioButtonNextEvents.Size = new System.Drawing.Size(156, 25);
            this.radioButtonNextEvents.TabIndex = 2;
            this.radioButtonNextEvents.Text = "Eventos siguientes";
            this.radioButtonNextEvents.UseVisualStyleBackColor = true;
            this.radioButtonNextEvents.CheckedChanged += new System.EventHandler(this.radioButtonNextEvents_CheckedChanged);
            // 
            // radioButtonAllEvents
            // 
            this.radioButtonAllEvents.AutoSize = true;
            this.radioButtonAllEvents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAllEvents.Location = new System.Drawing.Point(6, 81);
            this.radioButtonAllEvents.Name = "radioButtonAllEvents";
            this.radioButtonAllEvents.Size = new System.Drawing.Size(152, 25);
            this.radioButtonAllEvents.TabIndex = 3;
            this.radioButtonAllEvents.Text = "Todos los eventos";
            this.radioButtonAllEvents.UseVisualStyleBackColor = true;
            this.radioButtonAllEvents.CheckedChanged += new System.EventHandler(this.radioButtonAllEvents_CheckedChanged);
            // 
            // buttonAccept
            // 
            this.buttonAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonAccept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonAccept.Location = new System.Drawing.Point(371, 408);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonAccept.TabIndex = 4;
            this.buttonAccept.Text = "Aceptar";
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(452, 408);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(64, 64);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioButtonSelectedEvents);
            this.groupBox.Controls.Add(this.radioButtonCurrentEvent);
            this.groupBox.Controls.Add(this.radioButtonNextEvents);
            this.groupBox.Controls.Add(this.radioButtonAllEvents);
            this.groupBox.Location = new System.Drawing.Point(82, 84);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(445, 162);
            this.groupBox.TabIndex = 7;
            this.groupBox.TabStop = false;
            // 
            // radioButtonSelectedEvents
            // 
            this.radioButtonSelectedEvents.AutoSize = true;
            this.radioButtonSelectedEvents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSelectedEvents.Location = new System.Drawing.Point(6, 112);
            this.radioButtonSelectedEvents.Name = "radioButtonSelectedEvents";
            this.radioButtonSelectedEvents.Size = new System.Drawing.Size(184, 25);
            this.radioButtonSelectedEvents.TabIndex = 4;
            this.radioButtonSelectedEvents.Text = "Eventos Seleccionados";
            this.radioButtonSelectedEvents.UseVisualStyleBackColor = true;
            this.radioButtonSelectedEvents.CheckedChanged += new System.EventHandler(this.radioButtonSelectedEvents_CheckedChanged);
            // 
            // dataGridViewAsignaciones
            // 
            this.dataGridViewAsignaciones.AllowUserToAddRows = false;
            this.dataGridViewAsignaciones.AllowUserToDeleteRows = false;
            this.dataGridViewAsignaciones.AllowUserToResizeColumns = false;
            this.dataGridViewAsignaciones.AllowUserToResizeRows = false;
            this.dataGridViewAsignaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAsignaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAsignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewAsignaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCheck,
            this.ColumnAula,
            this.ColumnDia,
            this.ColumnInicio,
            this.ColumnFin,
            this.ColumnDuracion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAsignaciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAsignaciones.EnableHeadersVisualStyles = false;
            this.dataGridViewAsignaciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewAsignaciones.Location = new System.Drawing.Point(12, 252);
            this.dataGridViewAsignaciones.Name = "dataGridViewAsignaciones";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAsignaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAsignaciones.RowHeadersWidth = 10;
            this.dataGridViewAsignaciones.Size = new System.Drawing.Size(515, 150);
            this.dataGridViewAsignaciones.TabIndex = 45;
            // 
            // ColumnCheck
            // 
            this.ColumnCheck.FillWeight = 30.45685F;
            this.ColumnCheck.HeaderText = "";
            this.ColumnCheck.Name = "ColumnCheck";
            // 
            // ColumnAula
            // 
            this.ColumnAula.DataPropertyName = "AulaReferencia";
            this.ColumnAula.FillWeight = 113.9086F;
            this.ColumnAula.HeaderText = "Aula";
            this.ColumnAula.Name = "ColumnAula";
            this.ColumnAula.ReadOnly = true;
            // 
            // ColumnDia
            // 
            this.ColumnDia.DataPropertyName = "Dia";
            this.ColumnDia.FillWeight = 113.9086F;
            this.ColumnDia.HeaderText = "Dia";
            this.ColumnDia.Name = "ColumnDia";
            this.ColumnDia.ReadOnly = true;
            this.ColumnDia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnInicio
            // 
            this.ColumnInicio.AllowEmptyState = false;
            // 
            // 
            // 
            this.ColumnInicio.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.ColumnInicio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ColumnInicio.ButtonDropDown.Visible = true;
            this.ColumnInicio.CustomFormat = "hh:mm tt";
            this.ColumnInicio.DataPropertyName = "Inicio";
            this.ColumnInicio.FillWeight = 113.9086F;
            this.ColumnInicio.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.ColumnInicio.HeaderText = "Inicio";
            this.ColumnInicio.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.ColumnInicio.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.ColumnInicio.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ColumnInicio.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.ColumnInicio.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ColumnInicio.MonthCalendar.DisplayMonth = new System.DateTime(2012, 10, 1, 0, 0, 0, 0);
            this.ColumnInicio.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.ColumnInicio.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.ColumnInicio.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ColumnInicio.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.ColumnInicio.Name = "ColumnInicio";
            this.ColumnInicio.ReadOnly = true;
            this.ColumnInicio.ShowUpDown = true;
            this.ColumnInicio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnFin
            // 
            // 
            // 
            // 
            this.ColumnFin.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.ColumnFin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ColumnFin.CustomFormat = "hh:mm tt";
            this.ColumnFin.DataPropertyName = "Fin";
            this.ColumnFin.FillWeight = 113.9086F;
            this.ColumnFin.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.ColumnFin.HeaderText = "Fin";
            this.ColumnFin.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.ColumnFin.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.ColumnFin.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ColumnFin.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.ColumnFin.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ColumnFin.MonthCalendar.DisplayMonth = new System.DateTime(2012, 10, 1, 0, 0, 0, 0);
            this.ColumnFin.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.ColumnFin.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.ColumnFin.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ColumnFin.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.ColumnFin.Name = "ColumnFin";
            this.ColumnFin.ReadOnly = true;
            this.ColumnFin.ShowUpDown = true;
            this.ColumnFin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnDuracion
            // 
            this.ColumnDuracion.DataPropertyName = "Duracion";
            this.ColumnDuracion.FillWeight = 113.9086F;
            this.ColumnDuracion.HeaderText = "Duración";
            this.ColumnDuracion.Name = "ColumnDuracion";
            this.ColumnDuracion.ReadOnly = true;
            this.ColumnDuracion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EditarSerieForm
            // 
            this.AcceptButton = this.buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(547, 438);
            this.Controls.Add(this.dataGridViewAsignaciones);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.labelDescription);
            this.Name = "EditarSerieForm";
            this.Text = "EditarSerieForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelDescription;
        private System.Windows.Forms.RadioButton radioButtonCurrentEvent;
        private System.Windows.Forms.RadioButton radioButtonNextEvents;
        private System.Windows.Forms.RadioButton radioButtonAllEvents;
        private DevComponents.DotNetBar.ButtonX buttonAccept;
        private DevComponents.DotNetBar.ButtonX buttonCancel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewAsignaciones;
        private System.Windows.Forms.RadioButton radioButtonSelectedEvents;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDia;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn ColumnInicio;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn ColumnFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDuracion;
    }
}