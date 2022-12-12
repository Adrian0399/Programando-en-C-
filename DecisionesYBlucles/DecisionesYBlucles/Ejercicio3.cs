using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionesYBlucles
{
    internal class Ejercicio3
    {
        public static void Realizar(int n)
        {
            for (int i=1; i<=n; i++) 
            {
                var mensaje = i.ToString();

                if (i % 3 == 0 && i % 5 == 0)
                {
                    mensaje = "fizzbuzz";
                }
                else if (i % 3 == 0 )
                {
                    mensaje = "fizz";
                }
                else if (i % 5 == 0)
                {
                    mensaje = "buzz";
                }
                Console.WriteLine(mensaje);
            }
        }
    }
}
