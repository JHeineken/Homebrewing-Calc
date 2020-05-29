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
    //https://brewgr.com/calculations/srm-beer-color - reference for SRM calculations

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
            //collect all user inputs and store as number variables
            var g1pounds = Convert.ToDouble(PoundsTextBox1.Text);
            var g2pounds = Convert.ToDouble(PoundsTextBox2.Text);
            var g1gravpoints = Convert.ToDouble(GravityTextBox1.Text);
            var g2gravpoints = Convert.ToDouble(GravityTextBox2.Text);
            var g1SRM = Convert.ToDouble(SRMTextBox1.Text);
            var g2SRM = Convert.ToDouble(SRMTextBox2.Text);
            var srm1Result = new double();
            var srm2Result = new double();

            
            
            var gravResult = g1pounds * g1gravpoints + g2pounds * g2gravpoints;

            
            if (RadioButton5gal.Checked)
            {
                gravResult /= 5;
                srm1Result = g1pounds * g1SRM / 5;
                srm2Result = g2pounds * g2SRM / 5;
            }
            else
           if (RadioButton3gal.Checked)
            {
                gravResult /= 3;
                srm1Result = g1pounds * g1SRM / 3;
                srm2Result = g2pounds * g2SRM / 3;
            }
           else
            {
                gravResult /= 1;
                srm1Result = g1pounds * g1SRM / 1;
                srm2Result = g2pounds * g2SRM / 1;
            }

            var srmTotal = srm1Result + srm2Result;

            //Morey equation - color adjustments
            if(srmTotal>8)
            {
                srmTotal = srmTotal * .69 * 1.49;
            }
           //traditional "1.0xx" form
            gravResult = gravResult * .001 + 1;
            gravResult = Math.Round(gravResult, 3);
            EstimatedOGTextBox.Text = Convert.ToString(gravResult);
            EstimatedColorTextBox.Text = Convert.ToString(srmTotal);

        }

       
    }
}
