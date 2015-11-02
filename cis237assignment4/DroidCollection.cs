using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class DroidCollection
    {
        Droid[] droidCollection;
        int droidCollectionLength;


        //***************METHOD TO CREATE NEW DROID COLLECTION ARRAY***************//
        public DroidCollection(int size)
        {
            droidCollection = new Droid[size];
            droidCollectionLength = 0;
        }
        //***************END METHOD TO CREATE NEW DROID COLLECTION ARRAY***************//


        //*******************METHOD TO ADD NEW DROID TO COLLECTION**************//
        public void AddNewDroid(Droid newDroid)
        {
            droidCollection[droidCollectionLength] = newDroid;
            droidCollectionLength++;
        }
        //*******************END METHOD TO ADD NEW DROID TO COLLECTION**************//


        //****************METHOD TO GET PRINT STRING FOR ALL ITEMS********************//
        public string[] GetPrintStringForAllItems()
        {
            string[] allItemsString = new string[droidCollectionLength];
            int counter = 0;

            if (droidCollectionLength > 0)
            {
                foreach (Droid droid in droidCollection)
                {
                    if (droid != null)
                    {
                        allItemsString[counter] = droid.ToString();
                        counter++;
                    }
                }
            }
            return allItemsString;
        }
        //****************END METHOD TO GET PRINT STRING FOR ALL ITEMS********************//


        //****************METHOD TO DISPLAY ALL DROIDS**********************//
        public void DisplayAllDroids(string[] allItemsOutput)
        {
            Console.WriteLine();
            foreach (string itemOutput in allItemsOutput)
            {
                Console.WriteLine(itemOutput);
            }
        }
        //****************END METHOD TO DISPLAY ALL DROIDS**********************//


    }
}
