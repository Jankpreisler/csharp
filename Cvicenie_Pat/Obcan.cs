using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_Pat
{
    public class Obcan
    {
        protected string meno;
        protected int vek;


        public string Meno 
        {
            get { return meno; } 
            set { meno = value; }
        } 

        public int Vek 
        {
            get { return vek; } set { vek = value; }          
        }
        
        public Obcan(string meno, int vek)
        {
            Meno = meno;
            Vek = vek;
           
        }
        public virtual void VypisInfo() 
        {
            Console.WriteLine("Meno: " + Meno + " || Vek: " + Vek);

        }
    }
}
