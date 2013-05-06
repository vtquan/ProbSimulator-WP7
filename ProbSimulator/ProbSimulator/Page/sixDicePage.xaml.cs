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
    public partial class sixDicePage : PhoneApplicationPage
    {
        public sixDicePage()
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

            for (int i = 0; i < numRoll; i++)
            {
                result = random.Next(0, 6);
                result++;
                switch(result)
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
                default:
                    numSix++;
                    break;
                }   
            }
            numOneResultBox.Text = numOne.ToString();
            numTwoResultBox.Text = numTwo.ToString();
            numThreeResultBox.Text = numThree.ToString();
            numFourResultBox.Text = numFour.ToString();
            numFiveResultBox.Text = numFive.ToString();
            numSixResultBox.Text = numSix.ToString();
            resultBox.Text = result.ToString();         
        }
    }
}