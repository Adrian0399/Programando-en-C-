﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiAutores.DTOs
{
    public class AutorDTO: Recurso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
