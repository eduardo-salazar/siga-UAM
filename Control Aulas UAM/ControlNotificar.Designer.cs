namespace Control_Aulas_UAM
{
    partial class ControlNotificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlNotificar));
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.cbDestinatario = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnNotificar = new DevComponents.DotNetBar.ButtonX();
            this.dateTimeRecordatorio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.dateTimeFecha = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.NotObservacion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.NotDescripcion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cbAlertaEstado = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.compareValidator1 = new DevComponents.DotNetBar.Validator.CompareValidator();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeRecordatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX7.Location = new System.Drawing.Point(12, 427);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(59, 23);
            this.labelX7.TabIndex = 37;
            this.labelX7.Text = "Enviar a:";
            this.labelX7.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cbDestinatario
            // 
            this.cbDestinatario.DisplayMember = "Text";
            this.cbDestinatario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDestinatario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbDestinatario.FormattingEnabled = true;
            this.cbDestinatario.ItemHeight = 17;
            this.cbDestinatario.Location = new System.Drawing.Point(81, 427);
            this.cbDestinatario.Name = "cbDestinatario";
            this.cbDestinatario.Size = new System.Drawing.Size(131, 23);
            this.cbDestinatario.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbDestinatario.TabIndex = 36;
            // 
            // btnNotificar
            // 
            this.btnNotificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNotificar.Image = ((System.Drawing.Image)(resources.GetObject("btnNotificar.Image")));
            this.btnNotificar.Location = new System.Drawing.Point(164, 14);
            this.btnNotificar.Name = "btnNotificar";
            this.btnNotificar.Size = new System.Drawing.Size(60, 45);
            this.btnNotificar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNotificar.TabIndex = 35;
            this.btnNotificar.Tooltip = "Enviar Notificación";
            this.btnNotificar.Click += new System.EventHandler(this.btnNotificar_Click_1);
            // 
            // dateTimeRecordatorio
            // 
            // 
            // 
            // 
            this.dateTimeRecordatorio.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeRecordatorio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeRecordatorio.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeRecordatorio.ButtonDropDown.Visible = true;
            this.dateTimeRecordatorio.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dateTimeRecordatorio.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.Both;
            this.dateTimeRecordatorio.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dateTimeRecordatorio.IsPopupCalendarOpen = false;
            this.dateTimeRecordatorio.Location = new System.Drawing.Point(21, 135);
            // 
            // 
            // 
            this.dateTimeRecordatorio.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeRecordatorio.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeRecordatorio.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeRecordatorio.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeRecordatorio.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeRecordatorio.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeRecordatorio.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeRecordatorio.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeRecordatorio.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeRecordatorio.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeRecordatorio.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeRecordatorio.MonthCalendar.DayClickAutoClosePopup = false;
            this.dateTimeRecordatorio.MonthCalendar.DisplayMonth = new System.DateTime(2012, 11, 1, 0, 0, 0, 0);
            this.dateTimeRecordatorio.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTimeRecordatorio.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeRecordatorio.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeRecordatorio.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeRecordatorio.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeRecordatorio.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeRecordatorio.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeRecordatorio.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTimeRecordatorio.Name = "dateTimeRecordatorio";
            this.dateTimeRecordatorio.ShowUpDown = true;
            this.dateTimeRecordatorio.Size = new System.Drawing.Size(191, 20);
            this.dateTimeRecordatorio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeRecordatorio.TabIndex = 32;
            this.superValidator1.SetValidator1(this.dateTimeRecordatorio, this.compareValidator1);
            this.dateTimeRecordatorio.TextChanged += new System.EventHandler(this.dateTimeRecordatorio_TextChanged);
            this.dateTimeRecordatorio.Click += new System.EventHandler(this.dateTimeRecordatorio_Click);
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX6.Location = new System.Drawing.Point(14, 115);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(70, 23);
            this.labelX6.TabIndex = 33;
            this.labelX6.Text = "Fecha Fin:";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX5.Location = new System.Drawing.Point(21, 398);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(50, 23);
            this.labelX5.TabIndex = 32;
            this.labelX5.Text = "Estado:";
            // 
            // dateTimeFecha
            // 
            // 
            // 
            // 
            this.dateTimeFecha.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeFecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeFecha.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeFecha.ButtonDropDown.Visible = true;
            this.dateTimeFecha.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dateTimeFecha.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.Both;
            this.dateTimeFecha.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dateTimeFecha.IsPopupCalendarOpen = false;
            this.dateTimeFecha.Location = new System.Drawing.Point(21, 80);
            // 
            // 
            // 
            this.dateTimeFecha.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeFecha.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeFecha.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeFecha.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeFecha.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeFecha.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeFecha.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeFecha.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeFecha.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeFecha.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeFecha.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeFecha.MonthCalendar.DayClickAutoClosePopup = false;
            this.dateTimeFecha.MonthCalendar.DisplayMonth = new System.DateTime(2012, 11, 1, 0, 0, 0, 0);
            this.dateTimeFecha.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTimeFecha.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeFecha.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeFecha.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeFecha.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeFecha.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeFecha.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeFecha.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTimeFecha.Name = "dateTimeFecha";
            this.dateTimeFecha.ShowUpDown = true;
            this.dateTimeFecha.Size = new System.Drawing.Size(191, 20);
            this.dateTimeFecha.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeFecha.TabIndex = 31;
            this.dateTimeFecha.Click += new System.EventHandler(this.dateTimeFecha_Click);
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX4.Location = new System.Drawing.Point(21, 61);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(76, 23);
            this.labelX4.TabIndex = 30;
            this.labelX4.Text = "Fecha Inicio:";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX3.Location = new System.Drawing.Point(21, 283);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(85, 23);
            this.labelX3.TabIndex = 29;
            this.labelX3.Text = "Observación:";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX2.Location = new System.Drawing.Point(21, 168);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(76, 23);
            this.labelX2.TabIndex = 28;
            this.labelX2.Text = "Descripción:";
            // 
            // NotObservacion
            // 
            this.NotObservacion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // 
            // 
            this.NotObservacion.Border.Class = "TextBoxBorder";
            this.NotObservacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NotObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NotObservacion.ForeColor = System.Drawing.Color.Black;
            this.NotObservacion.Location = new System.Drawing.Point(21, 307);
            this.NotObservacion.MaxLength = 100;
            this.NotObservacion.Multiline = true;
            this.NotObservacion.Name = "NotObservacion";
            this.NotObservacion.Size = new System.Drawing.Size(191, 84);
            this.NotObservacion.TabIndex = 34;
            // 
            // NotDescripcion
            // 
            this.NotDescripcion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // 
            // 
            this.NotDescripcion.Border.Class = "TextBoxBorder";
            this.NotDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NotDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NotDescripcion.ForeColor = System.Drawing.Color.Black;
            this.NotDescripcion.Location = new System.Drawing.Point(21, 193);
            this.NotDescripcion.MaxLength = 100;
            this.NotDescripcion.Multiline = true;
            this.NotDescripcion.Name = "NotDescripcion";
            this.NotDescripcion.Size = new System.Drawing.Size(191, 84);
            this.NotDescripcion.TabIndex = 33;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX1.Location = new System.Drawing.Point(15, 8);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(76, 23);
            this.labelX1.TabIndex = 25;
            this.labelX1.Text = "Notificación:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cbAlertaEstado
            // 
            this.cbAlertaEstado.DisplayMember = "Text";
            this.cbAlertaEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAlertaEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlertaEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbAlertaEstado.FormattingEnabled = true;
            this.cbAlertaEstado.ItemHeight = 17;
            this.cbAlertaEstado.Location = new System.Drawing.Point(81, 398);
            this.cbAlertaEstado.Name = "cbAlertaEstado";
            this.cbAlertaEstado.Size = new System.Drawing.Size(131, 23);
            this.cbAlertaEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbAlertaEstado.TabIndex = 35;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.DarkOrange;
            this.rectangleShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.rectangleShape1.BorderWidth = 4;
            this.rectangleShape1.CornerRadius = 4;
            this.rectangleShape1.Location = new System.Drawing.Point(2, 3);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(234, 472);
            this.rectangleShape1.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(243, 478);
            this.shapeContainer1.TabIndex = 38;
            this.shapeContainer1.TabStop = false;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Image = global::Control_Aulas_UAM.Properties.Resources.cancelar48;
            this.buttonX1.ImageFixedSize = new System.Drawing.Size(26, 26);
            this.buttonX1.Location = new System.Drawing.Point(98, 14);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(60, 45);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 39;
            this.buttonX1.Tooltip = "Enviar Notificación";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            this.superValidator1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.superValidator1.ValidationType = DevComponents.DotNetBar.Validator.eValidationType.ValidatingEventPerControl;
            // 
            // compareValidator1
            // 
            this.compareValidator1.ControlToCompare = this.dateTimeFecha;
            this.compareValidator1.ControlToCompareValuePropertyName = "Text";
            this.compareValidator1.ErrorMessage = "La fecha de fin debe ser Mayor";
            this.compareValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.compareValidator1.Operator = DevComponents.DotNetBar.Validator.eValidationCompareOperator.GreaterThan;
            this.compareValidator1.ValuePropertyName = "Text";
            this.compareValidator1.ValueToCompare = "Text";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            this.highlighter1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // ControlNotificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.cbDestinatario);
            this.Controls.Add(this.btnNotificar);
            this.Controls.Add(this.dateTimeRecordatorio);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.dateTimeFecha);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.NotObservacion);
            this.Controls.Add(this.NotDescripcion);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cbAlertaEstado);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "ControlNotificar";
            this.Size = new System.Drawing.Size(243, 478);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeRecordatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbDestinatario;
        private DevComponents.DotNetBar.ButtonX btnNotificar;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeRecordatorio;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeFecha;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX NotObservacion;
        private DevComponents.DotNetBar.Controls.TextBoxX NotDescripcion;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbAlertaEstado;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.CompareValidator compareValidator1;

    }
}
