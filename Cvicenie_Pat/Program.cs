using System.Diagnostics.CodeAnalysis;

namespace Cvicenie_Pat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mesto bratislava = new Mesto("Bratislava") ;
            Mesto kosice = new Mesto("Kosice");            

            Obcan obcan = new Obcan() {Meno = "Peter",Vek = 45 };
            Obcan obcan1 = new Obcan() {Meno = "Igor",Vek = 35 };

            Obcan obcan2 = new Obcan() { Meno = "Jan", Vek = 16 };
            Obcan obcan3 = new Obcan() { Meno = "Martina", Vek = 45 };




            bratislava.PridajObcana(obcan);
            bratislava.PridajObcana(obcan1);

            kosice.PridajObcana(obcan2);
            kosice.PridajObcana(obcan3);

            bratislava.VypisObcanov();
            kosice.VypisObcanov();
        }
    }
}