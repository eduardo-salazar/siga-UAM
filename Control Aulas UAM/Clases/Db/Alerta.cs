using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Aulas_UAM.Clases.Db
{
    public class Alerta
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int idAula;

        public int IdAula
        {
            get { return idAula; }
            set { idAula = value; }
        }
        private Aula aula;

        public Aula Aula
        {
            get { return aula; }
            set { aula = value; }
        }
        private String descripcion;

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private DateTime fechaEvento;

        public DateTime FechaEvento
        {
            get { return fechaEvento; }
            set { fechaEvento = value; }
        }
        private DateTime fechaRecordatorio;

        public DateTime FechaRecordatorio
        {
            get { return fechaRecordatorio; }
            set { fechaRecordatorio = value; }
        }
        private String observaciones;

        public String Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }
        private int idAlertaEstado;

        public int IdAlertaEstado
        {
            get { return idAlertaEstado; }
            set { idAlertaEstado = value; }
        }
        private String descripcionEstado;

        public String DescripcionEstado
        {
            get { return descripcionEstado; }
            set { descripcionEstado = value; }
        }
        private int idUsuario;

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        private int usuarioEmisor;

        public int UsuarioEmisor
        {
            get { return usuarioEmisor; }
            set { usuarioEmisor = value; }
        }
        private int usuarioDestinatario;

        public int UsuarioDestinatario
        {
            get { return usuarioDestinatario; }
            set { usuarioDestinatario = value; }
        }

        private bool realizada;

        public bool Realizada
        {
            get { return realizada; }
            set { realizada = value; }
        }

    }
}
