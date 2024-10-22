using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_Pat
{
    internal class Obcan
    {
        public string Meno { get; set; }

        public int Vek { get; set; }

        public Obcan()
        {

        }

        public Obcan(string meno, int vek)
        {
            Meno = meno;
            Vek = vek;
        }
        public string Vypisobcanov() 
        {
            return Meno + Vek;
        
        }
    }
}
