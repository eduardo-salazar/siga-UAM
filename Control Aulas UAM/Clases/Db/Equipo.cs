﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Aulas_UAM.Clases.Db
{
    public class Equipo
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
        private String observacion;

        public String Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }
    }
}