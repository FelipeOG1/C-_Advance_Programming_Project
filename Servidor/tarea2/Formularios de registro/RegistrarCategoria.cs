using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;
using Microsoft.Data.SqlClient;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tarea2
{
    public partial class RegistrarCategoria : Form
    {
        private int[] idsCategoria;
        private CategoriaPlatos[] categorias;
        private int cuenta;

        public RegistrarCategoria()
        {
            InitializeComponent();
            comboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            LogicaConexion datos= new LogicaConexion();
            if (string.IsNullOrWhiteSpace(textBoxId.Text) || string.IsNullOrWhiteSpace(textBoxDescripcion.Text) || comboBoxEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detener la ejecución del evento
            }
            int id = int.Parse(textBoxId.Text);
            string descripcion = textBoxDescripcion.Text;
            bool estado = false;
            if (comboBoxEstado.SelectedIndex == 0)
            {
                estado = true;
            }
            else if (comboBoxEstado.SelectedIndex == 1)
            {
                estado = false;
            }
            if (datos.ExisteCategoriaPlato(id))
            {
                MessageBox.Show("El ID de esta categoria de plato ya está registrado.", "ID duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

               
                CategoriaPlatos categoria = new CategoriaPlatos(id, descripcion, estado);
                datos.AgregarCategoriaPlato(categoria);
                MessageBox.Show("Categoria de plato registrada con exito");


               
                
                

            }

           
        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten digitos.");
                e.Handled = true; // Bloquear la entrada del carácter
                System.Media.SystemSounds.Exclamation.Play(); // Reproducir sonido de error
            }
        }

        
    }


}

