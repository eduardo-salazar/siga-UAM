namespace Control_Aulas_UAM
{
    partial class MainCalendarViewControl
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
            DevComponents.Editors.ComboItem comboItemClase;
            DevComponents.Editors.ComboItem comboItemOtro;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainCalendarViewControl));
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.buttonBuscar = new DevComponents.DotNetBar.ButtonX();
            this.buttonAddSerie = new DevComponents.DotNetBar.ButtonX();
            this.buttonCancelar = new DevComponents.DotNetBar.ButtonX();
            this.buttonAceptar = new DevComponents.DotNetBar.ButtonX();
            this.superTabControl = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanelClase = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.asignacionClaseControl = new Control_Aulas_UAM.AsignacionClaseControl();
            this.superTabItemClase = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanelOtro = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.asignacionVariosControl = new Control_Aulas_UAM.AsignacionVariosControl();
            this.superTabItemOtro = new DevComponents.DotNetBar.SuperTabItem();
            this.comboBoxTipoAsignacion = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.calendarControl = new Control_Aulas_UAM.CalendarControl();
            comboItemClase = new DevComponents.Editors.ComboItem();
            comboItemOtro = new DevComponents.Editors.ComboItem();
            this.expandablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl)).BeginInit();
            this.superTabControl.SuspendLayout();
            this.superTabControlPanelClase.SuspendLayout();
            this.superTabControlPanelOtro.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboItemClase
            // 
            comboItemClase.Text = "Clase";
            comboItemClase.Value = "";
            // 
            // comboItemOtro
            // 
            comboItemOtro.Text = "Otro";
            comboItemOtro.Value = "Otro";
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.LeftToRight;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel1.Controls.Add(this.buttonBuscar);
            this.expandablePanel1.Controls.Add(this.buttonAddSerie);
            this.expandablePanel1.Controls.Add(this.buttonCancelar);
            this.expandablePanel1.Controls.Add(this.buttonAceptar);
            this.expandablePanel1.Controls.Add(this.superTabControl);
            this.expandablePanel1.Controls.Add(this.comboBoxTipoAsignacion);
            this.expandablePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.expandablePanel1.ExpandButtonVisible = false;
            this.expandablePanel1.ExpandOnTitleClick = true;
            this.expandablePanel1.Location = new System.Drawing.Point(815, 0);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(264, 557);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 0;
            this.expandablePanel1.TitleHeight = 0;
            this.expandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel1.TitleStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "Title Bar";
            this.expandablePanel1.Visible = false;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.Image")));
            this.buttonBuscar.Location = new System.Drawing.Point(147, 48);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(34, 34);
            this.buttonBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonBuscar.TabIndex = 7;
            this.buttonBuscar.Tooltip = "Buscar";
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonAddSerie
            // 
            this.buttonAddSerie.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonAddSerie.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonAddSerie.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddSerie.Image")));
            this.buttonAddSerie.Location = new System.Drawing.Point(107, 48);
            this.buttonAddSerie.Name = "buttonAddSerie";
            this.buttonAddSerie.Size = new System.Drawing.Size(34, 34);
            this.buttonAddSerie.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonAddSerie.TabIndex = 6;
            this.buttonAddSerie.Tooltip = "Agregar Serie";
            this.buttonAddSerie.Click += new System.EventHandler(this.buttonAddSerie_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.Location = new System.Drawing.Point(227, 48);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(34, 34);
            this.buttonCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Tooltip = "Cancelar";
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonAceptar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAceptar.Image")));
            this.buttonAceptar.Location = new System.Drawing.Point(187, 48);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(34, 34);
            this.buttonAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonAceptar.TabIndex = 4;
            this.buttonAceptar.Tooltip = "Aceptar";
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // superTabControl
            // 
            this.superTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.superTabControl.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl.ControlBox.MenuBox.Name = "";
            this.superTabControl.ControlBox.Name = "";
            this.superTabControl.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl.ControlBox.MenuBox,
            this.superTabControl.ControlBox.CloseBox});
            this.superTabControl.ControlBox.Visible = false;
            this.superTabControl.Controls.Add(this.superTabControlPanelClase);
            this.superTabControl.Controls.Add(this.superTabControlPanelOtro);
            this.superTabControl.Location = new System.Drawing.Point(3, 114);
            this.superTabControl.Name = "superTabControl";
            this.superTabControl.ReorderTabsEnabled = false;
            this.superTabControl.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.superTabControl.SelectedTabIndex = 0;
            this.superTabControl.Size = new System.Drawing.Size(258, 439);
            this.superTabControl.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControl.TabIndex = 3;
            this.superTabControl.TabLayoutType = DevComponents.DotNetBar.eSuperTabLayoutType.SingleLineFit;
            this.superTabControl.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItemClase,
            this.superTabItemOtro});
            this.superTabControl.TabsVisible = false;
            // 
            // superTabControlPanelClase
            // 
            this.superTabControlPanelClase.Controls.Add(this.asignacionClaseControl);
            this.superTabControlPanelClase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanelClase.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanelClase.Name = "superTabControlPanelClase";
            this.superTabControlPanelClase.Size = new System.Drawing.Size(258, 414);
            this.superTabControlPanelClase.TabIndex = 1;
            this.superTabControlPanelClase.TabItem = this.superTabItemClase;
            // 
            // asignacionClaseControl
            // 
            this.asignacionClaseControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.asignacionClaseControl.Asignatura = null;
            this.asignacionClaseControl.Asignaturas = null;
            this.asignacionClaseControl.Aula = null;
            this.asignacionClaseControl.Aulas = null;
            this.asignacionClaseControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.asignacionClaseControl.Fin = new System.DateTime(2012, 10, 29, 5, 53, 0, 0);
            this.asignacionClaseControl.Grupo = null;
            this.asignacionClaseControl.Inicio = new System.DateTime(2012, 10, 29, 4, 53, 31, 0);
            this.asignacionClaseControl.Location = new System.Drawing.Point(0, 0);
            this.asignacionClaseControl.Name = "asignacionClaseControl";
            this.asignacionClaseControl.ReadOnly = false;
            this.asignacionClaseControl.Size = new System.Drawing.Size(255, 411);
            this.asignacionClaseControl.TabIndex = 0;
            // 
            // superTabItemClase
            // 
            this.superTabItemClase.AttachedControl = this.superTabControlPanelClase;
            this.superTabItemClase.GlobalItem = false;
            this.superTabItemClase.Name = "superTabItemClase";
            this.superTabItemClase.Text = "Clase";
            // 
            // superTabControlPanelOtro
            // 
            this.superTabControlPanelOtro.Controls.Add(this.asignacionVariosControl);
            this.superTabControlPanelOtro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanelOtro.Location = new System.Drawing.Point(0, 0);
            this.superTabControlPanelOtro.Name = "superTabControlPanelOtro";
            this.superTabControlPanelOtro.Size = new System.Drawing.Size(258, 439);
            this.superTabControlPanelOtro.TabIndex = 0;
            this.superTabControlPanelOtro.TabItem = this.superTabItemOtro;
            // 
            // asignacionVariosControl
            // 
            this.asignacionVariosControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.asignacionVariosControl.Aula = null;
            this.asignacionVariosControl.Aulas = null;
            this.asignacionVariosControl.AutoScroll = true;
            this.asignacionVariosControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.asignacionVariosControl.Fin = new System.DateTime(2012, 10, 29, 4, 53, 39, 0);
            this.asignacionVariosControl.Inicio = new System.DateTime(2012, 10, 29, 4, 53, 31, 0);
            this.asignacionVariosControl.Location = new System.Drawing.Point(0, 0);
            this.asignacionVariosControl.Name = "asignacionVariosControl";
            this.asignacionVariosControl.Observaciones = "";
            this.asignacionVariosControl.ReadOnly = false;
            this.asignacionVariosControl.Size = new System.Drawing.Size(258, 461);
            this.asignacionVariosControl.TabIndex = 0;
            this.asignacionVariosControl.TipoUso = null;
            // 
            // superTabItemOtro
            // 
            this.superTabItemOtro.AttachedControl = this.superTabControlPanelOtro;
            this.superTabItemOtro.GlobalItem = false;
            this.superTabItemOtro.Name = "superTabItemOtro";
            this.superTabItemOtro.Text = "Otro";
            // 
            // comboBoxTipoAsignacion
            // 
            this.comboBoxTipoAsignacion.DisplayMember = "Text";
            this.comboBoxTipoAsignacion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxTipoAsignacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoAsignacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comboBoxTipoAsignacion.FormattingEnabled = true;
            this.comboBoxTipoAsignacion.ItemHeight = 16;
            this.comboBoxTipoAsignacion.Items.AddRange(new object[] {
            comboItemClase,
            comboItemOtro});
            this.comboBoxTipoAsignacion.Location = new System.Drawing.Point(27, 88);
            this.comboBoxTipoAsignacion.Name = "comboBoxTipoAsignacion";
            this.comboBoxTipoAsignacion.Size = new System.Drawing.Size(194, 22);
            this.comboBoxTipoAsignacion.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.comboBoxTipoAsignacion.TabIndex = 2;
            this.comboBoxTipoAsignacion.SelectedIndexChanged += new System.EventHandler(this.comboBoxExTipoAsignacion_SelectedIndexChanged);
            // 
            // superTabItem1
            // 
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "Clase";
            // 
            // calendarControl
            // 
            this.calendarControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarControl.Location = new System.Drawing.Point(0, 0);
            this.calendarControl.Name = "calendarControl";
            this.calendarControl.ReadOnly = true;
            this.calendarControl.Size = new System.Drawing.Size(815, 557);
            this.calendarControl.TabIndex = 1;
            // 
            // MainCalendarViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.calendarControl);
            this.Controls.Add(this.expandablePanel1);
            this.Name = "MainCalendarViewControl";
            this.Size = new System.Drawing.Size(1079, 557);
            this.Load += new System.EventHandler(this.AsignacionSimpleControl_Load);
            this.expandablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl)).EndInit();
            this.superTabControl.ResumeLayout(false);
            this.superTabControlPanelClase.ResumeLayout(false);
            this.superTabControlPanelOtro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private Control_Aulas_UAM.CalendarControl calendarControl;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxTipoAsignacion;
        private DevComponents.DotNetBar.SuperTabControl superTabControl;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanelClase;
        private DevComponents.DotNetBar.SuperTabItem superTabItemClase;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanelOtro;
        private DevComponents.DotNetBar.SuperTabItem superTabItemOtro;
        private AsignacionVariosControl asignacionVariosControl;
        private DevComponents.DotNetBar.ButtonX buttonAceptar;
        private DevComponents.DotNetBar.ButtonX buttonCancelar;
        private AsignacionClaseControl asignacionClaseControl;
        private DevComponents.DotNetBar.ButtonX buttonAddSerie;
        private DevComponents.DotNetBar.ButtonX buttonBuscar;
    }
}
