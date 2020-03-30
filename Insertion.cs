using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Insertion:SortingMethod
    {
        public Insertion(List<int> randomInts)
        {
            SetToSort(randomInts);
            SortName = "Insertion Sort";
        }

        public override void Sort()
        {
            InsertionSortS(ToSort,0,N);
        }

        public static void InsertionSortS(List<int> list, int start, int end)
        {
            int temp, j;
            for (int i = start; i <= end; i++)
            {
                temp = list[i];
                for (j = i; j > start && temp < list[j - 1]; j--)
                {
                    list[j] =list[j - 1];
                }

                list[j] = temp;
            }
        }
    }
}
