using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea2
{
    public partial class ConsultarExtras : Form
    {

        public ConsultarExtras()
        {
            InitializeComponent();
            LogicaConexion datos = new LogicaConexion();
            List<Extras> listaExtras = datos.ConsultarExtra();
            dataGridViewExtras.ReadOnly = true;
            dataGridViewExtras.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewExtras.DataSource = listaExtras;



        }
    }
}
