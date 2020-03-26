using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
