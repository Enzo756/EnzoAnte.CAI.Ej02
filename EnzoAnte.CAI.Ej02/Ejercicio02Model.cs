using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnzoAnte.CAI.Ej02
{
    internal class Ejercicio02Model
    {
        //Cualquier dato que se necesite para armar la pantalla lo tiene que tener el modelo.
        //public string[] Marcas { get; } = new string[] {"Ford","Fiat","Chevrolet","Audi" };
        public string MarcaIngresada { get; set; }
        public string ModeloIngresado { get; set; }
        public string AñoIngresado { get; set; }
        public string PrecioIngresado { get; set; }


        public string NombreUsuario { get; } = "Enzo756";
        public string NombreRealUsuario { get; } = "Enzo Antezana";

        public string Validar()
        {
            /*TODO: Validar los datos ingresados, responder con un mensaje y si hay un error 
            Ej: "El precio ingresado no es numérico"
            o devolver un mensaje de "Ok" si está todo bien
             */
            return "Ok";
        }
    }
}
