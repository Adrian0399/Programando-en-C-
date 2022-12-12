using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal abstract class Vehiculo
    {
        public Vehiculo() { } // Se puede agregar un constructo vacio, para evitar errores en las demas subclases
        public Vehiculo(string marca) //Constructor que indica que todas las subclases que heredan de Vehiculo, es obligatoria la marca, y debe de generarse un constructor en cada subclase
        {
            Marca = marca;
        }

        public string? Marca { get; set; }
        public int AñoCreacion { get; set; }
        public int Velocidad { get; private set; }
        public abstract int VelocidadMaxima { get; }

        public virtual void DarReversa() //virtual da la opcion de poder sobreescribir la implementacion
        {
            Console.WriteLine("Dando reversa - Implementación por defecto");
        }

        public abstract void SonarClaxon(); //COn un metdo abstracto todas las clases dereivadas estan obligadas a implementar este metodo
        public void Acelerar(int incremento = 1)
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
    }

    internal class Carro : Vehiculo
    {
        public Carro(string marca) : base(marca)
        {
        }

        public override int VelocidadMaxima => 120;

        public void EncenderRadio()
        {
            Console.WriteLine("Enciendiendo la Radio");
        }

        public sealed override void SonarClaxon() //Sealed => Para evitar que el metodo vuelva a ser sobreescrito, solamente puede ser llamado y utilizado
        {
            Console.WriteLine("Bip, Bip");
        }

        public override string ToString()
        {
            return "Carro con marca" + Marca;
        }

    }
    internal class SonataGris : Carro
    {
        //public override void SonarClaxon()
        //{
        //    base.SonarClaxon();
        //}
        public SonataGris(string marca) : base(marca)
        {
        }
    }

    internal class Camion : Vehiculo
    {

        public override int VelocidadMaxima => 50;

        public override void DarReversa() //(Override => Con virtual en el metodo, se puede añadir a la subclase y agregar mas atributos o funciones
        {
            base.DarReversa();
            Console.WriteLine("BEEP!, BEEP!, BEEP");
        }

        public override void SonarClaxon()
        {
            Console.WriteLine("Pon Pooooon");
        }
    }

    internal class Bicicleta : Vehiculo
    {

        public override int VelocidadMaxima => 20;
        public override void SonarClaxon()
        {
            Console.WriteLine("Tip tip");
        }
    }



}
