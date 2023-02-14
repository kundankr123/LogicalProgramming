using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace LogicalProgramming
{
    public class StopWatch
    {
        public static void StopwatchElapsedTime()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("Stopwatch Starting");
            for (int i=0; i<10; i++)
            {
                Console.WriteLine("inside for loop");
            }
            stopwatch.Stop();
            Console.WriteLine("Time Elapsed : {0}", stopwatch.Elapsed);
        }
    }
}
