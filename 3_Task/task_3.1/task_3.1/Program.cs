using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, x3, x4, y1, y2, y3, y4;

            Console.WriteLine("Ведите координаты:");

            Console.WriteLine("x1:");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("y1:");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("x2:");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("y2:");
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("x3:");
            x3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("y3:");
            y3 = Convert.ToInt32(Console.ReadLine());

            if ((x1 - x2) * (x3 - x2) + (y1 - y2) * (y3 - y2) == 0) //если 0, значит уго прямой
            {
                x4 = x2 + (x1 - x2) + (x3 - x2);
                y4 = y2 + (y1 - y2) + (y3 - y2);
                Console.WriteLine("Координаты x4 = {0}, y4 = {1}", x4, y4);
            }
            else
            {
                Console.WriteLine("увы, но это будет не прямоугольник =(");
            }

            Console.ReadKey();
        }
    }
}
