using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sorting
{
    class Sink:Sort
    {

        public Sink(int[] randomInts) : base(randomInts) { }//empty constructor to call parent constructor.
        public void SinkSort()
        {
            bool sorted = false;
            int pass = 0;
            TimerStart();
            while (!sorted && (pass < N))
            {
                pass++;
                sorted = true;
                for (int i = 0; i < N - pass; i++)
                {
                    if (SortedInts[i] > SortedInts[i + 1])
                    {
                        Swap(SortedInts,i, i+1);
                        NumSwaps++;
                        sorted = false;
                    }
                }
            }
            TimerEnd();
        }
    }
}
