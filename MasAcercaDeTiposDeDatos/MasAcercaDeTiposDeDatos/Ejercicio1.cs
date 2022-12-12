using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasAcercaDeTiposDeDatos
{
    internal class Ejercicio1
    {
        public int ? DeterminarElNumeroMayor(int[] numeros)
        {
            int? resultado = 0;
                
            if(numeros.Length == 0)
            {
                return null;
            }

            resultado = numeros[0];
            foreach (var  numero in numeros)
            {
                if (numero > resultado) 
                { 
                    resultado= numero;
                }
            }

            return resultado;
        }
    }
}
