using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticipationWPFClasses_2
{
    class Toy
    {


        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        private string Aisle;



        public Toy()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Aisle = "";

        }

      
        public string GetAisle()
        {

            string codeforgetaisle = ($"{Manufacturer[0]}{Price}");
            return codeforgetaisle;
        }

        public override string ToString()
        {
            string showinbox = ($"{Manufacturer}-{Name}");
            return showinbox;
        }











    }
}
