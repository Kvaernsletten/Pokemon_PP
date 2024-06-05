using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_PP
{
    internal class Pokemon
    {
        public string Name { get; private set; }
        public int Health { get; set; }
        public string Type { get; private set; }
        public int Strenght { get; set; }
        public Pokemon(string name, int health, string type, int strength) 
        {
            Name = name;
            Health = health;
            Type = type;
            Strenght = strength;
        }

    }
}
