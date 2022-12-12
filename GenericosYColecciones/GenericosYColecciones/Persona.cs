using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericosYColecciones
{
    internal class Persona: IComparable<Persona>
    {
        public string Nombre { get; set; }
        public int Edad { get; set;}

        public int CompareTo(Persona? other)
        {
            if(other is null)
            {
                throw new ArgumentNullException(nameof(other));
            }

            //Explicacion: Si e valor es menor que < 0, entonces la persona actual va primero
            // Si el valor es > 0, la persona actual va de segundo.
            //SI el valor es = 0, entonces llevan el mismo orden

            return this.Edad - other.Edad;

        }
    }
}
