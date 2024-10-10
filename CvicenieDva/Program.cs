using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            List<string> list = new List<string>();            
            bool isEnd = false;

            while (!isEnd)
            {
                PrintMenu();
                var odpoved = Console.ReadLine();

                switch (odpoved)
                {
                    case "1":
                        foreach (var item in list)
                        {                         
                          Console.WriteLine(item);                                                
                        }
                        break;
                    case "2":
                        Console.WriteLine("Zadajte meno noveho produktu");
                        var newtimes = Console.ReadLine();
                        Console.WriteLine("Zadajte kolko kusov noveho predmetu");
                        var newcount = Console.ReadLine();
                        AddTime(list, newtimes, int.Parse(newcount));
                        break;
                    case "3":
                        isEnd = true;
                        break;

                    default:
                        Console.WriteLine("Nespravny znak");
                        break;
                }
            }              
        }
        static void AddTime(List<string> itemList, string newtimes, int newCount)
        {
            string founditem = null;
            foreach (var item in itemList)
            {
                if (item.Contains(newtimes))
                { founditem = item; }
            }
            if (founditem == null)
            {
                var novyVytvorenyitem = $"{newtimes}||{newCount}";
                itemList.Add(newtimes);
                Console.WriteLine($"Predmet {newtimes.ToUpper()} bol pridany do obchodu");
            }
            else
            {
                Console.WriteLine();
                var spocitatitem = founditem.Split("||");
                var foundname = spocitatitem[0];
                var foundCount = int.Parse(spocitatitem[1]);
                var newitemcount = foundCount + newCount;

                var indexoditem = founditem.IndexOf(newtimes);
                itemList[indexoditem] = $"{newtimes}||{newitemcount}";
                Console.WriteLine($"Predmet {founditem.ToUpper()} bol zaktulizovany");
            } 

        }   
       static void PrintMenu() 
        {
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("1. Vpysanie polozky");
            Console.WriteLine("2. Pridanie Polozky");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Vyberte Akciu");
        }
    }
}


// odtranovanie velicin postupne

