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
        public string MarcaIngresada { get; set; }
        public string ModeloIngresado { get; set; }
        public string AñoIngresado { get; set; }
        public string PrecioIngresado { get; set; }
    

        //public string[] Marcas { get; } = new string[] {"Ford","Fiat","Chevrolet","Audi" };
        public string NombreUsuario { get; } = "Enzo756";
        public string NombreRealUsuario { get; } = "Enzo Antezana";
        public DateTime FechaActual { get; } = DateTime.Now;

        public string Validar()
        {
            //Precio es decimal
            if (!decimal.TryParse(PrecioIngresado, out decimal precio))
            {
                return "El precio ingresado no es un valor numérico válido.";
            }

            if (precio <= 0) // Siempre es if (algo está mal...)
            {
                return "El precio debe ser mayor a cero.";
            }

            if (string.IsNullOrWhiteSpace(ModeloIngresado))
            {
                return "El modelo es un dato requerido.";
            }

            if (ModeloIngresado.Length > 30)
            {
                return "El modelo debe tener menos de 30 caracteres.";
            }

            if (!int.TryParse(AñoIngresado, out int año))
            {
                return "El año ingresado no es un número válido.";
            }

            if (año <= 2000 || año > 2021)
            {
                return "El año debe estar entre 2001 y 2021.";
            }

            if (string.IsNullOrWhiteSpace(MarcaIngresada))
            {
                return "Debe seleccionar una marca.";
            }

            return "Ok";
        }
    }
}
