using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            long n;

            do
            {
                Console.Write("Input n: ");
                n = long.Parse(Console.ReadLine()); 
            } while (n <= 0);

            Console.Write("\n" + n + ": ");
            for (long i = 0; i <= n; i++)
            {
                if (i == n)
                {
                    Console.WriteLine(Fibonacci(i) + " ");
                }    
            }
            Console.ReadKey();
        }

        public static long Fibonacci(long n)
        {
            long x = 1;
            long y = 1;
            for (long i = 1; i < n; i++)
            {
                long temp = x;
                x = y;
                y = temp + y;
            }
            return x;
        }
    }
}
