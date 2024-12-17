namespace AutoBazar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garaze garaze = new Garaze();
            
            Auto kia = new Auto("Kia", "Ceed", 8000, 5, 5, 7, "je vo velmi dobrom stave neporusena");
            Auto toyota = new Auto("Toyota", "Corolla", 15000, 8, 7, 9, "je skoro neposkodena ako nova dobra kvalita");
            Auto VLKW = new Auto("Volkswagen", "Golf", 3500, 4, 4, 3, "Auto je trochu oskrete s bokou a brzdy sa prehrievaju");
            Auto Ford = new Auto("Ford", "Fiesta", 5675, 4, 5, 7, "je v dobrom stave a ma najazdne 15 000 km ");
            Auto Mercedez = new Auto("Mercedes-Benz ", "A-Class", 9500, 5, 5, 7, "je vo velmi dobrom stave neporusena a ma na kufri originalny podpis Fuck Shita a Lewis Hamiltona");
            Auto Audi = new Auto("Audi", "A6", 8573, 5, 5, 7, "je vo velmi dobrom stave neporusena a s tuningom podlahy a vyfuku");
            Auto honda = new Auto("Honda", "Civic", 10000, 5, 5, 410, "je vo velmi dobrom stave neporusena");
            Auto dodge = new Auto("Dodge", "Challenger STR Hellcat ", 103563, 18, 2, 458, "auto je nové, v základe vybavené s twin turbom");
            Auto mazda = new Auto("Mazda", "MX 5", 5000, 7, 2, 130, "Auto bolo jazdené YouTuberom CarMightyVids");
            Auto subaru = new Auto("Subaru", "Impreza", 12000, 6, 5, 385, "v aute bolo jazdené rallye, má vylepšené odpruženie + twin trubo");
            Auto mitsubishi = new Auto("Mitsubishi", "Lancer Evo 9", 40000, 8, 5, 430, "auto má pokrčený zadný nárazník");
            Auto lexus = new Auto("Lexus", "LS600HL President", 15000, 9, 4, 420, "auto v dobrom stave,´najazdené 240xxx KM");

            garaze.PridajAuto(kia);
            garaze.PridajAuto(toyota);
            garaze.PridajAuto(VLKW);
            garaze.PridajAuto(Ford);
            garaze.PridajAuto(Mercedez);
            garaze.PridajAuto(Audi);
            garaze.PridajAuto(honda);
            garaze.PridajAuto(dodge);
            garaze.PridajAuto(mazda);
            garaze.PridajAuto(subaru);
            garaze.PridajAuto(mitsubishi);
            garaze.PridajAuto(lexus);


            List<string> auticka = new List<string>();
            bool isEnd = false;

            while (!isEnd)
            {
                VypisInfo();
                var akcia = Console.ReadLine();

                switch (akcia)
                {
                    case "1": // pridavanie Aut
                        Console.Clear();
                        Menu();
                        Console.WriteLine("Zadaj Prihlasovacie meno");
                        var zadavaniemena = Console.ReadLine();
                        Console.WriteLine("  ");
                        Console.WriteLine("Zadaj Heslo");
                        var zadaniehesla = Console.ReadLine();
                        Console.WriteLine("  ");

                        var meno = "Jan";
                        var men0 = "Jakub";
                        var heslo = "Heslo123";
                        var hesl0 = "HesloHeslo";
                        var menosecret = "Mato";
                        var heslosecret = "Automaty<3";  

                        if (zadavaniemena == meno && zadaniehesla == heslo)
                        {
                            Console.Clear();
                            Menu();

                        }
                        else if (zadavaniemena == men0 && zadaniehesla == hesl0)
                        {
                            Console.Clear();
                            Menu();

                        }
                        else if (zadavaniemena == menosecret && zadaniehesla == heslosecret)
                        {
                            Console.Clear();
                            Menu();

                        }
                        else
                        {
                            Console.WriteLine("Nespravne meno alebo heslo");
                            break;
                        }
                        Console.WriteLine("Znacka Aut");
                        var znacka = Console.ReadLine();
                        Console.WriteLine("----------------------------------------- ");
                        Console.WriteLine("Model Auta");
                        var model = Console.ReadLine();
                        Console.WriteLine("----------------------------------------- ");
                        Console.WriteLine("Cena Auta");
                        var cena = Console.ReadLine();
                        Console.WriteLine("----------------------------------------- ");
                        Console.WriteLine("Spotreba Auta");
                        var spotreba = Console.ReadLine();
                        Console.WriteLine("----------------------------------------- ");
                        Console.WriteLine("Pocet pasazierov");
                        var pasaziery = Console.ReadLine();
                        Console.WriteLine("----------------------------------------- ");
                        Console.WriteLine("Objem botozinoveho prietoru Auta");
                        var batozina = Console.ReadLine();
                        Console.WriteLine("----------------------------------------- ");
                        Console.WriteLine("Opis");
                        var opis = Console.ReadLine();
                        Console.WriteLine("----------------------------------------- ");

                     
                        AddCar(auticka, znacka, model, Int32.Parse(cena), float.Parse(spotreba), Int32.Parse(pasaziery), Int32.Parse(batozina), opis);                    
                        break;

                    case "2": // Prezeranie Aut

                        Console.Clear();
                        Menu();
                        foreach (var caros in auticka)
                        {
                           
                            Console.WriteLine(caros);                         
                            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------");
                            
                        }
                        garaze.VypisVsetkyAuta();
                        Console.WriteLine("  ");
                        Console.WriteLine("[][][][][][][][][][][][][][][][][  ");
                        Console.WriteLine("1. Pridat Auto medzi oblubene  []");
                        Console.WriteLine("2. Vratit sa na Hlavnu ponuku  []");
                        Console.WriteLine("[][][][][][][][][][][][][][][][][  ");
                        var dhcp = Console.ReadLine();
                        switch (dhcp) 
                        {
                            case "1":
                                Console.WriteLine("Zadajte index auta na Pridanie medzi oblubene");
                                var indexAuta = Console.ReadLine();
                               // garaze.PridajAuto(indexAuta);                              
                                Console.WriteLine("");
                                Console.WriteLine("Funkcia zatial neplatna  ");

                                break; 
                            case "2":
                                Console.WriteLine("  ");
                                Console.WriteLine("Vraciam na Hlavnu ponuku  ");
                                Console.WriteLine("Bude chvilu trvat");
                                Thread.Sleep(1000);
                                break;
                        }
                        break;
                   
                    case "3": //Oblubene Auta
                        Console.Clear();
                        Menu();
                        Console.WriteLine("Tvoje oblubene auta");
                        

                        break;
                    case "4": //Kupovanie Auta
                        Console.Clear();
                        Menu();
                        Console.WriteLine("1. Prezeranie vsetkych Aut");
                        Console.WriteLine("2. Prezeranie oblubenych Aut");
                        var dhcpu = Console.ReadLine();
                        switch (dhcpu) 
                        {
                            case "1":
                                Console.Clear();
                                Menu();
                                garaze.VypisVsetkyAuta();
                                Console.WriteLine();
                                foreach (var caros in auticka)
                                {

                                    Console.WriteLine(caros);
                                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------");
                                    
                                }
                                Console.WriteLine("Vyber Auto na kupovania:");
                                int indexAuta = int.Parse(Console.ReadLine());
                                garaze.VypocitajCenuPredaju(indexAuta);
                                
                                Thread.Sleep(1000);
                                
                                break; 
                            case "2":
                                Console.Clear();
                                Menu();
                                Console.WriteLine("Nemas oblubene auta musis ich pridat");
                                break;                       
                        }

                        
                        
                        //Vypocitanie ceny
                        
                        break;

                    case "5": //Harakiri aplikacie
                        isEnd = true;
                        Console.WriteLine("");
                        Console.WriteLine("Dakujeme za pouzivanie applikacie. Dufam za sa vratite");
                        break;

                }
            }
        }
        public static void AddCar(List<string> carList, string znacka1, string model1, int cena1, double spotreba1, int batozina1, int pasaziery1, string opis1)
        {
            string foundedCar = null;
            foreach (var car in carList)
            {
                if (car.Contains(znacka1))
                {
                    foundedCar = car;

                }
            }

            if (foundedCar == null)
            {
                var newCreatedCar = $"Auto znacky {znacka1}  {model1} za {cena1}$ ma spotrebu {spotreba1} velkost batozinoveho priestoru je {batozina1} pasaziery {pasaziery1} Opis: {opis1}";
                carList.Add(newCreatedCar);
                Console.WriteLine($"Auto: {znacka1.ToUpper()} bolo pridane do aplikacie.");
            }
        }

        public static void VypisInfo()
        {
            Thread.Sleep(1500);
            Console.Clear();
           Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("    ___        __         ____");
            Console.WriteLine("   /   | __ __/ /______  / __ )____ _____  ____ ______");
            Console.WriteLine("  / /| |/ / / / __/ __ |/ __  / __  /_   / __  / ___/");
            Console.WriteLine(" / ___ / /_/ / /_/ /_/ / /_/ / /_/ /  / /_/_/ / /");
            Console.WriteLine("/_/  |_|__._/|__/|___/_____/ |__,_/  /___/|__/_/");
            Console.WriteLine("------------------------------------------------------- ");
            Console.WriteLine("  |  _. ._     _.     |  _. |      |_   ");
            Console.WriteLine("\\_| (_| | |   (_|   \\_| (_| |< |_| |_) ");
            Console.WriteLine("----------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Pridanie Auta");
            Console.WriteLine("2. Prezeranie Aut");
            Console.WriteLine("3. Oblubene Auta");
            Console.WriteLine("4. Kupovanie Auta");
            Console.WriteLine("5. Exit");
            Console.WriteLine("  ");
            Console.WriteLine("Vyberte akciu   ");
        }
        public static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("    ___        __         ____");
            Console.WriteLine("   /   | __ __/ /______  / __ )____ _____  ____ ______");
            Console.WriteLine("  / /| |/ / / / __/ __ |/ __  / __  /_   / __  / ___/");
            Console.WriteLine(" / ___ / /_/ / /_/ /_/ / /_/ / /_/ /  / /_/_/ / /");
            Console.WriteLine("/_/  |_|__._/|__/|___/_____/ |__,_/  /___/|__/_/");
            Console.WriteLine("------------------------------------------------------- ");
            Console.WriteLine("  |  _. ._     _.     |  _. |      |_   ");
            Console.WriteLine("\\_| (_| | |   (_|   \\_| (_| |< |_| |_) ");
            Console.WriteLine("----------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }    
}