using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class GenericNode<T> //Generic node class needed for linked list to properly function. Nodes are used in both generic stack and generic queue class
    {

        public GenericNode<T> Next
        {
            get;
            set;
        }

        public T Data
        {
            get;
            set;
        }
    }
}
