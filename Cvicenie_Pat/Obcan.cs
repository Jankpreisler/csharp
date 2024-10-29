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

        public Obcan(string meno, int vek, string zamestnanie)
        {
            Meno = meno;
            Vek = vek;
           
        }
        public void Vypisobcanov() 
        {
            Console.WriteLine("Meno: " + Meno + " || "+ " Vek:  " + Vek);

        }
        /* public void Lieci()         
        {
        Console.WriteLine("Meno - " + Meno + " || Vek  - " + Vek +" || - Lieci");    

        }
        public void Programy() 
        {
            Console.WriteLine("Meno - " + Meno + " || Vek  - " + Vek +  " || - programuje");
        }
        public void Ucitel() 
        {
            Console.WriteLine("Meno - " + Meno +  " || Vek  - " + Vek +" || - uci");
        }*/
    }
}
