using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Aulas_UAM.Clases.Db
{
    public class Docente
    {
        private int id;
        private String nombre;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
