using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2
{
    public class Extras
    {
      
        private int id;
        private string descripcion;
        private int idCategoria;
        private bool estado;
        private int precio;


        public Extras(int idExtra, string descripcionExtra,int categoria,bool estadoExtra, int precioExtra)
        {
            id=idExtra;
            descripcion=descripcionExtra;
            idCategoria=categoria;
            estado=estadoExtra;
            precio=precioExtra;
          
            

        }

        public int Id
        {
            get { return id; }
            set { id = value; }

        }


        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }




        }

        public int IdCategorias
        {
            get { return idCategoria; }
            set { idCategoria = value; }


        }


        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public int Precio
        {
            get { return precio; }
            set { precio = value; }




        }

    }
}
