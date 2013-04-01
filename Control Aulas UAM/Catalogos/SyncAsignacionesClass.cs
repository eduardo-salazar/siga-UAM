using Control_Aulas_UAM.Clases;
using Control_Aulas_UAM.Clases.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control_Aulas_UAM.Catalogos
{
    public partial class SyncAsignacionesClass : Form
    {
        List<AsignacionClass> asignaciones;
        Conexion db = new Conexion();
        public SyncAsignacionesClass()
        {
            InitializeComponent();
            cargarGrid();
        }

        public void cargarGrid() 
        {
            asignaciones = db.getAsignacionesClass();
            this.dgAsignacionesClass.DataSource = asignaciones;
            this.lbCantidadAsignaciones.Text = asignaciones.Count.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSync_Click(object sender, EventArgs e)
        {
           db.insertPendingTeachers();
           String serieTemp="";
           int serieID=0;
           foreach(AsignacionClass a in asignaciones)
           {
               AsignacionClase asignacion = new AsignacionClase();
               Serie serie = new Serie();
               if (!serieTemp.Equals(a.Serie()))
               {
                   //insertar serie                   
                   serie.Descripcion = a.Serie();
                   db.insertSerie(ref serie);
                   serieID = Convert.ToInt32(db.LastUpdated);//obtener id serie insertada
                   serieTemp = a.Serie();
               }
               serie.ID = serieID;//asignar id seria al objeto serie
               asignacion.Serie = serie;//asignar objeto seria a la asignacion

               //Asignar id aula a la asignacion
               Aula au = new Aula();
               au.Id = a.AulaID;
               asignacion.Aula = au;

               //Asignar el codigo de grupo
               //buscar el id en la tabla grupo en base a la serie
               Grupo g = new Grupo();
               g.Id = db.getIdFromGrupo(a.Serie());
               asignacion.Grupo = g;
               //Asignar inicio y fin
               string hora24=DateTime.Parse(a.HoraInicio).ToString("HH:mm", CultureInfo.CurrentCulture);
               DateTime inicio = a.FechaInicio.Add(TimeSpan.Parse(hora24));

               switch (a.Dia)
               {
                   case "LUNES": inicio=inicio.AddDays(-(inicio.DayOfWeek - DayOfWeek.Monday)); break;
                    case "MARTES": inicio=inicio.AddDays(-(inicio.DayOfWeek - DayOfWeek.Tuesday)); break;
                    case "MIERCOLES": inicio=inicio.AddDays(-(inicio.DayOfWeek - DayOfWeek.Wednesday) ); break;
                    case "JUEVES": inicio=inicio.AddDays(-(inicio.DayOfWeek - DayOfWeek.Thursday)); break;
                    case "VIERNES": inicio=inicio.AddDays(-(inicio.DayOfWeek - DayOfWeek.Friday)); break;
                    case "SABADO": inicio=inicio.AddDays(-(inicio.DayOfWeek - DayOfWeek.Saturday)); break;
                    case "DOMINGO": inicio=inicio.AddDays(-(inicio.DayOfWeek - DayOfWeek.Sunday)); break;
               }
               asignacion.Inicio = inicio;
               string hora242 = DateTime.Parse(a.HoraFin).ToString("HH:mm", CultureInfo.CurrentCulture);
               asignacion.Fin = asignacion.Inicio.Add(-TimeSpan.Parse(hora24));
               asignacion.Fin = asignacion.Fin.Add(TimeSpan.Parse(hora242));

               //reprogramada
               asignacion.Reprogramada = false;
               Asignacion fin = asignacion;
               while (asignacion.Inicio <= a.FechaFin)
               {
                   db.insertAsignacion(ref fin);
                   asignacion.Inicio = asignacion.Inicio.AddDays(7);
                   asignacion.Fin = asignacion.Fin.AddDays(7);
               }
              
               
           }
        }
    }
}
