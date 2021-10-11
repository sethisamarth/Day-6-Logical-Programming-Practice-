using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int i; int flag = 1;
            Console.WriteLine("Enter a number to check its Prime or not ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i < n/2; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("its not prime number");
                    flag = 0;
                    break;
                }
            }
                if (flag ==1)
                {
                    Console.WriteLine("its  prime number");
                }
        }
    }
}
