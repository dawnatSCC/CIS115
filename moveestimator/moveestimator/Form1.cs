using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moveestimator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            //variables
            const double BASE = 200.00;
            const double PERMILE = 2.00;
            const double HOURCOST = 150.00;
            double miles = 0.0;
            double hours = 0.0;
            double total = 0.0;

            //calculate
            miles = Convert.ToDouble(txtMiles.Text);
            hours = Convert.ToDouble(txtHours.Text);
            total = miles * PERMILE + BASE + hours * HOURCOST;

            //display
            lblTotal.Text = total.ToString("c");


        }
    }
}
