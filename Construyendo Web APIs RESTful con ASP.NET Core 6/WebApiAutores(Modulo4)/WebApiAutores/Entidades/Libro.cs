﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiAutores.Validaciones;

namespace WebApiAutores.Entidades

{
    public class Libro
    {
        public int Id { get; set; }
        [PrimeraLetraMayuscula]
        public string Titulo { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }
    }
}
