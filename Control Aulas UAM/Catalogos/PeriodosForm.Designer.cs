namespace Control_Aulas_UAM.Catalogos
{
    partial class PeriodosForm
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
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.dgPeriodos = new System.Windows.Forms.DataGridView();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtDescripcion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbDescripcion = new DevComponents.DotNetBar.LabelX();
            this.lbId = new DevComponents.DotNetBar.LabelX();
            this.lbFechaInicio = new DevComponents.DotNetBar.LabelX();
            this.lbFichaFin = new DevComponents.DotNetBar.LabelX();
            this.dtFechaInicio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtFechaFin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeriodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFin)).BeginInit();
            this.SuspendLayout();
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(12, 45);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(495, 23);
            this.line1.TabIndex = 13;
            this.line1.Text = "line1";
            // 
            // dgPeriodos
            // 
            this.dgPeriodos.AllowUserToAddRows = false;
            this.dgPeriodos.AllowUserToDeleteRows = false;
            this.dgPeriodos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPeriodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPeriodos.Location = new System.Drawing.Point(61, 238);
            this.dgPeriodos.MultiSelect = false;
            this.dgPeriodos.Name = "dgPeriodos";
            this.dgPeriodos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPeriodos.Size = new System.Drawing.Size(406, 150);
            this.dgPeriodos.TabIndex = 12;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(170, 16);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(179, 23);
            this.labelX1.TabIndex = 11;
            this.labelX1.Text = "Catálogo de Periodos";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
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
            this.txtDescripcion.Location = new System.Drawing.Point(128, 134);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(306, 85);
            this.txtDescripcion.TabIndex = 10;
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
            this.txtId.Location = new System.Drawing.Point(128, 78);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(61, 23);
            this.txtId.TabIndex = 9;
            // 
            // lbDescripcion
            // 
            // 
            // 
            // 
            this.lbDescripcion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.Location = new System.Drawing.Point(47, 134);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(75, 23);
            this.lbDescripcion.TabIndex = 8;
            this.lbDescripcion.Text = "Descripción:";
            this.lbDescripcion.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lbId
            // 
            // 
            // 
            // 
            this.lbId.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(47, 76);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(75, 23);
            this.lbId.TabIndex = 7;
            this.lbId.Text = "ID:";
            this.lbId.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lbFechaInicio
            // 
            // 
            // 
            // 
            this.lbFechaInicio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaInicio.Location = new System.Drawing.Point(225, 76);
            this.lbFechaInicio.Name = "lbFechaInicio";
            this.lbFechaInicio.Size = new System.Drawing.Size(82, 23);
            this.lbFechaInicio.TabIndex = 14;
            this.lbFechaInicio.Text = "Fecha Inicio:";
            this.lbFechaInicio.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lbFichaFin
            // 
            // 
            // 
            // 
            this.lbFichaFin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbFichaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFichaFin.Location = new System.Drawing.Point(225, 105);
            this.lbFichaFin.Name = "lbFichaFin";
            this.lbFichaFin.Size = new System.Drawing.Size(82, 23);
            this.lbFichaFin.TabIndex = 15;
            this.lbFichaFin.Text = "Fecha Fin:";
            this.lbFichaFin.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // dtFechaInicio
            // 
            // 
            // 
            // 
            this.dtFechaInicio.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFechaInicio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInicio.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFechaInicio.ButtonDropDown.Visible = true;
            this.dtFechaInicio.IsPopupCalendarOpen = false;
            this.dtFechaInicio.Location = new System.Drawing.Point(313, 78);
            // 
            // 
            // 
            this.dtFechaInicio.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaInicio.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInicio.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtFechaInicio.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFechaInicio.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFechaInicio.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaInicio.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFechaInicio.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFechaInicio.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFechaInicio.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFechaInicio.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInicio.MonthCalendar.DisplayMonth = new System.DateTime(2012, 10, 1, 0, 0, 0, 0);
            this.dtFechaInicio.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtFechaInicio.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaInicio.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFechaInicio.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaInicio.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFechaInicio.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaInicio.MonthCalendar.TodayButtonVisible = true;
            this.dtFechaInicio.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(121, 20);
            this.dtFechaInicio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFechaInicio.TabIndex = 16;
            // 
            // dtFechaFin
            // 
            // 
            // 
            // 
            this.dtFechaFin.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFechaFin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaFin.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFechaFin.ButtonDropDown.Visible = true;
            this.dtFechaFin.IsPopupCalendarOpen = false;
            this.dtFechaFin.Location = new System.Drawing.Point(313, 108);
            // 
            // 
            // 
            this.dtFechaFin.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaFin.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaFin.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtFechaFin.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFechaFin.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFechaFin.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaFin.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFechaFin.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFechaFin.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFechaFin.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFechaFin.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaFin.MonthCalendar.DisplayMonth = new System.DateTime(2012, 10, 1, 0, 0, 0, 0);
            this.dtFechaFin.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtFechaFin.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaFin.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFechaFin.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaFin.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFechaFin.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaFin.MonthCalendar.TodayButtonVisible = true;
            this.dtFechaFin.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(121, 20);
            this.dtFechaFin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFechaFin.TabIndex = 17;
            // 
            // PeriodosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtFechaFin);
            this.Controls.Add(this.dtFechaInicio);
            this.Controls.Add(this.lbFichaFin);
            this.Controls.Add(this.lbFechaInicio);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.dgPeriodos);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbId);
            this.Name = "PeriodosForm";
            this.Size = new System.Drawing.Size(521, 446);
            ((System.ComponentModel.ISupportInitialize)(this.dgPeriodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.Line line1;
        private System.Windows.Forms.DataGridView dgPeriodos;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDescripcion;
        private DevComponents.DotNetBar.Controls.TextBoxX txtId;
        private DevComponents.DotNetBar.LabelX lbDescripcion;
        private DevComponents.DotNetBar.LabelX lbId;
        private DevComponents.DotNetBar.LabelX lbFechaInicio;
        private DevComponents.DotNetBar.LabelX lbFichaFin;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaInicio;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaFin;
    }
}
