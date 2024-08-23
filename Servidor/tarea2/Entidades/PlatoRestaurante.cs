using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2
{
    public class PlatoRestaurante
    {
      
        private int idAsignacion;
        private DateTime fechaAfiliacion;
        private int idRestaurante;
        private int idPlato;
        







        public PlatoRestaurante(int id, int idResta,int idPla,DateTime fecha)
        {
            idAsignacion = id;
            fechaAfiliacion = fecha;
            idRestaurante = idResta;
            idPlato = idPla;
        }

        public int IdAsignacion
        {
            get { return idAsignacion; }
        }

        public int IdRestaurante
        {
            get { return idRestaurante; }
            set { idRestaurante = value; }




        }

        public int IdPlato
        {
            get { return idPlato; }
            set { idPlato = value; }


        }


        public DateTime FechaAfiliacion
        {
            get { return fechaAfiliacion; }
            set { fechaAfiliacion = value; }




        }

        
        
       

       












    }
}
