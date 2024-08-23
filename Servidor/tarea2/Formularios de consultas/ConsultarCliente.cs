using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea2
{

    public partial class ConsultarCliente : Form
    {

        public ConsultarCliente()
        {
            InitializeComponent();
            LogicaConexion datos = new LogicaConexion();
            List<Cliente> listaClientes = datos.ConsultarCliente();
            dataGridViewClientes.ReadOnly = true;
            dataGridViewClientes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewClientes.DataSource = listaClientes;



        }
    }
}
