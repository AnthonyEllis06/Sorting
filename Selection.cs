using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Selection:SortingMethod
    {
        public Selection(List<int> randominInts)
        {
            ToSort = randominInts;
            SortName = "Selection Sort";
        }

        public override void Sort()
        {
            SelectionSortRec(ToSort, N);
        }

        private void SelectionSortRec(List<int> list, int n)
        {
            if(n<=1)
                return;
            int max = Max(list, n);
            if (list[max] != list[n - 1])
            {
                Swap(list, max, n - 1);
                NumSwaps++;
            }
                
            SelectionSortRec(list,n-1);
        }

        private int Max(List<int> list, int n)
        {
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                if (list[max] < list[i])
                    max = i;
            }

            return max;
        }
    }
}
