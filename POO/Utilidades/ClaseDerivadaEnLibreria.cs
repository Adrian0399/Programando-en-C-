﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    internal class ClaseDerivadaEnLibreria: ClasePublicaDePrueba
    {
        void Metodo()
        {
            PropiedasProtegida = 15;
            PropiedadProtectedInternal = 7;
            PropiedadPrivateProtected = 83;
        }
    }
}
