﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace ProbSimulator.Page.Dice_Pages
{
    public partial class twelveDicePage : PhoneApplicationPage
    {
        public twelveDicePage()
        {
            InitializeComponent();
        }

        private void diceRollB_Click(object sender, RoutedEventArgs e)
        {
            int numRoll = 0;
            Int32.TryParse(numDiceBox.Text, out numRoll);

            if (Int32.TryParse(numDiceBox.Text, out numRoll) != false && numRoll <= 1000)
            {
                diceRoll(numRoll);
            }
            else if (Int32.TryParse(numDiceBox.Text, out numRoll) != false && numRoll > 1000)
            {
                MessageBox.Show("Please enter a number less than 1000");
            }
            else
            {
                MessageBox.Show("Please enter only integer (no decimal)");
            }
        }

        public void diceRoll(int numRoll)
        {

            Random random = new Random();
            int result = 0;

            int numOne = Int32.Parse(numOneResultBox.Text);
            int numTwo = Int32.Parse(numTwoResultBox.Text);
            int numThree = Int32.Parse(numThreeResultBox.Text);
            int numFour = Int32.Parse(numFourResultBox.Text);
            int numFive = Int32.Parse(numFiveResultBox.Text);
            int numSix = Int32.Parse(numSixResultBox.Text);
            int numSeven = Int32.Parse(numSevenResultBox.Text);
            int numEight = Int32.Parse(numEightResultBox.Text);
            int numNine = Int32.Parse(numNineResultBox.Text);
            int numTen = Int32.Parse(numTenResultBox.Text);
            int numEleven = Int32.Parse(numElevenResultBox.Text);
            int numTwelve = Int32.Parse(numTwelveResultBox.Text);

            for (int i = 0; i < numRoll; i++)
            {
                result = random.Next(0, 12);
                result++;
                switch (result)
                {
                    case 1:
                        numOne++;
                        break;
                    case 2:
                        numTwo++;
                        break;
                    case 3:
                        numThree++;
                        break;
                    case 4:
                        numFour++;
                        break;
                    case 5:
                        numFive++;
                        break;
                    case 6:
                        numSix++;
                        break;
                    case 7:
                        numSeven++;
                        break;
                    case 8:
                        numEight++;
                        break;
                    case 9:
                        numNine++;
                        break;
                    case 10:
                        numTen++;
                        break;
                    case 11:
                        numEleven++;
                        break;
                    default:
                        numTwelve++;
                        break;
                }
            }
            numOneResultBox.Text = numOne.ToString();
            numTwoResultBox.Text = numTwo.ToString();
            numThreeResultBox.Text = numThree.ToString();
            numFourResultBox.Text = numFour.ToString();
            numFiveResultBox.Text = numFive.ToString();
            numSixResultBox.Text = numSix.ToString();
            numSevenResultBox.Text = numSeven.ToString();
            numEightResultBox.Text = numEight.ToString();
            numNineResultBox.Text = numNine.ToString();
            numTenResultBox.Text = numTen.ToString();
            numElevenResultBox.Text = numEleven.ToString();
            numTwelveResultBox.Text = numTwelve.ToString();
            resultBox.Text = result.ToString();
        }
    }
}