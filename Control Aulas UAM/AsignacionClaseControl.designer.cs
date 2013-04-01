namespace Control_Aulas_UAM
{
    partial class AsignacionClaseControl
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
            System.Windows.Forms.ErrorProvider errorProvider;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignacionClaseControl));
            DevComponents.DotNetBar.Validator.Highlighter highlighter;
            DevComponents.DotNetBar.Validator.CompareValidator compareDateTimeFinValidator;
            DevComponents.DotNetBar.Validator.CompareValidator compareDateTimeInicioValidator;
            this.dateTimeInputInicio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dateTimeInputFin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelFin = new DevComponents.DotNetBar.LabelX();
            this.labelInicio = new DevComponents.DotNetBar.LabelX();
            this.labelAsignatura = new DevComponents.DotNetBar.LabelX();
            this.comboBoxAsignatura = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboBoxGrupo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelGrupo = new DevComponents.DotNetBar.LabelX();
            this.labelDuracion = new DevComponents.DotNetBar.LabelX();
            this.textBoxDuracion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelTitulo = new DevComponents.DotNetBar.LabelX();
            this.labelLugar = new DevComponents.DotNetBar.LabelX();
            this.comboBoxLugar = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.superValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.customValidator_Asignatura_Exists = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.requiredFieldGrupo = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Es requerido seleccionar un grupo");
            this.textBoxDocente = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelDocente = new DevComponents.DotNetBar.LabelX();
            errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            compareDateTimeFinValidator = new DevComponents.DotNetBar.Validator.CompareValidator();
            compareDateTimeInicioValidator = new DevComponents.DotNetBar.Validator.CompareValidator();
            ((System.ComponentModel.ISupportInitialize)(errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputFin)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // highlighter
            // 
            highlighter.ContainerControl = this;
            highlighter.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
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
            this.dateTimeInputInicio.Location = new System.Drawing.Point(10, 85);
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
            this.dateTimeInputInicio.TabIndex = 31;
            this.superValidator.SetValidator1(this.dateTimeInputInicio, compareDateTimeInicioValidator);
            this.dateTimeInputInicio.Value = new System.DateTime(2012, 10, 29, 4, 53, 31, 0);
            this.dateTimeInputInicio.ValueChanged += new System.EventHandler(this.dateTimeInput_ValueChanged);
            // 
            // compareDateTimeInicioValidator
            // 
            compareDateTimeInicioValidator.ControlToCompare = this.dateTimeInputFin;
            compareDateTimeInicioValidator.ControlToCompareValuePropertyName = "Value";
            compareDateTimeInicioValidator.ErrorMessage = "La fecha y hora de incio debe de ser mayor que la de finalizacion";
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
            this.dateTimeInputFin.Location = new System.Drawing.Point(10, 138);
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
            this.dateTimeInputFin.TabIndex = 33;
            this.superValidator.SetValidator1(this.dateTimeInputFin, compareDateTimeFinValidator);
            this.dateTimeInputFin.Value = new System.DateTime(2012, 10, 29, 5, 53, 0, 0);
            this.dateTimeInputFin.ValueChanged += new System.EventHandler(this.dateTimeInput_ValueChanged);
            // 
            // labelFin
            // 
            // 
            // 
            // 
            this.labelFin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFin.Location = new System.Drawing.Point(10, 111);
            this.labelFin.Name = "labelFin";
            this.labelFin.Size = new System.Drawing.Size(75, 23);
            this.labelFin.TabIndex = 32;
            this.labelFin.Text = "Fin:";
            // 
            // labelInicio
            // 
            // 
            // 
            // 
            this.labelInicio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelInicio.Location = new System.Drawing.Point(10, 56);
            this.labelInicio.Name = "labelInicio";
            this.labelInicio.Size = new System.Drawing.Size(75, 23);
            this.labelInicio.TabIndex = 30;
            this.labelInicio.Text = "Inicio:";
            // 
            // labelAsignatura
            // 
            // 
            // 
            // 
            this.labelAsignatura.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelAsignatura.Location = new System.Drawing.Point(10, 280);
            this.labelAsignatura.Name = "labelAsignatura";
            this.labelAsignatura.Size = new System.Drawing.Size(93, 23);
            this.labelAsignatura.TabIndex = 35;
            this.labelAsignatura.Text = "Asignatura:";
            // 
            // comboBoxAsignatura
            // 
            this.comboBoxAsignatura.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxAsignatura.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxAsignatura.DisplayMember = "Text";
            this.comboBoxAsignatura.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxAsignatura.DropDownWidth = 350;
            this.comboBoxAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAsignatura.FormattingEnabled = true;
            this.comboBoxAsignatura.ItemHeight = 16;
            this.comboBoxAsignatura.Location = new System.Drawing.Point(10, 309);
            this.comboBoxAsignatura.Name = "comboBoxAsignatura";
            this.comboBoxAsignatura.Size = new System.Drawing.Size(200, 22);
            this.comboBoxAsignatura.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxAsignatura.TabIndex = 36;
            this.superValidator.SetValidator1(this.comboBoxAsignatura, this.customValidator_Asignatura_Exists);
            this.comboBoxAsignatura.SelectedIndexChanged += new System.EventHandler(this.comboBoxAsignatura_SelectedIndexChanged);
            this.comboBoxAsignatura.Leave += new System.EventHandler(this.comboBoxAsignatura_Leave);
            // 
            // comboBoxGrupo
            // 
            this.comboBoxGrupo.DisplayMember = "Text";
            this.comboBoxGrupo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGrupo.FormattingEnabled = true;
            this.comboBoxGrupo.ItemHeight = 16;
            this.comboBoxGrupo.Location = new System.Drawing.Point(10, 364);
            this.comboBoxGrupo.Name = "comboBoxGrupo";
            this.comboBoxGrupo.Size = new System.Drawing.Size(75, 22);
            this.comboBoxGrupo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxGrupo.TabIndex = 38;
            this.superValidator.SetValidator1(this.comboBoxGrupo, this.requiredFieldGrupo);
            this.comboBoxGrupo.SelectedIndexChanged += new System.EventHandler(this.comboBoxGrupo_SelectedIndexChanged);
            // 
            // labelGrupo
            // 
            // 
            // 
            // 
            this.labelGrupo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelGrupo.Location = new System.Drawing.Point(10, 335);
            this.labelGrupo.Name = "labelGrupo";
            this.labelGrupo.Size = new System.Drawing.Size(75, 23);
            this.labelGrupo.TabIndex = 37;
            this.labelGrupo.Text = "Grupo:";
            // 
            // labelDuracion
            // 
            // 
            // 
            // 
            this.labelDuracion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDuracion.Location = new System.Drawing.Point(10, 166);
            this.labelDuracion.Name = "labelDuracion";
            this.labelDuracion.Size = new System.Drawing.Size(93, 23);
            this.labelDuracion.TabIndex = 39;
            this.labelDuracion.Text = "Duracion:";
            // 
            // textBoxDuracion
            // 
            // 
            // 
            // 
            this.textBoxDuracion.Border.Class = "TextBoxBorder";
            this.textBoxDuracion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDuracion.Location = new System.Drawing.Point(10, 195);
            this.textBoxDuracion.Name = "textBoxDuracion";
            this.textBoxDuracion.ReadOnly = true;
            this.textBoxDuracion.Size = new System.Drawing.Size(200, 22);
            this.textBoxDuracion.TabIndex = 40;
            this.textBoxDuracion.Text = "Invalido";
            // 
            // labelTitulo
            // 
            // 
            // 
            // 
            this.labelTitulo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelTitulo.Location = new System.Drawing.Point(10, 3);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(200, 47);
            this.labelTitulo.TabIndex = 41;
            this.labelTitulo.Text = "Asignación de Clase";
            // 
            // labelLugar
            // 
            // 
            // 
            // 
            this.labelLugar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelLugar.Location = new System.Drawing.Point(10, 223);
            this.labelLugar.Name = "labelLugar";
            this.labelLugar.Size = new System.Drawing.Size(75, 23);
            this.labelLugar.TabIndex = 42;
            this.labelLugar.Text = "Lugar:";
            // 
            // comboBoxLugar
            // 
            this.comboBoxLugar.DisplayMember = "Text";
            this.comboBoxLugar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxLugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLugar.FormattingEnabled = true;
            this.comboBoxLugar.ItemHeight = 16;
            this.comboBoxLugar.Location = new System.Drawing.Point(10, 252);
            this.comboBoxLugar.Name = "comboBoxLugar";
            this.comboBoxLugar.Size = new System.Drawing.Size(200, 22);
            this.comboBoxLugar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxLugar.TabIndex = 43;
            // 
            // superValidator
            // 
            this.superValidator.ContainerControl = this;
            this.superValidator.ErrorProvider = errorProvider;
            this.superValidator.Highlighter = highlighter;
            this.superValidator.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // customValidator_Asignatura_Exists
            // 
            this.customValidator_Asignatura_Exists.ErrorMessage = "Asignatura Invalida.";
            this.customValidator_Asignatura_Exists.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.customValidator_Asignatura_Exists.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.customValidator_Asignatura_Exists_ValidateValue);
            // 
            // requiredFieldGrupo
            // 
            this.requiredFieldGrupo.ErrorMessage = "Es requerido seleccionar un grupo";
            this.requiredFieldGrupo.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.requiredFieldGrupo.ValuePropertyName = "SelectedItem";
            // 
            // textBoxDocente
            // 
            // 
            // 
            // 
            this.textBoxDocente.Border.Class = "TextBoxBorder";
            this.textBoxDocente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDocente.Location = new System.Drawing.Point(10, 421);
            this.textBoxDocente.Name = "textBoxDocente";
            this.textBoxDocente.ReadOnly = true;
            this.textBoxDocente.Size = new System.Drawing.Size(200, 22);
            this.textBoxDocente.TabIndex = 47;
            // 
            // labelDocente
            // 
            // 
            // 
            // 
            this.labelDocente.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDocente.Location = new System.Drawing.Point(10, 392);
            this.labelDocente.Name = "labelDocente";
            this.labelDocente.Size = new System.Drawing.Size(75, 23);
            this.labelDocente.TabIndex = 46;
            this.labelDocente.Text = "Docente:";
            // 
            // AsignacionClaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.textBoxDocente);
            this.Controls.Add(this.labelDocente);
            this.Controls.Add(this.comboBoxLugar);
            this.Controls.Add(this.labelLugar);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.textBoxDuracion);
            this.Controls.Add(this.labelDuracion);
            this.Controls.Add(this.comboBoxGrupo);
            this.Controls.Add(this.labelGrupo);
            this.Controls.Add(this.comboBoxAsignatura);
            this.Controls.Add(this.labelAsignatura);
            this.Controls.Add(this.dateTimeInputFin);
            this.Controls.Add(this.labelFin);
            this.Controls.Add(this.dateTimeInputInicio);
            this.Controls.Add(this.labelInicio);
            this.Name = "AsignacionClaseControl";
            this.Size = new System.Drawing.Size(219, 466);
            ((System.ComponentModel.ISupportInitialize)(errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputFin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelFin;
        private DevComponents.DotNetBar.LabelX labelInicio;
        private DevComponents.DotNetBar.LabelX labelAsignatura;
        private DevComponents.DotNetBar.LabelX labelGrupo;
        private DevComponents.DotNetBar.LabelX labelDuracion;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxDuracion;
        private DevComponents.DotNetBar.LabelX labelTitulo;
        private DevComponents.DotNetBar.LabelX labelLugar;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator;
        public DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxLugar;
        public DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInputFin;
        public DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInputInicio;
        public DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxAsignatura;
        public DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxGrupo;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldGrupo;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxDocente;
        private DevComponents.DotNetBar.LabelX labelDocente;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator_Asignatura_Exists;
    }
}
