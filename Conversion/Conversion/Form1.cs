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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void btnConvert_Click(object sender, EventArgs e)
        {
            int celcius8 = Convert.ToInt32(txtTemp8);
            int celcius12 = Convert.ToInt32(txtTemp12);
            int celcius5 = Convert.ToInt32(txtTemp5);
            double fahrenheit8 = (celcius8 * 1.8) + 32;
            double fahrenheit12 = (celcius12 * 1.8) + 32;
            double fahrenheit5 = (celcius5 * 1.8) + 32;


        }
        
    }
}
