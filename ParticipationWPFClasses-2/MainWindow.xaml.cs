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

namespace ParticipationWPFClasses_2
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (txtbxtoy.Text=="" || txtbxmanufacturer.Text=="")
            {
                MessageBox.Show("the manufacturer or toy you have entered is invalid");
            }

            bool success = double.TryParse(txtbxprice.Text, out double number);
            if (success==false)
            {
                MessageBox.Show("Invalid price");
            }

            Toy Toy1 = new Toy();
            Toy1.Name = txtbxtoy.Text;
            Toy1.Manufacturer = txtbxmanufacturer.Text;
            Toy1.Price = Convert.ToDouble(txtbxprice.Text);
            
            
            
            listbox.Items.Add(Toy1);

            txtbxmanufacturer.Clear();
            txtbxprice.Clear();
            txtbxtoy.Clear();
        }

        private void listbox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Toy selectedtoy = (Toy)listbox.SelectedItem;
            MessageBox.Show(selectedtoy.GetAisle());
        }

 
    }
}
