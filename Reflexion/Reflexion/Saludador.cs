﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflexion
{
    internal partial class Saludador
    {
        static public void Saludar(string nombre)
        {
            SaludarGenerado(nombre);
        }

        static partial void SaludarGenerado(string nombre);
    }
}

namespace Reflexion
{
    internal partial class Saludador
    {

        static partial void SaludarGenerado(string nombre)
        {
            Console.WriteLine($"El generador dice: Hola {nombre}, ¿Como estas?");
        }
    }
}


