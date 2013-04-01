namespace Control_Aulas_UAM
{
    partial class CalendarControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarControl));
            this.dateNavigator = new DevComponents.DotNetBar.Schedule.DateNavigator();
            this.calendarView = new DevComponents.DotNetBar.Schedule.CalendarView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.barView = new DevComponents.DotNetBar.Bar();
            this.btnDayView = new DevComponents.DotNetBar.ButtonItem();
            this.btnWeekView = new DevComponents.DotNetBar.ButtonItem();
            this.btnMonthView = new DevComponents.DotNetBar.ButtonItem();
            this.panelCalendar = new System.Windows.Forms.Panel();
            this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.InContentContextMenu = new DevComponents.DotNetBar.ButtonItem();
            this.btnAddAppointment = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemBuscar = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemNotificar = new DevComponents.DotNetBar.ButtonItem();
            this.InTabContextMenu = new DevComponents.DotNetBar.ButtonItem();
            this.InTabOcultar = new DevComponents.DotNetBar.ButtonItem();
            this.InTabAddNewTab = new DevComponents.DotNetBar.LabelItem();
            this.InTabReplaceTab = new DevComponents.DotNetBar.LabelItem();
            this.InAppointment = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemVerAppointment = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDeleteAppointment = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemBorrarSerie = new DevComponents.DotNetBar.ButtonItem();
            this.checkBoxItemReprogramada = new DevComponents.DotNetBar.CheckBoxItem();
            this.barStatus = new DevComponents.DotNetBar.Bar();
            this.buttonItemMultiUser = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemSingleUser = new DevComponents.DotNetBar.ButtonItem();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.superTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
            ((System.ComponentModel.ISupportInitialize)(this.barView)).BeginInit();
            this.panelCalendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barStatus)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateNavigator
            // 
            this.dateNavigator.CalendarView = this.calendarView;
            this.dateNavigator.CanvasColor = System.Drawing.SystemColors.Control;
            this.dateNavigator.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateNavigator.Location = new System.Drawing.Point(0, 0);
            this.dateNavigator.Name = "dateNavigator";
            this.dateNavigator.Size = new System.Drawing.Size(694, 30);
            this.dateNavigator.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dateNavigator.TabIndex = 5;
            this.dateNavigator.Text = "dateNavigator";
            // 
            // calendarView
            // 
            this.calendarView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.calendarView.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calendarView.ContainerControlProcessDialogKey = true;
            this.calendarView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarView.HighlightCurrentDay = true;
            this.calendarView.Images = this.imageList;
            this.calendarView.LabelTimeSlots = true;
            this.calendarView.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.calendarView.Location = new System.Drawing.Point(0, 30);
            this.calendarView.MinimumTimeSlotHeight = 30;
            this.calendarView.MultiUserTabHeight = 19;
            this.calendarView.Name = "calendarView";
            this.calendarView.ShowOnlyWorkDayHours = true;
            this.calendarView.Size = new System.Drawing.Size(694, 271);
            this.calendarView.TabIndex = 4;
            this.calendarView.Text = "calendarView";
            this.calendarView.TimeIndicator.BorderColor = System.Drawing.Color.Empty;
            this.calendarView.TimeIndicator.IndicatorArea = DevComponents.DotNetBar.Schedule.eTimeIndicatorArea.Content;
            this.calendarView.TimeIndicator.Tag = null;
            this.calendarView.TimeIndicator.Visibility = DevComponents.DotNetBar.Schedule.eTimeIndicatorVisibility.AllResources;
            this.calendarView.TimeSlotDuration = 30;
            this.calendarView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.calendarView_MouseUp);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "disabled");
            // 
            // barView
            // 
            this.barView.AntiAlias = true;
            this.barView.Dock = System.Windows.Forms.DockStyle.Top;
            this.barView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.barView.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDayView,
            this.btnWeekView,
            this.btnMonthView});
            this.barView.Location = new System.Drawing.Point(0, 0);
            this.barView.Name = "barView";
            this.barView.RoundCorners = false;
            this.barView.Size = new System.Drawing.Size(700, 63);
            this.barView.Stretch = true;
            this.barView.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.barView.TabIndex = 3;
            this.barView.TabStop = false;
            this.barView.Text = "ViewBar";
            // 
            // btnDayView
            // 
            this.btnDayView.Checked = true;
            this.btnDayView.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnDayView.FixedSize = new System.Drawing.Size(100, 60);
            this.btnDayView.Image = ((System.Drawing.Image)(resources.GetObject("btnDayView.Image")));
            this.btnDayView.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDayView.Name = "btnDayView";
            this.btnDayView.OptionGroup = "View";
            this.superTooltip1.SetSuperTooltip(this.btnDayView, new DevComponents.DotNetBar.SuperTooltipInfo("Vista por día", "", "", ((System.Drawing.Image)(resources.GetObject("btnDayView.SuperTooltip"))), null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.btnDayView.Text = "Día";
            this.btnDayView.Click += new System.EventHandler(this.btnDayView_Click);
            // 
            // btnWeekView
            // 
            this.btnWeekView.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnWeekView.FixedSize = new System.Drawing.Size(100, 60);
            this.btnWeekView.Image = ((System.Drawing.Image)(resources.GetObject("btnWeekView.Image")));
            this.btnWeekView.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnWeekView.Name = "btnWeekView";
            this.btnWeekView.OptionGroup = "View";
            this.superTooltip1.SetSuperTooltip(this.btnWeekView, new DevComponents.DotNetBar.SuperTooltipInfo("Vista por semana", "", "", ((System.Drawing.Image)(resources.GetObject("btnWeekView.SuperTooltip"))), null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.btnWeekView.Text = "Semana";
            this.btnWeekView.Click += new System.EventHandler(this.btnWeekView_Click);
            // 
            // btnMonthView
            // 
            this.btnMonthView.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnMonthView.FixedSize = new System.Drawing.Size(100, 60);
            this.btnMonthView.Image = ((System.Drawing.Image)(resources.GetObject("btnMonthView.Image")));
            this.btnMonthView.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnMonthView.Name = "btnMonthView";
            this.btnMonthView.OptionGroup = "View";
            this.superTooltip1.SetSuperTooltip(this.btnMonthView, new DevComponents.DotNetBar.SuperTooltipInfo("Vista por mes", "", "", ((System.Drawing.Image)(resources.GetObject("btnMonthView.SuperTooltip"))), null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.btnMonthView.Text = "Mes";
            this.btnMonthView.Click += new System.EventHandler(this.btnMonthView_Click);
            // 
            // panelCalendar
            // 
            this.panelCalendar.Controls.Add(this.contextMenuBar1);
            this.panelCalendar.Controls.Add(this.calendarView);
            this.panelCalendar.Controls.Add(this.dateNavigator);
            this.panelCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCalendar.Location = new System.Drawing.Point(3, 3);
            this.panelCalendar.Name = "panelCalendar";
            this.panelCalendar.Size = new System.Drawing.Size(694, 301);
            this.panelCalendar.TabIndex = 6;
            // 
            // contextMenuBar1
            // 
            this.contextMenuBar1.AntiAlias = true;
            this.contextMenuBar1.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.contextMenuBar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.InContentContextMenu,
            this.InTabContextMenu,
            this.InAppointment});
            this.contextMenuBar1.Location = new System.Drawing.Point(153, 178);
            this.contextMenuBar1.Name = "contextMenuBar1";
            this.contextMenuBar1.Size = new System.Drawing.Size(116, 69);
            this.contextMenuBar1.Stretch = true;
            this.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.contextMenuBar1.TabIndex = 6;
            this.contextMenuBar1.TabStop = false;
            this.contextMenuBar1.Text = "contextMenuBar1";
            // 
            // InContentContextMenu
            // 
            this.InContentContextMenu.AutoExpandOnClick = true;
            this.InContentContextMenu.Name = "InContentContextMenu";
            this.InContentContextMenu.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAddAppointment,
            this.buttonItemBuscar,
            this.buttonItemNotificar});
            this.InContentContextMenu.Text = "In Content";
            this.InContentContextMenu.Click += new System.EventHandler(this.InContentContextMenu_Click);
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Text = "Agregar";
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // buttonItemBuscar
            // 
            this.buttonItemBuscar.Name = "buttonItemBuscar";
            this.buttonItemBuscar.Text = "Buscar";
            this.buttonItemBuscar.Click += new System.EventHandler(this.buttonItemBuscar_Click);
            // 
            // buttonItemNotificar
            // 
            this.buttonItemNotificar.Name = "buttonItemNotificar";
            this.buttonItemNotificar.Text = "Notificar";
            this.buttonItemNotificar.Click += new System.EventHandler(this.buttonItemNotificar_Click);
            // 
            // InTabContextMenu
            // 
            this.InTabContextMenu.AutoExpandOnClick = true;
            this.InTabContextMenu.Name = "InTabContextMenu";
            this.InTabContextMenu.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.InTabOcultar,
            this.InTabAddNewTab,
            this.InTabReplaceTab});
            this.InTabContextMenu.Text = "InTab";
            // 
            // InTabOcultar
            // 
            this.InTabOcultar.Name = "InTabOcultar";
            this.InTabOcultar.Text = "Ocultar";
            this.InTabOcultar.Click += new System.EventHandler(this.InTabOcultar_Click);
            // 
            // InTabAddNewTab
            // 
            this.InTabAddNewTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.InTabAddNewTab.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.InTabAddNewTab.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.InTabAddNewTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(110)))));
            this.InTabAddNewTab.Name = "InTabAddNewTab";
            this.InTabAddNewTab.PaddingBottom = 1;
            this.InTabAddNewTab.PaddingLeft = 10;
            this.InTabAddNewTab.PaddingTop = 1;
            this.InTabAddNewTab.SingleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.InTabAddNewTab.Text = "Agregar";
            // 
            // InTabReplaceTab
            // 
            this.InTabReplaceTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.InTabReplaceTab.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.InTabReplaceTab.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.InTabReplaceTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(110)))));
            this.InTabReplaceTab.Name = "InTabReplaceTab";
            this.InTabReplaceTab.PaddingBottom = 1;
            this.InTabReplaceTab.PaddingLeft = 10;
            this.InTabReplaceTab.PaddingTop = 1;
            this.InTabReplaceTab.SingleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.InTabReplaceTab.Text = "Reemplazar";
            // 
            // InAppointment
            // 
            this.InAppointment.AutoExpandOnClick = true;
            this.InAppointment.Name = "InAppointment";
            this.InAppointment.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemVerAppointment,
            this.buttonItemDeleteAppointment,
            this.buttonItemBorrarSerie,
            this.checkBoxItemReprogramada});
            this.InAppointment.Text = "InAppointment";
            // 
            // buttonItemVerAppointment
            // 
            this.buttonItemVerAppointment.Name = "buttonItemVerAppointment";
            this.buttonItemVerAppointment.Text = "Ver";
            this.buttonItemVerAppointment.Click += new System.EventHandler(this.buttonItemEditarAppointment_Click);
            // 
            // buttonItemDeleteAppointment
            // 
            this.buttonItemDeleteAppointment.Name = "buttonItemDeleteAppointment";
            this.buttonItemDeleteAppointment.Text = "Borrar";
            this.buttonItemDeleteAppointment.Click += new System.EventHandler(this.buttonItemDeleteAppointment_Click);
            // 
            // buttonItemBorrarSerie
            // 
            this.buttonItemBorrarSerie.Name = "buttonItemBorrarSerie";
            this.buttonItemBorrarSerie.Text = "Borrar Serie";
            this.buttonItemBorrarSerie.Visible = false;
            this.buttonItemBorrarSerie.Click += new System.EventHandler(this.buttonItemBorrarSerie_Click);
            // 
            // checkBoxItemReprogramada
            // 
            this.checkBoxItemReprogramada.Name = "checkBoxItemReprogramada";
            this.checkBoxItemReprogramada.Text = "Reprogramada";
            this.checkBoxItemReprogramada.Click += new System.EventHandler(this.checkBoxItemReprogramada_Click);
            // 
            // barStatus
            // 
            this.barStatus.AntiAlias = true;
            this.barStatus.BackColor = System.Drawing.Color.CornflowerBlue;
            this.barStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barStatus.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.barStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.barStatus.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemMultiUser,
            this.buttonItemSingleUser});
            this.barStatus.Location = new System.Drawing.Point(3, 310);
            this.barStatus.MaximumSize = new System.Drawing.Size(0, 23);
            this.barStatus.MinimumSize = new System.Drawing.Size(0, 23);
            this.barStatus.Name = "barStatus";
            this.barStatus.RoundCorners = false;
            this.barStatus.Size = new System.Drawing.Size(694, 23);
            this.barStatus.Stretch = true;
            this.barStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.barStatus.TabIndex = 7;
            this.barStatus.TabStop = false;
            this.barStatus.Text = "bar1";
            // 
            // buttonItemMultiUser
            // 
            this.buttonItemMultiUser.Checked = true;
            this.buttonItemMultiUser.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonItemMultiUser.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemMultiUser.Image")));
            this.buttonItemMultiUser.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.buttonItemMultiUser.Name = "buttonItemMultiUser";
            this.buttonItemMultiUser.OptionGroup = "UserView";
            this.superTooltip1.SetSuperTooltip(this.buttonItemMultiUser, new DevComponents.DotNetBar.SuperTooltipInfo("Horario por aula", "", "", ((System.Drawing.Image)(resources.GetObject("buttonItemMultiUser.SuperTooltip"))), null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItemMultiUser.Click += new System.EventHandler(this.buttonItemMultiUser_Click);
            // 
            // buttonItemSingleUser
            // 
            this.buttonItemSingleUser.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonItemSingleUser.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemSingleUser.Image")));
            this.buttonItemSingleUser.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.buttonItemSingleUser.Name = "buttonItemSingleUser";
            this.buttonItemSingleUser.OptionGroup = "UserView";
            this.superTooltip1.SetSuperTooltip(this.buttonItemSingleUser, new DevComponents.DotNetBar.SuperTooltipInfo("Horario en general", "", "", ((System.Drawing.Image)(resources.GetObject("buttonItemSingleUser.SuperTooltip"))), null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItemSingleUser.Click += new System.EventHandler(this.buttonItemSingleUser_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.barStatus, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.panelCalendar, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 63);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(700, 337);
            this.tableLayoutPanel.TabIndex = 8;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // superTooltip1
            // 
            this.superTooltip1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // CalendarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.barView);
            this.Name = "CalendarControl";
            this.Size = new System.Drawing.Size(700, 400);
            ((System.ComponentModel.ISupportInitialize)(this.barView)).EndInit();
            this.panelCalendar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barStatus)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Schedule.DateNavigator dateNavigator;
        private DevComponents.DotNetBar.Bar barView;
        private DevComponents.DotNetBar.ButtonItem btnDayView;
        private DevComponents.DotNetBar.ButtonItem btnWeekView;
        private DevComponents.DotNetBar.ButtonItem btnMonthView;
        private System.Windows.Forms.Panel panelCalendar;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
        private DevComponents.DotNetBar.ButtonItem InContentContextMenu;
        private DevComponents.DotNetBar.ButtonItem btnAddAppointment;
        public DevComponents.DotNetBar.Schedule.CalendarView calendarView;
        private DevComponents.DotNetBar.ButtonItem InTabContextMenu;
        private DevComponents.DotNetBar.ButtonItem InTabOcultar;
        private DevComponents.DotNetBar.LabelItem InTabAddNewTab;
        private DevComponents.DotNetBar.LabelItem InTabReplaceTab;
        private DevComponents.DotNetBar.ButtonItem InAppointment;
        private DevComponents.DotNetBar.ButtonItem buttonItemDeleteAppointment;
        private DevComponents.DotNetBar.ButtonItem buttonItemVerAppointment;
        private DevComponents.DotNetBar.CheckBoxItem checkBoxItemReprogramada;
        private System.Windows.Forms.ImageList imageList;
        private DevComponents.DotNetBar.ButtonItem buttonItemBuscar;
        private DevComponents.DotNetBar.Bar barStatus;
        private DevComponents.DotNetBar.ButtonItem buttonItemMultiUser;
        private DevComponents.DotNetBar.ButtonItem buttonItemSingleUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.SuperTooltip superTooltip1;
        private DevComponents.DotNetBar.ButtonItem buttonItemBorrarSerie;
        private DevComponents.DotNetBar.ButtonItem buttonItemNotificar;
    }
}
