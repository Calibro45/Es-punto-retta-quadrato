using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioPunto
{
    internal class Quadrato
    {
        public Retta Lato { get; set; }

        public Quadrato(Retta r)
        {
            Lato = r;
        }

        // Calcolare perimetro l*4
        public double Perimetro()
        {
            var perimetro = Lato.Distanza() * 4;
            return perimetro;
        }

        // Calcolare Area l*l
        public double Area()
        {
            return Math.Pow(Lato.Distanza(), 2);
        }
    }
}
