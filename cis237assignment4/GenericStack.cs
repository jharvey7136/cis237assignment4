using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class GenericStack<T>
    {

        //private GenericNode<T> current;

        private GenericNode<T> first; //top of stack
        private int N; //number of items

        public bool isEmpty() { return first == null; }
        public int size() { return N; }

        public void Push(T item)             //add item to top of stack
        {
            GenericNode<T> oldfirst = first; //makes backup of the firstNode
            first = new GenericNode<T>();    //create a new node
            first.Data = item;               //set the data for the node
            first.Next = oldfirst;           //set the first.next to the oldFirst backup
            N++;                             //increment the size
        }

        public T Pop()
        {
            T item = first.Data;             //get the data from the first node
            first = first.Next;              //set the first node to the first nodes next since we are removing the first node
            N--;
            return item;
        }
    }
}
