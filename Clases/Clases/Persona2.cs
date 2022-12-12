using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Persona2
    {
        public Persona2(string nombre, string apellido) : this(nombre, apellido, default)
        { 
        }

        public Persona2(string nombre, string apellido, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }   
    }
}
