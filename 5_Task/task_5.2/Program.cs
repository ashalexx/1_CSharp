using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[15];
            
            Random random = new Random();


            for (int i = 0; i < numbers.Length; i++)            
            {
                numbers[i] = random.Next(0, 50);
                Console.Write("{0} ", numbers[i]);
            }
            Console.WriteLine();

            int max = numbers[0];
            int min = numbers[0];

            foreach (int a in numbers)
            {
                if (a > max)
                {
                    max = a;
                }
                if (a < min)
                {
                    min = a;
                }
            }
            Console.WriteLine("Максимальное число в массиве = {0} ", max);
            Console.WriteLine("Минимальное число в массиве = {0} ", min);
            int sum = min + max;
            Console.WriteLine("Сумма {0} + {1} = {2}", max, min, sum);
            Console.WriteLine();


            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
