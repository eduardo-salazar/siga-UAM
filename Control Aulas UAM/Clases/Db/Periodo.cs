using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Aulas_UAM.Clases.Db
{
    public class Periodo
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private DateTime fechaInicio;

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }
        private DateTime fechaFin;

        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }
        private String descripcion;

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }


    }
}
