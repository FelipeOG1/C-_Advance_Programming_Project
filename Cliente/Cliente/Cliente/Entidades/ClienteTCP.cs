using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;



namespace Cliente.Entidades
{

    //Codigo basado en programa dado por tutor//
    public class ClienteTCP
    {
        private static IPAddress ipServidor;
        private static TcpClient cliente;
        private static IPEndPoint serverEndPoint;
        private static StreamWriter clienteStreamWriter;
        private static StreamReader clienteStreamReader;

        /// <summary>
        /// Conecta el cliente tcp con el servidor
        /// </summary>
        /// <param name="pIdentificadorCliente">Identificador o nombre del cliente</param>
        /// <returns>Retorna true si se conecta con el servidor</returns>
        /// 

        public static bool Conectar(string pIdentificadorCliente)
        {
            if (ExisteClienteEnServidor(pIdentificadorCliente))
            {
                try
                {
                    ipServidor = IPAddress.Parse("127.0.0.1");
                    cliente = new TcpClient();
                    serverEndPoint = new IPEndPoint(ipServidor, 14100);
                    cliente.Connect(serverEndPoint);
                    SocketObject mensajeConectar = new SocketObject { Metodo = "Conectar", Entidad = pIdentificadorCliente };

                    clienteStreamWriter = new StreamWriter(cliente.GetStream());
                    clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeConectar));
                    clienteStreamWriter.Flush();
                    clienteStreamReader = new StreamReader(cliente.GetStream());

                    return true;
                }
                catch (SocketException)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }



        }

        public static void Desconectar(string pIdentificadorCliente)
        {
            Socket<string> mensajeDesconectar = new Socket<string> { Metodo = "Desconectar", Entidad = pIdentificadorCliente };

            clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeDesconectar));
            clienteStreamWriter.Flush();
            //Se cierra la conexión del cliente
            cliente.Close();
        }


        public static List<Restaurante> ObtenerRestaurantes()
        {


            List<Restaurante> listaRestaurantes = new List<Restaurante>();
            Socket<string> mensajeObtenerRestaurantes = new Socket<string> { Metodo = "ObtenerRestaurante" };

            clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeObtenerRestaurantes));
            clienteStreamWriter.Flush();

            var mensaje = clienteStreamReader.ReadLine();
            if (!string.IsNullOrEmpty(mensaje))
            {
                listaRestaurantes = JsonConvert.DeserializeObject<List<Restaurante>>(mensaje);
            }

          
            return listaRestaurantes;



        }

       

        public static List<Platos>ObtenerPlatosAsociados(int idRestaurante)
        {
            List<Platos> listaPlatos = new List<Platos>();

            using (TcpClient cliente = new TcpClient("127.0.0.1", 14100))
            using (StreamWriter clienteStreamWriter = new StreamWriter(cliente.GetStream()))
            using (StreamReader clienteStreamReader = new StreamReader(cliente.GetStream()))
            {
                Socket<int> mensajeObtenerPlatosAsociados = new Socket<int> { Metodo = "ObtenerPlatos", Entidad = idRestaurante };

                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeObtenerPlatosAsociados));
                clienteStreamWriter.Flush();

                var mensaje = clienteStreamReader.ReadLine();
                if (!string.IsNullOrEmpty(mensaje))
                {
                    listaPlatos = JsonConvert.DeserializeObject<List<Platos>>(mensaje);
                }
            }

            return listaPlatos;


        }

        public static List<Extras>ObtenerExtrasPorPlatos(int idPlato)
        {
            List<Extras> listaExtras = new List<Extras>();

            using (TcpClient cliente = new TcpClient("127.0.0.1", 14100))
            using (StreamWriter clienteStreamWriter = new StreamWriter(cliente.GetStream()))
            using (StreamReader clienteStreamReader = new StreamReader(cliente.GetStream()))
            {
                Socket<int> mensajeObtenerExtrasPorPlatos = new Socket<int> { Metodo = "ObtenerExtrasPlatos", Entidad = idPlato };

                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeObtenerExtrasPorPlatos));
                clienteStreamWriter.Flush();

                var mensaje = clienteStreamReader.ReadLine();
                if (!string.IsNullOrEmpty(mensaje))
                {
                    listaExtras = JsonConvert.DeserializeObject<List<Extras>>(mensaje);
                }
            }

            return listaExtras;


        }
        public static List<Pedido> ObtenerPedidoPorCliente(string idCliente)
        {
            List<Pedido> listaPedidos = new List<Pedido>();

            using (TcpClient cliente = new TcpClient("127.0.0.1", 14100))
            using (StreamWriter clienteStreamWriter = new StreamWriter(cliente.GetStream()))
            using (StreamReader clienteStreamReader = new StreamReader(cliente.GetStream()))
            {
                Socket<string> mensajeObtenerPlatosAsociados = new Socket<string> { Metodo = "ConsultarPedido", Entidad = idCliente };

                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeObtenerPlatosAsociados));
                clienteStreamWriter.Flush();

                var mensaje = clienteStreamReader.ReadLine();
                if (!string.IsNullOrEmpty(mensaje))
                {
                    listaPedidos = JsonConvert.DeserializeObject<List<Pedido>>(mensaje);
                }
            }

            return listaPedidos;


        }


        public static bool RealizarPedido(Pedido pedido)
        {
            try
            {
                Socket<Pedido> mensajePedido = new Socket<Pedido> { Metodo = "RealizarPedido", Entidad = pedido };
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajePedido));
                clienteStreamWriter.Flush();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool RealizarPedidoExtra(PedidosExtra pedido)
        {
            try
            {
                Socket<PedidosExtra> mensajePedidoExtra = new Socket<PedidosExtra> { Metodo = "RealizarExtraPedido", Entidad = pedido };
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajePedidoExtra));
                clienteStreamWriter.Flush();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }






        private static bool ExisteClienteEnServidor(string idCliente)
        {
            try
            {
                ipServidor = IPAddress.Parse("127.0.0.1");
                cliente = new TcpClient();
                serverEndPoint = new IPEndPoint(ipServidor, 14100);
                cliente.Connect(serverEndPoint);
                SocketObject mensajeExisteCliente = new SocketObject { Metodo = "ExisteCliente", Entidad = idCliente };

                clienteStreamWriter = new StreamWriter(cliente.GetStream());
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeExisteCliente));
                clienteStreamWriter.Flush();
                clienteStreamReader = new StreamReader(cliente.GetStream());

                // Leer la respuesta del servidor
                var mensaje = clienteStreamReader.ReadLine();
                if (mensaje == "true")
                {
                    return true; // Cliente encontrado en el servidor.
                }
                else
                {
                    return false; // Cliente no encontrado en el servidor.
                }
            }
            catch (SocketException)
            {
                return false; // Error de conexión al servidor.
            }
        }



    }
}




