using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hurricane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enterbtn_Click(object sender, EventArgs e)
        {
            //declare variables and constants
            int wind = 0;
            int category = 0;
            const int CAT5 = 157;
            const int CAT4 = 130;
            const int CAT3 = 111;
            const int CAT2 = 96;
            const int CAT1 = 74;

            //get wind speed
            wind = Convert.ToInt32(windSpeedtxt.Text); //gets speed from textbox and converts it to an integer

            //determine category
            if (wind >= CAT5)
                category = 5;
            else
            if (wind >= CAT4)
                category = 4;
            else
           if (wind >= CAT3)
                category = 3;
            else
              if (wind >= CAT2)
                category = 2;
            else
                if (wind >= CAT1)
                category = 1;

            //display results
            if (category == 0)
                resultslbl.Text = "This is not a hurricane";
            else
                resultslbl.Text = "This is a category " + category + " hurricane.";
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            windSpeedtxt.Text = string.Empty;
            resultslbl.Text = string.Empty;
            windSpeedtxt.Focus();
        }
    }
}
