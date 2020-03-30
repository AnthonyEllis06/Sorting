using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Counting:SortingMethod
    {
        public Counting(List<int> randomInts)
        {
            SetToSort(randomInts);
            SortName = "Counting Sort";
        }

        public override void Sort()
        {
            StartTimer();
            CountingSort();
            StopTimer();
        }

        public void CountingSort()
        {
            List<int> newList = new List<int>(ToSort);
            int max = ToSort.Max();
            int[] counts = new int[max + 1];
            for (int i = 0; i <= max; i++)
                counts[i] = 0;
            for (int j = 0; j < N; j++)
                counts[ToSort[j]]++;
            for (int j = 1; j <= max; j++)
                counts[j] += counts[j - 1];
            for (int j = 0; j < newList.Count; j++)
            {
                newList[counts[ToSort[j]] - 1] = ToSort[j];
                counts[ToSort[j]]--;
            }
        }
    }
}
