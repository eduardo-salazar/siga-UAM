using Control_Aulas_UAM.Clases.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Aulas_UAM.Clases
{
    public class Asignacion
    {
        int id;
        public int ID { get { return id; } set { id = value; } }

        Aula aula;
        public Aula Aula { get { return aula; } set { aula = value; } }

        DateTime inicio;
        public DateTime Inicio { get { return inicio; } set { inicio = value; } }

        DateTime fin;
        public DateTime Fin { get { return fin; } set { fin = value; } }

        Serie serie;
        public Serie Serie { get { return serie; } set { serie = value; } }

        public String Duracion{get{return PeriodoTiempo.GetDuracion(Inicio, Fin);}}

        public String AulaReferencia {
            get
            {
                if (aula != null)
                    return Aula.Referencia;
                else
                    return null;
            } 
        }

        public String SerieDescripcion
        {
            get
            {
                if (serie != null)
                    return serie.Descripcion;
                else
                    return null;
            }
        }

        public String Dia {
            get 
            {
                if (inicio != null)
                    return PeriodoTiempo.GetDia(Inicio);
                else
                    return null;
            }
        }
    }
}
