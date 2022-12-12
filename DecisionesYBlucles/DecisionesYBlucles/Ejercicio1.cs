using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionesYBlucles
{
    internal class Ejercicio1
    {
        public int DeterminarElNumeroMayor(int a, int b)
        {
            int resultado = 0;

            if(a > b)
            {
                Console.WriteLine("A es mayor que B");
            } else if (a < b) {
                Console.WriteLine("B es Mayor que A");
            } else if (a == b) {
                Console.WriteLine("A y B son iguales");
            }
            return resultado;
        }
    }
}
