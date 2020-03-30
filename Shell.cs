using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Shell:SortingMethod
    {
        public Shell(List<int> randomInts)
        {
            SetToSort(randomInts);
        }

        public override void Sort()
        {
            StartTimer();
            ShellSort();
            StopTimer();
        }
        public void ShellSort()
        {
            for (int gap = N / 2; gap > 0; gap = (gap == 2 ? 1 : (int) (gap / 2.2)))
            {
                int temp, j;
                for (int i = gap; i < N; i++)
                {
                    temp = ToSort[i];
                    for (j = i; j >= gap && temp < ToSort[j - gap]; j -= gap)
                    {
                        ToSort[j] = ToSort[j - gap];
                    }

                    ToSort[j] = temp;
                }
            }
        }
    }
}
