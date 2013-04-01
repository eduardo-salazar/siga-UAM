using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Aulas_UAM.Clases.Db
{
    public class Aula
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int idTipo;

        public int IdTipo
        {
            get { return idTipo; }
            set { idTipo = value; }
        }
        private String nombreTipo;

        public String NombreTipo
        {
            get { return nombreTipo; }
            set { nombreTipo = value; }
        }
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private int capacidad;

        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }
        private int idEdificio;

        public int IdEdificio
        {
            get { return idEdificio; }
            set { idEdificio = value; }
        }
        private String nombreEdificio;

        public String NombreEdificio
        {
            get { return nombreEdificio; }
            set { nombreEdificio = value; }
        }
        private int piso;

        public int Piso
        {
            get { return piso; }
            set { piso = value; }
        }
        private int idEstado;

        public int IdEstado
        {
            get { return idEstado; }
            set { idEstado = value; }
        }
        private String nombreEstado;

        public String NombreEstado
        {
            get { return nombreEstado; }
            set { nombreEstado = value; }
        }
        private String referencia;

        public String Referencia
        {
            get { return referencia; }
            set { referencia = value; }
        }

    }
}
