using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class Janitorial : Utility
    {
        //Variables
        public bool trashCompactor;
        public bool vacuum;
        public string trashCompactorYesNo;
        public string vacuumYesNo;
        public int trashCost = 0;
        public int vacuumCost = 0;

        //Constructor which inherits from Utility class, which inherits from Droid class
        public Janitorial(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection, bool Arm, bool TrashCompactor,
            bool Vacuum)
            : base(Material, Model, Color, ToolBox, ComputerConnection, Arm)
        {
            this.trashCompactor = TrashCompactor;
            if (trashCompactor)
            {
                trashCompactorYesNo = "Trash Compactor = Yes";
                trashCost = 50;
            }
            if (!trashCompactor)
                trashCompactorYesNo = "Trash Compactor = No";

            this.vacuum = Vacuum;
            if (vacuum)
            {
                vacuumYesNo = "Vacuum = Yes";
                vacuumCost = 30;
            }
            if (!vacuum)
                vacuumYesNo = "Vacuum = No";

        }

        //***************METHOD TO CALCULATE BASE COST**************//
        public override void CalculateBaseCost()
        {
            baseCost = materialCost + modelCost + colorCost + toolCost + compCost + armCost + trashCost + vacuumCost;
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
            return this.Material.PadRight(8) + this.Model.PadRight(15) + this.Color.PadRight(9) + toolBoxYesNo.PadRight(18) + computerConnectionYesNo.PadRight(28) + armYesNo.PadRight(12) +
                trashCompactorYesNo.PadRight(28) + vacuumYesNo.PadRight(16) + "$" + costString.PadLeft(5);
        }
        //**************END METHOD THAT OVERRIDES TOSTRING****************//

    }
}
