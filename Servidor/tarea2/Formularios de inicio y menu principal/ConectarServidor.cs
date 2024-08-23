using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using tarea2.Entidades;

namespace tarea2.Formularios_de_inicio_y_menu_principal
{
    //Codigo basado en programa dado por tutor//
    public partial class ConectarServidor : Form
    {
        TcpListener tcpListener;
        Thread EscuchaClientes;
        ModoficarListBoxDelegado modificarListBoxClientes;

        bool servidorIniciado;
        public ConectarServidor()
        {
            InitializeComponent();
            modificarListBoxClientes = new ModoficarListBoxDelegado(ModificarListBox);
            lblEstado.ForeColor = Color.Red;
            btnApagar.Enabled = false;
        }

        private delegate void ModoficarListBoxDelegado(string texto, bool agregar);


        private void ModificarListBox(string texto, bool agregar)
        {
            if (agregar)
            {
                lstClientesConectados.Items.Add(texto);
            }
            else
            {
                lstClientesConectados.Items.Remove(texto);
            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            IPAddress local = IPAddress.Parse("127.0.0.1");
            tcpListener = new TcpListener(local, 14100);
            servidorIniciado = true;
            EscuchaClientes = new Thread(new ThreadStart(EscucharClientes));
            EscuchaClientes.Start();
            EscuchaClientes.IsBackground = true;
            lblEstado.Text = "Escuchando clientes... en (127.0.0.1, 14100)";
            lblEstado.ForeColor = Color.Green;
            btnIniciar.Enabled = false;
            btnApagar.Enabled = true;

        }

        private void EscucharClientes()
        {
            tcpListener.Start();
            try
            {
                while (servidorIniciado)
                {
                    //Se bloquea hasta que un cliente se haya conectado al servidor 
                    TcpClient client = tcpListener.AcceptTcpClient();
                    /*Se crea un nuevo hilo para manejar la comunicación con los clientes que se conectan al servidor*/
                    Thread clientThread = new Thread(new ParameterizedThreadStart(ComunicacionCliente));
                    clientThread.Start(client);
                }
            }
            catch (SocketException)
            {
                return;
            }
            catch (Exception)
            {
                return;
            }

        }

        private void ComunicacionCliente(object cliente)
        {
            TcpClient tcCliente = (TcpClient)cliente;
            StreamReader reader = new StreamReader(tcCliente.GetStream());
            StreamWriter servidorStreamWriter = new StreamWriter(tcCliente.GetStream());//El StreamWriter debe ser único por subproceso y por cliente por eso se pasa por referencia

            while (servidorIniciado)
            {

                try
                {
                    /*Esta sección se bloquea hasta que el cliente envíe unmensaje*/
                    var mensaje = reader.ReadLine();
                    SocketObject mensajeRecibido = JsonConvert.DeserializeObject<SocketObject>(mensaje);
                    SeleccionarMetodo(mensajeRecibido.Metodo, mensaje, ref servidorStreamWriter);
                }
                catch (Exception e)
                {
                    //Ocurrió un error en el socket 
                    break;
                }
            }

            tcCliente.Close();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            servidorIniciado = false;
            tcpListener.Stop();

            lblEstado.ForeColor = Color.Red;
            lblEstado.Text = "Sin iniciar";
            btnIniciar.Enabled = true;
            btnApagar.Enabled = false;
        }

        /// <summary>
        /// Método donde se procesa el mensaje recibido para seleccionar el método que está solicitanto el cliente
        /// </summary>
        /// <param name="pMetodo">Nombre del método que se debe invocar</param>
        /// <param name="pMensaje">Mensaje enviado por el cliente</param>
        /// 

        public void SeleccionarMetodo(string pMetodo, string pMensaje, ref StreamWriter servidorStreamWriter)
        {

            switch (pMetodo)
            {
                case "ObtenerRestaurante":

                    ObtenerRestaurante(ref servidorStreamWriter);
                    break;
                case "Conectar":

                    Socket<string> mensajeConectar = JsonConvert.DeserializeObject<Socket<string>>(pMensaje);// Se deserializa el objeto recibido mediante json
                    Conectar(mensajeConectar.Entidad);
                    break;

                case "ObtenerPlatos":
                    Socket<int> mensajeObtenerPlatosPorRestaurante = JsonConvert.DeserializeObject<Socket<int>>(pMensaje);//Se  ebjeto recibido mediante json

                    ObtenerPlatosPorRestaurante(mensajeObtenerPlatosPorRestaurante.Entidad, ref servidorStreamWriter);
                    break;
                case "ObtenerExtrasPlatos":
                    Socket<int> mensajeObtenerExtrasPlatos = JsonConvert.DeserializeObject<Socket<int>>(pMensaje);
                    ObtenerExtrasPorPlatos(mensajeObtenerExtrasPlatos.Entidad, ref servidorStreamWriter);
                    break;
                case "ExisteCliente":
                    LogicaConexion datos = new LogicaConexion();
                    Socket<string> mensajeExisteCliente = JsonConvert.DeserializeObject<Socket<string>>(pMensaje);
                    bool clienteExiste = datos.ExisteCliente(mensajeExisteCliente.Entidad);
                    servidorStreamWriter.WriteLine(clienteExiste ? "true" : "false");
                    servidorStreamWriter.Flush();
                    break;

                case "Desconectar":
                    Socket<string> mensajeDesconectar = JsonConvert.DeserializeObject<Socket<string>>(pMensaje);//Se deserializa el objeto recibido mediante json
                    Desconectar(mensajeDesconectar.Entidad);
                    break;

                case "RealizarPedido":
                    Socket<Pedido> mensajePedido = JsonConvert.DeserializeObject<Socket<Pedido>>(pMensaje);//Se deserializa el objeto recibido mediante json
                    RealizarPedido(mensajePedido.Entidad);
                    break;

                case "ConsultarPedido":
                    Socket<string> mensajeConsultarPedido = JsonConvert.DeserializeObject<Socket<string>>(pMensaje);
                    ObtenerPedidosPorCliente(mensajeConsultarPedido.Entidad, ref servidorStreamWriter);
                    break;

                case "RealizarExtraPedido":
                    Socket<PedidoExtra> mensajePedidoExtra = JsonConvert.DeserializeObject<Socket<PedidoExtra>>(pMensaje);//Se deserializa el objeto recibido mediante json
                    RealizarPedidoExtra(mensajePedidoExtra.Entidad);
                    break;


















                default:
                    break;
            }

        }




        private void ObtenerRestaurante(ref StreamWriter servidorStreamWriter)
        {
            LogicaConexion datos = new LogicaConexion();
            List<Restaurante> listaRestaurantes = new List<Restaurante>();

            listaRestaurantes = datos.ConsultarRestaurante();
            List<Restaurante> restaurantesActivos = listaRestaurantes.Where(r => r.Estado == true).ToList();

            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(restaurantesActivos));
            servidorStreamWriter.Flush();
        }

        private void ObtenerPlatosPorRestaurante(int idRestaurante, ref StreamWriter servidorStreamWriter)
        {
            LogicaConexion datos = new LogicaConexion();
            List<Platos> listaPlatos = new List<Platos>();
            listaPlatos = datos.ConsultarPlatosPorRestaurante(idRestaurante);
            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(listaPlatos));
            servidorStreamWriter.Flush();


        }
        private void ObtenerExtrasPorPlatos(int idPlato, ref StreamWriter servidorStreamWriter)
        {
            LogicaConexion datos = new LogicaConexion();
            List<Extras> listaExtras = new List<Extras>();
            listaExtras = datos.ConsultarExtrasPorPlato(idPlato);
            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(listaExtras));
            servidorStreamWriter.Flush();

        }
        private void RealizarPedido(Pedido pedido)
        {
            LogicaConexion datos = new LogicaConexion();
            datos.AgregarPedido(pedido);

        }
        private void RealizarPedidoExtra(PedidoExtra pedido)
        {
            LogicaConexion datos = new LogicaConexion();
            datos.AgregarPedidoExtra(pedido);

        }
        private void ObtenerPedidosPorCliente(string idCliente, ref StreamWriter servidorStreamWriter)
        {
            LogicaConexion datos = new LogicaConexion();
            List<Pedido> pedidos = new List<Pedido>();
            pedidos = datos.ConsultarPedido(idCliente);
            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(pedidos));
            servidorStreamWriter.Flush();

        }



        private void Conectar(string pIdentificadorCliente)
        {

            lstClientesConectados.Invoke(modificarListBoxClientes, new object[] { pIdentificadorCliente, true });

        }

        private void Desconectar(string pIdentificadorCliente)
        {

            lstClientesConectados.Invoke(modificarListBoxClientes, new object[] { pIdentificadorCliente, false });
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.ShowDialog();
        }
    }
}
