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

namespace Classes3
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Student Student1 = new Student();
            Student1.FirstName = txtbxfirstname.Text;
            Student1.LastName = txtbxlastname.Text;
            Student1.Major = txtbxmajor.Text;
            Student1.GPA =Convert.ToDouble( txtbxgpa.Text);
            Student1.SetAddress(Convert.ToInt32(txtbxstreetnum.Text), txtstreetname.Text, txtbxstate.Text, txtbxcity.Text, Convert.ToInt32(txtbxzipcode.Text));

            lstbxstudents.Items.Add(Student1);

        }

        private void lstbxstudents_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            StudentInfo newstudentinfo = new StudentInfo();
        }
    }
}
