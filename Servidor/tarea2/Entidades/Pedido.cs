using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2.Entidades
{
    [Serializable]
    public class Pedido
    {
        public int IdPedido { get; set; }
        public string IdCliente { get; set; }
        public int IdPlato { get; set; }
        public DateTime FechaPedido { get; set; }



    }
}
