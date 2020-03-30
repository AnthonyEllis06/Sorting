using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Sorting
    {
        static void Main(string[] args)
        { 
            Sort s = new Sort(1000);
            Sink sink = new Sink(s.RandomInts);
            sink.SinkSort();
            Console.WriteLine(sink.GetTotalTime());
            Console.ReadLine();
        }

        public Sorting()
        {
            List<String> SortingNames =new List<string>(){"Counting","Insertion", "Merge","Quick","Quick Median of Three","Radix","Selection","Shell","Sink"};
            Console.WriteLine("Enter Number of random numbers to sort");
            int numToSort = int.Parse(Console.ReadLine());
            


        }
    }
}
