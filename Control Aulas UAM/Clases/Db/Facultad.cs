using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Aulas_UAM.Clases
{
    public class Facultad
    {
        private int id;

        public int Id
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
        private Color color;

        public Color Color
        {
            get { return color; }
            set { color = value; }
        }


    }
}
