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
            Console.WriteLine("Введите целочисленное число: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[,] A = new int[N,N];//создание 2мерного массива

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = 1 - (i + j) % 2;//деление с остатком чтобы получить 1 0 1 0
                    Console.Write("{0} ", A[i,j]);
                }
                Console.WriteLine(); //перенос строки, чтобы небыло все в одну длинную строку
            }
            Console.WriteLine();                     
            
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
