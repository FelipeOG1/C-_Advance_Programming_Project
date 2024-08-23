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
    public partial class RegistrarPlato : Form
    {

       
        public RegistrarPlato()
        {
            LogicaConexion datos = new LogicaConexion();
            InitializeComponent();
            TablaCategorias.ReadOnly = true;
            TablaCategorias.EditMode = DataGridViewEditMode.EditProgrammatically;
            TablaCategorias.DataSource = datos.ConsultarCategoriaPlato();




        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            LogicaConexion datos = new LogicaConexion();
            if (string.IsNullOrWhiteSpace(textBoxId.Text) || string.IsNullOrWhiteSpace(textBoxNombre.Text) || string.IsNullOrWhiteSpace(textBoxPrecio.Text) || string.IsNullOrWhiteSpace(textBoxIdCategoria.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detener la ejecución del evento
            }


            int id = int.Parse(textBoxId.Text);
            string nombre = textBoxNombre.Text;
            int precio = int.Parse(textBoxPrecio.Text);
            int idCategoria = int.Parse(textBoxIdCategoria.Text);






            if (datos.ExistePlato(id))
            {
                MessageBox.Show("El ID de este plato ya está registrado.", "ID duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else if (!datos.ExisteCategoriaPlato(idCategoria))
            {
                MessageBox.Show("No existe niguna categoria de plato con este ID.", "ID no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }

            else
            {

                Platos plato = new Platos();
                plato.IdPlato = id;
                plato.Nombre = nombre;
                plato.Precio = precio;
                plato.IdCategoria = idCategoria;
                datos.AgregarPlato(plato);
                MessageBox.Show("Plato registrado con exito");
            }
























        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten digitos");
                e.Handled = true; // Bloquear la entrada del carácter
                System.Media.SystemSounds.Exclamation.Play(); // Reproducir sonido de error
            }
        }

        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
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
