﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazar
{
    internal class Auto
    {
        public int ID { get; set; }
        public string Znacka { get; set; }
        public string  Model { get; set; }
        public int Cena { get; set; }
        public int Spotreba { get; set; }
        public int Pasaziery { get; set; }
        public int Batozina { get; set; }
        public string Opis { get; set; }

        public Auto(int id,string znacka, string model, int cena, int spotreba, int pasaziery, int batozina, string opis)
        {
            this.ID = id;
            Znacka = znacka;
            Model = model;
            Cena = cena;
            Spotreba = spotreba;
            Pasaziery = pasaziery;
            Batozina = batozina;
            Opis = opis;
        }

        public virtual void VypisInfo() 
        {
            Console.WriteLine($"{ID} - {Znacka}  {Model} za {Cena}$ ma spotrebu {Spotreba} velkost batozinoveho priestoru je {Batozina} pasaziery {Pasaziery} Opis: {Opis}");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------");
        }
    }
}
