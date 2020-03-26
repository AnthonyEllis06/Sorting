using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Selection:Sort
    {
        public Selection(int[] randominInts) : base(randominInts) { }

        public void SelectionSort()
        {
            SelectionSortRec(SortedInts, N);
        }

        private void SelectionSortRec(int[] NumArray, int n)
        {
            if(n<=1)
                return;
            int max = Max(NumArray, n);
            if (NumArray[max] != NumArray[n - 1])
            {
                Swap(NumArray, max, n - 1);
                NumSwaps++;
            }
                
            SelectionSortRec(NumArray,n-1);
        }

        private int Max(int[] NumArray, int n)
        {
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                if (NumArray[max] < NumArray[i])
                    max = i;
            }

            return max;
        }
    }
}
