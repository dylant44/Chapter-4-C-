using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            int randomNumber;
            Random ranNumberGenerator = new Random();
            randomNumber = ranNumberGenerator.Next(1, 4);

            if (randomNumber == 1)
            {
                lblOutput.Text = "Tie! You both picked Rock";
            }
            else if(randomNumber == 2)
            {
                lblOutput.Text = "You Lose! They picked Paper";
            }
            else if(randomNumber == 3)
            {
                lblOutput.Text = "You Win! They Picked Scissors";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int randomNumber;
            Random ranNumberGenerator = new Random();
            randomNumber = ranNumberGenerator.Next(1, 4);

            if (randomNumber == 1)
            {
                lblOutput.Text = "You Win! They picked Rock";
            }
            else if (randomNumber == 2)
            {
                lblOutput.Text = "Tie! You both picked Paper";
            }
            else if (randomNumber == 3)
            {
                lblOutput.Text = "You Lose! They picked Scissors";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int randomNumber;
            Random ranNumberGenerator = new Random();
            randomNumber = ranNumberGenerator.Next(1, 4);

            if (randomNumber == 1)
            {
                lblOutput.Text = "You Lose! They Picked Rock";
            }
            else if (randomNumber == 2)
            {
                lblOutput.Text = "You Win! They picked Paper";
            }
            else if (randomNumber == 3)
            {
                lblOutput.Text = "Tie! You both picked Scissors";
            }
        }
    }
}
