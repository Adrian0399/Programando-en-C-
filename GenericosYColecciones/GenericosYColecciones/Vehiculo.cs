using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericosYColecciones
{
    internal class Vehiculo
    {
    }

    internal class Carro: Vehiculo
    {
        public Carro(string marca)
        {
            Marca = marca;
        }

        public string Marca { get; }
    }

    internal class Camion: Vehiculo
    {

    }
}
