using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Ejercicio3
    {
        public string nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public bool EsMayorDeEdad()
        {
            var fechaActual = DateTime.Today;
            var edad = fechaActual.Year - FechaNacimiento.Year;

            var fechaCumpleañosEsteAño = new DateTime(fechaActual.Year,
                FechaNacimiento.Month, FechaNacimiento.Day);

            var yaCumpliAños = fechaCumpleañosEsteAño <= fechaActual;

            if(!yaCumpliAños)
            {
                edad--;
            }

            var esMayorde18 = edad >= 18;
            return esMayorde18;
        }
    }
}
