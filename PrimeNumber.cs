using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class PrimeNumber
    {
        public static void CheckPrime()
        {
            int NoOfFactors = 0;
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            while(i < (num/2)) 
            {
                if (num % i == 0)
                    NoOfFactors++;
                i++;
            }
            if (NoOfFactors == 1)
            {
                Console.WriteLine("Number is Prime.");
            }
            else
            {
                Console.WriteLine("Number is not Prime.");
            }

        }
    }
}
