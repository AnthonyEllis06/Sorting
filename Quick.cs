using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Quick:Sort
    {
        public Quick(int[] randomInts) : base(randomInts) { }

        public void QuickSort()
        {
            SortedInts = RandomInts;
            NumSwaps = 0;
            QuickSortRec(SortedInts,0,N-1);
        }

        

        private void QuickSortRec(int[] NumArray, int start, int end)
        {
            int left = start;
            int right = end;
            if (left >= right)
                return;
            while (left < right)
            {
                while (NumArray[left] <= NumArray[right] && left < right)
                    right--;
                if (left < right)
                {
                    Swap(NumArray, left, right);
                    NumSwaps++;
                }
                while (NumArray[left] <= NumArray[right] && left < right)
                    left++;
                if (left < right)
                {
                    Swap(NumArray, left, right);
                }
            }
            QuickSortRec(NumArray,start,left-1);
            QuickSortRec(NumArray,right+1,end);
        }
        public void QuickSortMedThree()
        {
            SortedInts = RandomInts;
            NumSwaps = 0;

        }

        private void QuickMedThree(int[] NumArray, int start, int end)
        {
            const int cutoff = 10;//point at which we switch to insertion sort.
            if (start + cutoff > end)
                Insertion.InsertionSortS(NumArray, start, end);
            else
            {
                int middle = (start + end) / 2;                     //find median of three for pivot
                if (NumArray[middle] < NumArray[start])             //  by sorting them and pivot is
                {                                                   //  in the middle position
                    Swap(NumArray, start, middle);
                    NumSwaps++;
                }

                if (NumArray[end] < NumArray[start])
                {
                    Swap(NumArray,start,end);
                    NumSwaps++;
                }

                if (NumArray[end] < NumArray[middle])
                {
                    Swap(NumArray,middle,end);
                    NumSwaps++;
                }
                //place pivot at position(end-1) since we know that array[end] >= array[middle]
                int pivot = NumArray[middle];
                Swap(NumArray,middle,end-1);
                NumSwaps++;
                //begin partitioning
                int left, right;
                for (left = start, right = end - 1;;)
                {
                    while (NumArray[++left] < pivot)
                        ;
                    while (pivot < NumArray[--right])
                        ;
                    if (left < right)
                    {
                        Swap(NumArray, left, right);
                        NumSwaps++;
                    }
                    else
                        break;
                }
                //restore pivot
                Swap(NumArray,left,end-1);
                QuickMedThree(NumArray,start,left-1);//recursively sort left subset
                QuickMedThree(NumArray,left+1,end);//recursively sort right subset
            }

        }
    }
}
