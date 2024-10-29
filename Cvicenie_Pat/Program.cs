using System.Diagnostics.CodeAnalysis;

namespace Cvicenie_Pat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mesto bratislava = new Mesto("Bratislava") ;
            Mesto kosice = new Mesto("Kosice");            

            Obcan  obcan = new Obcan() {Meno = "Peter",Vek = 45};
            Obcan obcan1 = new Obcan() { Meno = "Igor", Vek = 35 };

            Obcan obcan2 = new Obcan() { Meno = "Jan", Vek = 16 };
            Obcan obcan3 = new Obcan() { Meno = "Martina", Vek = 45 };

            Lekar lekar = new Lekar() { Meno = "FIlo", Vek = 25};
            Predavac predavac = new Predavac() {Meno = "Dalibor", Vek = 25 };
            Lekar lekar1 = new Lekar() {Meno = "Vanasa", Vek = 16 };
            Programator programator = new Programator() {Meno = "Rado", Vek = 36 };
                       

            bratislava.Pridajlekaradomesta(lekar1);
            bratislava.Pridajlekaradomesta(lekar);
            bratislava.PridajObcanadomesta(obcan);


            kosice.PridajPredavaca(predavac);
            kosice.PridajProgramatora(programator);
            kosice.PridajObcanadomesta(obcan3);

            bratislava.VypisObcanov();
            kosice.VypisObcanov();
        }
    }
}