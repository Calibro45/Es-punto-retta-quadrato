using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioPunto
{
    internal class Retta
    {
        public Punto Coordinata1 { get; set; }
        public Punto Coordinata2 { get; set; }

        public Retta(Punto coordinata1, Punto coordinata2)
        {
            Coordinata1 = coordinata1;
            Coordinata2 = coordinata2;
        }

        public double Distanza()
        {
            var yf = Coordinata2.Ordinata;
            var yi = Coordinata1.Ordinata;

            var xf = Coordinata2.Ascissa;
            var xi = Coordinata1.Ascissa;

            var diffY = Diff(yf, yi);
            var diffX = Diff(xf, xi);

            var sumPotenze = Power(diffX, 2) + Power(diffY, 2);

            var sqrt = Radice(sumPotenze);

            return sqrt;
        }
        private double Diff(double n1, double n2)
        {
            return n1 - n2;
        }
        private double Power(double n, double esp)
        {
            return Math.Pow(n, esp);
        }
        private double Radice(double n)
        {
            return Math.Sqrt(n);
        }
    }
}
