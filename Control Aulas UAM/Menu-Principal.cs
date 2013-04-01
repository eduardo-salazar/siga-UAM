using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Control_Aulas_UAM;
using Control_Aulas_UAM.Clases;
using Control_Aulas_UAM.Clases.Db;
using DevComponents.DotNetBar;
using Control_Aulas_UAM.Catalogos;

namespace Control_Aulas_UAM
{
    public partial class Menu_Principal : DevComponents.DotNetBar.Controls.SlidePanel
    {
        Usuario usuario = null;
        Conexion db = new Conexion();
        List<Alerta> notificaciones = null;
        public Menu_Principal(Usuario a)
        {
            InitializeComponent();
            usuario = a;
            labelNombre.Text = "Bienvenido "+ a.Nombre;
            if (a.Admin) {
                btnAdministrador.Visible = true;
                btnCrearSerie.Visible = true;
            }
            timer1_Tick(null, null);
        }
       
       protected override void OnResize(EventArgs e)
        {
           // Center the panel
           //usuarioGadget.Location=new Point((this.Width - usuarioGadget.Width)/2,20);
           //itemPanel1.Location = new Point((this.Width - itemPanel1.Width) / 2 + 16, ((this.Height - tabUsuario.Height - 16) - itemPanel1.Height) / 2 );
           itemPanel1.Location = new Point((this.Width - itemPanel1.Width) / 2 + 16, (this.Height - itemPanel1.Height)/2);
           usuarioResumen.Location = new Point(this.itemPanel1.Location.X,50);
          
           base.OnResize(e);
        }
      
        private void Menu_Principal_Load(object sender, EventArgs e)
        {

        }

        private void appViewTile_Click(object sender, EventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void btnAbrirServicio_Click(object sender, EventArgs e)
        {
            this.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Right;
            this.IsOpen = false;
        }


        private void ribbonTabItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void infoUsuario_Click(object sender, EventArgs e)
        {

        }

        private void usuarioResumen_Click(object sender, EventArgs e)
        {

        }

        void irEntorno() {
            this.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Right;
            this.IsOpen = false;
        }
        private void btnAgregarEmpresa_Click(object sender, EventArgs e)
        {
            this.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Right;
            this.IsOpen = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listCatSolicitudApoyo_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void listCatSectores_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        public List<Alerta> getAlertas()
        {
            return notificaciones;
        }

        private void listCatCasos_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void listCatTipoMembresia_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void listCatTipoEmpresa_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void listCatTarifas_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void metroTileItem2_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void metroTileItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En construccion");
        }

       
        private void imagenUsuario_DoubleClick(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void listTipoActividad_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void listAdmPantallaGerencial_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void listAgrupaciones_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void listCatComunicacion_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void btnComunicacion_Click(object sender, EventArgs e)
        {

        }

        private void btnCatalogos_Click(object sender, EventArgs e)
        {
            if (listaCatalogos.Visible == true)
            {
                this.listaCatalogos.Visible = false;
            }
            else
            {
                if (sender is DevComponents.DotNetBar.Metro.MetroTileItem)
                {
                    Point listaLocation=((DevComponents.DotNetBar.Metro.MetroTileItem)sender).DisplayRectangle.Location;
                    Point newLocation=new Point(listaLocation.X,listaLocation.Y+50);
                    this.listaCatalogos.Location = newLocation;
                }
                this.listaCatalogos.Visible = true;
            }
        }

        private void listCatFacultad_Click(object sender, EventArgs e)
        {
            irEntorno();
            
        }

        private void listCatEdificios_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void listCatDocentes_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void listCatPeriodos_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void listCatAsignaturaCategorias_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void listCatAsignaturas_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void btnCrearSerie_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void btnVerCalendario_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void listCatAulaEstados_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void listCatAulaTipos_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void listCatAulas_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void listCatAlertaEstados_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void listCatEquipos_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void bubbleBar1_ButtonClick(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {

        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {

        }

        private void labelItem5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lbCantidadNotificaciones_Click(object sender, EventArgs e)
        {

        }

        private void lbCantidadNotificaciones_Click_1(object sender, EventArgs e)
        {
            irEntorno();
        }
        String msg = "";
        private void timer1_Tick(object sender, EventArgs e)
        {
            msg = "";
            List<Alerta> not = null ;
            int cant=0;
            try
            {
                notificaciones = db.getAlertas(usuario.Cod_Usua);
                not = notificaciones.FindAll(valor => valor.Realizada == false || valor.Realizada.Equals(null));
                cant= not.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede obtener notificaciones");
            }
            if (cant != 0)
            {
                this.lbCantidadNotificaciones.Visible = true;
                this.lbCantidadNotificaciones.Text = cant.ToString();
                int indice = 0;
                foreach (Alerta a in not)
                {
                    if(a.Descripcion.ToString().Length<50)
                        msg += ++indice+"."+ a.Descripcion.Substring(0, a.Descripcion.Length) + "\n";
                    else
                        msg += ++indice+"."+a.Descripcion.Substring(0, 50) + "...\n";
                }
                balloonTip1.SetBalloonText(this.lbCantidadNotificaciones, msg);
            }
            else
            {
                this.lbCantidadNotificaciones.Visible = false;
            }

        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            this.listaAdministrador.Visible = !this.listaAdministrador.Visible;
        }

        private void listAdmSync_Click(object sender, EventArgs e)
        {
            SyncAsignacionesClass a = new SyncAsignacionesClass();
            a.ShowDialog();
        }
    }
}
