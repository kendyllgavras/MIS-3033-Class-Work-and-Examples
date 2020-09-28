using System;
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

    public class PokemonSprite
    {
        public int Height { get; set; }
        public int Weight { get; set; }
    }

    public class sprite
    {
        //info on one pokemon
    }
}
