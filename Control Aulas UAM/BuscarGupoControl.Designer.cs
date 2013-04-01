namespace Control_Aulas_UAM
{
    partial class BuscarGupoControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            this.dataGridViewResultado = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBoxCriterios = new System.Windows.Forms.GroupBox();
            this.checkBoxFin = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxInicio = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.comboBoxGrupo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.checkBoxGrupo = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxAsignatura = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.comboBoxAsignatura = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.checkBoxDocente = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.dateTimeInputInicio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dateTimeInputFin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.comboBoxDocente = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ColumnCheck = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.ColumnAula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInicio = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.ColumnFin = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.groupBoxResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultado)).BeginInit();
            this.groupBoxCriterios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputFin)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxResultado
            // 
            this.groupBoxResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxResultado.Controls.Add(this.dataGridViewResultado);
            this.groupBoxResultado.Location = new System.Drawing.Point(367, 3);
            this.groupBoxResultado.Name = "groupBoxResultado";
            this.groupBoxResultado.Size = new System.Drawing.Size(266, 290);
            this.groupBoxResultado.TabIndex = 53;
            this.groupBoxResultado.TabStop = false;
            this.groupBoxResultado.Text = "Resultado";
            // 
            // dataGridViewResultado
            // 
            this.dataGridViewResultado.AllowUserToAddRows = false;
            this.dataGridViewResultado.AllowUserToDeleteRows = false;
            this.dataGridViewResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCheck,
            this.ColumnAula,
            this.ColumnDocente,
            this.ColumnAsignatura,
            this.ColumnGrupo,
            this.ColumnInicio,
            this.ColumnFin});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewResultado.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResultado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewResultado.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResultado.Name = "dataGridViewResultado";
            this.dataGridViewResultado.RowHeadersWidth = 10;
            this.dataGridViewResultado.Size = new System.Drawing.Size(260, 271);
            this.dataGridViewResultado.TabIndex = 52;
            // 
            // groupBoxCriterios
            // 
            this.groupBoxCriterios.Controls.Add(this.checkBoxFin);
            this.groupBoxCriterios.Controls.Add(this.checkBoxInicio);
            this.groupBoxCriterios.Controls.Add(this.comboBoxGrupo);
            this.groupBoxCriterios.Controls.Add(this.checkBoxGrupo);
            this.groupBoxCriterios.Controls.Add(this.checkBoxAsignatura);
            this.groupBoxCriterios.Controls.Add(this.comboBoxAsignatura);
            this.groupBoxCriterios.Controls.Add(this.checkBoxDocente);
            this.groupBoxCriterios.Controls.Add(this.dateTimeInputInicio);
            this.groupBoxCriterios.Controls.Add(this.dateTimeInputFin);
            this.groupBoxCriterios.Controls.Add(this.comboBoxDocente);
            this.groupBoxCriterios.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCriterios.Name = "groupBoxCriterios";
            this.groupBoxCriterios.Size = new System.Drawing.Size(361, 290);
            this.groupBoxCriterios.TabIndex = 63;
            this.groupBoxCriterios.TabStop = false;
            this.groupBoxCriterios.Text = "Criterios";
            // 
            // checkBoxFin
            // 
            // 
            // 
            // 
            this.checkBoxFin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxFin.Checked = true;
            this.checkBoxFin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFin.CheckValue = "Y";
            this.checkBoxFin.Location = new System.Drawing.Point(6, 46);
            this.checkBoxFin.Name = "checkBoxFin";
            this.checkBoxFin.Size = new System.Drawing.Size(84, 23);
            this.checkBoxFin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxFin.TabIndex = 73;
            this.checkBoxFin.Text = "Fin";
            this.checkBoxFin.CheckedChanged += new System.EventHandler(this.checkBoxFin_CheckedChanged);
            // 
            // checkBoxInicio
            // 
            // 
            // 
            // 
            this.checkBoxInicio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxInicio.Checked = true;
            this.checkBoxInicio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxInicio.CheckValue = "Y";
            this.checkBoxInicio.Location = new System.Drawing.Point(6, 19);
            this.checkBoxInicio.Name = "checkBoxInicio";
            this.checkBoxInicio.Size = new System.Drawing.Size(84, 23);
            this.checkBoxInicio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxInicio.TabIndex = 72;
            this.checkBoxInicio.Text = "Inicio";
            this.checkBoxInicio.CheckedChanged += new System.EventHandler(this.checkBoxInicio_CheckedChanged);
            // 
            // comboBoxGrupo
            // 
            this.comboBoxGrupo.DisplayMember = "Text";
            this.comboBoxGrupo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrupo.Enabled = false;
            this.comboBoxGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGrupo.FormattingEnabled = true;
            this.comboBoxGrupo.ItemHeight = 16;
            this.comboBoxGrupo.Location = new System.Drawing.Point(96, 132);
            this.comboBoxGrupo.Name = "comboBoxGrupo";
            this.comboBoxGrupo.Size = new System.Drawing.Size(66, 22);
            this.comboBoxGrupo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxGrupo.TabIndex = 71;
            // 
            // checkBoxGrupo
            // 
            // 
            // 
            // 
            this.checkBoxGrupo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxGrupo.Enabled = false;
            this.checkBoxGrupo.Location = new System.Drawing.Point(6, 133);
            this.checkBoxGrupo.Name = "checkBoxGrupo";
            this.checkBoxGrupo.Size = new System.Drawing.Size(84, 23);
            this.checkBoxGrupo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxGrupo.TabIndex = 70;
            this.checkBoxGrupo.Text = "Grupo";
            this.checkBoxGrupo.CheckedChanged += new System.EventHandler(this.checkBoxGrupo_CheckedChanged);
            // 
            // checkBoxAsignatura
            // 
            // 
            // 
            // 
            this.checkBoxAsignatura.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxAsignatura.Location = new System.Drawing.Point(6, 104);
            this.checkBoxAsignatura.Name = "checkBoxAsignatura";
            this.checkBoxAsignatura.Size = new System.Drawing.Size(84, 23);
            this.checkBoxAsignatura.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxAsignatura.TabIndex = 69;
            this.checkBoxAsignatura.Text = "Asignatura";
            this.checkBoxAsignatura.CheckedChanged += new System.EventHandler(this.checkBoxAsignatura_CheckedChanged);
            // 
            // comboBoxAsignatura
            // 
            this.comboBoxAsignatura.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxAsignatura.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxAsignatura.DisplayMember = "Text";
            this.comboBoxAsignatura.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxAsignatura.DropDownWidth = 350;
            this.comboBoxAsignatura.Enabled = false;
            this.comboBoxAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAsignatura.FormattingEnabled = true;
            this.comboBoxAsignatura.ItemHeight = 16;
            this.comboBoxAsignatura.Location = new System.Drawing.Point(96, 104);
            this.comboBoxAsignatura.Name = "comboBoxAsignatura";
            this.comboBoxAsignatura.Size = new System.Drawing.Size(259, 22);
            this.comboBoxAsignatura.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxAsignatura.TabIndex = 68;
            this.comboBoxAsignatura.SelectedIndexChanged += new System.EventHandler(this.comboBoxAsignatura_SelectedIndexChanged);
            this.comboBoxAsignatura.Leave += new System.EventHandler(this.comboBoxAsignatura_Leave);
            // 
            // checkBoxDocente
            // 
            // 
            // 
            // 
            this.checkBoxDocente.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxDocente.Location = new System.Drawing.Point(6, 75);
            this.checkBoxDocente.Name = "checkBoxDocente";
            this.checkBoxDocente.Size = new System.Drawing.Size(84, 23);
            this.checkBoxDocente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxDocente.TabIndex = 67;
            this.checkBoxDocente.Text = "Docente";
            this.checkBoxDocente.CheckedChanged += new System.EventHandler(this.checkBoxDocente_CheckedChanged);
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
            this.dateTimeInputInicio.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.DateSelector;
            this.dateTimeInputInicio.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dateTimeInputInicio.IsPopupCalendarOpen = false;
            this.dateTimeInputInicio.Location = new System.Drawing.Point(96, 19);
            this.dateTimeInputInicio.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
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
            this.dateTimeInputInicio.Size = new System.Drawing.Size(259, 20);
            this.dateTimeInputInicio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInputInicio.TabIndex = 64;
            this.dateTimeInputInicio.Value = new System.DateTime(2012, 10, 29, 4, 53, 31, 0);
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
            this.dateTimeInputFin.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.DateSelector;
            this.dateTimeInputFin.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dateTimeInputFin.IsPopupCalendarOpen = false;
            this.dateTimeInputFin.Location = new System.Drawing.Point(96, 48);
            this.dateTimeInputFin.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
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
            this.dateTimeInputFin.Size = new System.Drawing.Size(259, 20);
            this.dateTimeInputFin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInputFin.TabIndex = 65;
            this.dateTimeInputFin.Value = new System.DateTime(2012, 10, 29, 4, 53, 39, 0);
            // 
            // comboBoxDocente
            // 
            this.comboBoxDocente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxDocente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxDocente.DisplayMember = "Text";
            this.comboBoxDocente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxDocente.DropDownWidth = 350;
            this.comboBoxDocente.Enabled = false;
            this.comboBoxDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDocente.FormattingEnabled = true;
            this.comboBoxDocente.ItemHeight = 16;
            this.comboBoxDocente.Location = new System.Drawing.Point(96, 75);
            this.comboBoxDocente.Name = "comboBoxDocente";
            this.comboBoxDocente.Size = new System.Drawing.Size(259, 22);
            this.comboBoxDocente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxDocente.TabIndex = 63;
            // 
            // ColumnCheck
            // 
            this.ColumnCheck.Checked = true;
            this.ColumnCheck.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.ColumnCheck.CheckValue = null;
            this.ColumnCheck.CheckValueIndeterminate = "False";
            this.ColumnCheck.ConsiderEmptyStringAsNull = false;
            this.ColumnCheck.HeaderText = "";
            this.ColumnCheck.Name = "ColumnCheck";
            // 
            // ColumnAula
            // 
            this.ColumnAula.FillWeight = 107.7622F;
            this.ColumnAula.HeaderText = "Aula";
            this.ColumnAula.Name = "ColumnAula";
            this.ColumnAula.ReadOnly = true;
            // 
            // ColumnDocente
            // 
            this.ColumnDocente.HeaderText = "Docente";
            this.ColumnDocente.Name = "ColumnDocente";
            this.ColumnDocente.ReadOnly = true;
            // 
            // ColumnAsignatura
            // 
            this.ColumnAsignatura.HeaderText = "Asignatura";
            this.ColumnAsignatura.Name = "ColumnAsignatura";
            this.ColumnAsignatura.ReadOnly = true;
            // 
            // ColumnGrupo
            // 
            this.ColumnGrupo.HeaderText = "Grupo";
            this.ColumnGrupo.Name = "ColumnGrupo";
            this.ColumnGrupo.ReadOnly = true;
            // 
            // ColumnInicio
            // 
            // 
            // 
            // 
            this.ColumnInicio.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.ColumnInicio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ColumnInicio.CustomFormat = "dd/MM/yyyy hh:mm tt";
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
            this.ColumnInicio.MonthCalendar.DisplayMonth = new System.DateTime(2013, 3, 1, 0, 0, 0, 0);
            this.ColumnInicio.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.ColumnInicio.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.ColumnInicio.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ColumnInicio.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.ColumnInicio.Name = "ColumnInicio";
            this.ColumnInicio.ReadOnly = true;
            // 
            // ColumnFin
            // 
            // 
            // 
            // 
            this.ColumnFin.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.ColumnFin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ColumnFin.CustomFormat = "dd/MM/yyyy hh:mm tt";
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
            this.ColumnFin.MonthCalendar.DisplayMonth = new System.DateTime(2013, 3, 1, 0, 0, 0, 0);
            this.ColumnFin.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.ColumnFin.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.ColumnFin.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ColumnFin.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.ColumnFin.Name = "ColumnFin";
            this.ColumnFin.ReadOnly = true;
            // 
            // BuscarGupoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxCriterios);
            this.Controls.Add(this.groupBoxResultado);
            this.Name = "BuscarGupoControl";
            this.Size = new System.Drawing.Size(636, 296);
            this.Load += new System.EventHandler(this.BuscarGupoControl_Load);
            this.groupBoxResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultado)).EndInit();
            this.groupBoxCriterios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputFin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxResultado;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewResultado;
        private System.Windows.Forms.GroupBox groupBoxCriterios;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxFin;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxInicio;
        public DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxGrupo;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxGrupo;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxAsignatura;
        public DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxAsignatura;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxDocente;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInputInicio;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInputFin;
        public DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxDocente;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn ColumnCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGrupo;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn ColumnInicio;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn ColumnFin;

    }
}
