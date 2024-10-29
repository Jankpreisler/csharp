using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_Pat
{
    internal class Lekar
    {
        public string Meno { get; set; }
        public int Vek { get; set; }

        public Lekar()
        {
        }

        public Lekar(string meno, int vek)
        {
          Meno = meno;
           Vek = vek;
            
        }

        public void Liecenie()
        {
            Console.WriteLine("Meno: " + Meno + " || Vek " + Vek + " || Lieci");
        }
    }

}

