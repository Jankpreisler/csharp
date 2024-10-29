using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_Pat
{
    internal class Programator : Obcan
    {
        public string Programovacijazyk { get; set; }
        public Programator(string meno, int vek, string programovacijazyk) : base(meno, vek) 
        { 
        
         this.Programovacijazyk = programovacijazyk;
        }
        public new void VypisInfo()
        {
            Console.WriteLine("Meno: " + Meno + " || Vek " + Vek + " || Programuje v " + Programovacijazyk);
        }
    }
}
