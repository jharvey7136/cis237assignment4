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

        private GenericNode<T> last;

        public GenericNode<T> Head
        {
            get;
            set;
        }

        public GenericStack()
        {
            Head = null;
        }

        public void Push(T content)
        {
            GenericNode<T> node = new GenericNode<T>();
            node.Data = content;

            if (Head == null)
            {
                Head = node;
            }

            else
            {
                last.Next = node;
            }

            last = node;
        }










    }
}
