using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class PerfectNumber
    {
        public static void FindPerfectNumber()
        {
            int mn, mx, n, i, sum;

            Console.WriteLine("input the starting range or number:");
            mn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the ending range or number:");
            mx = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The perfect numbers within the given range :");
            for(n=mn; n<mx; n++) 
            {
                i = 1; sum=0;

                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                    
                }
                if (sum == n)
                {
                    Console.WriteLine("{0} ", n);
                }
            }
        }
    }
}
