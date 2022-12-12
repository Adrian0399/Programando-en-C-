using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    internal class Ejercicio5
    {
    
        public void ImprimirSumaYMultiplicacion(int a, int b, int veces)
        {
            Func<int, int, int> sumar = (x, y) => x + y;

            Func<int, int, int> multiplicar = (x, y) => x * y;

            Action<int, int, int> imprimir = (resultadoSuma, resultadoMultiplicacion, n) => {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"{resultadoSuma} - {resultadoMultiplicacion}");
                }
            };

            int suma = sumar(a, b);
            int multiplicacion = multiplicar(a, b);
            imprimir(suma, multiplicacion, veces);
        }

    }
}
