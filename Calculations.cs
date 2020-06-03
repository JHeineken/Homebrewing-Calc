using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerCalculator
{
   public class Calculations
    {

        public double GetGrav(Grain g1, Grain g2, double gal)
        {
            var g1Grav = g1.pounds * g1.gPoints;
            var g2Grav = g2.pounds * g2.gPoints;
            var totalGrav = (g1Grav + g2Grav) / gal;

            return totalGrav;
        }
        public double GetColor(Grain g1, Grain g2, double gal)
        {
            //https://brewgr.com/calculations/srm-beer-color - reference for SRM calculations

            var g1Color = g1.pounds * g1.srmPoints;
            var g2Color = g2.pounds * g2.srmPoints;
            var totalColor = (g1Color + g2Color) / gal;

            //Morey equation - color adjustments
            if (totalColor > 8)
            {
                totalColor = totalColor * .69 * 1.49;
            }

            return totalColor;
        }
        public double ConvertFormat (double gravResult)
        {

            //1.0xx format
            gravResult = gravResult * .001 + 1;
            gravResult = Math.Round(gravResult, 3);
            return gravResult;
        }

      
    }
}
