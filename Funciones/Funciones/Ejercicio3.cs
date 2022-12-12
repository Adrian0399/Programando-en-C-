using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    internal class Ejercicio3
    {
        bool ObtenerMinMaxPromedio(int[] numeros, out int minimo, out int maximo, out double promedio)
        { 
            minimo = 0;
            maximo = 0;
            promedio = 0.0;

            if(numeros.Length == 0) {
                return false;
            }

            maximo = numeros[0];
            minimo = numeros[0];
            var suma = 0.0;

            foreach (var numero in numeros)
            {
                if (numero > maximo)
                {
                    maximo = numero;
                }
                if (numero < minimo)
                {
                    minimo = numero;
                }
                suma += numero;
            }
            promedio = suma / numeros.Length;

            return true;
        }
    }
}
