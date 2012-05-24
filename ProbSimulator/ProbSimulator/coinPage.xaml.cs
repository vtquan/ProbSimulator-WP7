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
                }
                else
                {
                    numHead++;
                }
            }
            if (result == 1)	//set last roll
            {
                lastFlipBox.Text = "Tail";
            }
            else
                lastFlipBox.Text = "Head";

            numHeadBox.Text = numHead.ToString();
            numTailBox.Text = numTail.ToString();
        }

        private void lastFlipBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void numFlipBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}