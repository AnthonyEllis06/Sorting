using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Merge : SortingMethod
    {
        public Merge(List<int> randomInts)
        {
            SetToSort(randomInts);
            SortName = "Merge Sort";
        }

        public override void Sort()
        {
            StartTimer();
            MergeSort();
            StopTimer();
        }
        public void MergeSort()
        {
            List<int> result = new List<int>(ToSort);
            result = MergeSortRec(result);
            ToSort = result;
        }

        private static List<int> MergeSortRec(List<int> Numbers)
        {
            if (Numbers.Count <= 1)
                return Numbers;
            List<int> result = new List<int>();
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            int middle = Numbers.Count / 2;
            for (int i = 0; i < middle; i++)
                left.Add(Numbers[i]);
            for (int i = middle; i < Numbers.Count; i++)
                right.Add(Numbers[i]);

            left = MergeSortRec(left);
            right = MergeSortRec(right);

            if (left[left.Count - 1] <= right[0])
                return append(left, right);
            result = MergeSides(left, right);
            return result;

        }

        private static List<int> MergeSides(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 && right.Count > 0)
            {
                if (left[0] < right[0])
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }

            while (left.Count > 0)
            {
                result.Add(left[0]);
                left.RemoveAt(0);
            }

            while (right.Count > 0)
            {
                result.Add(right[0]);
                right.RemoveAt(0);
            }

            return result;
        }

        private static List<int> append(List<int> left, List<int> right)
        {
            List<int> result = new List<int>(left);
            foreach (int x in right)
                result.Add(x);
            return result;
        }
    }
}
