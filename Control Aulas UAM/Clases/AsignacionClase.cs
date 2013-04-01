using Control_Aulas_UAM.Clases.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Aulas_UAM.Clases
{
    public class AsignacionClase:Asignacion
    {
        public Grupo Grupo { get; set; }

        public bool Reprogramada { get; set; }
    }
}
