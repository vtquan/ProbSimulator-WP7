using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace ProbSimulator
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void coinB_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/coinPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void diceB_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/dicePage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void cardB_Click(object sender, RoutedEventArgs e)
        {

        }

        private void spinnerB_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}