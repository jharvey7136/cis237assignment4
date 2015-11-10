using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class MergeSort       //class which sorts droids by total cost using a merge sort. 
    {

        private IComparable[] aux; // auxiliary array for merges


        private void sort(IComparable[] a, IComparable[] aux, int lo, int hi)
        {                               // Sort a[lo..hi].
            if (hi <= lo) return;
            int mid = lo + (hi - lo) / 2;
            sort(a, aux, lo, mid);      // Sort left half.
            sort(a, aux,  mid + 1, hi); // Sort right half.
            merge(a, aux, lo, mid, hi); // Merge results 
        }


        public void sort(IComparable[] a, int highIndex) //Int highIndex is passed in to determine the length of the aux array being used. 
        {                                                //Without the int highIndex, the array could possibly have nulls and break the sort.                
            aux = new IComparable[highIndex];            // Allocate space just once.
            sort(a, aux, 0, highIndex - 1);
        }


        public void merge(IComparable[] a, IComparable[] aux, int lo, int mid, int hi)
        {
                                           // Merge a[lo..mid] with a[mid+1..hi].
            int i = lo;
            int j = mid + 1;

            for (int k = lo; k <= hi; k++) // Copy a[lo..hi] to aux[lo..hi].
            {
                aux[k] = a[k];
            }

            for (int k = lo; k <= hi; k++) // Merge back to a[lo..hi].
            {
                if (i > mid)
                {
                    a[k] = aux[j++];
                }
                else if (j > hi)
                {
                    a[k] = aux[i++];
                }
                else if (aux[j].CompareTo(aux[i]) < 0)
                {
                    a[k] = aux[j++];
                }
                else a[k] = aux[i++];
            }
        }



    }
}
