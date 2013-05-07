/*This file is part of Probability Simulator.

Probability Simulator is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Probability Simulator is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Probability Simulator.  If not, see<http://www.gnu.org/licenses/> */
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

        private void _4dB_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page/Dice Pages/fourDicePage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void _6dB_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page/Dice Pages/sixDicePage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void _8dB_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page/Dice Pages/eightDicePage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void _10dB_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page/Dice Pages/tenDicePage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void _12dB_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page/Dice Pages/twelveDicePage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void _20dB_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page/Dice Pages/twentyDicePage.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}