using System;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using System.Data;
using DevComponents.DotNetBar;
using Control_Aulas_UAM;
using Control_Aulas_UAM.Catalogos;

namespace Control_Aulas_UAM
{
    public partial class Entorno : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        Menu_Principal _StartControl = null;
        UserControl panel;
        Usuario usuario = null;
        StyleManager stryle = null;

        public Entorno(Usuario a)
        {
            InitializeComponent();

            this.bar1.Style = eDotNetBarStyle.Office2010;
           
            this.bar1.Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) - (this.bar1.Width / 2), this.bar1.Location.Y);
            //Abrir Menu-Principal
            this.SuspendLayout();
            usuario = a;
            _StartControl = new Menu_Principal(a);
            
            this.Controls.Add(_StartControl);
            _StartControl.BringToFront();
            _StartControl.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Right;

           

            //Controles de eventos de la lista de Adminstrador
            //_StartControl.listAdmControlUsuarios.Click+=new EventHandler(listAdmControlUsuarios_Click);
            

            //Eventos de los botones de los controles
            this.btnNuevo.Click +=new EventHandler(btnNuevo_Click);
            this.btnGuardar.Click +=new EventHandler(btnGuardar_Click);
            this.btnEditar.Click +=new EventHandler(btnEditar_Click);
            this.btnBorrar.Click+=new EventHandler(btnBorrar_Click);
            this.btnCancelar.Click+=new EventHandler(btnCancelar_Click);

                //navegacion
            this.btnPrimero.Click+=new EventHandler(btnPrimero_Click);
            this.btnAnterior.Click+=new EventHandler(btnAnterior_Click);
            this.btnSiguiente.Click+=new EventHandler(btnSiguiente_Click);
            this.btnUltimo.Click+=new EventHandler(btnUltimo_Click);
            this.btnBuscar.Click+=new EventHandler(btnBuscar_Click);
            


            /*------------Manejadores de Eventos del Menu Principal---------*/
            _StartControl.btnCrearSerie.Click+=new EventHandler(btnCrearSerie_Click);
            _StartControl.btnVerCalendario.Click+=new EventHandler(btnVerCalendario_Click);
            //_StartControl.btnComunicacion.Click += btnComunicacion_Click;

            _StartControl.listCatFacultad.Click += new EventHandler(listCatFacultad_Click);
            _StartControl.listCatEdificios.Click+=new EventHandler(listCatEdificios_Click);
            _StartControl.listCatDocentes.Click += new EventHandler(listCatDocentes_Click);
            _StartControl.listCatPeriodos.Click += new EventHandler(listCatPeriodos_Click);
            _StartControl.listCatAsignaturaCategorias.Click += new EventHandler(listCatAsignaturaCategorias_Click);
            _StartControl.listCatAsignaturas.Click += new EventHandler(listCatAsignaturas_Click);
            _StartControl.listCatAulaEstados.Click+=new EventHandler(listCatAulaEstados_Click);
            _StartControl.listCatAulaTipos.Click+=new EventHandler(listCatAulaTipos_Click);
            _StartControl.listCatAulaTipoUsos.Click += new EventHandler(listCatAulaTipoUsos_Click);
            _StartControl.listCatAulas.Click+=new EventHandler(listCatAulas_Click);
            _StartControl.listCatAlertaEstados.Click += listCatAlertaEstados_Click;
            _StartControl.listCatEquipos.Click += listCatEquipos_Click;
            _StartControl.lbCantidadNotificaciones.Click+=lbCantidadNotificaciones_Click;
            _StartControl.listAdmControlUsuarios.Click+=listAdmControlUsuarios_Click;
            /*----------------------FIN MENU PRINCIPAL---------------------*/

            this.KeyDown += Entorno_KeyDown;

            this.ResumeLayout(false);

            if (!usuario.Admin)
            {
                this.btnEditar.Enabled = false;
                this.btnBorrar.Enabled = false;
                this.btnNuevo.Enabled = false;
            }
 
        }

        

        void Entorno_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        

        


        /*-----------------Estos metodos controlan el desplazamiento de los paneles--------------------------------*/
        protected override void OnLoad(EventArgs e)
        {
            UpdateControlsSizeAndLocation();
            base.OnLoad(e);
        }

        private Rectangle GetStartControlBounds()
        {
            int captionHeight = metroShell1.MetroTabStrip.GetCaptionHeight() + 2;
            Thickness borderThickness = this.GetBorderThickness();
            return new Rectangle((int)borderThickness.Left, captionHeight, this.Width - (int)borderThickness.Horizontal, this.Height - captionHeight - 1);
        }
        private void UpdateControlsSizeAndLocation()
        {
            if (_StartControl != null)
            {
                if (!_StartControl.IsOpen)
                    _StartControl.OpenBounds = GetStartControlBounds();
                else
                {
                    _StartControl.Bounds = GetStartControlBounds();
                }
                if (!IsModalPanelDisplayed)
                    _StartControl.BringToFront();
            }
        }
        protected override void OnResize(EventArgs e)
        {
            UpdateControlsSizeAndLocation();
            //base.OnResize(e);
        }

        private void Entorno_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /*---------FIN METODOS DE CONTROL DE DESPLAZAMIENTO DE PANELES---------------------*/

        /*-------------CONTROL EVENTOS CLICK DE MENU-PRINCIPAL-----------------------------*/
            
        
        
        void limpiarControles() 
        {
            this.btnEditar.Enabled = false;
            this.btnCancelar.Enabled = false;
            this.btnBorrar.Enabled = false;
            this.btnGuardar.Enabled = false;
            ActivarNavegacion(false);
            this.btnNuevo.Enabled = true;
        }
        void verificarVacio(UserControl panel)
        {
            Funciones f = (Funciones)panel;
            if (f.vacio())
            {
                limpiarControles();
            }
        }

        void btnCrearSerie_Click(Object sender, EventArgs e)
        {
            limpiarPanel();
            panel = new AsignacionMultipleControl();
            ((AsignacionMultipleControl)panel).setUsuario(usuario);
            ajustarTamano(panel);
            this.Controls.Add(panel);
            seleccionar_tabControles();
            //modoNavegacion();
            //verificarVacio(panel);
        }

        void btnVerCalendario_Click(Object sender, EventArgs e)
        {
            limpiarPanel();
            this.stryle = this.styleManager1;
            panel = new MainCalendarViewControl();
            ((MainCalendarViewControl)panel).Usuario = this.usuario;
            ajustarTamano(panel);
            this.Controls.Add(panel);
            seleccionar_tabControles();
            this.bar1.Visible = false;
            //modoNavegacion();
            //verificarVacio(panel);
        }

        void btnComunicacion_Click(object sender, EventArgs e)
        {
            BuscarForm g = new BuscarForm();
            g.ShowDialog();
        }

        void listCatFacultad_Click(Object sender,EventArgs e)
        {
            limpiarPanel();
            this.btnBuscar.Visible = true;
            panel = new FacultadForm();
            ajustarTamano(panel);
            this.Controls.Add(panel);
            seleccionar_tabControles();
            modoNavegacion();
            verificarVacio(panel);
        }
        void listCatEdificios_Click(Object sender, EventArgs e)
        {
            limpiarPanel();
            this.btnBuscar.Visible = true;
            panel = new EdificiosForm();
            ajustarTamano(panel);
            this.Controls.Add(panel);
            seleccionar_tabControles();
            modoNavegacion();
            verificarVacio(panel); 
        }
        void listCatDocentes_Click(Object sender, EventArgs e)
        {
            limpiarPanel();
            this.btnBuscar.Visible = true;
            panel = new DocentesForm();
            ajustarTamano(panel);
            this.Controls.Add(panel);
            seleccionar_tabControles();
            modoNavegacion();
            verificarVacio(panel);
        }
        void listCatPeriodos_Click(Object sender, EventArgs e)
        {
            limpiarPanel();
            this.btnBuscar.Visible = true;
            panel = new PeriodosForm();
            ajustarTamano(panel);
            this.Controls.Add(panel);
            seleccionar_tabControles();
            modoNavegacion();
            verificarVacio(panel);
        }
        void listCatAsignaturaCategorias_Click(Object sender, EventArgs e)
        {
            limpiarPanel();
            this.btnBuscar.Visible = true;
            panel = new AsignaturaCategoriasForm();
            ajustarTamano(panel);
            this.Controls.Add(panel);
            seleccionar_tabControles();
            modoNavegacion();
            verificarVacio(panel);
        }
        void listCatAsignaturas_Click(Object sender, EventArgs e)
        {
            limpiarPanel();
            this.btnBuscar.Visible = true;
            panel = new AsignaturasForm();
            ajustarTamano(panel);
            this.Controls.Add(panel);
            seleccionar_tabControles();
            modoNavegacion();
            verificarVacio(panel);
        }


        void listCatAulaEstados_Click(Object sender, EventArgs e)
        {
            limpiarPanel();
            this.btnBuscar.Visible = true;
            panel = new AulaEstadosForm();
            ajustarTamano(panel);
            this.Controls.Add(panel);
            seleccionar_tabControles();
            modoNavegacion();
            verificarVacio(panel);
        }
        void listCatAulaTipos_Click(Object sender, EventArgs e)
        {
            limpiarPanel();
            this.btnBuscar.Visible = true;
            panel = new AulaTipoForm();
            ajustarTamano(panel);
            this.Controls.Add(panel);
            seleccionar_tabControles();
            modoNavegacion();
            verificarVacio(panel);
        
        }
        void listCatAulaTipoUsos_Click(Object sender, EventArgs e)
        {
            limpiarPanel();
            this.btnBuscar.Visible = true;
            panel = new AulaTipoUsoForm();
            ajustarTamano(panel);
            this.Controls.Add(panel);
            seleccionar_tabControles();
            modoNavegacion();
            verificarVacio(panel);
        }
        void listCatAulas_Click(Object sender, EventArgs e)
        {
            limpiarPanel();
            this.btnBuscar.Visible = true;
            panel = new AulasForm(this.usuario);
            ajustarTamano(panel);
            this.Controls.Add(panel);
            seleccionar_tabControles();
            modoNavegacion();
            verificarVacio(panel);
        }
        void listCatAlertaEstados_Click(object sender, EventArgs e)
        {
            limpiarPanel();
            this.btnBuscar.Visible = true;
            panel = new AlertaEstadosForm();
            ajustarTamano(panel);
            this.Controls.Add(panel);
            seleccionar_tabControles();
            modoNavegacion();
            verificarVacio(panel);
        }
        void listCatEquipos_Click(object sender, EventArgs e)
        {
            limpiarPanel();
            this.btnBuscar.Visible = true;
            panel = new EquiposForm();
            ajustarTamano(panel);
            this.Controls.Add(panel);
            seleccionar_tabControles();
            modoNavegacion();
            verificarVacio(panel);
        }
        void lbCantidadNotificaciones_Click(Object sender, EventArgs e)
        {
            limpiarPanel();
            _StartControl.getAlertas();
            panel = new NotificacionForm(_StartControl.getAlertas());
            ajustarTamano(panel);
            this.Controls.Add(panel);
            seleccionar_tabControles();
            modoNavegacion();
            this.bar1.Visible = false;
        }
        void listAdmControlUsuarios_Click(Object sender, EventArgs e)
        {
            limpiarPanel();
            panel = new ControlUsuario();
            ajustarTamano(panel);
            this.Controls.Add(panel);
            seleccionar_tabControles();
            modoNavegacion();

        }
        /*-----------CONTROL DE EVENTOS CLICK DE LOS CONTROLES DEL ENTORNO------------------*/
        
        void btnNuevo_Click(Object sender, EventArgs e)
        {
            ActivarNavegacion(false);
            this.btnEditar.Enabled = false;
            this.btnNuevo.Enabled = false;
            this.btnBorrar.Enabled = false;
            this.btnGuardar.Enabled = true;
            this.btnCancelar.Enabled = true;
            Funciones f = (Funciones)panel;
            f.Nuevo();
        }
        void btnGuardar_Click(Object sender, EventArgs e)
        {
            DialogResult resultado=MessageBox.Show("Desea guardar los cambios?","Confirmar",MessageBoxButtons.YesNo);
            Funciones f;
            bool estado = false ;
            if (resultado == DialogResult.Yes)
            {
                f = (Funciones)panel;
                estado = f.Guardar();
            }
            else
            {
                estado = true;
            }
            if (estado)
            {
                ActivarNavegacion(true);
                this.btnNuevo.Enabled = true;
                this.btnEditar.Enabled = true;
                this.btnBorrar.Enabled = true;
                
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
            }
        }
        void btnEditar_Click(Object sender, EventArgs e)
        {
            if (usuario.Admin)
            {
                Funciones f = (Funciones)panel;
                f.Editar();
                ActivarNavegacion(false);
                this.btnCancelar.Enabled = true;
                this.btnGuardar.Enabled = true;
                this.btnBorrar.Enabled = false;
                this.btnNuevo.Enabled = false;
            }

        }
        void btnBorrar_Click(Object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea borrar es registro seleccionado?", "Confirmar", MessageBoxButtons.YesNo);
            Funciones f=(Funciones)panel;
            bool estado = false;
            if (resultado == DialogResult.Yes)
            {
                f.Borrar();
                estado = true;
            }
            else
            {
                estado = false;
            }
            if (estado)
            {
                if (f.vacio())
                {
                    limpiarControles();
                }            
            }
            
            
        }
        void btnCancelar_Click(Object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea cancelar los cambios realizados?","Confirmar",MessageBoxButtons.YesNo);
            Funciones f = (Funciones)panel;
            if (resultado == DialogResult.Yes)
            {
                f.Cancelar();
                ActivarNavegacion(true);
                this.btnNuevo.Enabled = true;
                this.btnEditar.Enabled = true;
                this.btnBorrar.Enabled = true;
                
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
                if (f.vacio())
                {
                    limpiarControles();
                }    
            }
            
        }

            //navegacion

         void btnPrimero_Click(Object sender, EventArgs e)
        {
            Funciones f = (Funciones)panel;
            f.IrPrimero();
        }
        void btnAnterior_Click(Object sender, EventArgs e)
        {
            Funciones f = (Funciones)panel;
            f.Anterior();
        }
        void btnSiguiente_Click(Object sender, EventArgs e)
        {
            Funciones f = (Funciones)panel;
            f.Siguiente();
        }
        void btnUltimo_Click(Object sender, EventArgs e)
        {
            Funciones f = (Funciones)panel;
            f.IrFinal();
        }


        /*--------------FIN EVENTOS DE CONTROLES DEL ENTORNO---------------------------------*/


        /*---------------------METODOS PROPIOS PARA EL ENTRONO------------------------------*/
        

        void seleccionar_tabControles()
        {
            this.metroShell1.SelectedTab = this.tabControles;
        }
        void limpiarPanel()
        {
            if (this.bar1.Visible == false)
                this.bar1.Visible = true;
            if (panel != null)
                this.Controls.Remove(panel);
            if (this.stryle != null)
            {
                this.styleManager1 = stryle;
                this.stryle = null;
            }
            this.btnBuscar.Visible = false;
            
        }
        void ajustarTamano(UserControl p)
        {
            panel.Location = new Point((this.Width - panel.Width) / 2, this.metroShell1.Height + 5);
            panel.Size = new Size(panel.Width, this.Height - this.metroShell1.Height - 40);
        }
       
        //Metodos que controlan los controles habilitados y los desabilitados
        void modoNavegacion()
        {
            if (usuario.Admin)
            {
                this.btnNuevo.Enabled = true;
                this.btnBorrar.Enabled = true;
                this.btnEditar.Enabled = true;
            }
            
            this.btnGuardar.Enabled = false;

            this.btnCancelar.Enabled = false;
            //Navegacion
            this.btnPrimero.Enabled = true;
            this.btnAnterior.Enabled = true;
            this.btnSiguiente.Enabled = true;
            this.btnUltimo.Enabled = true;
        }
        void ActivarNavegacion(bool a)
        {
            this.btnPrimero.Enabled = a;
            this.btnAnterior.Enabled = a;
            this.btnSiguiente.Enabled = a;
            this.btnUltimo.Enabled = a;

        }
        void modoEdicion()
        {
            this.btnNuevo.Enabled = true;
            this.btnGuardar.Enabled = true;
            this.btnEditar.Enabled = true;
            //Navegacion
            ActivarNavegacion(false);

        }
      
      
        void btnImprimir_Click(Object sender,EventArgs e)
        {
            MessageBox.Show("En construcción");
        }
        void btnBuscar_Click(object sender, EventArgs e)
        {
            Funciones f = (Funciones)panel;
            f.Filtrar();
        }
        void btnReportesControl_Click(Object sender,EventArgs e)
        {
            Funciones f = (Funciones)panel;
            f.Reportes();
        }
        void btnRealizarPago_Click(Object sender, EventArgs e)
        {
            Funciones f = (Funciones)panel;
            f.RealizarPago();
        }

        private void Entorno_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                MessageBox.Show("Se presiono esc");
            }
        }

        /*-------------------------------FIN ENTORNO-----------------------------------------*/

    }
}