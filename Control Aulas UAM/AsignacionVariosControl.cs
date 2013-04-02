using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_Aulas_UAM.Clases;
using Control_Aulas_UAM.Clases.Db;

namespace Control_Aulas_UAM
{
    public partial class AsignacionVariosControl : UserControl
    {
        Conexion conexion;
        List<Aula> aulas;
        List<Cliente> clientes;
        public List<AulaTipoUso> tipoUso;
        bool readOnly;
        public bool ReadOnly { get { return readOnly; } set { readOnly = value; HandleControls(); } }
        
        public List<Aula> Aulas { get { return aulas; } set { aulas = value; comboBoxLugar.DataSource = aulas; } }
        

        public DateTime Inicio { get { return dateTimeInputInicio.Value; } set { dateTimeInputInicio.Value = value; } }
        public DateTime Fin { get { return dateTimeInputFin.Value; } set { dateTimeInputFin.Value = value; } }
        public Aula Aula { get { return (Aula)comboBoxLugar.SelectedItem; } set { if(value!=null)comboBoxLugar.SelectedItem = aulas.Find(element=>element.Id==value.Id); } }
        public AulaTipoUso TipoUso { get { return (AulaTipoUso)comboBoxTipoUso.SelectedItem; } set { try { comboBoxLugar.SelectedItem = tipoUso.Find(element => element.Id == value.Id); } catch { } } }
        public String Observaciones { get { return textBoxObservaciones.Text; } set { textBoxObservaciones.Text = value; } }
        public Cliente Cliente { get { return (Cliente)comboBoxCliente.SelectedItem; } 
            set {
                if (value != null ? value.Id > 0 : false)
                {
                    comboBoxCliente.SelectedItem = clientes.Find(element => element.Id == value.Id);
                }
                else
                    comboBoxCliente.SelectedIndex = 0;
            } 
        }

        public AsignacionVariosControl()
        {
            InitializeComponent();
            try
            {
                conexion = new Conexion();
                aulas = conexion.getAulas();
                comboBoxLugar.DisplayMember = "Referencia";
                tipoUso = conexion.getAulaTipoUso();
                comboBoxTipoUso.DataSource = tipoUso;
                comboBoxTipoUso.DisplayMember = "descripcion";
                comboBoxTipoUso.SelectedIndex = 0;
                clientes = new List<Cliente>();
                //clientes.Add(new Cliente());
                /*List<Cliente> clientesT=  conexion.getClientes();
                if (clientesT != null) {
                    clientes.AddRange(clientesT);
                }
                comboBoxCliente.DataSource = clientes;
                comboBoxCliente.DisplayMember = "nombre";*/
                loadClientes();
            }
            catch { }
        }

        void loadClientes() {
            Cliente empty = new Cliente();
            clientes = new List<Cliente>();
            clientes.Add(empty);
            List<Cliente> clientesT = conexion.getClientes();
            if (clientesT != null)
            {
                clientes.AddRange(clientesT);
            }
            comboBoxCliente.DataSource = clientes;
            comboBoxCliente.DisplayMember = "NombreCompleto";
        }

        void HandleControls()
        {
            bool enabled = !readOnly;
            dateTimeInputInicio.Enabled = enabled;
            dateTimeInputFin.Enabled = enabled;
            comboBoxTipoUso.Enabled = enabled;
            textBoxObservaciones.Enabled = enabled;
            comboBoxLugar.Enabled = enabled;
        }


        private void dateTimeInput_ValueChanged(object sender, EventArgs e)
        {
            DateTime inicio = dateTimeInputInicio.Value;
            DateTime fin = dateTimeInputFin.Value;
            if (DateTime.Compare(inicio, fin) == -1)
            {
                TimeSpan offset = fin.Subtract(inicio);
                String text = "Duración: ";
                if (offset.Days > 0)
                    text += offset.Days + " dias ";
                if (offset.Hours > 0)
                    text += offset.Hours + " horas ";
                if (offset.Minutes > 0)
                    text += " " + offset.Minutes + " minutos ";
                textBoxDuracion.Text = text;
            }
            else
            {
                textBoxDuracion.Text = "Invalido";
            }
        }

        public void EnableEdit(bool enable)
        {
            dateTimeInputInicio.Enabled = enable;
            dateTimeInputFin.Enabled = enable;
            comboBoxLugar.Enabled = enable;
            comboBoxTipoUso.Enabled = enable;
            textBoxObservaciones.Enabled = enable;
            comboBoxCliente.Enabled = enable;
            if(!enable)
                textBoxObservaciones.Clear();
        }

        public bool ValidateControls()
        {
            return superValidator.Validate();
        }

        private void customValidator_Cliente_Valido_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            /*String text = comboBoxCliente.Text;
            Cliente foundCliente = clientes.Find(element => element.Nombre.Equals(text));
            if (foundCliente != null)
            {
                e.IsValid = true;
            }
            else
            {
                e.IsValid = false;
            }*/
            bool isValid=false;
            Cliente cliente = (Cliente)comboBoxCliente.SelectedItem;
            if (cliente != null)
            {
                isValid = true;
            }
            e.IsValid = isValid;
        }

        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            superValidator.Validate();
        }

        private void comboBoxCliente_Leave(object sender, EventArgs e)
        {
            superValidator.Validate();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = comboBoxCliente.Text;
            showFormCliente(cliente);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)comboBoxCliente.SelectedItem;
            if (cliente==null) {
                cliente = new Cliente();
                cliente.Nombre = comboBoxCliente.Text;
            }
            showFormCliente(cliente);
        }

        void showFormCliente(Cliente cliente) {
            FormCliente formCliente = new FormCliente();
            if (cliente != null) {
                formCliente.Cliente = cliente;
            }
            DialogResult result = formCliente.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                cliente = formCliente.Cliente;
                if (cliente != null)
                {
                    bool saved = false;
                    if (cliente.Id > 0)
                    {
                        saved=conexion.actualizarCliente(cliente);
                    }
                    else
                    {
                        saved = conexion.insertCliente(ref cliente);
                    }
                    if (saved) {
                        loadClientes();
                        int index = clientes.FindIndex(element => element.Id == cliente.Id);
                        if (index >= 0 && index < clientes.Count)
                        {
                            comboBoxCliente.SelectedIndex = index;
                        }
                    }
                }
            }
            superValidator.Validate();
        }
    }
}
