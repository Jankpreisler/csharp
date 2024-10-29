using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_Pat
{
    internal class Programator
    {
        public string Meno { get; set; }
        public int Vek { get; set; }

        public Programator()
        {
        }

        public Programator(string meno, int vek)
        {
            this.Meno = meno;
            this.Vek = vek;

        }
        public void Programovanie()
        {
            Console.WriteLine("Meno: " + Meno + " || Vek " + Vek + " || Programuje");
        }
    }
}
