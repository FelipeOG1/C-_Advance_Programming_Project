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
    public partial class RegistrarExtras : Form
    {
        private int[] idsExtras;
        private Extras[] extras;
        private int cuenta;
        private CategoriaPlatos[] categorias;

        public RegistrarExtras()
        {
            InitializeComponent();
            dataGridViewIds.ReadOnly = true;
            dataGridViewIds.EditMode = DataGridViewEditMode.EditProgrammatically;
            comboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            LogicaConexion datos = new LogicaConexion();
            dataGridViewIds.DataSource = datos.ConsultarCategoriaPlato();






        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogicaConexion datos = new LogicaConexion();
            if (string.IsNullOrWhiteSpace(textBoxIdPlato.Text) || string.IsNullOrWhiteSpace(textBoxPrecio.Text) || string.IsNullOrWhiteSpace(textBoxDescripcion.Text) || string.IsNullOrWhiteSpace(textBoxIdCategoria.Text) || comboBoxEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detener la ejecución del evento
            }
            CategoriaPlatos categoria = null;
            int idExtra = int.Parse(textBoxIdPlato.Text);
            int precio = int.Parse(textBoxPrecio.Text);
            bool estado = false;
            string descripcion = textBoxDescripcion.Text;
            int idCategoria = int.Parse(textBoxIdCategoria.Text);

            if (comboBoxEstado.SelectedIndex == 0)
            {
                estado = true;
            }
            else if (comboBoxEstado.SelectedIndex == 1)
            {
                estado = false;
            }

            if (datos.ExisteExtra(idExtra))
            {
                MessageBox.Show("El ID de este cliente ya está registrado.", "ID duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else if (!datos.ExisteCategoriaPlato(idCategoria))
            {
                MessageBox.Show("No existe niguna categoria de plato con este ID.", "ID no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }

            else
            {

                Extras extra = new Extras(idExtra, descripcion, idCategoria, estado, precio);
                datos.AgregarExtra(extra);
                MessageBox.Show("Extra registrado con exito");
            }



        }









        private void textBoxIdPlato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten digitos.");
                e.Handled = true; // Bloquear la entrada del carácter
                System.Media.SystemSounds.Exclamation.Play(); // Reproducir sonido de error
            }

        }

        private void textBoxIdCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten digitos.");
                e.Handled = true; // Bloquear la entrada del carácter
                System.Media.SystemSounds.Exclamation.Play(); // Reproducir sonido de error
            }
        }

        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten digitos.");
                e.Handled = true; // Bloquear la entrada del carácter
                System.Media.SystemSounds.Exclamation.Play(); // Reproducir sonido de error
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
