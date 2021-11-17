using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0, d = 0;
            Console.WriteLine("Введите сторону прямогульника A:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону прямоуголника B:");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону квадрата:");
            int C = Convert.ToInt32(Console.ReadLine());

            while (C <= A)
            {
                A = A - C;
                i++;
            }

            while (C <= B)
            {
                B = B - C;
                j++;
            }          

            while (j > 0)
            {
                d = d + i;
                j--;
            }

            Console.WriteLine("{0}шт. квадратов в этом прямоугольнике", d);
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
