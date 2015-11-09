using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class GenericQueue<T>
    {
        private GenericNode<T> last;
        private GenericNode<T> first;


        //private int N;

        //public GenericNode<T> Head
        //{
        //    get;
        //    set;
        //}


        public void Enqueue(T content)
        {
            GenericNode<T> oldLast = last;
            first = new GenericNode<T>();
            first.Data = content;
            first.Next = last;

        }

        public T Dequeue()     //IS NOT PROPERLY DEQUEUEING
        {
            T data = first.Data;
            first = first.Next;
            return data;
        }

        






    }
}
