﻿using System;
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
    public partial class cardDrawSettingPage : PhoneApplicationPage
    {
        public cardDrawSettingPage()
        {
            InitializeComponent();
        }

        private void repeatingCardB_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page/repeatingCardPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void nonrepeatingCardB_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page/nonrepeatingCardPage.xaml", UriKind.RelativeOrAbsolute));
        }





    }
}