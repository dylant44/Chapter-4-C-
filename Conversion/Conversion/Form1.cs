using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            
            double celcius8 = Convert.ToDouble(txtTemp8.Text);
            double celcius12 = Convert.ToDouble(txtTemp12.Text);
            double celcius5 = Convert.ToDouble(txtTemp5.Text);
            double fahrenheit8 = (celcius8 * 1.8) + 32;
            double fahrenheit12 = (celcius12 * 1.8) + 32;
            double fahrenheit5 = (celcius5 * 1.8) + 32;
            double average = (fahrenheit8 + fahrenheit12 + fahrenheit5) / 3;

            lblFahrenheit8.Visible = true;
            lblFahrenheit12.Visible = true;
            lblFahrenheit5.Visible = true;
            lblAverageFahrenheit.Visible = true;
            lblResult8.Visible = true;
            lblResult12.Visible = true;
            lblResult5.Visible = true;
            lblResultAverageFah.Visible = true;
           

            lblResult8.Text = "" + fahrenheit8;
            lblResult12.Text = "" + fahrenheit12;
            lblResult5.Text = "" + fahrenheit5;
            lblResultAverageFah.Text = "" + average;

            if(fahrenheit8 >= 100)
            {
                lblMessageF1.Text = "It is hot outside";
            }
            else if(fahrenheit8 <= 32)
            {
                lblMessageF1.Text = "It is freezing";
            }

            if (fahrenheit12 >= 100)
            {
                lblMessageF2.Text = "It is hot outside";
            }
            else if (fahrenheit12 <= 32)
            {
                lblMessageF2.Text = "It is freezing";
            }

            if (fahrenheit5 >= 100)
            {
                lblMessageF3.Text = "It is hot outside";
            }
            else if (fahrenheit5 <= 32)
            {
                lblMessageF3.Text = "It is freezing";
            }

        }

        private void btnCelsiusConversion_Click(object sender, EventArgs e)
        {
            double celcius8 = Convert.ToDouble(txtTemp8.Text);
            double celcius12 = Convert.ToDouble(txtTemp12.Text);
            double celcius5 = Convert.ToDouble(txtTemp5.Text);
            double celciusAverage = (celcius8 + celcius12 + celcius5) / 3;
            lblResultCel8.Text = "" + celcius8;
            lblResultCel12.Text = "" + celcius12;
            lblResultCel5.Text = "" + celcius5;
            lblResultAverageCel.Text = "" + celciusAverage;

            lblTitleCel8.Visible = true;
            lblTitleCel12.Visible = true;
            lblTitleCel5.Visible = true;
            lblAverageCel.Visible = true;
            lblResultCel8.Visible = true;
            lblResultCel12.Visible = true;
            lblResultCel5.Visible = true;
            lblResultAverageCel.Visible = true;


        }
    }
}
