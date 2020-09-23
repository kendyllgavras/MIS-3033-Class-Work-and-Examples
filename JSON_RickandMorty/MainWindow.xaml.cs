using Newtonsoft.Json;
using System;
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

namespace JSON_RickandMorty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string webService = @"https://rickandmortyapi.com/api/character/";


            //HttpClient Client = new HttpClient(); line 31 and and 32 means same thing

            characters characters;
            using(HttpClient client=new HttpClient())
            {
                var results = client.GetStringAsync(webService).Result;

                characters = JsonConvert.DeserializeObject<characters>(results);

            }

            foreach (var character in characters.results)
            {
                cbocharacters.Items.Add(character);
            }


        }

        private void cbocharacters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var character = (character)cbocharacters.SelectedItem;
            var uri = new Uri(character.image);


            imgCharacter.source = new BitmapImage(new Uri(character.image));
        }
    }
}
