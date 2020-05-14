using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double total1 = 0;
        double total2;
        int flag ;

        private void buttonOne_Click(object sender, EventArgs e)
        {
            textDisplay.Text =textDisplay.Text+ buttonOne.Text;
        }

        private void textDisplay_TextChanged(object sender, EventArgs e)
        {
            //textDisplay.Text = textDisplay.Text + buttonOne.Text;
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + buttonTwo.Text;
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + buttonThree.Text;
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + buttonFour.Text;
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + buttonFive.Text;
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + buttonSix.Text;
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + buttonSeven.Text;
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + buttonEight.Text;
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + buttonNine.Text;
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + buttonZero.Text;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textDisplay.Clear();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(textDisplay.Text);
            textDisplay.Clear();
            flag = 1;
         
            
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {

                total2 = total1 - double.Parse(textDisplay.Text);
                textDisplay.Text = total2.ToString();
                total1 = 0;
                
            }
            else if(flag==1)
            {
                total2 = total1 + double.Parse(textDisplay.Text);
                textDisplay.Text = total2.ToString();
                total1 = 0;
            }
            else if (flag == 2)
            {
                total2 = total1 * double.Parse(textDisplay.Text);
                textDisplay.Text = total2.ToString();
                total1 = 0;
            }
            else
            {
                total2 = total1 / double.Parse(textDisplay.Text);
                textDisplay.Text = total2.ToString();
                total1 = 0;
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            total1 = total1 +double.Parse(textDisplay.Text);
            textDisplay.Clear();
            flag = 0;
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(textDisplay.Text);
            textDisplay.Clear();
            flag = 2;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {

            total1 = total1 + double.Parse(textDisplay.Text);
            textDisplay.Clear();
            flag = 3;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + buttonDot.Text;
        }
    }
}
