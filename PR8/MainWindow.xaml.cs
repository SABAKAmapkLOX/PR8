﻿using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PR8
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
            Person person = new Person(tbFirstName.Text,tbLastName.Text,tbEmail.Text,tbPhoneNumber.Text);
            string compareLastName = tbLastName.Text;
            string InformationPerson = person.ReturnInformation();
            ListBoxPersonInformation.Items.Add(InformationPerson);
        }
    }
}