using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task_22._1
{
    internal class Program
    {
        static int Sum(int[] mass)
        {
            int Sum = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                Sum += mass[i];
            }
            Console.WriteLine();
            Console.WriteLine("Сумма всех чисел в массиве равна: {0}", Sum);
            return Sum;
        }
        static int MaxNumber(int[] mass)
        {
            Console.WriteLine();
            Console.WriteLine("Максимальное число в массиве равно: {0}", mass.Max());
            return mass.Max();            
        }
        static void Main(string[] args)
        {
            Console.Write("Задайте размер массива: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[b];
            
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 100);
            }

            Func<int> func = new Func<int>(() => Sum(array));
            Task<int> task1 = new Task<int>(func);
            task1.Start();

            Func<int> func1 = new Func<int>(() => MaxNumber(array));
            Task<int> task2 = new Task<int>(func1);
            task2.Start();

            task1.Wait();
            task2.Wait();

            Console.WriteLine("\nНвжмите любую клавишу...");
            Console.ReadKey();
        }        
    }
}
