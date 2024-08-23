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
    public partial class RegistrarCliente : Form
    {
        private String[] idsCliente;
        private Cliente[] clientes;
        private int cuenta;


        public RegistrarCliente()
        {
            InitializeComponent();

           
            comboBoxGenero.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            LogicaConexion datos = new LogicaConexion();
            if (string.IsNullOrWhiteSpace(textBoxId.Text) || string.IsNullOrWhiteSpace(textBoxNombre.Text) || string.IsNullOrWhiteSpace(textBoxPrimerApe.Text) || string.IsNullOrWhiteSpace(textBoxSegundoApe.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detener la ejecución del evento
            }
            string id = textBoxId.Text;
            string nombre = textBoxNombre.Text;
            string primerApe = textBoxPrimerApe.Text;
            string segundoApe = textBoxSegundoApe.Text;
            DateTime FechaNacimiento = dateTimePickerCliente.Value;
            char genero = 'H';
            if (comboBoxGenero.SelectedIndex == 0)
            {
                genero = 'H';

            }
            else if (comboBoxGenero.SelectedIndex == 1)
            {
                genero = 'M';
            }

            if (datos.ExisteCliente(id))
            {
                MessageBox.Show("El ID de este cliente ya está registrado.", "ID duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);



            }
            else
            {
              

                Cliente cliente = new Cliente(id, nombre, primerApe, segundoApe, FechaNacimiento, genero);
                datos.AgregarCliente(cliente);
                MessageBox.Show("Cliente registrado existosamente");
               
                
            }



        }

        
    }
}
