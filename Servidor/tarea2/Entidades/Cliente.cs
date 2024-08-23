using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2
{
    public class Cliente
    {
        
        

        private string identificacion;
        private string nombreCliente;
        private string primerApellido;
        private string segundoApellido;
        private DateTime fechaNacimiento;
        private char genero;

        public Cliente(string id, string nombre, string primerApe, string segundoApe, DateTime fecha, char gen)
        {
            identificacion = id;
            nombreCliente = nombre;
            primerApellido = primerApe;
            segundoApellido = segundoApe;
            fechaNacimiento = fecha;
            genero = gen;
            


        }






        public string Identificacion
        {
            get { return identificacion; }

        }

        public string NombreCliente
        {
            get { return nombreCliente; }
            set { nombreCliente = value; }
        }

        public string PrimerApellido
        {
            get { return primerApellido; }
            set { primerApellido = value; }
        }

        public string SegundoApellido
        {
            get { return segundoApellido; }
            set { segundoApellido = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public char Genero
        {
            get { return genero; }
            set { genero = value; }
        }
       





    }
}
