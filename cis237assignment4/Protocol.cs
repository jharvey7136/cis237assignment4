using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class Protocol : Droid
    {
        //Variables
        public int numberLanguages;
        const int costPerlanguage = 10;


        public int NumberLanguages
        {
            get { return numberLanguages; }
            set { numberLanguages = value; }
        }

        //Constructor which inherits from Droid class
        public Protocol(string Material, string Model, string Color, int NumberLanguages)
            : base(Material, Model, Color)
        {
            this.numberLanguages = NumberLanguages;
        }

        //***************METHOD TO CALCULATE BASE COST**************//
        public override void CalculateBaseCost()
        {
            baseCost = modelCost + materialCost + colorCost + (numberLanguages * 10);
            costString = baseCost.ToString();
        }
        //***************END METHOD TO CALCULATE BASE COST**************//

        //***************METHOD TO CALCULATE TOTAL COST**************//
        public override void CalculateTotalCost()
        {
            base.totalCost += baseCost;

        }
        //***************END METHOD TO CALCULATE TOTAL COST**************//

        //**************METHOD THAT OVERRIDES TOSTRING****************//
        public override string ToString()
        {
            return this.Material + " - " + this.Model + " - " + this.Color + " - " + numberLanguages + " language(s) for $" + costString;
        }
        //**************END METHOD THAT OVERRIDES TOSTRING****************//

    }
}
