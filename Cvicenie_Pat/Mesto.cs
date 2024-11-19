using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_Pat
{
    internal class Mesto
    {
        private string mesta;
        private List<Obcan> obcanie;

        public string Mesta 
        { 
          get { return mesta; } 
          set { mesta = value; }      
        } 

        public List<Obcan> Obcania 
        {
            get { return obcanie; } 
            set { obcanie = value; }
        
        } 
        

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
