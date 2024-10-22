using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_Pat
{
    internal class Mesto
    {
        public string Mesta { get; set; }

        public List<Obcan> Obcania { get; set; }

        public Mesto()
        {

        }

        public Mesto(string mesta, List<Obcan> obcania)
        {
            Mesta = mesta;
            Obcania = obcania;
        }
        public string PridajObcana(Obcan obcan) 
        {
            return Mesta + Obcania;

        }
        public string VypisObcanov() 
        {
            return 


        }
    }
}
