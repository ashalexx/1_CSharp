using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {           
                       
           
            double perimeterHalf;

            Console.WriteLine("Введите координату x1");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координату y1");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координату x2");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координату y2");
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координату x3");
            int x3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координату y3");
            int y3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Координата x1 = {0}", x1);
            Console.WriteLine("Координата y1 = {0}", y1);
            Console.WriteLine("Координата x2 = {0}", x2);
            Console.WriteLine("Координата y2 = {0}", y2);
            Console.WriteLine("Координата x3 = {0}", x3);
            Console.WriteLine("Координата y3 = {0}", y3);

            int A_sideLength = Convert.ToInt32(Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2)));
            int B_sideLength = Convert.ToInt32(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
            int C_sideLength = Convert.ToInt32(Math.Sqrt(Math.Pow((x2 - x3), 2) + Math.Pow((y2 - y3), 2)));

            Console.WriteLine("Длина стороны A = {0}", A_sideLength);
            Console.WriteLine("Длина стороны B = {0}", B_sideLength);
            Console.WriteLine("Длина стороны C = {0}", C_sideLength);

            int trianglePerimeter = Convert.ToInt32(A_sideLength + B_sideLength + C_sideLength);
            Console.WriteLine("Периметр треугольника = {0}", trianglePerimeter);

            perimeterHalf = Convert.ToDouble(trianglePerimeter / 2);
            Console.WriteLine("Половина периметра = {0}", perimeterHalf);

            int triangleArea = (int)Convert.ToDouble(Math.Sqrt(perimeterHalf * (perimeterHalf - A_sideLength) * (perimeterHalf - B_sideLength) * (perimeterHalf - C_sideLength)));
                

            Console.WriteLine("Площадь треуголника = {0}", triangleArea);

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
