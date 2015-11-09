using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class DroidCollection
    {

        IComparable[] sortCollection = new IComparable[50]; 
        Droid[] droidCollection;
        int droidCollectionLength;

        MergeSort merge;

        GenericStack<Droid> protocolStack = new GenericStack<Droid>();
        GenericStack<Droid> astromechStack = new GenericStack<Droid>();
        GenericStack<Droid> janitorialStack = new GenericStack<Droid>();
        GenericStack<Droid> utilityStack = new GenericStack<Droid>();

        GenericQueue<Droid> genericQueue = new GenericQueue<Droid>();

        

        


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

            if (newDroid.Model == "Protocol")
            {
                protocolStack.Push(newDroid);
            }
            if (newDroid.Model == "Astromech")
            {
                astromechStack.Push(newDroid);
            }
            if (newDroid.Model == "Janitor")
            {
                janitorialStack.Push(newDroid);
            }
            if (newDroid.Model == "Utility")
            {
                utilityStack.Push(newDroid);
            }

        }
        //*******************END METHOD TO ADD NEW DROID TO COLLECTION**************//



        public void MergeSort()
        {
            merge = new MergeSort();

            merge.sort(droidCollection);          

            
        }

        public void BucketSort()
        {
            //Sort order should be: Astromech, Janitor, Utility, Protocol

            for (GenericNode<Droid> x = protocolStack.Head; x != null; x = x.Next)
            {
                genericQueue.Enqueue(x.Data);
            }
            for (GenericNode<Droid> x = utilityStack.Head; x != null; x = x.Next)
            {
                genericQueue.Enqueue(x.Data);
            }
            for (GenericNode<Droid> x = janitorialStack.Head; x != null; x = x.Next)
            {
                genericQueue.Enqueue(x.Data);
            }
            for (GenericNode<Droid> x = astromechStack.Head; x != null; x = x.Next)
            {
                genericQueue.Enqueue(x.Data);
            }

            for (int i = 0; i <= droidCollection.Length; i++)
            {
                droidCollection[i] = genericQueue.Dequeue();
            }

            

        }








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
