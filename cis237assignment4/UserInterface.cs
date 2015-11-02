using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class UserInterface
    {
        //Menu and Droid Selection Variables
        private int menuSelection;
        private int droidSelection;

        //Protocol Selection Variables
        private int numLangauges;

        //Utility Selection Variables
        private bool toolBox;
        private bool computerConnection;
        private bool arm;

        //Janitor Selection Options
        private bool trashCompactor;
        private bool vacuum;

        //Astromech Selection Options
        private int numberShips = 0;
        private bool fireExtinquisher;

        //Adding Option Variables
        private int selectionInt;
        private string materailSelectionString;
        private string colorSelectionString;

        private decimal totalCost = 0;

        DroidCollection droidCollection = new DroidCollection(50);

        public UserInterface()
        {
        }

        //*********************MAIN MENU METHOD**************************//
        public void MainMenu()
        {
            while (menuSelection != 1 || menuSelection != 2 || menuSelection != 3)
            {
                Console.WriteLine("Welcome to the Jawas on Tatooine Droid Program\n");
                Console.WriteLine("1 - Add Droid");
                Console.WriteLine("2 - Print Droid List");
                Console.WriteLine("3 - Exit\n");
                Console.Write("Enter Number: ");
                try
                {
                    menuSelection = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (menuSelection == 1)
                        AddDroid();
                    if (menuSelection == 2)
                        PrintDroidList();
                    if (menuSelection == 3)
                        Environment.Exit(0);
                    if (menuSelection > 3 || menuSelection < 1)
                        Console.WriteLine("Input Must Be Integer Between 1 - 3");
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("Input Error");
                }
            }
        }
        //*********************END MAIN MENU METHOD**************************//

        //********************ADD NEW DROID METHOD********************//
        public void AddDroid()
        {
            Console.WriteLine("Select Droid Type:\n");
            Console.WriteLine("1 - Protocol  - $1000");
            Console.WriteLine("2 - Utility   - $750");
            Console.WriteLine("3 - Janitor   - $500");
            Console.WriteLine("4 - Astromech - $250");
            Console.WriteLine("5 - Back to Main Menu");
            Console.WriteLine("6 - Exit\n");
            Console.Write("Enter Number: ");

            try
            {
                droidSelection = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (droidSelection == 1)
                    AddProtocol();
                if (droidSelection == 2)
                    AddUtility();
                if (droidSelection == 3)
                    AddJanitor();
                if (droidSelection == 4)
                    AddAstromech();
                if (droidSelection == 5)
                    MainMenu();
                if (droidSelection == 6)
                    Environment.Exit(0);
                if (menuSelection > 6 || menuSelection < 1)
                    Console.WriteLine("Input Must Be Integer Between 1 - 6");
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Input Error");
            }
        }
        //*************************END ADD DROID METHOD***************************//












        //*************************ADD PROTOCOL METHOD*****************************//
        public void AddProtocol()
        {
            DroidOptions("Protocol");

            //ADD NEW PROTOCOL TO DROID COLLECTION AND DISPLAY CONFIRMATION
            Console.WriteLine();
            Droid newProtocol = new Protocol(materailSelectionString, "Protocol", colorSelectionString, numLangauges);
            droidCollection.AddNewDroid(newProtocol);
            newProtocol.CalculateBaseCost();
            newProtocol.CalculateTotalCost();
            totalCost += newProtocol.totalCost;
            Console.WriteLine(newProtocol + " has been added to droid collection.\n");


        }
        //*************************END ADD PROTOCOL METHOD************************//

        //*************************ADD UTILITY METHOD*****************************//
        public void AddUtility()
        {
            DroidOptions("Utility");

            //ADD NEW UTILITY TO DROID COLLECTION AND DISPLAY CONFIRMATION
            Console.WriteLine();
            Droid newUtility = new Utility(materailSelectionString, "Utility", colorSelectionString, toolBox, computerConnection, arm);
            droidCollection.AddNewDroid(newUtility);
            newUtility.CalculateBaseCost();
            newUtility.CalculateTotalCost();
            totalCost += newUtility.totalCost;


            Console.WriteLine(newUtility + " has been added to droid collection.\n");

        }
        //*********************END ADD UTILITY METHOD*************************//

        //**********************ADD JANITOR METHOD****************************//
        public void AddJanitor()
        {
            DroidOptions("Janitor");

            Console.WriteLine();
            Droid newJanitor = new Janitorial(materailSelectionString, "Janitor", colorSelectionString, toolBox, computerConnection, arm, trashCompactor, vacuum);
            droidCollection.AddNewDroid(newJanitor);
            newJanitor.CalculateBaseCost();
            newJanitor.CalculateTotalCost();
            totalCost += newJanitor.totalCost;


            Console.WriteLine(newJanitor + " has been added to droid collection.\n");

        }
        //***********************END ADD JANITOR METHOD***********************//

        //**********************ADD ASTROMECH METHOD*************************//
        public void AddAstromech()
        {
            DroidOptions("Astromech");

            Console.WriteLine();
            Droid newAstromech = new Astromech(materailSelectionString, "Astromech", colorSelectionString, toolBox, computerConnection, arm, fireExtinquisher, numberShips);
            droidCollection.AddNewDroid(newAstromech);

            newAstromech.CalculateBaseCost();
            newAstromech.CalculateTotalCost();
            totalCost += newAstromech.totalCost;


            Console.WriteLine(newAstromech + " has been added to droid collection.\n");


        }
        //**********************END ADD ASTROMECH METHOD********************//















        //************METHOD FOR ADDING DROID OPTIONS BASED ON MODEL SELECTED**************//
        public void DroidOptions(string Model)
        {
            //MATERIAL SELECTION
            Console.WriteLine("Select " + Model + " Material\n");
            Console.WriteLine("1 - Iron  - $150");
            Console.WriteLine("2 - Steel - $200\n");
            Console.Write("Enter Number: ");
            try
            {
                selectionInt = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (selectionInt == 1)
                    materailSelectionString = "Iron";

                if (selectionInt == 2)
                    materailSelectionString = "Steel";


            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Input Error");
            }

            //COLOR SELECTION
            Console.WriteLine("Select " + Model + " Color\n");
            Console.WriteLine("1 - White  - $75");
            Console.WriteLine("2 - Black  - $100\n");
            Console.Write("Enter Number: ");

            try
            {
                selectionInt = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (selectionInt == 1)
                    colorSelectionString = "White";

                if (selectionInt == 2)
                    colorSelectionString = "Black";


            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Input Error");
            }
            //IF MODEL IS PROTOCOL, THEN DETERMINE AMOUNT OF LANGUAGES
            if (Model == "Protocol")
            {
                try
                {
                    Console.Write("Enter Desired Number of Languages for New Protocol at $10 per Language: ");
                    numLangauges = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("Input Error");
                }
            }
            //IF MODEL IS UTILITY, JANITOR, OR ASTROMECH, THEN DETERMINE IF TOOLBOX, COMPUTER CONNECTION, OR ARM ARE DESIRED
            if (Model == "Utility" || Model == "Janitor" || Model == "Astromech")
            {
                //TOOLBOX SELECTION
                Console.WriteLine("Toolbox?\n");
                Console.WriteLine("1 - Yes - $10");
                Console.WriteLine("2 - No  - $0\n");
                Console.Write("Enter Number: ");
                try
                {
                    selectionInt = int.Parse(Console.ReadLine());
                    if (selectionInt == 1)
                        toolBox = true;
                    if (selectionInt == 2)
                        toolBox = false;
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("Input Error");
                }
                Console.WriteLine();

                //COMPUTER CONNECTION SELECTION
                Console.WriteLine("Computer Connection?\n");
                Console.WriteLine("1 - Yes - $20");
                Console.WriteLine("2 - No  - $0\n");
                Console.Write("Enter Number: ");
                try
                {
                    selectionInt = int.Parse(Console.ReadLine());
                    if (selectionInt == 1)
                        computerConnection = true;
                    if (selectionInt == 2)
                        computerConnection = false;
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("Input Error");
                }
                Console.WriteLine();

                //ARM SELECTION
                Console.WriteLine("Arm?\n");
                Console.WriteLine("1 - Yes - $30");
                Console.WriteLine("2 - No  - $0\n");
                Console.Write("Enter Number: ");

                try
                {
                    selectionInt = int.Parse(Console.ReadLine());
                    if (selectionInt == 1)
                        arm = true;
                    if (selectionInt == 2)
                        arm = false;
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("Input Error");
                }
                Console.WriteLine();
            }
            //IF JANITOR IS SELECTED, DETERMINE IF TRASH COMPACTOR AND/OR VACUUM ARE/IS DESIRED
            if (Model == "Janitor")
            {
                //TRASH COMPACTOR SELECTION
                Console.WriteLine("Trash Compactor?\n");
                Console.WriteLine("1 - Yes - $50");
                Console.WriteLine("2 - No  - $0\n");
                Console.Write("Enter Number: ");
                try
                {
                    selectionInt = int.Parse(Console.ReadLine());
                    if (selectionInt == 1)
                        trashCompactor = true;
                    if (selectionInt == 2)
                        trashCompactor = false;
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("Input Error");
                }
                Console.WriteLine();

                //VACUUM SELECTION
                Console.WriteLine("Vacuum?\n");
                Console.WriteLine("1 - Yes - $30");
                Console.WriteLine("2 - No  - $0\n");
                Console.Write("Enter Number: ");
                try
                {
                    selectionInt = int.Parse(Console.ReadLine());
                    if (selectionInt == 1)
                        vacuum = true;
                    if (selectionInt == 2)
                        vacuum = false;
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("Input Error");
                }
                Console.WriteLine();
            }
            //IF ASTROMECH IS SELECTED, DETERMINE IF FIRE EXTINGUISHER IS DESIRED AND/OR HOW MANY SHIPS TO INCLUDE
            if (Model == "Astromech")
            {
                Console.WriteLine("Fire Extinguisher?\n");
                Console.WriteLine("1 - Yes - $100");
                Console.WriteLine("2 - No  - $0\n");
                Console.Write("Enter Number: ");
                try
                {
                    selectionInt = int.Parse(Console.ReadLine());
                    if (selectionInt == 1)
                        fireExtinquisher = true;
                    if (selectionInt == 2)
                        fireExtinquisher = false;
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("Input Error");
                }
                Console.WriteLine();
                try
                {
                    Console.Write("Enter Desired Number of Ships for New Astromech at $200 per Ship: ");
                    numberShips = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("Input Error");
                }
                Console.WriteLine();
            }

        }
        //************END METHOD FOR ADDING DROID OPTIONS BASED ON MODEL SELECTED**************//

        //*********************PRINT DROID LIST METHOD**********************//
        public void PrintDroidList()
        {
            Console.Write("*********Droid Collection**********");
            string[] allItems = droidCollection.GetPrintStringForAllItems();
            droidCollection.DisplayAllDroids(allItems);
            Console.WriteLine("Total Cost = $" + totalCost);
            Console.WriteLine();

        }
        //*********************END PRINT DROID LIST************************//
    }
}
