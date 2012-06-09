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
    public partial class coinPage : PhoneApplicationPage
    {
        public coinPage()
        {
            InitializeComponent();
        }

        private void coinFlipB_Click(object sender, RoutedEventArgs e)
        {            
            int numFlip = 0;
            if (Int32.TryParse(numFlipBox.Text, out numFlip))
            {
                coinFlip(numFlip);
            }
            else
            {
                MessageBox.Show("Please enter only integer (no decimal)");
            }
        }

        public void coinFlip(int numFlip)
        {

            Random random = new Random();

            int result = 0;
            int numHead = Int32.Parse(numHeadBox.Text);
            int numTail = Int32.Parse(numTailBox.Text);

            for (int i = 0; i < numFlip; i++)
            {
                result = random.Next(0, 2);
                if (result == 1)
                {
                    numTail++;

                    stackPanel1.Children.Add(new TextBlock() { Text = "Tail" });
                    scrollViewer1.ScrollToVerticalOffset(2 * stackPanel1.ActualHeight);
                }
                else
                {
                    numHead++;

                    stackPanel1.Children.Add(new TextBlock() { Text = "Head" });
                    scrollViewer1.ScrollToVerticalOffset(2 * stackPanel1.ActualHeight);
                }
            }
            if (result == 1)	//set last roll
            {
                lastFlipBox.Text = "Tail";
            }
            else
            {
                lastFlipBox.Text = "Head";
            }

            numHeadBox.Text = numHead.ToString();
            numTailBox.Text = numTail.ToString();

            stackPanel1.Children.Add(new TextBlock() { Text = "  " });
            scrollViewer1.ScrollToVerticalOffset(2 * stackPanel1.ActualHeight);

        }

        private void lastFlipBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void numFlipBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}