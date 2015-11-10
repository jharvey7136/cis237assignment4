using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class GenericQueue<T> //Generic class to hold the queue of droids. used in the bucket sort
    {

        private GenericNode<T> first;   //link to least recently added node
        private GenericNode<T> last;    //link to most recently added node
        private int N;                  //number of items on queue

        public bool isEmpty() { return first == null; }
        public int size() { return N; }

        public void Enqueue(T item)
        {                                          //Add item to the end of the list.
            GenericNode<T> oldlast = last;         //Backup the last node
            last = new GenericNode<T>();           //create a new node as the new last
            last.Data = item;                      //Set the 'data' on the node
            last.Next = null;                      //Set the last.next to null
            if (isEmpty()) first = last;           //Do a empty check. True when first putting something into the queue
            else oldlast.Next = last;              //set the oldLast's next to the new node
            N++;                                   //increment the size
        }


        public T Dequeue()
        {
            T item = first.Data;        //Get the data off the node
            first = first.Next;         //Set first to first's next
            if (isEmpty()) last = null; //If empty, make last = null;
            N--;                        //decrement that size
            return item;                //return the data
        }   
    }
}
