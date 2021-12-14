using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task_23._1
{
    internal class Program
    {
        static void Factorial()
        {           
            long x = 6;
            // находим факториал числа
            long f = 1;
            for (int i = 2; i <= x; i++)
            {
                f = f * i;
            }
            Thread.Sleep(8000);
            Console.WriteLine($"\nФакториал числа {x} равен {f}");
        }
        // определение асинхронного метода
        static async void FactorialAsync()
        {
            Console.WriteLine("\nНачало метода FactorialAsync"); // выполняется синхронно
            await Task.Run(() => Factorial());                // выполняется асинхронно
            Console.WriteLine("\nКонец метода FactorialAsync");
        }
        static void Main(string[] args)
        {
            //Console.Write("Введите число: ");
            //long x = Convert.ToInt32(Console.ReadLine());
            FactorialAsync();

            Console.Write("\nВведите число b: ");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Квадрат числа z равен {z * z}");


            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
