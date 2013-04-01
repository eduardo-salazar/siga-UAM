using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Control_Aulas_UAM
{
    public interface Funciones 
    {
        void Nuevo();
        void Imprimir();
        bool Guardar();
        void Cancelar();
        void Editar();
        void Borrar();
        void IrPrimero();
        void Anterior();
        void Siguiente();
        void IrFinal();
        bool vacio();
        void Reportes();
        void RealizarPago();
        void Filtrar();

    }
}
