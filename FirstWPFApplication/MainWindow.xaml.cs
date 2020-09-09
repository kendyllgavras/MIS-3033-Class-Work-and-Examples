﻿using System;
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

namespace FirstWPFApplication
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
            string name, birthdate;
            name = txtName.Text;
            birthdate = txtBday.Text;

            DateTime birthdateasdatetime = Convert.ToDateTime(birthdate);
            var howoldtheyare = DateTime.Now - birthdateasdatetime;
            int old = Convert.ToInt32(howoldtheyare.TotalDays / 365);


            MessageBox.Show($"{name} you are {old} years old!","Hello!");
        }

        private void btnGo_MouseEnter(object sender, MouseEventArgs e)
        {
            btnGo.Background = new SolidColorBrush(Colors.Coral);
        }
    }
}
