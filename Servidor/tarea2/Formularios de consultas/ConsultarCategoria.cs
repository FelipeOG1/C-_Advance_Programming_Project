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
    public partial class ConsultarCategoria : Form
    {

        public ConsultarCategoria()
        {
            InitializeComponent();
            LogicaConexion datos = new LogicaConexion();
            List<CategoriaPlatos> listaCategorias = datos.ConsultarCategoriaPlato();
            dataGridViewCategorias.ReadOnly = true;
            dataGridViewCategorias.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewCategorias.DataSource = listaCategorias;




        }


    }
}
