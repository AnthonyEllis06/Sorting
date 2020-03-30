using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Quick:SortingMethod
    {
        public Quick(List<int> randomInts)
        {
            SetToSort(randomInts);
            SortName = "Quick Sort";
        }

        public override void Sort()
        {
            QuickSortRec(ToSort,0,N-1);
        }

        

        private void QuickSortRec(List<int> list, int start, int end)
        {
            int left = start;
            int right = end;
            if (left >= right)
                return;
            while (left < right)
            {
                while (list[left] <= list[right] && left < right)
                    right--;
                if (left < right)
                {
                    base.Swap(list, left, right);
                }
                while (list[left] <= list[right] && left < right)
                    left++;
                if (left < right)
                {
                    Swap(list, left, right);
                }
            }
            QuickSortRec(list,start,left-1);
            QuickSortRec(list,right+1,end);
        }


    }

    class QuickMedOf3 : SortingMethod
    {
        public QuickMedOf3(List<int> randomInts)
        {
            ToSort = randomInts;
            SortName = "Quick Sort(median of three)";
        }

        public override void Sort()
        {
            StartTimer();
            QuickMedThree(ToSort,0,N);
        }
        private void QuickMedThree(List<int> list, int start, int end)
        {
            const int cutoff = 10;//point at which we switch to insertion sort.
            if (start + cutoff > end)
                Insertion.InsertionSortS(list, start, end);
            else
            {
                int middle = (start + end) / 2;                     //find median of three for pivot
                if (list[middle] < list[start])             //  by sorting them and pivot is
                {                                                   //  in the middle position
                    Swap(list, start, middle);
                    NumSwaps++;
                }

                if (list[end] < list[start])
                {
                    Swap(list, start, end);
                    NumSwaps++;
                }

                if (list[end] < list[middle])
                {
                    Swap(list, middle, end);
                    NumSwaps++;
                }
                //place pivot at position(end-1) since we know that array[end] >= array[middle]
                int pivot = list[middle];
                Swap(list, middle, end - 1);
                NumSwaps++;
                //begin partitioning
                int left, right;
                for (left = start, right = end - 1; ;)
                {
                    while (list[++left] < pivot)
                        ;
                    while (pivot < list[--right])
                        ;
                    if (left < right)
                    {
                        Swap(list, left, right);
                        NumSwaps++;
                    }
                    else
                        break;
                }
                //restore pivot
                Swap(list, left, end - 1);
                QuickMedThree(list, start, left - 1);//recursively sort left subset
                QuickMedThree(list, left + 1, end);//recursively sort right subset
            }

        }
    }
}
