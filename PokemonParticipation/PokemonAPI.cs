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
        public int height { get; set; }
        public int weight { get; set; }
        public string front_default { get; set; }
        public string back_default { get; set; }
    }


}
