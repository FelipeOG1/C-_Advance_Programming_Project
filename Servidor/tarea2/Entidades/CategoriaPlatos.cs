using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2
{
    public class CategoriaPlatos
    {
        
       
        private int idCategoria;
        private string descripcion;
        private bool estado;

        public CategoriaPlatos(int id, string descripcionPlato, bool est)
        {
            idCategoria = id;
            descripcion = descripcionPlato;
            estado = est;
           
          



        }

        public int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }

        }


        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }




        }

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }




        }

        





    }
}
