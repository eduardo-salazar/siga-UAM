using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Aulas_UAM.Clases
{
    public class PeriodoTiempo
    {
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        private static String[] diasDeLaSemana = { "Domingo", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado" };
        

        public PeriodoTiempo() {}

        public PeriodoTiempo(DateTime inicio, DateTime fin) {
            Inicio = inicio;
            Fin = fin;
        }

        public String Dia
        {
            get { return GetDia(Inicio); }
        }

        public static String GetDia(DateTime fecha) {
            return diasDeLaSemana[(int)fecha.DayOfWeek];
        }

        public String Duracion
        {
            get
            {
                return GetDuracion(Inicio,Fin);
            }
        }

        public static String GetDuracion(DateTime inicio, DateTime fin) {
            TimeSpan offset = fin.Subtract(inicio);
            String duracion = "";
            if (offset.Days > 0)
                duracion += offset.Days + " dias ";
            if (offset.Hours > 0)
                duracion += offset.Hours + " horas ";
            if (offset.Minutes > 0)
                duracion += " " + offset.Minutes + " minutos ";
            return duracion;
        }
    }
}
