using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    abstract class SortingMethod
    {
        private DateTime Start;
        private DateTime End;
        public List<int> ToSort { get; set; }
        public int N { get; set; }
        public int NumSwaps { get; set; }
        public String SortName;
        public abstract void Sort();
        public static List<int> MakeRandomInts(int numOfRandoms)
        {
            List<int> RandomInts = new List<int>();
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < numOfRandoms; i++)
            {
                RandomInts.Add(rand.Next(0, numOfRandoms));
            }
            return RandomInts;
        }

        public void Swap(List<int> NumList, int indexOne, int indexTwo)
        {
            int temp = NumList[indexOne];
            NumList[indexOne] = NumList[indexTwo];
            NumList[indexTwo] = temp;
            NumSwaps++;
        }

        public void SetToSort(List<int> toSet)
        {
            ToSort = toSet;
            N = ToSort.Count;
            NumSwaps = 0;
        }
        public void StartTimer()
        {
            Start = DateTime.Now;
        }

        public void StopTimer()
        {
            End = DateTime.Now;
        }

        public Double GetTimeTotal()
        {
            return End.Subtract(Start).Milliseconds;
        }
    }
}
