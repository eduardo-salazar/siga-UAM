namespace Control_Aulas_UAM.Catalogos
{
    partial class NotificacionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificacionForm));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.dtDesde = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtHasta = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.notificacionesView = new DevComponents.DotNetBar.Schedule.CalendarView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.colorCombControl1 = new DevComponents.DotNetBar.ColorPickers.ColorCombControl();
            this.NotificacionPanel = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnNotificar = new DevComponents.DotNetBar.ButtonX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.dateTimeFecha = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.NotObservacion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.NotDescripcion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.cbAlertaEstado = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbFiltrar = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnLimpiar = new DevComponents.DotNetBar.ButtonX();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta)).BeginInit();
            this.NotificacionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeFecha)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(32, 2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(103, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Notificaciones:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(268, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(43, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "desde";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(433, 2);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(39, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "hasta";
            // 
            // dtDesde
            // 
            // 
            // 
            // 
            this.dtDesde.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtDesde.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDesde.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtDesde.ButtonDropDown.Visible = true;
            this.dtDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDesde.IsInputReadOnly = true;
            this.dtDesde.IsPopupCalendarOpen = false;
            this.dtDesde.Location = new System.Drawing.Point(317, 4);
            // 
            // 
            // 
            this.dtDesde.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtDesde.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDesde.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtDesde.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtDesde.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtDesde.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtDesde.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtDesde.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtDesde.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtDesde.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtDesde.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDesde.MonthCalendar.DisplayMonth = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
            this.dtDesde.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtDesde.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtDesde.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtDesde.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtDesde.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtDesde.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDesde.MonthCalendar.TodayButtonVisible = true;
            this.dtDesde.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(110, 24);
            this.dtDesde.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtDesde.TabIndex = 4;
            // 
            // dtHasta
            // 
            // 
            // 
            // 
            this.dtHasta.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtHasta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtHasta.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtHasta.ButtonDropDown.Visible = true;
            this.dtHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHasta.IsInputReadOnly = true;
            this.dtHasta.IsPopupCalendarOpen = false;
            this.dtHasta.Location = new System.Drawing.Point(478, 4);
            // 
            // 
            // 
            this.dtHasta.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtHasta.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtHasta.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtHasta.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtHasta.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtHasta.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtHasta.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtHasta.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtHasta.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtHasta.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtHasta.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtHasta.MonthCalendar.DisplayMonth = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
            this.dtHasta.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtHasta.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtHasta.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtHasta.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtHasta.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtHasta.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtHasta.MonthCalendar.TodayButtonVisible = true;
            this.dtHasta.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(115, 24);
            this.dtHasta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtHasta.TabIndex = 5;
            // 
            // notificacionesView
            // 
            this.notificacionesView.AllowTabReorder = false;
            this.notificacionesView.AppointmentBorderWidth = 0;
            this.notificacionesView.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.notificacionesView.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.notificacionesView.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.notificacionesView.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Dash;
            this.notificacionesView.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Dash;
            this.notificacionesView.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Dash;
            this.notificacionesView.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Dash;
            this.notificacionesView.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.notificacionesView.BackgroundStyle.WordWrap = true;
            this.notificacionesView.ContainerControlProcessDialogKey = true;
            this.notificacionesView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notificacionesView.EnableDragDrop = false;
            this.notificacionesView.Images = this.imageList1;
            this.notificacionesView.Is24HourFormat = true;
            this.notificacionesView.IsMonthMoreItemsIndicatorVisible = false;
            this.notificacionesView.IsMonthSideBarVisible = false;
            this.notificacionesView.IsTimeRulerVisible = false;
            this.notificacionesView.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.notificacionesView.Location = new System.Drawing.Point(0, 0);
            this.notificacionesView.MultiUserTabHeight = 19;
            this.notificacionesView.Name = "notificacionesView";
            this.notificacionesView.Padding = new System.Windows.Forms.Padding(0, 0, 12, 12);
            this.notificacionesView.ShowTabs = false;
            this.notificacionesView.Size = new System.Drawing.Size(702, 439);
            this.notificacionesView.TabIndex = 6;
            this.notificacionesView.Text = "calendarView1";
            this.notificacionesView.TimeIndicator.BorderColor = System.Drawing.Color.White;
            this.notificacionesView.TimeIndicator.Tag = null;
            this.notificacionesView.TimeIndicator.Thickness = 9;
            this.notificacionesView.TimeSlotDuration = 5;
            this.notificacionesView.YearViewAllowDateSelection = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "down.png");
            this.imageList1.Images.SetKeyName(1, "up.png");
            // 
            // colorCombControl1
            // 
            this.colorCombControl1.Location = new System.Drawing.Point(55, 36);
            this.colorCombControl1.Name = "colorCombControl1";
            this.colorCombControl1.Size = new System.Drawing.Size(93, 23);
            this.colorCombControl1.TabIndex = 7;
            this.colorCombControl1.Text = "colorCombControl1";
            // 
            // NotificacionPanel
            // 
            this.NotificacionPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.NotificacionPanel.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.LeftToRight;
            this.NotificacionPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.NotificacionPanel.Controls.Add(this.btnNotificar);
            this.NotificacionPanel.Controls.Add(this.labelX5);
            this.NotificacionPanel.Controls.Add(this.dateTimeFecha);
            this.NotificacionPanel.Controls.Add(this.labelX4);
            this.NotificacionPanel.Controls.Add(this.labelX8);
            this.NotificacionPanel.Controls.Add(this.labelX9);
            this.NotificacionPanel.Controls.Add(this.NotObservacion);
            this.NotificacionPanel.Controls.Add(this.NotDescripcion);
            this.NotificacionPanel.Controls.Add(this.labelX10);
            this.NotificacionPanel.Controls.Add(this.cbAlertaEstado);
            this.NotificacionPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.NotificacionPanel.ExpandButtonVisible = false;
            this.NotificacionPanel.Location = new System.Drawing.Point(702, 0);
            this.NotificacionPanel.Name = "NotificacionPanel";
            this.NotificacionPanel.Size = new System.Drawing.Size(226, 487);
            this.NotificacionPanel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.NotificacionPanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.NotificacionPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.NotificacionPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.NotificacionPanel.Style.GradientAngle = 90;
            this.NotificacionPanel.TabIndex = 18;
            this.NotificacionPanel.TitleHeight = 0;
            this.NotificacionPanel.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.NotificacionPanel.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.NotificacionPanel.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.NotificacionPanel.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.NotificacionPanel.TitleStyle.GradientAngle = 90;
            this.NotificacionPanel.TitleText = "Title Bar";
            this.NotificacionPanel.Visible = false;
            // 
            // btnNotificar
            // 
            this.btnNotificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNotificar.Image = ((System.Drawing.Image)(resources.GetObject("btnNotificar.Image")));
            this.btnNotificar.Location = new System.Drawing.Point(155, 3);
            this.btnNotificar.Name = "btnNotificar";
            this.btnNotificar.Size = new System.Drawing.Size(60, 45);
            this.btnNotificar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNotificar.TabIndex = 21;
            this.btnNotificar.Click += new System.EventHandler(this.btnNotificar_Click);
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX5.Location = new System.Drawing.Point(6, 361);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(50, 23);
            this.labelX5.TabIndex = 18;
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
            this.dateTimeFecha.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dateTimeFecha.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.Both;
            this.dateTimeFecha.Enabled = false;
            this.dateTimeFecha.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dateTimeFecha.IsPopupCalendarOpen = false;
            this.dateTimeFecha.Location = new System.Drawing.Point(6, 67);
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
            this.dateTimeFecha.TabIndex = 17;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX4.Location = new System.Drawing.Point(6, 48);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(43, 23);
            this.labelX4.TabIndex = 16;
            this.labelX4.Text = "Fecha:";
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX8.Location = new System.Drawing.Point(6, 232);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(85, 23);
            this.labelX8.TabIndex = 15;
            this.labelX8.Text = "Observación:";
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX9.Location = new System.Drawing.Point(6, 104);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(76, 23);
            this.labelX9.TabIndex = 14;
            this.labelX9.Text = "Descripción:";
            // 
            // NotObservacion
            // 
            this.NotObservacion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // 
            // 
            this.NotObservacion.Border.Class = "TextBoxBorder";
            this.NotObservacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NotObservacion.Enabled = false;
            this.NotObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NotObservacion.ForeColor = System.Drawing.Color.Black;
            this.NotObservacion.Location = new System.Drawing.Point(6, 261);
            this.NotObservacion.MaxLength = 100;
            this.NotObservacion.Multiline = true;
            this.NotObservacion.Name = "NotObservacion";
            this.NotObservacion.Size = new System.Drawing.Size(191, 84);
            this.NotObservacion.TabIndex = 13;
            // 
            // NotDescripcion
            // 
            this.NotDescripcion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // 
            // 
            this.NotDescripcion.Border.Class = "TextBoxBorder";
            this.NotDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NotDescripcion.Enabled = false;
            this.NotDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NotDescripcion.ForeColor = System.Drawing.Color.Black;
            this.NotDescripcion.Location = new System.Drawing.Point(6, 133);
            this.NotDescripcion.MaxLength = 100;
            this.NotDescripcion.Multiline = true;
            this.NotDescripcion.Name = "NotDescripcion";
            this.NotDescripcion.Size = new System.Drawing.Size(191, 84);
            this.NotDescripcion.TabIndex = 12;
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX10.Location = new System.Drawing.Point(60, 3);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(76, 23);
            this.labelX10.TabIndex = 12;
            this.labelX10.Text = "Notificación:";
            this.labelX10.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cbAlertaEstado
            // 
            this.cbAlertaEstado.DisplayMember = "Text";
            this.cbAlertaEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAlertaEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlertaEstado.Enabled = false;
            this.cbAlertaEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbAlertaEstado.FormattingEnabled = true;
            this.cbAlertaEstado.ItemHeight = 17;
            this.cbAlertaEstado.Location = new System.Drawing.Point(66, 361);
            this.cbAlertaEstado.Name = "cbAlertaEstado";
            this.cbAlertaEstado.Size = new System.Drawing.Size(131, 23);
            this.cbAlertaEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbAlertaEstado.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbFiltrar);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.dtDesde);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.labelX3);
            this.panel1.Controls.Add(this.dtHasta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 32);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbFiltrar
            // 
            this.cbFiltrar.DisplayMember = "Text";
            this.cbFiltrar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltrar.FormattingEnabled = true;
            this.cbFiltrar.ItemHeight = 14;
            this.cbFiltrar.Location = new System.Drawing.Point(141, 5);
            this.cbFiltrar.Name = "cbFiltrar";
            this.cbFiltrar.Size = new System.Drawing.Size(121, 20);
            this.cbFiltrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbFiltrar.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLimpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLimpiar.Location = new System.Drawing.Point(599, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(702, 48);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.notificacionesView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(702, 439);
            this.panel2.TabIndex = 19;
            // 
            // NotificacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.NotificacionPanel);
            this.Controls.Add(this.colorCombControl1);
            this.Name = "NotificacionForm";
            this.Size = new System.Drawing.Size(928, 487);
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta)).EndInit();
            this.NotificacionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeFecha)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtDesde;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtHasta;
        private DevComponents.DotNetBar.ColorPickers.ColorCombControl colorCombControl1;
        private DevComponents.DotNetBar.Schedule.CalendarView notificacionesView;
        private DevComponents.DotNetBar.ExpandablePanel NotificacionPanel;
        private DevComponents.DotNetBar.ButtonX btnNotificar;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeFecha;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX NotObservacion;
        private DevComponents.DotNetBar.Controls.TextBoxX NotDescripcion;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbAlertaEstado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbFiltrar;
        private DevComponents.DotNetBar.ButtonX btnLimpiar;
        private System.Windows.Forms.ImageList imageList1;

    }
}
