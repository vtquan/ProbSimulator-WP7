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

        private void cardDrawB_Click(object sender, RoutedEventArgs e)
        {
                cardDraw();
        }

        public void cardDraw()
        {
            Random random = new Random();

            int result = 0;
            String suit = "";
            String value = "";
            result = random.Next(0, 4);
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
                resultBox.Text = "An " + value + " of " + suit;
            }
            else
            {
                resultBox.Text = "A " + value + " of " + suit;
            }


        }
    }
}