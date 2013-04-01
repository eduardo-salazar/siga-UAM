namespace Control_Aulas_UAM
{
    partial class BuscarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarForm));
            this.buttonBuscar = new DevComponents.DotNetBar.ButtonX();
            this.buttonAceptar = new DevComponents.DotNetBar.ButtonX();
            this.buttonCancelar = new DevComponents.DotNetBar.ButtonX();
            this.superTabControlModoBusqueda = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.buscarGupoControl1 = new Control_Aulas_UAM.BuscarGupoControl();
            this.superTabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.buscarControl1 = new Control_Aulas_UAM.BuscarControl();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.comboBoxModoBusqueda = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItemDetalleAula = new DevComponents.Editors.ComboItem();
            this.comboItemDetalleGrupo = new DevComponents.Editors.ComboItem();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControlModoBusqueda)).BeginInit();
            this.superTabControlModoBusqueda.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonBuscar.Location = new System.Drawing.Point(12, 12);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonBuscar.TabIndex = 5;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonAceptar.Location = new System.Drawing.Point(516, 12);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonAceptar.TabIndex = 6;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(597, 12);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // superTabControlModoBusqueda
            // 
            this.superTabControlModoBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControlModoBusqueda.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControlModoBusqueda.ControlBox.MenuBox.Name = "";
            this.superTabControlModoBusqueda.ControlBox.Name = "";
            this.superTabControlModoBusqueda.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControlModoBusqueda.ControlBox.MenuBox,
            this.superTabControlModoBusqueda.ControlBox.CloseBox});
            this.superTabControlModoBusqueda.Controls.Add(this.superTabControlPanel2);
            this.superTabControlModoBusqueda.Controls.Add(this.superTabControlPanel1);
            this.superTabControlModoBusqueda.Location = new System.Drawing.Point(12, 51);
            this.superTabControlModoBusqueda.Name = "superTabControlModoBusqueda";
            this.superTabControlModoBusqueda.ReorderTabsEnabled = true;
            this.superTabControlModoBusqueda.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.superTabControlModoBusqueda.SelectedTabIndex = 0;
            this.superTabControlModoBusqueda.Size = new System.Drawing.Size(660, 298);
            this.superTabControlModoBusqueda.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControlModoBusqueda.TabIndex = 8;
            this.superTabControlModoBusqueda.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem1,
            this.superTabItem2});
            this.superTabControlModoBusqueda.TabsVisible = false;
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.buscarGupoControl1);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(660, 273);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.superTabItem2;
            // 
            // buscarGupoControl1
            // 
            this.buscarGupoControl1.Aulas = null;
            this.buscarGupoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buscarGupoControl1.Location = new System.Drawing.Point(0, 0);
            this.buscarGupoControl1.Name = "buscarGupoControl1";
            this.buscarGupoControl1.Size = new System.Drawing.Size(660, 273);
            this.buscarGupoControl1.TabIndex = 0;
            // 
            // superTabItem2
            // 
            this.superTabItem2.AttachedControl = this.superTabControlPanel2;
            this.superTabItem2.GlobalItem = false;
            this.superTabItem2.Name = "superTabItem2";
            this.superTabItem2.Text = "Grupo";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.buscarControl1);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(660, 273);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // buscarControl1
            // 
            this.buscarControl1.Aulas = null;
            this.buscarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buscarControl1.Location = new System.Drawing.Point(0, 0);
            this.buscarControl1.Name = "buscarControl1";
            this.buscarControl1.Size = new System.Drawing.Size(660, 273);
            this.buscarControl1.TabIndex = 3;
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "Aula";
            // 
            // comboBoxModoBusqueda
            // 
            this.comboBoxModoBusqueda.DisplayMember = "Text";
            this.comboBoxModoBusqueda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxModoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModoBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxModoBusqueda.FormattingEnabled = true;
            this.comboBoxModoBusqueda.ItemHeight = 17;
            this.comboBoxModoBusqueda.Items.AddRange(new object[] {
            this.comboItemDetalleAula,
            this.comboItemDetalleGrupo});
            this.comboBoxModoBusqueda.Location = new System.Drawing.Point(93, 12);
            this.comboBoxModoBusqueda.Name = "comboBoxModoBusqueda";
            this.comboBoxModoBusqueda.Size = new System.Drawing.Size(157, 23);
            this.comboBoxModoBusqueda.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxModoBusqueda.TabIndex = 9;
            this.comboBoxModoBusqueda.SelectedIndexChanged += new System.EventHandler(this.comboBoxModo_SelectedIndexChanged);
            // 
            // comboItemDetalleAula
            // 
            this.comboItemDetalleAula.Text = "Detalle de Aula";
            // 
            // comboItemDetalleGrupo
            // 
            this.comboItemDetalleGrupo.Text = "Detalle de Grupo";
            // 
            // BuscarForm
            // 
            this.AcceptButton = this.buttonAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.comboBoxModoBusqueda);
            this.Controls.Add(this.superTabControlModoBusqueda);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscarForm";
            this.Text = "Buscar";
            ((System.ComponentModel.ISupportInitialize)(this.superTabControlModoBusqueda)).EndInit();
            this.superTabControlModoBusqueda.ResumeLayout(false);
            this.superTabControlPanel2.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BuscarControl buscarControl1;
        private DevComponents.DotNetBar.ButtonX buttonBuscar;
        private DevComponents.DotNetBar.ButtonX buttonAceptar;
        private DevComponents.DotNetBar.ButtonX buttonCancelar;
        private DevComponents.DotNetBar.SuperTabControl superTabControlModoBusqueda;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem superTabItem2;
        private BuscarGupoControl buscarGupoControl1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxModoBusqueda;
        private DevComponents.Editors.ComboItem comboItemDetalleAula;
        private DevComponents.Editors.ComboItem comboItemDetalleGrupo;

    }
}