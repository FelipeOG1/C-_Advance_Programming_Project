using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tarea2
{
    public partial class RegistrarPlatosRestaurante : Form
    {
        private Restaurante[] restaurantes;
        private int[] idsAsignacion;
        private Platos[] platos;
        private PlatoRestaurante[] platosRestaurante;
        private int cuenta;





        public RegistrarPlatosRestaurante()
        {
            InitializeComponent();
            LogicaConexion datos = new LogicaConexion();
            List<Restaurante> restaurantes = datos.ConsultarRestaurante();
            List<Platos> platos = datos.ConsultarPlato();
            List<Restaurante> restaurantesActivos = restaurantes.Where(r => r.Estado == true).ToList();

            dataGridViewPlatos.ReadOnly = true;
            dataGridViewPlatos.EditMode = DataGridViewEditMode.EditProgrammatically;
            comboBoxRestaurante.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRestaurante.DisplayMember = "NombreRestaurante";
            comboBoxRestaurante.DataSource = restaurantesActivos;
            dataGridViewRestaurantes.ReadOnly = true;
            dataGridViewRestaurantes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewRestaurantes.DataSource = restaurantesActivos;
            dataGridViewPlatos.DataSource = platos; 









        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            LogicaConexion datos = new LogicaConexion();
            List<Restaurante> restaurantes = datos.ConsultarRestaurante();
            List<Restaurante> restaurantesActivos = restaurantes.Where(r => r.Estado == true).ToList();


            if (string.IsNullOrWhiteSpace(textBoxIdAsignacion.Text) || string.IsNullOrWhiteSpace(textBoxIdPlato.Text) || comboBoxRestaurante.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detener la ejecución del evento
            }



            int idAsignacion = int.Parse(textBoxIdAsignacion.Text);

            int idRestaurante = 0;


            int idPlato = int.Parse(textBoxIdPlato.Text);
            DateTime fecha= DateTime.Now;

            if (comboBoxRestaurante.SelectedItem != null)
            {
                 Restaurante restauranteSeleccionado = (Restaurante)comboBoxRestaurante.SelectedItem;
                 idRestaurante = restauranteSeleccionado.IdRestaurante;

               
            }

            if (datos.ExistePlatoRestaurante(idAsignacion))
            {
                MessageBox.Show("Este ID de asignacion ya está registrado.", "ID duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (!datos.ExistePlato(idPlato))
            {
                MessageBox.Show("No existe un plato registrado con este id.", "ID no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);





            }
            else
            {
                PlatoRestaurante platoRestaurante = new PlatoRestaurante(idAsignacion, idRestaurante, idPlato, fecha);
                datos.AgregarPlatoRestaurante(platoRestaurante);
                MessageBox.Show("Plato restaurante registrado con exito");




            }
























        }


        private void textBoxIdAsignacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten digitos");
                e.Handled = true; // Bloquear la entrada del carácter
                System.Media.SystemSounds.Exclamation.Play(); // Reproducir sonido de error
            }
        }

        private void textBoxIdRestaurante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten digitos");
                e.Handled = true; // Bloquear la entrada del carácter
                System.Media.SystemSounds.Exclamation.Play(); // Reproducir sonido de error
            }
        }

        private void textBoxIdPlato_KeyPress(object sender, KeyPressEventArgs e)
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
