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
    public partial class dicePage : PhoneApplicationPage
    {
        public dicePage()
        {
            InitializeComponent();
        }

        private void sixDiceB_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/sixDicePage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void tenDiceB_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/tenDicePage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void twentyDiceB_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/twentyDicePage.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}