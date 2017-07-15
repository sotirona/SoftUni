﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.PokemonTrainer
{
    public class Pokemon
    {
        public string Name { get; set; }
        public string Element { get; set; }
        public double Health { get; set; }      

        public Pokemon(string name, string element, double health)
        {
            this.Name = name;
            this.Element = element;
            this.Health = health;
        }
    }
}
