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

namespace DiceSimulator
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int numRoll = Int32.Parse(textBox1.Text);
            int numHead = Int32.Parse(textBox2.Text);
            int numTail = Int32.Parse(textBox3.Text);
            sixDiceRoll(numHead, numTail, numRoll);
        }

        public void sixDiceRoll(int numHead, int numTail, int numRoll)
        {

            Random random = new Random();
            int result = 0;
	    for(int i = 0; i < numRoll; i++)
	    {
		    result = random.Next(0, 2);
		    if(result == 1)
		    {
			    numTail++;
		    }
		    else
		    {
			    numHead++;
		    }
	    }
	    if(result == 1)	//set last roll
	    {
		    textBox4.Text = "Tail";
	    }
	    else
		    textBox4.Text = "Head";
		    
            textBox2.Text = numHead.ToString();
            textBox3.Text = numTail.ToString();
	    }
    }
}
