using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control_Aulas_UAM.Clases.Db
{
    public class AsignacionClass
    {
        private String horaInicio;

        public String HoraInicio
        {
            get { return horaInicio; }
            set { horaInicio = value; }
        }
        private String horaFin;

        public String HoraFin
        {
            get { return horaFin; }
            set { horaFin = value; }
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
        private String dia;

        public String Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        private String serie;
        public AsignacionClass(String serie)
        {
            this.serie = serie;
            String[] valores;

            valores = serie.Split('_');
            //asignar los valores
            this.Ano = Convert.ToInt32(valores[0]);
            this.Periodo = Convert.ToInt32(valores[1]);
            this.Nivel = valores[2];
            this.Asignatura = valores[3];
            this.Aula = valores[4];
            this.Grupo = Convert.ToInt32(valores[5]);
            this.dias = valores[6].Replace("(","").Replace(")","");
            this.Docente = valores[7];

        }
        private int aulaID;

        public int AulaID
        {
            get { return aulaID; }
            set { aulaID = value; }
        }
        public String Serie()
        {
            return serie;
        }
        private int ano;

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }
        private int periodo;

        public int Periodo
        {
            get { return periodo; }
            set { periodo = value; }
        }
        private String nivel;

        public String Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }
        private String asignatura;

        public String Asignatura
        {
            get { return asignatura; }
            set { asignatura = value; }
        }
        private String aula;
        public int cantDias()
        {
            return this.Dias.Split('-').Length;
        }
        public String Aula
        {
            get { return aula; }
            set { aula = value; }
        }
        private int grupo;

        public int Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }
        private String dias;

        public String Dias
        {
            get { return dias; }
            set { dias = value; }
        }
        private String docente;

        public String Docente
        {
            get { return docente; }
            set { docente = value; }
        }

        
    }
}
