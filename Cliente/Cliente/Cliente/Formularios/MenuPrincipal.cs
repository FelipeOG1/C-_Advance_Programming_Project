using Cliente.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente.Formularios
{
    //Codigo basado en programa dado por tutor//
    public partial class MenuPrincipal : Form
    {
        bool clienteConectado = false;



        public MenuPrincipal()
        {
            InitializeComponent();
            lblEstado.ForeColor = Color.Red;
            btnDesconectar.Enabled = false;
            btnConectar.Enabled = true;

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdCliente.Text))
            {

                if (VerificarServidorActivo())
                {
                    if (ClienteTCP.Conectar(txtIdCliente.Text))
                    {
                        lblEstado.Text = "Conectado al servidor... en (127.0.0.1, 14100)";
                        lblEstado.ForeColor = Color.Green;
                        labelEstado.Enabled = false;
                        clienteConectado = true;
                        btnConectar.Enabled = false;
                        btnDesconectar.Enabled = true;
                        txtIdCliente.ReadOnly = true;
                        RegistrarPedido registrarPedido = new RegistrarPedido(txtIdCliente.Text);

                        registrarPedido.StartPosition = FormStartPosition.CenterScreen;
                        registrarPedido.ShowDialog();



                    }
                    else
                    {

                        MessageBox.Show("El cliente digitado no fue encontrado.", "No es posible conectarse", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {

                    MessageBox.Show("El servidor no está activo o no es accesible.", "No es posible conectarse", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {

                MessageBox.Show("Debe ingresar el identificador del cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (clienteConectado)
            {

            }
            else
            {
                MessageBox.Show("Debe conectarse primero con el servidor", "No es posible realizar la acción solicitada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        public static bool VerificarServidorActivo()
        {
            try
            {

                string direccionIP = "127.0.0.1";
                int puerto = 14100;


                using (TcpClient cliente = new TcpClient())
                {
                    cliente.Connect(direccionIP, puerto);
                    return true;
                }
            }
            catch (SocketException)
            {
                return false;
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            ClienteTCP.Desconectar(txtIdCliente.Text);

            lblEstado.Text = "Desconectado";
            lblEstado.ForeColor = Color.Red;
            btnDesconectar.Enabled = false;
            btnConectar.Enabled = true;
            clienteConectado = false;
            txtIdCliente.ReadOnly = false;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }


}

