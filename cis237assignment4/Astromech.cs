using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class Astromech : Utility
    {
        //Variables
        public bool fireExtinguisher;
        public int numberShips;
        public int shipsCost;
        public int fireCost;
        public string fireExtinguisherYesNo;

        //Constructor which inherits from Utility class, which inherits from Droid class
        public Astromech(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection, bool Arm, bool FireExtinguisher, int NumberShips)
            : base(Material, Model, Color, ToolBox, ComputerConnection, Arm)
        {
            this.fireExtinguisher = FireExtinguisher;
            if (fireExtinguisher)
            {
                fireExtinguisherYesNo = "Fire Extinguisher = Yes";
                fireCost = 100;
            }
            if (!fireExtinguisher)
                fireExtinguisherYesNo = "Fire Extinguisher = No";

            this.numberShips = NumberShips;
            shipsCost = numberShips * 200;
        }

        //***************METHOD TO CALCULATE BASE COST**************//
        public override void CalculateBaseCost()
        {
            baseCost = modelCost + materialCost + colorCost + toolCost + compCost + armCost + fireCost + shipsCost;
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
            return this.Material + " - " + this.Model + " - " + this.Color + " - " + toolBoxYesNo + " - " + computerConnectionYesNo + " - " + armYesNo + " - " +
                fireExtinguisherYesNo + " - with " + numberShips.ToString() + " ship(s)" + " for $" + costString;
        }
        //**************END METHOD THAT OVERRIDES TOSTRING****************//


    }
}
