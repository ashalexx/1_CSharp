﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1, x2;
            int y1, y2;
            int a, b;
            int rectangleArea;
            int rectanglePerimeter;
            int A_sideLength;
            int B_sideLength;

            Console.WriteLine("Введите координату x1");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату x2");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату y1");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату y2");
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Координата x1 = {0}", x1);
            Console.WriteLine("Координата x2 = {0}", x2);
            Console.WriteLine("Координата y1 = {0}", y1);
            Console.WriteLine("Координата y2 = {0}", y2);

            A_sideLength = Convert.ToInt32(y2 - y1);
            B_sideLength = Convert.ToInt32(x2 - x1);

            Console.WriteLine("Длина стороны A = {0}", A_sideLength);
            Console.WriteLine("Длина стороны B = {0}", B_sideLength);

            rectangleArea = Convert.ToInt32(A_sideLength * B_sideLength);

            Console.WriteLine("Площадь прямоугольника = {0}", rectangleArea);

            rectanglePerimeter = Convert.ToInt32((A_sideLength + B_sideLength)*2);

            Console.WriteLine("Периметр прямоугольника = {0}", rectanglePerimeter);

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
