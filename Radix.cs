using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Radix : Sort
    {
        public Radix(int[] randomInts) : base(randomInts) { }

        public void RadixSort()
        {
            SortedInts= Radix10LSDSort(new List<int>(SortedInts)).ToArray();
        }
        public static List<int> Radix10LSDSort(List<int> list)
        {
            List<List<int>> bin = new List<List<int>>(10);
            for(int i = 0; i<10;i++)
                bin.Add(new List<int>(list.Count));
            
            int numDigits = list.Max().ToString().Length;

            for(int j = 0; j<numDigits;j++)
            {
               for(int n = 0; n<list.Count; n++)
                    bin[Digit(list[n],j)].Add(list[n]);
            
               CopyToResult(bin,list);
                for(int i = 0; i<10;i++)
                    bin[i].Clear();
            }
            return list;
        }
        private static void CopyToResult(List<List<int>> bin, List<int> result)
        {
            result.Clear();
            for(int i = 0; i<10;i++)
                foreach(int j in bin[i])
                    result.Add(j);
        }
        private static int Digit(int value, int digitPosition)
        {
            return (value / (int)Math.Pow(10, digitPosition) % 10);
        }


    }
}
