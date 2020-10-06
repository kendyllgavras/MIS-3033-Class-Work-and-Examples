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
            string apiURL = @"https://pokeapi.co/api/v2/pokemon?limit=1100&offset=0";

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
        private void lstbx1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedPokie = (AllResults)lstbx1.SelectedItem;
            string infoseturl = @"https://pokeapi.co/api/v2/pokemon/" + selectedPokie;

            PokemonInfo pokieinfo;
            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(infoseturl).Result;
                pokieinfo = JsonConvert.DeserializeObject<PokemonInfo>(json);
            }

            txtbxinfo.Text = pokieinfo.ToString();

            Sprite sprite = new Sprite();
            sprite.front_default = @"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/" + pokieinfo.id + ".png";
            sprite.back_default = @"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/" + pokieinfo.id + ".png";

            if (rdofront.IsChecked==true)
            {
            imgpokemon.Source = new BitmapImage(new Uri(sprite.front_default));
            }
            if (rdoback.IsChecked==true)
            {
                imgpokemon.Source = new BitmapImage(new Uri(sprite.back_default));
            }
        }
    }
}
