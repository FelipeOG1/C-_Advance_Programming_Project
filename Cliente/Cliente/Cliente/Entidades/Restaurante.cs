using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Entidades
{
    public class Restaurante
    {
        public int IdRestaurante { get; set; }
        public string NombreRestaurante { get; set; }
        public string Direccion { get; set; }
        public bool Estado { get; set; }
        public string Telefono { get; set; }

        
    }
}
