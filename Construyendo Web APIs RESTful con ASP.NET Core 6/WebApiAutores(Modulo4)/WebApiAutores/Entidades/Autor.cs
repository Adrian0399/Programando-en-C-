﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApiAutores.Entidades;
using WebApiAutores.Validaciones;

namespace WebApiAutores.Entidades
{
    public class Autor: IValidatableObject
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "El campo {0} es requerido!")]
        [StringLength(maximumLength: 120, ErrorMessage = "El campo {0} no debe de tener mas de {1} de caracteres!")]
        //[PrimeraLetraMayuscula]
        public string Nombre { get; set; }

        //[Range(18, 120)]
        //[NotMapped]
        //public int Edad { get; set; }

        //[CreditCard]
        //[NotMapped]
        //public string TarjetaDeCredito { get; set; }

        //[Url]
        //[NotMapped]
        //public string URL { get; set; }

        //public int Menor { get; set; }
        //public int Mayor { get; set; }

        public List<Libro> Libros { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!string.IsNullOrEmpty(Nombre))
            {
                var primeraLetra = Nombre[0].ToString();
                if (primeraLetra != primeraLetra.ToUpper())
                {
                    yield return new ValidationResult("La primera letra debe de ser Mayuscula", 
                        new string[] { nameof(Nombre) } );
                }
            }

            //if (Menor > Mayor)
            //{
            //    yield return new ValidationResult("Este valor no puede ser mas grande que el campo Mayor",
            //        new string[] { nameof(Menor) });
            //}

        }
    }
}