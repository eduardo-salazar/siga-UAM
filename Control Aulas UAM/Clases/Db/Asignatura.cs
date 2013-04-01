using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Aulas_UAM.Clases.Db
{
    public class Asignatura
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private String referencia;

        public String Referencia
        {
            get { return referencia; }
            set { referencia = value; setNombreCompleto(); }
        }
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; setNombreCompleto(); }
        }
        
        private int idFacultad;

        public int IdFacultad
        {
            get { return idFacultad; }
            set { idFacultad = value; }
        }
        private String facultad;

        public String Facultad
        {
            get { return facultad; }
            set { facultad = value; }
        }
        private int idCategoria;

        public int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }
        private String categoria;

        public String Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        private String carrera;

        public String Carrera
        {
            get { return carrera; }
            set { carrera = value; setNombreCompleto(); }
        }
        private String nombreCompleto;
        public String NombreCompleto { get { return nombreCompleto; } }

        private void setNombreCompleto() {
            nombreCompleto = nombre;
            if (this.Carrera != null)
            {
                nombreCompleto += " - " + this.carrera;
            }
            if (this.Referencia != null) {
                nombreCompleto += this.Referencia;
            }
        }
    }
}
