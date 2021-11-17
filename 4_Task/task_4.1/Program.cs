using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите не отрицательное число:");

            int N = Convert.ToInt32(Console.ReadLine());
            int Number;         

            if (N > 0)
            {
                for (int i = 0, j = 1; j <= N; i = ((2*1 + 2 * (j - 1)) / 2)*j, j++)
                {
                    Number = i + (2 * j - 1);
                    Console.WriteLine("о боги! как я долго делал это задание! Квадрат числа {0} равен {1}", j, Number);
                }
            }
            else
            {
                Console.WriteLine("Вы ввели отрицательное число. Вам не стыдно? =)");
            }
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
