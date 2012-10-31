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
    public partial class nonrepeatingCardPage : PhoneApplicationPage
    {
        bool[,] drawned = new bool[4, 13];
        int numDrawned = 0;

        public nonrepeatingCardPage()
        {
            InitializeComponent();
        }

        private void cardDrawB_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();

            
            int result1 = 0;
            int result2 = 0;
            String suit = "";
            String value = "";
            String cardString = "";

            numDrawned++;
            if (numDrawned > 52)
            {
                stackPanel1.Children.Add(new TextBlock() { Text = "All cards have been drawned" });
                stackPanel1.Children.Add(new TextBlock() { Text = "  " });

                scrollViewer1.ScrollToVerticalOffset(stackPanel1.ActualHeight);
            }
            else
            {
                do
                {
                    result1 = random.Next(0, 4);
                    result2 = random.Next(0, 13);
                } while (drawned[result1, result2] == true);

                drawned[result1, result2] = true;

                result1++;
                result2++;

                switch (result1)
                {
                    case 1:
                        suit = "Hearts";
                        break;
                    case 2:
                        suit = "Clubs";
                        break;
                    case 3:
                        suit = "Diamonds";
                        break;
                    default:
                        suit = "Spades";
                        break;
                }

                switch (result2)
                {
                    case 1:
                        value = "Ace";
                        break;
                    case 2:
                        value = "2";
                        break;
                    case 3:
                        value = "3";
                        break;
                    case 4:
                        value = "4";
                        break;
                    case 5:
                        value = "5";
                        break;
                    case 6:
                        value = "6";
                        break;
                    case 7:
                        value = "7";
                        break;
                    case 8:
                        value = "8";
                        break;
                    case 9:
                        value = "9";
                        break;
                    case 10:
                        value = "10";
                        break;
                    case 11:
                        value = "Jack";
                        break;
                    case 12:
                        value = "Queen";
                        break;
                    default:
                        value = "King";
                        break;
                }
                if (value.Equals("Ace") || value.Equals("8"))
                {
                    cardString = "An " + value + " of " + suit;
                    lastDrawBox.Text = cardString;
                }
                else
                {
                    cardString = "A " + value + " of " + suit;
                    lastDrawBox.Text = cardString;
                }

                stackPanel1.Children.Add(new TextBlock() { Text = cardString });
                stackPanel1.Children.Add(new TextBlock() { Text = "  " });
                scrollViewer1.UpdateLayout();
                scrollViewer1.ScrollToVerticalOffset(stackPanel1.ActualHeight);
            }
        }
    }
}