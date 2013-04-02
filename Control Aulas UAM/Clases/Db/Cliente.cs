using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control_Aulas_UAM.Clases.Db
{
    public class Cliente
    {
        private int id;
        private string nombre;
        private string area;
        private bool isDocente;

        public int Id { get { return id; } set { id = value; } }
        public String Nombre { get { return nombre; } set { nombre = value; setNombreCompleto(); } }
        public String Area { get { return area; } set { area = value; setNombreCompleto(); } }
        public bool IsDocente { get { return isDocente; } set { isDocente = value; } }

        private String nombreCompleto;
        public String NombreCompleto { get { return nombreCompleto; } }

        private void setNombreCompleto() {
            nombreCompleto = nombre;
            if (area != null?area.Length>0:false) {
                nombreCompleto += " - " + area;
            }
        }
    }
}
