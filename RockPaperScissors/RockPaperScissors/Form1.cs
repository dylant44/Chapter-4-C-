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
        private static int win = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            int rock = 1;
            DisplayCalculation(rock);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int scissors = 3;
            DisplayCalculation(scissors);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int paper = 2;
            DisplayCalculation(paper);
        }
        private void DisplayCalculation(int decision)
        {
            string result = null;
           
            int randomNumber;
            Random ranNumberGenerator = new Random();
            randomNumber = ranNumberGenerator.Next(1, 4);
            if (decision == 1)
            {
                if (randomNumber == 1)
                {
                    result = "Tie!";
                }
                else if (randomNumber == 2)
                {
                    result = "You Lose!";
                }
                else if (randomNumber == 3)
                {
                    result = "You Win!";
                    win = 1 + win;
                }
            }
            else if (decision == 2)
            {
                if (randomNumber == 1)
                {
                    result = "You Lose!";
                }
                else if (randomNumber == 2)
                {
                    result = "You Win!";
                    win = 1 + win;
                }
                else if (randomNumber == 3)
                {
                    result = "Tie!";
                }
            }
            else if (decision == 3)
            {
                if (randomNumber == 1)
                {
                    result = "You Win!";
                    win = 1 + win;
                }
                else if (randomNumber == 2)
                {
                    result = "Tie!";
                }
                else if (randomNumber == 3)
                {
                    result = "You Lose!";
                }
            }
            lblOutput.Text = result;
            lblWins.Text = "" + win;
        }
         
    }
}
