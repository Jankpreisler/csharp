using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazar
{
    internal class Garaze
    {
        public List<Auto> ZoznamAut { get; set; }
        public List<string> ZoznamAuta { get; set; }

        public  Garaze()
        {
            ZoznamAut = new List<Auto>();
            ZoznamAuta = new List<string>();
        }

        public Garaze(List<Auto> zoznamAut)
        {
            ZoznamAut = zoznamAut;
        }
        public void PridajAuto(Auto auto )
        {
            ZoznamAut.Add(auto);
            
        }
        public void OdstranjAuto(Auto auto)
        {
            ZoznamAut.Remove(auto);

        }
        public void VypisVsetkyAuta()
        {
            for (int i = 0; i < ZoznamAut.Count; i++)
            {
                Console.WriteLine($"Auto {i}:");
                ZoznamAut[i].VypisInfo();
                Console.WriteLine();
            }
           
        }
        public void VypocitajCenuPredaju(int indexAuta)
        {

            if (indexAuta < 0 || indexAuta >= 13)
            {
                Console.WriteLine("Bud ho niekto ukradol alebo jednoducho neexistuje.");
                return;
            }
            Auto vybraneAuto = ZoznamAut[indexAuta];
            double cenaPredaju = vybraneAuto.Cena;
            Console.WriteLine($"Auto znacky {vybraneAuto.Znacka} {vybraneAuto.Model} je predane za {cenaPredaju} eur.");
        }
    }
}
