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
            
            string result = null;
            int randomNumber;
            Random ranNumberGenerator = new Random();
            randomNumber = ranNumberGenerator.Next(1, 4);

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
            }
            DisplayCalculation(result);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = null;
            int randomNumber;
            Random ranNumberGenerator = new Random();
            randomNumber = ranNumberGenerator.Next(1, 4);

            if (randomNumber == 1)
            {
                result = "You Win!";
            }
            else if (randomNumber == 2)
            {
                result = "Tie!";
            }
            else if (randomNumber == 3)
            {
                result = "You Lose!";
            }
            DisplayCalculation(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string result = null;
            int randomNumber;
            Random ranNumberGenerator = new Random();
            randomNumber = ranNumberGenerator.Next(1, 4);

            if (randomNumber == 1)
            {
                result = "You Lose!";
            }
            else if (randomNumber == 2)
            {
                result = "You Win!";
            }
            else if (randomNumber == 3)
            {
                result = "Tie!";
            }
            DisplayCalculation(result);
        }
        private void DisplayCalculation(string result)
        {
            int randomNumber;
            Random ranNumberGenerator = new Random();
            randomNumber = ranNumberGenerator.Next(1, 4);

            if (btnRock_Click = true && randomNumber == 1)
            {

            }
            lblOutput.Text = result;
        }
         
    }
}
