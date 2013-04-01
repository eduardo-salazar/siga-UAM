namespace Control_Aulas_UAM
{
    partial class AsignacionVariosControl
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
            DevComponents.DotNetBar.Validator.CompareValidator compareDateTimeFinValidator;
            DevComponents.DotNetBar.Validator.CompareValidator compareDateTimeInicioValidator;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignacionVariosControl));
            this.dateTimeInputInicio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dateTimeInputFin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.comboBoxLugar = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelLugar = new DevComponents.DotNetBar.LabelX();
            this.labelTitulo = new DevComponents.DotNetBar.LabelX();
            this.textBoxDuracion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelDuracion = new DevComponents.DotNetBar.LabelX();
            this.labelObservaciones = new DevComponents.DotNetBar.LabelX();
            this.labelTipoUso = new DevComponents.DotNetBar.LabelX();
            this.labelFin = new DevComponents.DotNetBar.LabelX();
            this.labelInicio = new DevComponents.DotNetBar.LabelX();
            this.comboBoxTipoUso = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.textBoxObservaciones = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.superValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            compareDateTimeFinValidator = new DevComponents.DotNetBar.Validator.CompareValidator();
            compareDateTimeInicioValidator = new DevComponents.DotNetBar.Validator.CompareValidator();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // compareDateTimeFinValidator
            // 
            compareDateTimeFinValidator.ControlToCompare = this.dateTimeInputInicio;
            compareDateTimeFinValidator.ControlToCompareValuePropertyName = "Value";
            compareDateTimeFinValidator.ErrorMessage = "La fecha y hora de finalizacion debe de ser mayor que la de inicio";
            compareDateTimeFinValidator.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            compareDateTimeFinValidator.Operator = DevComponents.DotNetBar.Validator.eValidationCompareOperator.GreaterThan;
            compareDateTimeFinValidator.ValuePropertyName = "Value";
            compareDateTimeFinValidator.ValueToCompare = "Value";
            // 
            // dateTimeInputInicio
            // 
            this.dateTimeInputInicio.AllowEmptyState = false;
            // 
            // 
            // 
            this.dateTimeInputInicio.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInputInicio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputInicio.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInputInicio.ButtonDropDown.Visible = true;
            this.dateTimeInputInicio.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dateTimeInputInicio.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.Both;
            this.dateTimeInputInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeInputInicio.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dateTimeInputInicio.IsPopupCalendarOpen = false;
            this.dateTimeInputInicio.Location = new System.Drawing.Point(3, 85);
            // 
            // 
            // 
            this.dateTimeInputInicio.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInputInicio.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputInicio.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeInputInicio.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInputInicio.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInputInicio.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputInicio.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInputInicio.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInputInicio.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInputInicio.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInputInicio.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputInicio.MonthCalendar.DayClickAutoClosePopup = false;
            this.dateTimeInputInicio.MonthCalendar.DisplayMonth = new System.DateTime(2012, 10, 1, 0, 0, 0, 0);
            this.dateTimeInputInicio.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTimeInputInicio.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInputInicio.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInputInicio.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputInicio.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInputInicio.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputInicio.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInputInicio.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTimeInputInicio.Name = "dateTimeInputInicio";
            this.dateTimeInputInicio.ShowUpDown = true;
            this.dateTimeInputInicio.Size = new System.Drawing.Size(200, 22);
            this.dateTimeInputInicio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInputInicio.TabIndex = 45;
            this.superValidator.SetValidator1(this.dateTimeInputInicio, compareDateTimeInicioValidator);
            this.dateTimeInputInicio.Value = new System.DateTime(2012, 10, 29, 4, 53, 31, 0);
            this.dateTimeInputInicio.ValueChanged += new System.EventHandler(this.dateTimeInput_ValueChanged);
            // 
            // compareDateTimeInicioValidator
            // 
            compareDateTimeInicioValidator.ControlToCompare = this.dateTimeInputFin;
            compareDateTimeInicioValidator.ControlToCompareValuePropertyName = "Value";
            compareDateTimeInicioValidator.ErrorMessage = "La fecha y hora de inicio debe de ser menor que la de finalizacion";
            compareDateTimeInicioValidator.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            compareDateTimeInicioValidator.Operator = DevComponents.DotNetBar.Validator.eValidationCompareOperator.LessThan;
            compareDateTimeInicioValidator.ValuePropertyName = "Value";
            compareDateTimeInicioValidator.ValueToCompare = "Value";
            // 
            // dateTimeInputFin
            // 
            this.dateTimeInputFin.AllowEmptyState = false;
            // 
            // 
            // 
            this.dateTimeInputFin.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInputFin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputFin.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInputFin.ButtonDropDown.Visible = true;
            this.dateTimeInputFin.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dateTimeInputFin.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.Both;
            this.dateTimeInputFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeInputFin.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dateTimeInputFin.IsPopupCalendarOpen = false;
            this.dateTimeInputFin.Location = new System.Drawing.Point(3, 138);
            // 
            // 
            // 
            this.dateTimeInputFin.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInputFin.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputFin.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeInputFin.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInputFin.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInputFin.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputFin.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInputFin.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInputFin.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInputFin.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInputFin.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputFin.MonthCalendar.DayClickAutoClosePopup = false;
            this.dateTimeInputFin.MonthCalendar.DisplayMonth = new System.DateTime(2012, 10, 1, 0, 0, 0, 0);
            this.dateTimeInputFin.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTimeInputFin.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInputFin.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInputFin.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputFin.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInputFin.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputFin.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInputFin.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTimeInputFin.Name = "dateTimeInputFin";
            this.dateTimeInputFin.ShowUpDown = true;
            this.dateTimeInputFin.Size = new System.Drawing.Size(200, 22);
            this.dateTimeInputFin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInputFin.TabIndex = 47;
            this.superValidator.SetValidator1(this.dateTimeInputFin, compareDateTimeFinValidator);
            this.dateTimeInputFin.Value = new System.DateTime(2012, 10, 29, 4, 53, 39, 0);
            this.dateTimeInputFin.ValueChanged += new System.EventHandler(this.dateTimeInput_ValueChanged);
            // 
            // comboBoxLugar
            // 
            this.comboBoxLugar.DisplayMember = "Text";
            this.comboBoxLugar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxLugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLugar.FormattingEnabled = true;
            this.comboBoxLugar.ItemHeight = 16;
            this.comboBoxLugar.Location = new System.Drawing.Point(3, 252);
            this.comboBoxLugar.Name = "comboBoxLugar";
            this.comboBoxLugar.Size = new System.Drawing.Size(200, 22);
            this.comboBoxLugar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxLugar.TabIndex = 56;
            // 
            // labelLugar
            // 
            // 
            // 
            // 
            this.labelLugar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelLugar.Location = new System.Drawing.Point(3, 223);
            this.labelLugar.Name = "labelLugar";
            this.labelLugar.Size = new System.Drawing.Size(75, 23);
            this.labelLugar.TabIndex = 55;
            this.labelLugar.Text = "Lugar:";
            // 
            // labelTitulo
            // 
            // 
            // 
            // 
            this.labelTitulo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelTitulo.Location = new System.Drawing.Point(3, 3);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(200, 47);
            this.labelTitulo.TabIndex = 54;
            this.labelTitulo.Text = "Asignación de Varios";
            // 
            // textBoxDuracion
            // 
            // 
            // 
            // 
            this.textBoxDuracion.Border.Class = "TextBoxBorder";
            this.textBoxDuracion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDuracion.Location = new System.Drawing.Point(3, 195);
            this.textBoxDuracion.Name = "textBoxDuracion";
            this.textBoxDuracion.ReadOnly = true;
            this.textBoxDuracion.Size = new System.Drawing.Size(200, 22);
            this.textBoxDuracion.TabIndex = 53;
            this.textBoxDuracion.Text = "Invalido";
            // 
            // labelDuracion
            // 
            // 
            // 
            // 
            this.labelDuracion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDuracion.Location = new System.Drawing.Point(3, 166);
            this.labelDuracion.Name = "labelDuracion";
            this.labelDuracion.Size = new System.Drawing.Size(93, 23);
            this.labelDuracion.TabIndex = 52;
            this.labelDuracion.Text = "Duracion:";
            // 
            // labelObservaciones
            // 
            // 
            // 
            // 
            this.labelObservaciones.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelObservaciones.Location = new System.Drawing.Point(3, 335);
            this.labelObservaciones.Name = "labelObservaciones";
            this.labelObservaciones.Size = new System.Drawing.Size(151, 23);
            this.labelObservaciones.TabIndex = 50;
            this.labelObservaciones.Text = "Observaciones:";
            // 
            // labelTipoUso
            // 
            // 
            // 
            // 
            this.labelTipoUso.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelTipoUso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTipoUso.Location = new System.Drawing.Point(3, 280);
            this.labelTipoUso.Name = "labelTipoUso";
            this.labelTipoUso.Size = new System.Drawing.Size(151, 23);
            this.labelTipoUso.TabIndex = 48;
            this.labelTipoUso.Text = "Tipo de Uso:";
            // 
            // labelFin
            // 
            // 
            // 
            // 
            this.labelFin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFin.Location = new System.Drawing.Point(3, 111);
            this.labelFin.Name = "labelFin";
            this.labelFin.Size = new System.Drawing.Size(75, 23);
            this.labelFin.TabIndex = 46;
            this.labelFin.Text = "Fin:";
            // 
            // labelInicio
            // 
            // 
            // 
            // 
            this.labelInicio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelInicio.Location = new System.Drawing.Point(3, 56);
            this.labelInicio.Name = "labelInicio";
            this.labelInicio.Size = new System.Drawing.Size(75, 23);
            this.labelInicio.TabIndex = 44;
            this.labelInicio.Text = "Inicio:";
            // 
            // comboBoxTipoUso
            // 
            this.comboBoxTipoUso.DisplayMember = "Text";
            this.comboBoxTipoUso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxTipoUso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoUso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipoUso.FormattingEnabled = true;
            this.comboBoxTipoUso.ItemHeight = 16;
            this.comboBoxTipoUso.Location = new System.Drawing.Point(3, 309);
            this.comboBoxTipoUso.Name = "comboBoxTipoUso";
            this.comboBoxTipoUso.Size = new System.Drawing.Size(200, 22);
            this.comboBoxTipoUso.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxTipoUso.TabIndex = 49;
            // 
            // textBoxObservaciones
            // 
            // 
            // 
            // 
            this.textBoxObservaciones.Border.Class = "TextBoxBorder";
            this.textBoxObservaciones.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxObservaciones.Location = new System.Drawing.Point(3, 364);
            this.textBoxObservaciones.Multiline = true;
            this.textBoxObservaciones.Name = "textBoxObservaciones";
            this.textBoxObservaciones.Size = new System.Drawing.Size(200, 129);
            this.textBoxObservaciones.TabIndex = 57;
            this.textBoxObservaciones.WatermarkText = "Observaciones";
            // 
            // superValidator
            // 
            this.superValidator.ContainerControl = this;
            this.superValidator.ErrorProvider = this.errorProvider;
            this.superValidator.Highlighter = this.highlighter;
            this.superValidator.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            this.highlighter.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // AsignacionVariosControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxObservaciones);
            this.Controls.Add(this.comboBoxLugar);
            this.Controls.Add(this.labelLugar);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.textBoxDuracion);
            this.Controls.Add(this.labelDuracion);
            this.Controls.Add(this.labelObservaciones);
            this.Controls.Add(this.comboBoxTipoUso);
            this.Controls.Add(this.labelTipoUso);
            this.Controls.Add(this.dateTimeInputFin);
            this.Controls.Add(this.labelFin);
            this.Controls.Add(this.dateTimeInputInicio);
            this.Controls.Add(this.labelInicio);
            this.Name = "AsignacionVariosControl";
            this.Size = new System.Drawing.Size(219, 510);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelLugar;
        private DevComponents.DotNetBar.LabelX labelTitulo;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxDuracion;
        private DevComponents.DotNetBar.LabelX labelDuracion;
        private DevComponents.DotNetBar.LabelX labelObservaciones;
        private DevComponents.DotNetBar.LabelX labelTipoUso;
        private DevComponents.DotNetBar.LabelX labelFin;
        private DevComponents.DotNetBar.LabelX labelInicio;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxObservaciones;
        public DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInputFin;
        public DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInputInicio;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        public DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxLugar;
        public DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxTipoUso;

    }
}
