using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.Schedule.Model;
using Control_Aulas_UAM.Clases.Db;
using Control_Aulas_UAM.Clases;

namespace Control_Aulas_UAM.Catalogos
{
    public partial class NotificacionForm : UserControl
    {
        List<Alerta> notificaciones;
        String rangoMin="";
        String rangoMax="";
        //verifica si se esta intentando limpiar los datetime del filtro
        //true significa que se deben verificar los rangos
        //false significa que no se deben verificar los rangos
        bool band = true;
        public NotificacionForm(List<Alerta> alertas)
        {
            InitializeComponent();
            this.notificacionesView.TimeLineStretchRowHeight = true;
            notificaciones = alertas;
            this.notificacionesView.Click+=notificacionesView_Click;
            //Agregar opciones al combobox filtrar
            this.cbFiltrar.Items.Add("Pendiente");
            this.cbFiltrar.Items.Add("Realizados");
            this.cbFiltrar.Items.Add("Todos");
            this.cbFiltrar.SelectedIndex = 0;
            this.cbFiltrar.SelectedIndexChanged += cbFiltrar_SelectedIndexChanged;
            this.dtDesde.ValueChanged += dtDesde_ValueChanged;
            this.dtHasta.ValueChanged += dtHasta_ValueChanged;
            this.NotificacionPanel.Expanded = false;
            //Llenar Notificaciones
            llenarNotificaciones();

        }
        bool checkDates()
        {
            if (!this.dtHasta.IsEmpty && band)
            {
                if (this.dtDesde.Value.Date > this.dtHasta.Value.Date || this.dtDesde.IsEmpty)
                {
                    MessageBox.Show("Verificar rango de Fecha. El valor de la fecha \"Desde\" debe ser menor  o este no puede estar Vacío", "Error", MessageBoxButtons.OK);
                    return false;
                }
                if (this.dtDesde.Value.Date < this.dtHasta.Value.Date)
                {
                    this.rangoMin = this.dtDesde.Value.ToShortDateString();
                    this.rangoMax = this.dtHasta.Value.ToShortDateString();
                    return true;
                }
            }
            return false;
        }

        void dtHasta_ValueChanged(object sender, EventArgs e)
        {
            if (checkDates())
            {
                llenarNotificaciones();
            }
            band = true;
        }

        void dtDesde_ValueChanged(object sender, EventArgs e)
        {
            if (checkDates())
            {
                llenarNotificaciones();
            }
            band = true;
        }

        void cbFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.llenarNotificaciones();
        }
        String lastAlert="";
        void notificacionesView_Click(Object sender, EventArgs e)
        {
            if (this.notificacionesView.SelectedAppointments.Count!=0)
            {
                int id=this.notificacionesView.SelectedAppointments[0].Appointment.Id;
                if (!lastAlert.Equals(id.ToString()))
                {
                    //Mostrar alerta en el panel
                    this.NotificacionPanel.Visible = true;
                    Alerta temp = notificaciones.Find(alert => alert.Id == id);
                    this.dateTimeFecha.Text = temp.FechaEvento.ToString();
                    this.NotDescripcion.Text = temp.Descripcion;
                    this.NotObservacion.Text = temp.Observaciones;
                    if (this.cbAlertaEstado.Items.Count!=0)
                    {
                        this.cbAlertaEstado.Items.RemoveAt(0); 
                    }
                    this.cbAlertaEstado.Items.Add(temp.DescripcionEstado);
                    this.cbAlertaEstado.SelectedItem = this.cbAlertaEstado.Items[0];
                    this.NotificacionPanel.Expanded = true;
                    lastAlert = id.ToString();
                }
                else
                {
                    this.NotificacionPanel.Expanded = false;
                    this.NotificacionPanel.Visible = false;
                    lastAlert = "";
                }
            }
        }
        private void llenarNotificaciones()
        {
            CalendarModel modelo = new CalendarModel();

            int cont = 0;//inicion del tiempo del calendario
            int salto = 10;//Salto es de 10 segundo

            int verificar = 60 /salto;//salto en el que la hora cambia
            int temp = 0;

            List<Alerta> alertas;
            if (this.cbFiltrar.SelectedIndex == 0)
                alertas = notificaciones.FindAll(valor => valor.Realizada == false || valor.Realizada.Equals(null));
            else
            {
                if (this.cbFiltrar.SelectedIndex == 1)
                    alertas = notificaciones.FindAll(valor => valor.Realizada == true);
                else
                    alertas = notificaciones;
            }
            //filtrar por fechas
            if (!rangoMin.Equals("") || !rangoMax.Equals(""))
            {
                alertas = alertas.FindAll(valor => valor.FechaEvento >= DateTime.Parse(rangoMin) && valor.FechaEvento <= DateTime.Parse(rangoMax));
            }
            foreach (Alerta a in alertas)
            {
                
                Appointment app = new Appointment();
                Appointment header=new Appointment();
                String mensaje = "<font color=\"Blue\">" + a.FechaEvento + "</font><br />" +
                "<font color=\"Green\">" + a.Descripcion + "</font><br />";
                app.DisplayTemplate = "<font color=\"Blue\">" + a.FechaEvento.ToString("dddd, dd MMMM yyyy hh:mm tt") + "</font>";
                if (temp == 4)
                    cont++;
                app.StartTime = DateTime.Parse(Convert.ToString(cont)+":"+salto*temp);                
                temp++;
                app.Id = a.Id;
                app.EndTime = app.StartTime.AddMinutes(salto);
                app.CategoryColor = Appointment.CategoryYellow;
                app.Locked = true;

                //appointemt que muestra la referencia de la clase
                header.StartTime = app.StartTime;
                header.StartTime=header.StartTime;
                header.Id = a.Id;
                header.EndTime = header.StartTime.AddMinutes(salto);
                header.CategoryColor = Appointment.CategoryYellow;
                header.DisplayTemplate="<font size=\"18\" width=\"5\">" + a.Aula.Referencia +
                "</font>";
                if (a.Realizada)
                    header.ImageKey = "up.png";
                else
                    header.ImageKey = "down.png";
                header.ImageAlign = eImageContentAlignment.MiddleLeft;
                header.Locked = true;
                modelo.Appointments.Add(header);

                modelo.Appointments.Add(app);

                Appointment tempo = new Appointment();
                tempo.StartTime = app.StartTime;
                tempo.StartTime = header.StartTime;
                tempo.Id = a.Id;
                tempo.EndTime = header.StartTime.AddMinutes(salto);
                tempo.CategoryColor = Appointment.CategoryYellow;
                tempo.DisplayTemplate = "<font color=\"Green\">" + a.Descripcion + "</font><br />";
                tempo.Locked = true;
                modelo.Appointments.Add(tempo);
              
            }
            this.notificacionesView.CalendarModel = modelo;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNotificar_Click(object sender, EventArgs e)
        {
            Conexion db = new Conexion();
            int id=this.notificacionesView.SelectedAppointments[0].Appointment.Id;
            Alerta a = notificaciones.Find(valor => valor.Id == id);
            a.Realizada = !a.Realizada;
            db.actualizarAlerta(a);
            llenarNotificaciones();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.rangoMin = "";
            this.rangoMax = "";
            band = false;//para que se dalte la verificacion al cambiar los valores de los controles
            this.dtHasta.ResetValue();
            this.dtDesde.ResetValue();
            llenarNotificaciones();
        }
    }
}
