using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class Utility : Droid
    {
        //Variables
        public bool toolBox;
        public bool computerConnection;
        public bool arm;
        public string toolBoxYesNo;
        public string computerConnectionYesNo;
        public string armYesNo;
        public int toolCost = 0;
        public int compCost = 0;
        public int armCost = 0;

        //Constructor which inherits from Droid class
        public Utility(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection, bool Arm)
            : base(Material, Model, Color)
        {
            this.toolBox = ToolBox;
            if (toolBox)
            {
                toolBoxYesNo = "ToolBox = Yes";
                toolCost = 10;
            }
            if (!toolBox)
                toolBoxYesNo = "ToolBox = No";

            this.computerConnection = ComputerConnection;
            if (computerConnection)
            {
                computerConnectionYesNo = "Computer Connection = Yes";
                compCost = 20;
            }
            if (!computerConnection)
                computerConnectionYesNo = "Computer Connection = No";

            this.arm = Arm;
            if (arm)
            {
                armYesNo = "Arm = Yes";
                armCost = 30;
            }
            if (!arm)
                armYesNo = "Arm = No";
        }

        //***************METHOD TO CALCULATE BASE COST**************//
        public override void CalculateBaseCost()
        {
            baseCost = modelCost + materialCost + colorCost + toolCost + compCost + armCost;
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
            return this.Material + " - " + this.Model + " - " + this.Color + " - " + toolBoxYesNo + " - " + computerConnectionYesNo + " - " + armYesNo + " for $" + costString;
        }
        //**************END METHOD THAT OVERRIDES TOSTRING****************//
    }
}
