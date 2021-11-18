using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            int[,] A = new int[N,N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = 1 - (i + j) % 2;
                    Console.Write(A[i,j]+" ");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
