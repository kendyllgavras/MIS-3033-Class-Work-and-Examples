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

namespace IntrotoWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtAge.Text = string.Empty;
            txtName.Clear();
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            string name, age;
            name = txtName.Text;
            age = txtAge.Text;

            int ageasnumber = Convert.ToInt32(age);

            // for wpf participation on 9/9/2020
            //DateTime birthdate = Convert.ToDateTime(name); //name is date as a string
            //var howOldAreThey = DateTime.Now - birthdate;
            //int old = Convert.ToInt32(howOldAreThey.TotalDays / 365);

            btnGo.Background = new SolidColorBrush(Colors.AliceBlue);

            MessageBox.Show($"Welcome {name} who is {age}", "Hello!");
        }

        //shows this message when you enter the go! btn with your mouse
        // private void btnGo_MouseEnter(object sender, MouseEventArgs e)
        // {
        //     MessageBox.Show("You have entered the button", "ENTERED");
        // }
    }
}
