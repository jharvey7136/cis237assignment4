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
        Droid[] auxCollection;
        int droidCollectionLength;
        int highestIndex;              //this int will increment by 1 with every droid added to collection
        int bucketCounter;             //int used as a counter in the bucket sort method

        GenericStack<Droid> protocolStack = new GenericStack<Droid>();    //here are the new instances of all the stacks being created
        GenericStack<Droid> astromechStack = new GenericStack<Droid>();
        GenericStack<Droid> janitorialStack = new GenericStack<Droid>();
        GenericStack<Droid> utilityStack = new GenericStack<Droid>();

        GenericQueue<Droid> genericQueue = new GenericQueue<Droid>();


        public int HighestIndex        //highestindex property to determine amount of valid droid in droid collection array. 
        {                              //increment by one with each droid added to collection.
            get { return highestIndex; }
            set { highestIndex = value; }
        }

        


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
            highestIndex++;   //increment int by one with each droid added to droid collection



        }
        //*******************END METHOD TO ADD NEW DROID TO COLLECTION**************//




        //******************METHOD WHICH WILL MERGE SORT DROID COLLECTION BY TOTAL COST******************//
        public void MergeSort()
        {
            MergeSort merge = new MergeSort();     //create new instance of MergeSort class

            merge.sort(droidCollection, highestIndex);   //pass in the droid collection, along with the highest index of the array.
        }                                                //without the highestIndex, the sort could break due to possible null values in the array.
        //******************END METHOD WHICH WILL MERGE SORT DROID COLLECTION BY TOTAL COST******************//




        //*****************METHOD WHICH WILL USE BUCKET SORT TO SORT DROIDS BY MODEL******************************//
        public void BucketSort()
        {
            //Sort order should be: Astromech, Janitor, Utility, Protocol

            auxCollection = new Droid[highestIndex];
            for (int i = 0; i < highestIndex; i++)    //for loop that copys the droidcollection array to the auxcollection array, removing any empty spots in
            {                                         //the droidcollection array
                auxCollection[i] = droidCollection[i];
            }

            foreach (Droid droid in auxCollection)   //these statements will push droids onto the appropriate stack
            {
                if (droid.Model == "Astromech")
                {
                    astromechStack.Push(droid);
                }
                if (droid.Model == "Janitor")
                {
                    janitorialStack.Push(droid);
                }
                if (droid.Model == "Utility")
                {
                    utilityStack.Push(droid);
                }
                if (droid.Model == "Protocol")      
                {
                    protocolStack.Push(droid);
                }
            }

            //A group of while loops that will Pop off the droid from each stack and enqueue them into the genericqueue   

                while (astromechStack.size() != 0)
                    genericQueue.Enqueue(astromechStack.Pop());

                while (janitorialStack.size() != 0)
                    genericQueue.Enqueue(janitorialStack.Pop());

                while (utilityStack.size() != 0)
                    genericQueue.Enqueue(utilityStack.Pop());

                while (protocolStack.size() != 0)
                    genericQueue.Enqueue(protocolStack.Pop());

                bucketCounter = 0;  //set bucketcounter to 0, the following while loop will increment the counter by 1 each time

             //This while loop will dequeue all the droids back into the original droidcollection array in the correct order  
                while (genericQueue.size() != 0)
                {
                    
                    droidCollection[bucketCounter] = genericQueue.Dequeue();
                    bucketCounter++;
                }
            

        }
        //*****************END METHOD WHICH WILL USE BUCKET SORT TO SORT DROIDS BY MODEL******************************//








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
