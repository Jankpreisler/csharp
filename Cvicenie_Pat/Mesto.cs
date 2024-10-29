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
        public List<Lekar> lekars { get; set; }
        public List<Predavac> Preda { get; set; }
        public List<Programator>  Progra { get; set; }


        public Mesto(string mesta)
        {
            Mesta = mesta;
            Obcania = new List<Obcan>();
            lekars = new List<Lekar>();
            Preda = new List<Predavac>();   
            Progra = new List<Programator>();   
        }
        public void Pridajlekaradomesta(Lekar lekar)
        {
            lekars.Add(lekar);
        }
        public void PridajObcanadomesta(Obcan obcan) 
        {
            Obcania.Add(obcan);
        }
        public void PridajPredavaca(Predavac predavac)
        {
            Preda.Add(predavac);
        }
        public void PridajProgramatora(Programator programator)
        {
            Progra.Add(programator);
        }

       
        public void VypisObcanov()
        {                      
            Console.WriteLine("Obcania mesta " + Mesta);

            foreach (var obcan in Obcania)
            {
                obcan.Vypisobcanov();

            }          
               
            foreach (var lekar in lekars)
            {
                lekar.Liecenie();
            }
            
            foreach (var program in Progra)
            {
                program.Programovanie();
            }                      
            ;
            foreach (var predavanie in Preda)
            {
                predavanie.Predavanie();
            }
            Console.WriteLine() ;   
        }

    }
}
