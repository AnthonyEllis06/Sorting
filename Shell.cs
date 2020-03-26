using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Shell:Sort
    {
        public Shell(int[] randomInts) : base(randomInts) { }

        public void ShellSort()
        {
            for (int gap = N / 2; gap > 0; gap = (gap == 2 ? 1 : (int) (gap / 2.2)))
            {
                int temp, j;
                for (int i = gap; i < N; i++)
                {
                    temp = SortedInts[i];
                    for (j = i; j >= gap && temp < SortedInts[j - gap]; j -= gap)
                    {
                        SortedInts[j] = SortedInts[j - gap];
                    }

                    SortedInts[j] = temp;
                }
            }
        }
    }
}
