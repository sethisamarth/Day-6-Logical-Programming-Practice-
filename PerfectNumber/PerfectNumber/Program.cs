using System;

namespace PerfectNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of n");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1, sum1 = 0, finalsum = 0;
            for (i = 1; i < n * n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                    sum1 = sum1 + i;
                }

            }
            finalsum = sum1 - n;
            Console.WriteLine("value of final sum ={0}",finalsum);  
            if (finalsum == n)
            {
                Console.WriteLine("its a perfect no.");
            }
            else
            {
                Console.WriteLine("its a not  perfect no.");

            }

        }
    }
}
