using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WPFClasses
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
               
        }

        private void btnapplication_Click(object sender, RoutedEventArgs e)
        {   
            EntryForm Userentry=new EntryForm();
            Userentry.Name = txtname.Text;
            Userentry.Address = txtzipcode.Text;


            ListBox ListBox1 = new ListBox();
            
            txtname.Text = "";
            txtaddress.Text = "";
            txtzipcode.Text = "";

            ListBox1.Items.Add(Userentry);
          
        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            txtname.Clear();
            txtaddress.Clear();
            txtzipcode.Clear();
        }
    }
}
