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
        
        


        public Mesto(string mesta)
        {
            Mesta = mesta;
            Obcania = new List<Obcan>();          
              
      
        }        
        public void PridajObcanadomesta(Obcan obcan) 
        {
            Obcania.Add(obcan);
        }
        
        public void VypisObcanov()
        {                      
            Console.WriteLine("Obcania mesta " + Mesta);

            foreach (var obcan in Obcania)
            {
                obcan.VypisInfo();
               
            }                                                       
            
            
        }

    }
}
