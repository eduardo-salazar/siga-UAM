using Control_Aulas_UAM.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Aulas_UAM
{
    public partial class EditarSerieForm : Form
    {
        public enum Option { CurrentEvent, NextEvents, AllEvents };
        List<Asignacion> asignacionesSeleccionadas;
        Asignacion current;

        public EditarSerieForm()
        {
            InitializeComponent();
        }

        public Option getSelectedOption() { 
            Option opcion;
            if (radioButtonCurrentEvent.Checked)
                opcion = Option.CurrentEvent;
            else if (radioButtonNextEvents.Checked)
                opcion=Option.NextEvents;
            else
                opcion=Option.AllEvents;
            return opcion;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            handleAsignacionesSeleccionadas();
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        public void setAsignaciones(List<Asignacion> asignaciones) {
            dataGridViewAsignaciones.AutoGenerateColumns = false;
            dataGridViewAsignaciones.DataSource = asignaciones;
        }

        void handleColumnCheck() {
            if (radioButtonSelectedEvents.Checked)
                ColumnCheck.ReadOnly = false;
            else
                ColumnCheck.ReadOnly = true;
        }

        private void radioButtonCurrentEvent_CheckedChanged(object sender, EventArgs e)
        {
            handleColumnCheck();
            List<Asignacion> asignaciones = (List<Asignacion>)dataGridViewAsignaciones.DataSource;
            for (int i = 0; i < dataGridViewAsignaciones.Rows.Count; i++)
            {
                dataGridViewAsignaciones["ColumnCheck", i].Value = false ;
            }
            dataGridViewAsignaciones["ColumnCheck", asignaciones.FindIndex(element => element.ID == current.ID)].Value = true;
        }

        private void radioButtonNextEvents_CheckedChanged(object sender, EventArgs e)
        {
            handleColumnCheck();
            List<Asignacion> asignaciones = (List<Asignacion>)dataGridViewAsignaciones.DataSource;
            for (int i = 0; i < dataGridViewAsignaciones.Rows.Count; i++)
            {
                if ((DateTime)dataGridViewAsignaciones["ColumnInicio", i].Value > current.Fin)
                {
                    dataGridViewAsignaciones["ColumnCheck", i].Value = true;
                }
                else {
                    dataGridViewAsignaciones["ColumnCheck", i].Value = false;
                }
            }
            dataGridViewAsignaciones["ColumnCheck", asignaciones.FindIndex(element => element.ID == current.ID)].Value = true;
        }

        private void radioButtonAllEvents_CheckedChanged(object sender, EventArgs e)
        {
            handleColumnCheck();
            for (int i = 0; i < dataGridViewAsignaciones.Rows.Count; i++)
            {
                dataGridViewAsignaciones["ColumnCheck", i].Value = true;    
            }
        }

        private void radioButtonSelectedEvents_CheckedChanged(object sender, EventArgs e)
        {
            handleColumnCheck();
        }

        public void setCurrentAsignacion(Asignacion asignacion) {
            current = asignacion;
        }

        void handleAsignacionesSeleccionadas()
        {
            asignacionesSeleccionadas = new List<Asignacion>();
            for (int i = 0; i < dataGridViewAsignaciones.Rows.Count; i++)
            {
                if ((bool)dataGridViewAsignaciones["ColumnCheck", i].Value)
                {
                    List<Asignacion> asignacionesFiltradas = (List<Asignacion>)dataGridViewAsignaciones.DataSource;
                    asignacionesSeleccionadas.Add(asignacionesFiltradas[i]);
                }
            }
            if (asignacionesSeleccionadas.Count == 0)
                asignacionesSeleccionadas = null;
        }

        public List<Asignacion> getAsignacionesSeleccionadas() {
            return asignacionesSeleccionadas;
        }
    }
}
