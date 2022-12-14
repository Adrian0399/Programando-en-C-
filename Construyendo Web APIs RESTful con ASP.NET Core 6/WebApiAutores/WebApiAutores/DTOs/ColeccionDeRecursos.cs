﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiAutores.DTOs
{
    public class ColeccionDeRecursos<T>: Recurso where T: Recurso
    {
        public List<T> Valores { get; set; }
    }
}
