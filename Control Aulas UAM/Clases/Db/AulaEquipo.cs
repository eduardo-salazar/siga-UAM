using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Aulas_UAM.Clases.Db
{
    public class AulaEquipo
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int idEquipo;

        public int IdEquipo
        {
            get { return idEquipo; }
            set { idEquipo = value; }
        }
        private String descripcionEquipo;

        public String DescripcionEquipo
        {
            get { return descripcionEquipo; }
            set { descripcionEquipo = value; }
        }
        private String observacionEquipo;

        public String ObservacionEquipo
        {
            get { return observacionEquipo; }
            set { observacionEquipo = value; }
        }
        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        private String observaciones;

        public String Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }
    }
}
