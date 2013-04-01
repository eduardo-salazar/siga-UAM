namespace Control_Aulas_UAM
{
    partial class BuscarControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.checkBoxCapacidad = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.integerInputCapacidad = new DevComponents.Editors.IntegerInput();
            this.dateTimeInputFin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelFin = new DevComponents.DotNetBar.LabelX();
            this.dateTimeInputInicio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelInicio = new DevComponents.DotNetBar.LabelX();
            this.groupBoxEquipos = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new DevComponents.DotNetBar.ButtonX();
            this.comboBoxEquipo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.dataGridViewEquipo = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ColumnEquipo = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.ColumnCantidad = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxTipoAula = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelTipoAula = new DevComponents.DotNetBar.LabelX();
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            this.dataGridViewResultado = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ColumnCheck = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.ColumnEdificio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCapacidad = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.ColumnAulaTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.integerInputCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputInicio)).BeginInit();
            this.groupBoxEquipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxCapacidad
            // 
            // 
            // 
            // 
            this.checkBoxCapacidad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxCapacidad.Location = new System.Drawing.Point(6, 104);
            this.checkBoxCapacidad.Name = "checkBoxCapacidad";
            this.checkBoxCapacidad.Size = new System.Drawing.Size(85, 23);
            this.checkBoxCapacidad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxCapacidad.TabIndex = 4;
            this.checkBoxCapacidad.Text = "Capacidad";
            this.checkBoxCapacidad.CheckedChanged += new System.EventHandler(this.checkBoxCapacidad_CheckedChanged);
            // 
            // integerInputCapacidad
            // 
            // 
            // 
            // 
            this.integerInputCapacidad.BackgroundStyle.Class = "DateTimeInputBackground";
            this.integerInputCapacidad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.integerInputCapacidad.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.integerInputCapacidad.Enabled = false;
            this.integerInputCapacidad.Location = new System.Drawing.Point(97, 107);
            this.integerInputCapacidad.MaxValue = 200;
            this.integerInputCapacidad.MinValue = 1;
            this.integerInputCapacidad.Name = "integerInputCapacidad";
            this.integerInputCapacidad.ShowUpDown = true;
            this.integerInputCapacidad.Size = new System.Drawing.Size(49, 20);
            this.integerInputCapacidad.TabIndex = 5;
            this.integerInputCapacidad.Value = 1;
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
            this.dateTimeInputFin.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dateTimeInputFin.IsPopupCalendarOpen = false;
            this.dateTimeInputFin.Location = new System.Drawing.Point(70, 51);
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
            this.dateTimeInputFin.Size = new System.Drawing.Size(172, 20);
            this.dateTimeInputFin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInputFin.TabIndex = 48;
            this.dateTimeInputFin.Value = new System.DateTime(2012, 10, 29, 4, 53, 39, 0);
            // 
            // labelFin
            // 
            // 
            // 
            // 
            this.labelFin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelFin.Location = new System.Drawing.Point(6, 48);
            this.labelFin.Name = "labelFin";
            this.labelFin.Size = new System.Drawing.Size(58, 23);
            this.labelFin.TabIndex = 47;
            this.labelFin.Text = "Fin:";
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
            this.dateTimeInputInicio.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dateTimeInputInicio.IsPopupCalendarOpen = false;
            this.dateTimeInputInicio.Location = new System.Drawing.Point(70, 22);
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
            this.dateTimeInputInicio.Size = new System.Drawing.Size(172, 20);
            this.dateTimeInputInicio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInputInicio.TabIndex = 46;
            this.dateTimeInputInicio.Value = new System.DateTime(2012, 10, 29, 4, 53, 31, 0);
            // 
            // labelInicio
            // 
            // 
            // 
            // 
            this.labelInicio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelInicio.Location = new System.Drawing.Point(6, 19);
            this.labelInicio.Name = "labelInicio";
            this.labelInicio.Size = new System.Drawing.Size(58, 23);
            this.labelInicio.TabIndex = 45;
            this.labelInicio.Text = "Inicio:";
            // 
            // groupBoxEquipos
            // 
            this.groupBoxEquipos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEquipos.Controls.Add(this.buttonAdd);
            this.groupBoxEquipos.Controls.Add(this.comboBoxEquipo);
            this.groupBoxEquipos.Controls.Add(this.dataGridViewEquipo);
            this.groupBoxEquipos.Location = new System.Drawing.Point(6, 133);
            this.groupBoxEquipos.Name = "groupBoxEquipos";
            this.groupBoxEquipos.Size = new System.Drawing.Size(247, 215);
            this.groupBoxEquipos.TabIndex = 49;
            this.groupBoxEquipos.TabStop = false;
            this.groupBoxEquipos.Text = "Equipos";
            // 
            // buttonAdd
            // 
            this.buttonAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonAdd.Location = new System.Drawing.Point(165, 19);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 20);
            this.buttonAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Añadir";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxEquipo
            // 
            this.comboBoxEquipo.DisplayMember = "Text";
            this.comboBoxEquipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEquipo.FormattingEnabled = true;
            this.comboBoxEquipo.ItemHeight = 14;
            this.comboBoxEquipo.Location = new System.Drawing.Point(6, 19);
            this.comboBoxEquipo.Name = "comboBoxEquipo";
            this.comboBoxEquipo.Size = new System.Drawing.Size(153, 20);
            this.comboBoxEquipo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEquipo.TabIndex = 7;
            // 
            // dataGridViewEquipo
            // 
            this.dataGridViewEquipo.AllowUserToAddRows = false;
            this.dataGridViewEquipo.AllowUserToOrderColumns = true;
            this.dataGridViewEquipo.AllowUserToResizeColumns = false;
            this.dataGridViewEquipo.AllowUserToResizeRows = false;
            this.dataGridViewEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEquipo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEquipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnEquipo,
            this.ColumnCantidad});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEquipo.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEquipo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewEquipo.Location = new System.Drawing.Point(6, 45);
            this.dataGridViewEquipo.Name = "dataGridViewEquipo";
            this.dataGridViewEquipo.RowHeadersWidth = 10;
            this.dataGridViewEquipo.Size = new System.Drawing.Size(234, 158);
            this.dataGridViewEquipo.TabIndex = 6;
            // 
            // ColumnEquipo
            // 
            this.ColumnEquipo.DisplayMember = "Text";
            this.ColumnEquipo.DropDownHeight = 106;
            this.ColumnEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColumnEquipo.DropDownWidth = 121;
            this.ColumnEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnEquipo.HeaderText = "Equipo";
            this.ColumnEquipo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ColumnEquipo.IntegralHeight = false;
            this.ColumnEquipo.ItemHeight = 15;
            this.ColumnEquipo.Name = "ColumnEquipo";
            this.ColumnEquipo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // ColumnCantidad
            // 
            // 
            // 
            // 
            this.ColumnCantidad.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.ColumnCantidad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ColumnCantidad.HeaderText = "Cantidad";
            this.ColumnCantidad.MaxValue = 100;
            this.ColumnCantidad.MinValue = 1;
            this.ColumnCantidad.Name = "ColumnCantidad";
            this.ColumnCantidad.ShowUpDown = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.comboBoxTipoAula);
            this.groupBox1.Controls.Add(this.labelTipoAula);
            this.groupBox1.Controls.Add(this.labelInicio);
            this.groupBox1.Controls.Add(this.groupBoxEquipos);
            this.groupBox1.Controls.Add(this.dateTimeInputInicio);
            this.groupBox1.Controls.Add(this.integerInputCapacidad);
            this.groupBox1.Controls.Add(this.dateTimeInputFin);
            this.groupBox1.Controls.Add(this.checkBoxCapacidad);
            this.groupBox1.Controls.Add(this.labelFin);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 354);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterios";
            // 
            // comboBoxTipoAula
            // 
            this.comboBoxTipoAula.DisplayMember = "Text";
            this.comboBoxTipoAula.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxTipoAula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoAula.FormattingEnabled = true;
            this.comboBoxTipoAula.ItemHeight = 14;
            this.comboBoxTipoAula.Location = new System.Drawing.Point(87, 78);
            this.comboBoxTipoAula.Name = "comboBoxTipoAula";
            this.comboBoxTipoAula.Size = new System.Drawing.Size(155, 20);
            this.comboBoxTipoAula.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxTipoAula.TabIndex = 51;
            // 
            // labelTipoAula
            // 
            // 
            // 
            // 
            this.labelTipoAula.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelTipoAula.Location = new System.Drawing.Point(6, 77);
            this.labelTipoAula.Name = "labelTipoAula";
            this.labelTipoAula.Size = new System.Drawing.Size(75, 23);
            this.labelTipoAula.TabIndex = 50;
            this.labelTipoAula.Text = "Tipo de Aula:";
            // 
            // groupBoxResultado
            // 
            this.groupBoxResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxResultado.Controls.Add(this.dataGridViewResultado);
            this.groupBoxResultado.Location = new System.Drawing.Point(269, 3);
            this.groupBoxResultado.Name = "groupBoxResultado";
            this.groupBoxResultado.Size = new System.Drawing.Size(464, 354);
            this.groupBoxResultado.TabIndex = 51;
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
            this.ColumnEdificio,
            this.ColumnAula,
            this.ColumnCapacidad,
            this.ColumnAulaTipo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewResultado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResultado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewResultado.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResultado.Name = "dataGridViewResultado";
            this.dataGridViewResultado.RowHeadersWidth = 10;
            this.dataGridViewResultado.Size = new System.Drawing.Size(458, 335);
            this.dataGridViewResultado.TabIndex = 52;
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
            // ColumnEdificio
            // 
            this.ColumnEdificio.FillWeight = 107.7622F;
            this.ColumnEdificio.HeaderText = "Edificio";
            this.ColumnEdificio.Name = "ColumnEdificio";
            this.ColumnEdificio.ReadOnly = true;
            // 
            // ColumnAula
            // 
            this.ColumnAula.FillWeight = 107.7622F;
            this.ColumnAula.HeaderText = "Aula";
            this.ColumnAula.Name = "ColumnAula";
            this.ColumnAula.ReadOnly = true;
            // 
            // ColumnCapacidad
            // 
            // 
            // 
            // 
            this.ColumnCapacidad.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.ColumnCapacidad.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.ColumnCapacidad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ColumnCapacidad.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.ColumnCapacidad.FillWeight = 107.7622F;
            this.ColumnCapacidad.HeaderText = "Capacidad";
            this.ColumnCapacidad.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.ColumnCapacidad.Name = "ColumnCapacidad";
            this.ColumnCapacidad.ReadOnly = true;
            // 
            // ColumnAulaTipo
            // 
            this.ColumnAulaTipo.FillWeight = 107.7622F;
            this.ColumnAulaTipo.HeaderText = "Tipo";
            this.ColumnAulaTipo.Name = "ColumnAulaTipo";
            this.ColumnAulaTipo.ReadOnly = true;
            // 
            // BuscarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxResultado);
            this.Controls.Add(this.groupBox1);
            this.Name = "BuscarControl";
            this.Size = new System.Drawing.Size(736, 360);
            ((System.ComponentModel.ISupportInitialize)(this.integerInputCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputInicio)).EndInit();
            this.groupBoxEquipos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxCapacidad;
        private DevComponents.Editors.IntegerInput integerInputCapacidad;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInputFin;
        private DevComponents.DotNetBar.LabelX labelFin;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInputInicio;
        private DevComponents.DotNetBar.LabelX labelInicio;
        private System.Windows.Forms.GroupBox groupBoxEquipos;
        private DevComponents.DotNetBar.ButtonX buttonAdd;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEquipo;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewEquipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxTipoAula;
        private DevComponents.DotNetBar.LabelX labelTipoAula;
        private System.Windows.Forms.GroupBox groupBoxResultado;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewResultado;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn ColumnEquipo;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn ColumnCantidad;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn ColumnCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEdificio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAula;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn ColumnCapacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAulaTipo;

    }
}
