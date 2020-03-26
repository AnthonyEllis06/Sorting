using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Insertion:Sort
    {
        public Insertion(int[] randomInts) : base(randomInts) { }

        public void InsertionSort()
        {
            InsertionSortS(SortedInts,0,N);
        }

        public static void InsertionSortS(int[] NumArray, int start, int end)
        {
            int temp, j;
            for (int i = start; i <= end; i++)
            {
                temp = NumArray[i];
                for (j = i; j > start && temp < NumArray[j - 1]; j--)
                {
                    NumArray[j] = NumArray[j - 1];
                }

                NumArray[j] = temp;
            }
        }
    }
}
