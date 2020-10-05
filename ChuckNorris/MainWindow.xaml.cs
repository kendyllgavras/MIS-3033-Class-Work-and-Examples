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

namespace ChuckNorris
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            
            string apiurl = @"https://api.chucknorris.io/jokes/categories";



            using (var client=new HttpClient())
            {
                string jsonresults = client.GetStringAsync(apiurl).Result;
                jsonresults = client.GetStringAsync(@"https://api.chucknorris.io/jokes/categories").Result;
                string[] cats = JsonConvert.DeserializeObject<string[]>(jsonresults);

                cbocategory.Items.Add("all");
                 foreach (var item in cats)
                 {
                    cbocategory.Items.Add(item);
                 }
            }
        
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string selectedcategory = cbocategory.SelectedItem.ToString();
            string allapiuril= @"https://api.chucknorris.io/jokes/random";
            string catapi = @"https://api.chucknorris.io/jokes/random?category=" + selectedcategory;
            
            if (cbocategory.SelectedValue.ToString()=="all")
            {
                using (var client=new HttpClient())
                {

                }
            }
        }
    }
}
