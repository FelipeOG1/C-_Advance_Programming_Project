using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;
using Microsoft.Data.SqlClient;
using tarea2.Entidades;

namespace tarea2
{

    //Codigo para conectividad a base de datos basado en programa dado por tutor//
    public class LogicaConexion
    {
        private string cadenaConexion;
        private SqlConnection conexion;

        public LogicaConexion()
        {
            ObtenerConexion();
        }

        public string ObtenerConexion()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexionRestaurante"].ConnectionString;
            return cadenaConexion;

        }

        public void AgregarCategoriaPlato(CategoriaPlatos categoria)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand();
                String sentencia = "Insert Into CategoriaPlato(idcategoria,descripcion,estado)" + "Values (@IdCategoria, @Descripcion, @Estado)";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;

                comando.Parameters.AddWithValue("@IdCategoria", categoria.IdCategoria);
                comando.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
                comando.Parameters.AddWithValue("@Estado", categoria.Estado);

                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    
                    throw;
                }
            }


        }

        public void AgregarCliente(Cliente cliente)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand();
                String sentencia = "Insert Into Cliente(idcliente,nombre,primerapellido,segundoapellido,fechanacimiento,genero)" + "Values (@IdCliente, @Nombre, @PrimerApellido,@SegundoApellido,@FechaNacimiento,@Genero)";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection =  conexion;

                comando.Parameters.AddWithValue("@IdCLIENTE", cliente.Identificacion);
                comando.Parameters.AddWithValue("@Nombre", cliente.NombreCliente);
                comando.Parameters.AddWithValue("@PrimerApellido", cliente.PrimerApellido);
                comando.Parameters.AddWithValue("@SegundoApellido", cliente.SegundoApellido);
                comando.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);
                comando.Parameters.AddWithValue("@Genero", cliente.Genero);



                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw;
                }
            }

        }

        public void AgregarExtra(Extras extra)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand();
                String sentencia = "Insert Into Extra(idextra,descripcion,idcategoria,estado,precio)" + "Values (@IdExtra, @Descripcion, @IdCategoria,@Estado,@Precio)";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;

                comando.Parameters.AddWithValue("@IdExtra", extra.Id);
                comando.Parameters.AddWithValue("@Descripcion", extra.Descripcion);
                comando.Parameters.AddWithValue("@IdCategoria", extra.IdCategorias);
                comando.Parameters.AddWithValue("@Estado", extra.Estado);
                comando.Parameters.AddWithValue("@Precio", extra.Precio);





                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw;
                }
            }



        }

        public void AgregarPedido(Pedido pedido)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand();
                String sentencia = "Insert Into Pedido(idpedido,idcliente,idplato,fechapedido)" + "Values (@IdPedido, @IdCliente, @IdPlato,@FechaPedido)";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;

                comando.Parameters.AddWithValue("@IdPedido", pedido.IdPedido);
                comando.Parameters.AddWithValue("@IdCliente", pedido.IdCliente);
                comando.Parameters.AddWithValue("@IdPlato", pedido.IdPlato);
                comando.Parameters.AddWithValue("@FechaPedido", pedido.FechaPedido);




                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw;
                }
            }




        }

        public void AgregarPedidoExtra(PedidoExtra pedido)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand();
                String sentencia = "Insert Into ExtraPedido(idpedido,idplato,idextra)" + "Values (@IdPedido, @IdPlato, @IdExtra)";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;

                comando.Parameters.AddWithValue("@IdPedido", pedido.IdPedido);
                comando.Parameters.AddWithValue("@IdPlato", pedido.IdPlato);
                comando.Parameters.AddWithValue("@IdExtra", pedido.IdExtra);




                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw;
                }
            }

        }

        public void AgregarPlato(Platos plato)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand();
                String sentencia = "Insert Into Plato(idplato,Nombre,idcategoria,precio)" + "Values (@IdPlato, @Nombre, @IdCategoria,@Precio)";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;

                comando.Parameters.AddWithValue("@IdPlato", plato.IdPlato);
                comando.Parameters.AddWithValue("@Nombre", plato.Nombre);
                comando.Parameters.AddWithValue("@IdCategoria", plato.IdCategoria);
                comando.Parameters.AddWithValue("@Precio", plato.Precio);
                



                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw;
                }
            }

        }

        public void AgregarPlatoRestaurante(PlatoRestaurante platoRestaurante)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand();
                String sentencia = "Insert Into PlatoRestaurante(idasignacion,idrestaurante,idplato,fechaasignacion)" + "Values (@IdAsignacion, @IdRestaurante, @IdPlato,@FechaAsignacion)";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;

                comando.Parameters.AddWithValue("@IdAsignacion", platoRestaurante.IdAsignacion);
                comando.Parameters.AddWithValue("@IdRestaurante", platoRestaurante.IdRestaurante);
                comando.Parameters.AddWithValue("@IdPlato", platoRestaurante.IdPlato);
                comando.Parameters.AddWithValue("@FechaAsignacion", platoRestaurante.FechaAfiliacion);
                

                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw;
                }
            }

        }

        public void AgregarRestaurante(Restaurante restaurante)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand();
                String sentencia = "Insert Into Restaurante(idrestaurante,nombre,direccion,estado,telefono)" + "Values (@IdRestaurante, @Nombre, @Direccion,@Estado,@Telefono)";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;

                comando.Parameters.AddWithValue("@IdRestaurante", restaurante.IdRestaurante);
                comando.Parameters.AddWithValue("@Nombre", restaurante.NombreRestaurante);
                comando.Parameters.AddWithValue("@Direccion", restaurante.Direccion);
                comando.Parameters.AddWithValue("@Estado", restaurante.Estado);
                comando.Parameters.AddWithValue("@Telefono", restaurante.Telefono);
                



                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw;
                }
            }

        }

        public List<CategoriaPlatos> ConsultarCategoriaPlato()
        {
            List<CategoriaPlatos> listaCategorias = new List<CategoriaPlatos>();

            SqlCommand comando = new SqlCommand();
            String sentencia;

            SqlDataReader lector;

            SqlConnection conexion = new SqlConnection(cadenaConexion);

            sentencia = "Select IdCategoria, Descripcion, Estado FROM CategoriaPlato";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;

            conexion.Open();

            lector = comando.ExecuteReader();

            if (lector.HasRows)
            {
                while (lector.Read())
                {



                    int IdCategoria = lector.GetInt32(0);
                    string Descripcion = lector.GetString(1);
                    bool Estado = lector.GetBoolean(2);

                    listaCategorias.Add(new CategoriaPlatos(IdCategoria, Descripcion, Estado));






                }
            }

            conexion.Close();
            return listaCategorias;


        }

        public List<Restaurante> ConsultarRestaurante()
        {
            List<Restaurante> listaRestaurantes = new List<Restaurante>();

            {
                SqlCommand comando = new SqlCommand();

                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String sentencia = "SELECT IdRestaurante, Nombre, Direccion, Estado, Telefono FROM Restaurante";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;

                try
                {
                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();

                    while (lector.Read())
                    {

                        Restaurante restaurante = new Restaurante();
                        restaurante.IdRestaurante = lector.GetInt32(0);
                        restaurante.NombreRestaurante = lector.GetString(1);
                        restaurante.Direccion = lector.GetString(2);
                        restaurante.Estado= lector.GetBoolean(3);
                        restaurante.Telefono = lector.GetString(4);

                        listaRestaurantes.Add(restaurante);
                    }

                    lector.Close();
                }
                catch (Exception ex)
                {
                    throw;
                }
              
            }
            return listaRestaurantes;



        }

        
        public List<Cliente> ConsultarCliente()
        {
            List<Cliente> listaClientes = new List<Cliente>();

            {
                SqlCommand comando = new SqlCommand();

                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String sentencia = "SELECT IdCliente, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, Genero FROM Cliente";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;

                try
                {
                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                       string idCliente=lector.GetString(0);
                       string nombre=lector.GetString(1);
                       string primerApe=lector.GetString(2);
                       string segundoApe=lector.GetString(3);
                       DateTime fecha=lector.GetDateTime(4);
                       char genero = Convert.ToChar(lector.GetString(5));



                        Cliente cliente = new Cliente(idCliente,nombre, primerApe, segundoApe, fecha,genero);  
                        listaClientes.Add(cliente);
                    }

                    lector.Close();
                }
                catch (Exception ex)
                {
                    throw;
                }

            }
            return listaClientes;

        }

        public List<Extras> ConsultarExtra()
        {
            List<Extras> listaExtras = new List<Extras>();
            {
                SqlCommand comando = new SqlCommand();

                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String sentencia = "SELECT IdExtra, Descripcion, IdCategoria, Estado, Precio FROM Extra";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;

                try
                {
                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        int idExtra = lector.GetInt32(0);
                        string descripcion = lector.GetString(1);
                        int idCate= lector.GetInt32(2);
                        bool estado = lector.GetBoolean(3);
                        int precio = lector.GetInt32(4);

                        Extras extras=new Extras(idExtra,descripcion,idCate,estado,precio);
                        listaExtras.Add(extras);
                    }

                    lector.Close();
                }
                catch (Exception ex)
                {
                    throw;
                }

            }
            return listaExtras;

        }

        public List<Pedido> ConsultarPedido(String idCliente)
        {
            List<Pedido> listaPedidos = new List<Pedido>();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand();
                String sentencia = "SELECT IdPedido, IdCliente, IdPlato, FechaPedido FROM Pedido " +
                                   "WHERE IdCliente = @IdCliente";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;

                comando.Parameters.AddWithValue("@IdCliente", idCliente);

                try
                {
                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        Pedido pedido = new Pedido();
                        pedido.IdPedido = lector.GetInt32(0);
                        pedido.IdCliente = lector.GetString(1);
                        pedido.IdPlato = lector.GetInt32(2);
                        pedido.FechaPedido = lector.GetDateTime(3);

                        listaPedidos.Add(pedido);
                    }

                    lector.Close();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }

            return listaPedidos;


        }

        public List<Platos> ConsultarPlato()
        {
            List<Platos> listaPlatos = new List<Platos>();

            {
                SqlCommand comando = new SqlCommand();

                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String sentencia = "SELECT IdPlato, Nombre, IdCategoria, Precio FROM Plato";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;

                try
                {
                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        Platos platos = new Platos();
                        platos.IdPlato = lector.GetInt32(0);
                        platos.Nombre = lector.GetString(1);
                        platos.IdCategoria = lector.GetInt32(2);
                        platos.Precio = lector.GetInt32(3);


                        
                        listaPlatos.Add(platos);    
                    }

                    lector.Close();
                }
                catch (Exception ex)
                {
                    throw;
                }

            }
            return listaPlatos;

        }

        public List<PlatoRestaurante> ConsultarPlatoRestaurante()
        {
            List<PlatoRestaurante> listaPlatosRestaurante = new List<PlatoRestaurante>();

            {
                SqlCommand comando = new SqlCommand();

                SqlConnection conexion = new SqlConnection(cadenaConexion);
                String sentencia = "SELECT IdAsignacion, IdRestaurante, IdPlato, FechaAsignacion FROM PlatoRestaurante";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;

                try
                {
                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        int idAsignacion = lector.GetInt32(0);
                        int idRes = lector.GetInt32(1);
                        int idPlato = lector.GetInt32(2);
                        DateTime fechaAsignacion = lector.GetDateTime(3);
                        

                        PlatoRestaurante platoRestaurante = new PlatoRestaurante(idAsignacion,idRes,idPlato,fechaAsignacion);
                        listaPlatosRestaurante.Add(platoRestaurante);
                    }

                    lector.Close();
                }
                catch (Exception ex)
                {
                    throw;
                }

            }
            return listaPlatosRestaurante;

        }

        public List<Platos> ConsultarPlatosPorRestaurante(int idRestaurante)
        {
            List<Platos> listaPlatos = new List<Platos>();

          
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand();
                String sentencia = "SELECT p.IdPlato, p.Nombre, p.IdCategoria , p.Precio FROM Plato p " +
                                   "INNER JOIN PlatoRestaurante pr ON p.IdPlato = pr.IdPlato " +
                                   "WHERE pr.IdRestaurante = @IdRestaurante";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;

                
                comando.Parameters.AddWithValue("@IdRestaurante", idRestaurante);

                try
                {
                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        Platos platos= new Platos();    
                        platos.IdPlato = lector.GetInt32(0);
                        platos.Nombre = lector.GetString(1);
                        platos.IdCategoria = lector.GetInt32(2);
                        platos.Precio = lector.GetInt32(3);

                        
                        listaPlatos.Add(platos);
                    }

                    lector.Close();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }

            return listaPlatos;
        }

        public List<Extras> ConsultarExtrasPorPlato(int idPlato)
        {
            List<Extras> listaExtras = new List<Extras>();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand();
                String sentencia = "SELECT e.IdExtra, e.Descripcion, e.IdCategoria, e.Estado, e.Precio FROM Extra e " +
                                   "INNER JOIN Plato p ON e.IdCategoria = p.IdCategoria " +
                                   "WHERE p.IdPlato = @IdPlato";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;

                comando.Parameters.AddWithValue("@IdPlato", idPlato);

                try
                {
                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                      
                        int IdExtra = lector.GetInt32(0);
                        string Descripcion = lector.GetString(1);
                        int IdCategoria = lector.GetInt32(2);
                        bool Estado = lector.GetBoolean(3);
                        int Precio = lector.GetInt32(4);
                        Extras extra = new Extras(IdExtra,Descripcion,IdCategoria,Estado,Precio);
                        listaExtras.Add(extra);
                    }

                    lector.Close();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }

            return listaExtras;
        }





        public bool ExisteCategoriaPlato(int idCategoria)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand();
                String sentencia = "SELECT COUNT(*) FROM CategoriaPlato WHERE idcategoria = @IdCategoria";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;

                comando.Parameters.AddWithValue("@IdCategoria", idCategoria);

                try
                {
                    conexion.Open();
                    int count = (int)comando.ExecuteScalar();
                    return count > 0;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public bool ExisteRestaurante(int idRestaurante)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand();
                String sentencia = "SELECT COUNT(*) FROM Restaurante WHERE idrestaurante = @IdRestaurante";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;

                comando.Parameters.AddWithValue("@IdRestaurante", idRestaurante);

                try
                {
                    conexion.Open();
                    int count = (int)comando.ExecuteScalar();
                    return count > 0;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public bool ExisteCliente(string idCliente)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand();
                String sentencia = "SELECT COUNT(*) FROM Cliente WHERE idcliente = @IdCliente";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;

                comando.Parameters.AddWithValue("@IdCliente", idCliente);

                try
                {
                    conexion.Open();
                    int count = (int)comando.ExecuteScalar();
                    return count > 0;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public bool ExisteExtra(int idExtra)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand();
                String sentencia = "SELECT COUNT(*) FROM Extra WHERE idextra = @IdExtra";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;

                comando.Parameters.AddWithValue("@IdExtra", idExtra);

                try
                {
                    conexion.Open();
                    int count = (int)comando.ExecuteScalar();
                    return count > 0;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public bool ExistePedido(int idPedido)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand();
                String sentencia = "SELECT COUNT(*) FROM Pedido WHERE idpedido = @IdPedido";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;

                comando.Parameters.AddWithValue("@IdPedido", idPedido);

                try
                {
                    conexion.Open();
                    int count = (int)comando.ExecuteScalar();
                    return count > 0;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
        public bool ExistePlato(int idPlato)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand();
                String sentencia = "SELECT COUNT(*) FROM Plato WHERE idplato = @IdPlato";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;

                comando.Parameters.AddWithValue("@IdPlato", idPlato);

                try
                {
                    conexion.Open();
                    int count = (int)comando.ExecuteScalar();
                    return count > 0;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
        public bool ExistePlatoRestaurante(int idAsignacion)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand();
                String sentencia = "SELECT COUNT(*) FROM PlatoRestaurante WHERE idasignacion = @IdAsignacion";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;

                comando.Parameters.AddWithValue("@IdAsignacion", idAsignacion);

                try
                {
                    conexion.Open();
                    int count = (int)comando.ExecuteScalar();
                    return count > 0;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }





















    }
}

        





















    