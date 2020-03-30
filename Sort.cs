using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Sorting
{
    class Sort
    {
        public int[] RandomInts { get; set; }
        public int[] SortedInts { get; set; }
        public int N { get; set; }
        public int NumSwaps { get; set; }
        public DateTime Start;
        public DateTime Finish;
        

        public Sort(int[] NewRandomInts)
        {
            this.RandomInts = NewRandomInts;
            this.SortedInts = NewRandomInts;
            N = RandomInts.Length;
            NumSwaps = 0;
        }

        public Sort(int NumInts)
        {
            N = NumInts;
            MakeRandomInts();
            NumSwaps = 0;
        }

        public static void Swap(int[] list,int indexOfA, int indexOfB)
        {
            int temp = list[indexOfA];
            list[indexOfA] = list[indexOfB];
            list[indexOfB] = temp;
        }

        public void MakeRandomInts()
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            RandomInts = new int[N];
            for (int i = 0; i < N; i++)
            {
                RandomInts[i] = rand.Next(0, N);
            }

            SortedInts = RandomInts;
        }

        public void TimerStart()
        {
            Start = DateTime.Now;
        }

        public void TimerEnd()
        {
            Finish = DateTime.Now;
        }

        public Double GetTotalTime()
        {
            return Finish.Subtract(Start).TotalSeconds;
        }

    }
}
