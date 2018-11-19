using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailySpecial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        enum Day
        {
            Sunday = 1, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int day = Convert.ToInt32(txtInput.Text);
            string special;
            switch((Day)day)
            {
                case Day.Sunday:
                    special = "Fried Chicken";
                    break;
                case Day.Monday:
                    special = "Sorry - closed";
                    break;
                case Day.Tuesday:
                case Day.Wednesday:
                case Day.Thursday:
                    special = "Meat Loaf";
                    break;
                case Day.Friday:
                    special = "Fish Fry";
                    break;
                case Day.Saturday:
                    special = "Liver and Onions";
                    break;
                default:
                    special = "Invalid Day";
                    break;
            }
            lblResult.Text = "Today's Special is " + special;
        }
    }
}
