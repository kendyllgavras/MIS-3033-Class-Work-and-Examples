﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonParticipation
{
    public class PokemonAPI
    {
        public List<AllResults> results { get; set; }


    }

    public class AllResults
    {
        public string name { get; set; }
        public string url { get; set; }


        public override string ToString()
        {
            return name;
        }
    }

    public class PokemonInfo
    {
        public double height { get; set; }
        public double weight { get; set; }
        public double id { get; set; }

        public override string ToString()
        {
            string sentence = $"height: {height}  weight: {weight}";
            return sentence;
        }
    }


    public class Sprite
    {
        public string front_default { get; set; }
        public string back_default { get; set; }
    }


}
