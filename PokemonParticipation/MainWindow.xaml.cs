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

            //using is too complex so we have to convert it to json so it can be read
            using (var client=new HttpClient())
            {
                string jsonresults = client.GetStringAsync(apiURL).Result;
                pokemonAPIResults = JsonConvert.DeserializeObject<PokemonAPI>(jsonresults);
            }

            foreach (var character in pokemonAPIResults.results)
            {
                lstbx1.Items.Add(character);
               
            }


        }

        private void cbocharacters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // save selected item as variable so we can find url
            var selection = (AllResults)cbocharacters.SelectedItem;

           
            
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            string pokemonback = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/132.png";
             imgpokemon.Source = new BitmapImage(new Uri(pokemonback));
        }

        private void rdofront_Checked(object sender, RoutedEventArgs e)
        {
            string pokemonfront = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/front/132.png";
            imgpokemon.Source = new BitmapImage(new Uri(pokemonfront));
        }
    }
}
