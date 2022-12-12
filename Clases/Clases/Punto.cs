using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal struct Punto
    {
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int x { get; }
        public int y { get; }

        public double Distancia(Punto b) => Math.Sqrt(Math.Pow(b.x - x, 2) + Math.Pow(b.y - y, 2));
        
    }
}
