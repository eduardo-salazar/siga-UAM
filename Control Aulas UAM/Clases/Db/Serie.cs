using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control_Aulas_UAM.Clases.Db
{
    public class Serie
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private String descripcion;

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
