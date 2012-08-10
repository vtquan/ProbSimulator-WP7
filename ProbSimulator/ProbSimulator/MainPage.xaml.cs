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
            NavigationService.Navigate(new Uri("/cardDrawSettingPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void spinnerB_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}