using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    interface IDroid : IComparable //inherits from Icomparable to aid in the merge sort
    {
        void CalculateTotalCost();

        decimal TotalCost { get; set; }
    }
}
