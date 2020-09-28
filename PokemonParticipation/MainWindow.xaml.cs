using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PokemonParticipation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            PokemonAPI pokemonAPIResults;
            string apiURL = @"https://pokeapi.co/api/v2/pokemon?limit=0&offset=1100";

            using (var client=new HttpClient())
            {
                string jsonresults = client.GetStringAsync(apiURL).Result;
                pokemonAPIResults = JsonConvert.DeserializeObject<PokemonAPI>(jsonresults);
            }

            foreach (var character in pokemonAPIResults.results)
            {
                cbocharacters.Items.Add(character);
            }
        }
    }
}
