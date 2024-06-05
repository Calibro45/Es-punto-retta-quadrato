using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioPunto
{
    internal class Punto
    {
        public int Ascissa {  get; set; }
        public int Ordinata { get; set; }

        public Punto(int asc, int ord) 
        {
            Ascissa = asc;
            Ordinata = ord;
        }
    }
}
