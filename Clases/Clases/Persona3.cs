using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Persona3
    {
        public string NombreCompleto { get; set; } = null!;

        public static void Procesar(Persona p)
        {
            if(p == null)
            {
                throw new ArgumentNullException(nameof(p));
                //throw new ArgumentNullException("p");
            }
        }
    }
}
