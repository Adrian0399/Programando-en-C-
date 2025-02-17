﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericosYColecciones
{
    internal class ComparadorPersonasPorNombre : IComparer<Persona>
    {
        public int Compare(Persona? p1,  Persona? p2)
        {
            if (p1 is null || p1.Nombre is null)
            {
                throw new ArgumentException($"El parametro {nameof(p1)} o su nombre es nulo");
            }

            if (p2 is null || p2.Nombre is null)
            {
                throw new ArgumentException($"El parametro {nameof(p1)} o su nombre es nulo");
            }
            return String.Compare(p1.Nombre, p2.Nombre); 
        }
    }
}
