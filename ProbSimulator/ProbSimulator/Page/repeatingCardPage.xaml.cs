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
    public partial class cardPage : PhoneApplicationPage
    {
        public cardPage()
        {
            InitializeComponent();
        }

        private void drawB_Click(object sender, RoutedEventArgs e)
        {

            int numDraw = 0;
            Int32.TryParse(numDrawBox.Text, out numDraw);

            if (Int32.TryParse(numDrawBox.Text, out numDraw) != false && numDraw <= 1000)
            {
                cardDraw(numDraw);
            }
            else if (Int32.TryParse(numDrawBox.Text, out numDraw) != false && numDraw > 1000)
            {
                MessageBox.Show("Please enter a number less than 1000");
            }
            else
            {
                MessageBox.Show("Please enter only integer (no decimal)");
            }
        }

        private void cardDraw(int numDraw)
        {
            Random random = new Random();

            
            int result = 0;
            String suit = "";
            String value = "";
            String cardString = "";

            for (int i = 0; i < numDraw; i++)
            {
                result = random.Next(0, 4);
                result++;
                switch (result)
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
                result = random.Next(0, 13);
                result++;
                switch (result)
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
                    resultBox.Text = cardString;
                }
                else
                {
                    cardString = "A " + value + " of " + suit;
                    resultBox.Text = cardString;
                }

                stackPanel1.Children.Add(new TextBlock() { Text = cardString });
            }
            stackPanel1.Children.Add(new TextBlock() { Text = "  " });
            scrollViewer1.UpdateLayout();
            scrollViewer1.ScrollToVerticalOffset(stackPanel1.ActualHeight);
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}