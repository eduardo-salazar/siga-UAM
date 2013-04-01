using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Aulas_UAM.Clases.Db
{
    public class Grupo
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int grupo;
        public int NumeroGrupo
        {
            get { return grupo; }
            set { grupo = value; }
        }
        private Asignatura asignatura;

        public Asignatura Asignatura
        {
            get { return asignatura; }
            set { asignatura = value; }
        }
                       
        private Docente docente;

        public Docente Docente
        {
            get { return docente; }
            set { docente = value; }
        }
        public String NombreDocente
        {
            get { return docente.Nombre; }
        }
        private Periodo periodo;

        public Periodo Periodo
        {
            get { return periodo; }
            set { periodo = value; }
        }
        public String NombrePeriodo
        {
            get { return periodo.Descripcion; }
        }
        private int cantidadEstudiantes;

        public int CantidadEstudiantes
        {
            get { return cantidadEstudiantes; }
            set { cantidadEstudiantes = value; }
        }
        
        
    }
}
