﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class MergeSort
    {

        private IComparable[] aux; // auxiliary array for merges


        private void sort(IComparable[] a, IComparable[] aux, int lo, int hi)
        { // Sort a[lo..hi].
            if (hi <= lo) return;
            int mid = lo + (hi - lo) / 2;
            sort(a, aux, lo, mid); // Sort left half.
            sort(a, aux,  mid + 1, hi); // Sort right half.
            merge(a, aux, lo, mid, hi); // Merge results 
        }


        public void sort(IComparable[] a)
        {
            aux = new IComparable[a.Length]; // Allocate space just once.
            sort(a, aux, 0, a.Length - 1);
        }


        public void merge(IComparable[] a, IComparable[] aux, int lo, int mid, int hi)
        {                                  // Merge a[lo..mid] with a[mid+1..hi].
            int i = lo, j = mid + 1;

            for (int k = lo; k <= hi; k++) // Copy a[lo..hi] to aux[lo..hi].
                aux[k] = a[k];

            for (int k = lo; k <= hi; k++) // Merge back to a[lo..hi].
                if (i > mid)                           a[k] = aux[j++];
                else if (j > hi)                       a[k] = aux[i++];
                else if (aux[j].CompareTo(aux[i]) < 0) a[k] = aux[j++];
                else                                   a[k] = aux[i++];
        }



    }
}
