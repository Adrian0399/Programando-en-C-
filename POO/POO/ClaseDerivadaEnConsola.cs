﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace POO
{
    internal class ClaseDerivadaEnConsola: ClasePublicaDePrueba
    {
        void MetodoPrueba()
        {
            PropiedasProtegida = 15;
            PropiedadProtectedInternal = 4;
        }
    }
}
