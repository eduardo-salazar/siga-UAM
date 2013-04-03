using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Control_Aulas_UAM.Clases.Db;
using Control_Aulas_UAM.Clases;

namespace Control_Aulas_UAM
{
    public partial class ControlNotificar : UserControl
    {
        private Aula aula;
        private Usuario usuario;
        private Usuario destino;
        private DateTime inicio, fin;

        //Notificaciones
        List<AlertaEstado> alertaEstado;
        List<Usuario> usuarios;

        Conexion db ;

        public ControlNotificar()
        {
            InitializeComponent();
            //combos de notificacion
            try
            {
                db = new Conexion();
                alertaEstado = db.getAlertaEstado();
                this.cbAlertaEstado.DataSource = alertaEstado;
                this.cbAlertaEstado.DisplayMember = "Descripcion";
                this.cbAlertaEstado.ValueMember = "Id";

                usuarios = db.getUsuario();
                this.cbDestinatario.DataSource = usuarios;
                this.cbDestinatario.DisplayMember = "Nombre";
                this.cbDestinatario.ValueMember = "Cod_Usua";
            }
            catch (Exception e) { 
            
            }
        }
        public ControlNotificar(Aula a,Usuario user) {
            aula = a;
            usuario = user;
        }
        public Aula Aula
        {
            set { aula = value; }
        }
        public DateTime Inicio
        {
            set { inicio = value; this.dateTimeFecha.Value = value; }
        }
        public DateTime Fin
        {
            set { fin = value; this.dateTimeRecordatorio.Value = value; }
        }
        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private void btnNotificar_Click(object sender, EventArgs e)
        {

        }

        private void dateTimeFecha_Click(object sender, EventArgs e)
        {

        }
        private Boolean guardarNotificacion()
        {
            //obtner inputs
            int id_aula = aula.Id;
            String descripcion = this.NotDescripcion.Text;
            DateTime fecha_evento = Convert.ToDateTime(this.dateTimeFecha.Text);
            DateTime fecha_recordatorio = Convert.ToDateTime(this.dateTimeRecordatorio.Text);
            String observaciones = this.NotObservacion.Text;
            int id_alerta_estado = Convert.ToInt32(this.cbAlertaEstado.SelectedValue);
            int usuario_emisor = this.usuario.Cod_Usua;
            int usuario_destinatario = Convert.ToInt32(this.cbDestinatario.SelectedValue);

            Alerta alerta = new Alerta();
            alerta.IdAula = id_aula;
            alerta.Aula = aula;
            alerta.Descripcion = descripcion;
            alerta.FechaEvento = fecha_evento;
            alerta.FechaRecordatorio = fecha_recordatorio;
            alerta.Observaciones = observaciones;
            alerta.IdAlertaEstado = id_alerta_estado;
            alerta.UsuarioEmisor = usuario_emisor;
            alerta.UsuarioDestinatario = usuario_destinatario;
            alerta.DescripcionEstado = this.cbAlertaEstado.Text;
            try
            {
                db.insertAlerta(alerta);
                destino = this.usuarios.Find(o=>o.Cod_Usua==usuario_destinatario);
                Email.send(usuario,destino, alerta);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }

        private void btnNotificar_Click_1(object sender, EventArgs e)
        {
            if (guardarNotificacion())
            {
                MessageBox.Show("Se ha registrado su notificaciones. Se ha enviado una email con la informacón de la reservación al correo "+destino.Email+" con copia a su correo " + this.usuario.Email);
                 this.Dispose();
            }
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dateTimeRecordatorio_TextChanged(object sender, EventArgs e)
        {
            //DateTime val1=this.dateTimeFecha.Value;
            //DateTime val2=this.dateTimeRecordatorio.Value;
            //int resp=val2.CompareTo(val1);
            //if (resp<0)
            //{
            //    MessageBox.Show("La fecha de find debe ser mayor a la de inicio ");
            //}
        }

        private void dateTimeRecordatorio_Click(object sender, EventArgs e)
        {

        }
    }
}
