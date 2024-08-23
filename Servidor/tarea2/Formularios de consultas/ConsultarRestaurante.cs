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
    public partial class ConsultarRestaurante : Form
    {
        
        public ConsultarRestaurante()
        {
            InitializeComponent();
            LogicaConexion datos = new LogicaConexion();
            List<Restaurante> listaRestaurante = datos.ConsultarRestaurante();
            dataGridViewRestaurantes.ReadOnly = true;
            dataGridViewRestaurantes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewRestaurantes.DataSource = listaRestaurante;


        }
    }
}
