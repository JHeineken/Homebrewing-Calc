using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerCalculator
{
    /*Upcoming implementations:
    -Combobox (?) w/ database of grain types
    -Search function
    -Visual representation for user of ComboBox /search selection || of all grains to be calculated
    -add/remove grains feature to compliment above point
    */

    //Consider if "Error Provider" class is worth implementing (give immediate feedback to user if entered info is invalid) 

    public partial class MainForm : Form
    {
       
       
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
          
        }

        private void CalculateButtonClick(object sender, EventArgs e)
        {
            Calculations calc = new Calculations();
            Grain g1 = new Grain();
            Grain g2 = new Grain();

            //collect all user inputs
            g1.pounds = Convert.ToDouble(PoundsTextBox1.Text);
            g1.gPoints = Convert.ToDouble(GravityTextBox1.Text);
            g1.srmPoints = Convert.ToDouble(SRMTextBox1.Text);
            g2.gPoints = Convert.ToDouble(GravityTextBox2.Text);
            g2.pounds = Convert.ToDouble(PoundsTextBox2.Text);
            g2.srmPoints = Convert.ToDouble(SRMTextBox2.Text);
            var gal = Convert.ToDouble(BatchSizeTextBox.Text);

            var srmResult = calc.GetColor(g1, g2, gal);
            var gravResult = calc.GetGrav(g1, g2, gal);


            gravResult = calc.ConvertFormat(gravResult);

            EstimatedOGTextBox.Text = Convert.ToString(gravResult);
            EstimatedColorTextBox.Text = Convert.ToString(srmResult);

        }

       
    }
}
