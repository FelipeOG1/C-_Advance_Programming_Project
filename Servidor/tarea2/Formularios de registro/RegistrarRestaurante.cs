using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tarea2
{
    public partial class RegistrarRestaurante : Form
    {

      

        public RegistrarRestaurante()
        {
            InitializeComponent();
           
            comboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;





        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LogicaConexion datos = new LogicaConexion();

            // Verificar si los campos están completos
            if (string.IsNullOrWhiteSpace(textBoxID.Text) || string.IsNullOrWhiteSpace(textBoxNombre.Text) || string.IsNullOrWhiteSpace(textBoxDireccion.Text) || string.IsNullOrWhiteSpace(textBoxTelefono.Text) || comboBoxEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detener la ejecución del evento
            }

            int id = int.Parse(textBoxID.Text);
            string direccion = textBoxDireccion.Text;
            string nombre = textBoxNombre.Text;
            string telefono = textBoxTelefono.Text;
            bool estado = comboBoxEstado.SelectedIndex == 0; // Si el índice es 0, estado será true, de lo contrario, será false

            // Crear una instancia del objeto Restaurante
            Restaurante restaurante = new Restaurante();

            // Establecer los valores de las propiedades
            restaurante.IdRestaurante = id;
            restaurante.NombreRestaurante = nombre;
            restaurante.Direccion = direccion;
            restaurante.Estado = estado;
            restaurante.Telefono = telefono;

            // Verificar si el restaurante ya existe en la base de datos
            if (datos.ExisteRestaurante(id))
            {
                MessageBox.Show("El ID de este restaurante ya está registrado.", "ID duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Agregar el restaurante a la base de datos
                datos.AgregarRestaurante(restaurante);

                MessageBox.Show("Restaurante registrado con éxito.");
            }










        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten digitos");
                e.Handled = true; // Bloquear la entrada del carácter
                System.Media.SystemSounds.Exclamation.Play(); // Reproducir sonido de error
            }
        }

        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten digitos");
                e.Handled = true; // Bloquear la entrada del carácter
                System.Media.SystemSounds.Exclamation.Play(); // Reproducir sonido de error
            }
        }
    }
}
