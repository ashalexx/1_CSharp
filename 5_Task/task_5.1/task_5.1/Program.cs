using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] numbers = new int[7];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Введите элемент масива: {0}", i);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }            

            foreach (int i in numbers)
            {
                sum = sum + i;                
            }

            int numLength = numbers.Length;
            int arifmet = sum / numLength;
            Console.WriteLine("Сумма массива = {0}", sum);
            Console.WriteLine("Длина массива = {0}", numLength);
            Console.WriteLine("Среднее арифметическое элементов массива = {0}", arifmet);

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
