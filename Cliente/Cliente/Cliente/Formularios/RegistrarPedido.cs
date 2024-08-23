using Cliente.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente.Formularios
{

    public partial class RegistrarPedido : Form
    {
        private Restaurante restauranteSeleccionado;
        private Platos platoSeleccionado;
        private Extras extraSeleccionado;
        public string idCliente;



        public RegistrarPedido(String cliente)
        {
            InitializeComponent();
            cmbRestaurantes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPlatos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxExtras.DropDownStyle = ComboBoxStyle.DropDownList;


            cmbRestaurantes.DisplayMember = "NombreRestaurante";
            cmbRestaurantes.DataSource = ClienteTCP.ObtenerRestaurantes();
            dataGridViewPlatos.AutoGenerateColumns = true;
            idCliente = cliente;










        }

        private void cmbRestaurantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRestaurantes.SelectedItem != null && cmbRestaurantes.SelectedItem is Restaurante restaurante)
            {

                restauranteSeleccionado = restaurante;


                ActualizarTablaPlatos();
                lblPlatos.Text = "Lista de platos asociados al restaurante " + restauranteSeleccionado.NombreRestaurante;
            }

        }

        private void ActualizarTablaPlatos()
        {

            List<Platos> platosAsociados = ClienteTCP.ObtenerPlatosAsociados(restauranteSeleccionado.IdRestaurante);


            dataGridViewPlatos.DataSource = platosAsociados;
            comboBoxPlatos.DisplayMember = "Nombre";
            comboBoxPlatos.DataSource = platosAsociados;



        }


        private void comboBoxPlatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPlatos.SelectedItem != null && comboBoxPlatos.SelectedItem is Platos platos)
            {

                platoSeleccionado = platos;
                ActualizarTablaExtras();
                platoSeleccionado = platos;


                Extras extraSeleccionado = comboBoxExtras.SelectedItem as Extras;


                int precioTotal = platoSeleccionado.Precio;
                if (extraSeleccionado != null)
                {
                    precioTotal += extraSeleccionado.Precio;
                }

                listBoxPedido.Items.Clear();
                listBoxPedido.Items.Add("IdPlato: " + platoSeleccionado.IdPlato);
                listBoxPedido.Items.Add("Nombre: " + platoSeleccionado.Nombre);
                listBoxPedido.Items.Add("IdCategoria: " + platoSeleccionado.IdCategoria);
                listBoxPedido.Items.Add("Precio Plato: " + platoSeleccionado.Precio);

                if (extraSeleccionado != null)
                {
                    listBoxPedido.Items.Add("IdExtras: " + extraSeleccionado.Id);
                    listBoxPedido.Items.Add("Descripcion: " + extraSeleccionado.Descripcion);
                    listBoxPedido.Items.Add("IdCategoria: " + extraSeleccionado.IdCategorias);
                    listBoxPedido.Items.Add("Estado: " + extraSeleccionado.Estado);
                    listBoxPedido.Items.Add("Precio Extra: " + extraSeleccionado.Precio);
                }

                listBoxPedido.Items.Add("Precio Total: " + precioTotal);
            }










        }

        private void ActualizarTablaExtras()
        {
            List<Extras> extras = ClienteTCP.ObtenerExtrasPorPlatos(platoSeleccionado.IdPlato);
            dataGridViewExtras.DataSource = extras;
            comboBoxExtras.DisplayMember = "Descripcion";
            comboBoxExtras.DataSource = extras;
        }

        private void comboBoxExtras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxExtras.SelectedItem != null && comboBoxExtras.SelectedItem is Extras extras)
            {
                extraSeleccionado = extras;


            }





        }

        private void btnRealizarPedido_Click(object sender, EventArgs e)
        {
            if (comboBoxPlatos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe de seleccionar un plato para el pedido", "eleccion incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);





            }
            else if (cmbRestaurantes.SelectedIndex == -1)
            {
                MessageBox.Show("Debe de seleccionar un restaurante", "eleccion incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (comboBoxPlatos.SelectedIndex == -1 && cmbRestaurantes.SelectedIndex == -1)
            {
                MessageBox.Show("Debe de seleccionar un restaurante y un plato", "Eleccion incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }else if(comboBoxExtras.SelectedIndex!= -1)
            {
                Random random = new Random();

                int idExtra = extraSeleccionado.Id;
               
                int numeroAleatorio = random.Next(1000, 10000);

                int idPedido = numeroAleatorio;

                int idPlato = platoSeleccionado.IdPlato;

                DateTime fecha = DateTime.Now;
                Pedido nuevoPedido = new Pedido();
                PedidosExtra nuevoPedidoExtra= new PedidosExtra();
                nuevoPedido.IdPedido = numeroAleatorio;
                nuevoPedido.IdPlato = idPlato;


                nuevoPedido.IdCliente = idCliente;

                nuevoPedido.FechaPedido = fecha;
                nuevoPedidoExtra.IdPedido = idPedido;
                nuevoPedidoExtra.IdPlato= idPlato;
                nuevoPedidoExtra.IdExtra = idExtra;

                ClienteTCP.RealizarPedido(nuevoPedido);
                ClienteTCP.RealizarPedidoExtra(nuevoPedidoExtra);
                MessageBox.Show("RegistroExitoso", "Pedido Realizado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);



            }
            else
            {
                Random random = new Random();
                int numeroAleatorio = random.Next(1000, 10000);
                int idPedido = numeroAleatorio;
                int idPlato = platoSeleccionado.IdPlato;
                DateTime fecha = DateTime.Now;
                Pedido nuevoPedido = new Pedido();
                nuevoPedido.IdPedido = numeroAleatorio;
                nuevoPedido.IdPlato = idPlato;


                nuevoPedido.IdCliente = idCliente;

                nuevoPedido.FechaPedido = fecha;
                ClienteTCP.RealizarPedido(nuevoPedido);
                MessageBox.Show("RegistroExitoso", "Pedido Realizado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);














            }














        }

        private void button1_Click(object sender, EventArgs e)
        {
            List <Pedido> pedidos = new List<Pedido>();
            pedidos = ClienteTCP.ObtenerPedidoPorCliente(idCliente);
            dataGridViewPedidos.DataSource = pedidos;
        }
    }






}












