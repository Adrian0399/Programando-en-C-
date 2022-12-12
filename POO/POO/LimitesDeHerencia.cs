using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Base1
    {
        public int PropiedadBase1 { get; set; }
    }

    public class Base2: Base1 //Base 2 hereda de base 1
    {
        public int PropiedadBase2 { get; set; }
    }

    public class Derivada: Base2 //Derivada hereda de Base2, que Base2 hereda de Base1, por lo tanto Derivada hereda ambas clases
    {
        void Metodo()
        {
            PropiedadBase2 = 2;
            PropiedadBase1 = 1;
        }
    }
    public class SubDerivada: Derivada //No es recomendable tener mas de 4 niveles de herencia
    {
        
    }
}
