using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class ControladorDePeliculas
    {
        private readonly IAlmacenadorArchivos almacenadorArchivos;

        public ControladorDePeliculas(IAlmacenadorArchivos almacenadorArchivos)
        {
            this.almacenadorArchivos = almacenadorArchivos;
        }

        public void GuardarPoster(string poster)
        {
            //Mas codigo antes de...
            almacenadorArchivos.Guardar(poster);
        
            //Mas codigo depues de...
        }

        public void BorrarPoster(string urlPoster)
        {
            //mas codigo
            almacenadorArchivos.Borrar(urlPoster);
            //mas codigo
        }
    }
}
