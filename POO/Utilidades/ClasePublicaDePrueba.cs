namespace Utilidades
{
    public class ClasePublicaDePrueba
    {
        public int PropiedadPublica { get; set; }  
        internal int PropiedadInterna { get; set; }
        protected int PropiedasProtegida { get; set; }
        protected internal int PropiedadProtectedInternal { get; set; }
        private protected int PropiedadPrivateProtected { get; set; }
        public void MetodoPublico()
        {
            PropiedadInterna = 1;
            PropiedasProtegida = 2;
            PropiedadProtectedInternal = 3;
            PropiedadPrivateProtected = 4;
            Console.WriteLine("Soy un metodo publico de otro proyecto");
            MetodoPrivado();
        }

        private void MetodoPrivado()
        {
            var claseInterna = new ClaseInterna();
        }

        private class ClaseInterna
        {

        }

    }
}