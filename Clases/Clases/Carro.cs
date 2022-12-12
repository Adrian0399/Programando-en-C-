using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Carro
    {
        internal Carro(): this("Marca por defecto")
        {
            Console.WriteLine("Instanciando un carro");
        }

        internal Carro(string marca)
        {
            Console.WriteLine("Instanciando un carro con una marca");
            _marca = marca;
            ConteoInstancias++;
        }

        internal void Aceleraar()
        {
            Aceleraar(1);
        }

        public static int ConteoInstancias { get; set; }

        //Por convencia, los campos empiezan con guion bajo _
        private string _marca;

        internal string Marca
        {
            get { return _marca.ToUpper(); }
            
            set { _marca = value; }
        }

        internal int Año { get; set; } // = 1990; //Agregar un valor predeterminado

        internal int Velocidad { get; private set; } = 20;
        //internal int Velocidad => 20;

        private int VelocidadMaxima => 120;

        internal string NombreComercial => $"{Marca} ({Año})";

        internal void Acelerar()
        {
            Aceleraar(1);
        }

        internal void Aceleraar(int incremento)
        {
            if (Velocidad >= VelocidadMaxima)
            {
                Console.WriteLine("La velocidad maxima ya ha sido alcanzada");
                return;
            }
            else if (Velocidad + incremento > VelocidadMaxima)
            {
                incremento = VelocidadMaxima - Velocidad;
            }

            Velocidad += incremento;
        }

        internal void Detener() => Velocidad = 0;
    }
}
