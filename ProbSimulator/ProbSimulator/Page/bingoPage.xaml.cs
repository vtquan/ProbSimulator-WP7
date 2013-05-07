using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace ProbSimulator
{
    public partial class bingoPage : PhoneApplicationPage
    {
        Random random = new Random();
        bool[] called = new bool[75];   //store whether each of the possible 75 numbers was called
        int numCalled = 0;
        int[,] card = new int[5, 5]; //store the values of the bingo card; [row, column]
        TextBlock[,] cardText = new TextBlock[5, 5]; //store the textBox [row, column]
        bool[,] cardCalled = new bool[5, 5];   //bingo card represented by whether or not the number has been called; [row, column]
        Image[,] chipArray = new Image[5, 5]; //link to each of the bingo chip image in the bingo card; [row, column]
        bool gameEnd;   //if game has ended

        public bingoPage()
        {
            InitializeComponent();

            cardCalled[2, 2] = true;    //Set free space to true
        }

        private void callB_Click(object sender, RoutedEventArgs e)
        {

            int numCall = 0;
            Int32.TryParse(numCallBox.Text, out numCall);

            if (Int32.TryParse(numCallBox.Text, out numCall) != false && numCall <= 1000)
            {
                DrawNumber(numCall);
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

        private void DrawNumber(int numDraw)
        {
            int result = 0;
            int numCall;    //total number of call to do
            int callNum = 0 ;    //current number of call
            Int32.TryParse(numCallBox.Text, out numCall);
            int[] resultList = new int[numCall];
            for (int i = 0; i < numDraw; i++)
            {
                numCalled++;
                if (numCalled > 75)
                {
                    MessageBoxResult messageResult = MessageBox.Show("Reset?", "Out of Numbers", MessageBoxButton.OKCancel);
                    if (messageResult == MessageBoxResult.OK)
                    {
                        Reset();
                    }
                    break;
                }
                do
                {
                    result = random.Next(0, 75);
                } while (called[result] == true);

                called[result] = true;
                result++;

                resultList[callNum] = result;
                callNum++;

                if(result <16)
                    historyList.Children.Add(new TextBlock() { Text = "B-"+result });
                else if (result < 31)
                    historyList.Children.Add(new TextBlock() { Text = "I-" + result });
                else if (result < 46)
                    historyList.Children.Add(new TextBlock() { Text = "N-" + result });
                else if (result < 61)
                    historyList.Children.Add(new TextBlock() { Text = "G-" + result });
                else 
                    historyList.Children.Add(new TextBlock() { Text = "O-" + result });

                if (i == numDraw - 1)   //add spacing at the end only when there are no problem
                {
                    historyList.Children.Add(new TextBlock() { Text = "  " });
                }
            }

            if (result < 16)
                resultBox.Text = "B-" + result;
            else if (result < 31)
                resultBox.Text = "I-" + result;
            else if (result < 46)
                resultBox.Text = "N-" + result;
            else if (result < 61)
                resultBox.Text = "G-" + result;
            else
                resultBox.Text = "O-" + result;

            historyScroll.UpdateLayout();
            historyScroll.ScrollToVerticalOffset(historyList.ActualHeight);
        }

        private void Reset()  
        {
            for (int i = 0; i < 75; i++)
            {
                called[i] = false;
            }
            numCalled = 0;
            historyList.Children.Clear();

            //Reset variables
            called = new bool[75];
            numCalled = 0;
            card = new int[5, 5];
            cardCalled = new bool[5, 5];
            gameEnd = false;
        }
    }
}