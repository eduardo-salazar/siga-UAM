using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Control_Aulas_UAM.Clases.Db;
using Control_Aulas_UAM.Clases;

namespace Control_Aulas_UAM
{
    public partial class FormCliente : Form
    {
        private Cliente cliente;
        public Cliente Cliente { get { return cliente; } set { cliente = value; handleFields(); } }

        public FormCliente()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (superValidator.Validate())
            {
                if (cliente == null)
                    cliente = new Cliente();
                String nombre = this.textBoxNombre.Text;
                String area = this.textBoxArea.Text;
                if (textBoxId.Text != null ? textBoxId.Text.Length > 0 : false)
                {
                    cliente.Id = Convert.ToInt32(textBoxId.Text);
                }
                cliente.Nombre = nombre;
                cliente.Area = area;
                cliente.IsDocente = false;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Dispose();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Dispose();
        }

        void handleFields()
        {
            if (Cliente != null)
            {
                String nombre = Cliente.Nombre;
                String area = Cliente.Area;
                int id = Cliente.Id;
                if (nombre != null)
                    this.textBoxNombre.Text = nombre;
                if (area != null)
                    this.textBoxArea.Text = Cliente.Area;
                if (id > 0)
                    this.textBoxId.Text = Cliente.Id.ToString();
            }
        }
    }
}
