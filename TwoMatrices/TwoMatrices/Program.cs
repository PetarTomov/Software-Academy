using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoMatrices
{
    class Program
    {
        static void Main(string[] args)
        {   
            int n = int.Parse(Console.ReadLine());

            int[,] Matrix1 = new int[n, n];
            int[,] Matrix2 = new int[n, n];

            Console.WriteLine("Enter the numbers inside the first matrix");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Enter element {0} {1}", i, j);
                    Matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter the numbers inside the second matrix");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Enter element {0} {1}", i, j);
                    Matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int dif = Matrix1[i, j] - Matrix2[i, j];
                    Console.Write(dif + " ");
                }
                Console.WriteLine();
            }
            
            Console.ReadKey(true);

        }
    }
}
