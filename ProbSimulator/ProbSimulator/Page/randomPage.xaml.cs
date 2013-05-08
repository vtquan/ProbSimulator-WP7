using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace ProbSimulator.Page
{
    public partial class randomPage : PhoneApplicationPage
    {
        public randomPage()
        {
            InitializeComponent();
        }

        private void generateB_Click(object sender, RoutedEventArgs e)
        {
            int numCall = 0;
            Int32.TryParse(numCallBox.Text, out numCall);

            if (Int32.TryParse(numCallBox.Text, out numCall) != false && numCall <= 1000)
            {
                checkRange(numCall);
            }
            else if (Int32.TryParse(numCallBox.Text, out numCall) != false && numCall > 1000)
            {
                MessageBox.Show("Please enter a number less than 1000");
            }
            else
            {
                MessageBox.Show("Please enter only integer (no decimal)");
            }
        }

        private void checkRange(int numNumber)
        {
            int minNumber = 0;
            Int32.TryParse(MinNumBox.Text, out minNumber);

            if (Int32.TryParse(MinNumBox.Text, out minNumber) != false && minNumber >= Int32.MinValue && minNumber <= Int32.MaxValue)   //if minInput is valid 
            {
                Int32 maxNumber = 0;
                Int32.TryParse(MaxNumBox.Text, out maxNumber);

                if (Int32.TryParse(MaxNumBox.Text, out maxNumber) != false && maxNumber >= Int32.MinValue && maxNumber <= Int32.MaxValue && maxNumber > minNumber)   //if maxInput is valid 
                {
                    if (minNumber <= maxNumber)
                    {
                        generateNumber(numNumber);
                    }
                }

                else if (Int32.TryParse(MaxNumBox.Text, out maxNumber) == false)  //if input is not an integer
                {
                    MessageBox.Show("Please enter a real number for maximum number."); 
                }
                else if (maxNumber <= minNumber)  
                {
                    MessageBox.Show("Maximum number must be greater than minimum number.");
                }
                else   //input is out of bound
                {
                    MessageBox.Show("Please enter a number between " + Int32.MinValue + " and " + Int32.MaxValue + "2.");
                }
            }

            else if (Int32.TryParse(MinNumBox.Text, out minNumber) == false)  //if input is not an integer
            {
                MessageBox.Show("Please enter a real number for minimum number.");
            }
            else //input is out of bound
            {
                MessageBox.Show("Please enter a number between " + Int32.MinValue + " and " + Int32.MaxValue + ".");
            }
        }

        private void generateNumber(int numNumber)
        {
            Random random = new Random();
            string result = "";
            int minNumber = 0;
            Int32.TryParse(MinNumBox.Text, out minNumber);
            int maxNumber = 0;
            Int32.TryParse(MaxNumBox.Text, out maxNumber);

            for (int i = 0; i < numNumber; i++)
            {
                result = random.Next(minNumber, maxNumber + 1).ToString();
                historyList.Children.Add(new TextBlock() { Text = result });
            }
            historyList.Children.Add(new TextBlock() { Text = "  " });
            historyScroll.UpdateLayout();
            historyScroll.ScrollToVerticalOffset(historyList.ActualHeight);
            resultBox.Text = result;
        }
    }
}