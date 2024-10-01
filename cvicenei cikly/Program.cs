using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Console.WriteLine("Zadajte cislo");
            int number1 = int.Parse(Console.ReadLine());

            int i = 0;
            while (true)
            {
                Console.WriteLine(i);
                i++;
            
            if (i == number1)
            
                break;
            }*/

            /*List<string> listnames = new List<string>();

            listnames.Add(".Jan");
            listnames.Add(".Jakub");
            listnames.Add(".Michal");
            listnames.Add(".Fero");
            listnames.Add(".Martin");
            listnames.Add(".Peter");


            int poradie = 0;
            
            
            foreach (string name in listnames)            
            {
                poradie++;
                Console.WriteLine(poradie.ToString().PadLeft(5, '0') + name.ToUpper());
                
            }



            /*for (int i = 0; i < 10; i++)
            {
                string riadok = "";
                for (int x = 0; x <i; x++)
                {
                    riadok += "*";
                }
                Console.WriteLine(riadok);*/
       

            
                
            Console.WriteLine("Zadajte Meno");
                   

            List<string> listnames = new List<string>();
            listnames.Add(Console.ReadLine());
            listnames.Add(Console.ReadLine());
            listnames.Add(Console.ReadLine());
            listnames.Add(Console.ReadLine());
            listnames.Add(Console.ReadLine());
            listnames.Add(Console.ReadLine());

            foreach (string name in listnames)
            {
                Console.WriteLine(name);
            }



            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }















        }
    }
}