﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Fight
{
    public class GameEngine 
    {
      public Pokemon FirstPokemon { get; set; }
      public Pokemon LastPokemon { get; set; }

        public GameEngine()
        {
            FirstPokemon = new Pokemon("Pikachu");
            LastPokemon = new Pokemon("Eevee");
        }
    }
}
