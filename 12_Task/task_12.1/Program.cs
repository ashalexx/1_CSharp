using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_12._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try//пробуем сделать это
            {
                Console.Write("Введите радиус окружности: ");
                double Radius = Convert.ToDouble(Console.ReadLine());
                if (Radius <= 0)
                {
                    Console.WriteLine("Вы ввели 0 или отрицательное число\n");
                    Console.WriteLine("Нажмите любую клавишу...");
                    Console.ReadKey();
                    return;//без return программа продолжает работать дальше
                }

                Circle.CircleLength(Radius);//вызов метода CircleLength
                Circle.CircleArea(Radius);//вызов метода CircleArea
                Console.Write("Введите координату X: ");
                double X = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите координату Y: ");
                double Y = Convert.ToDouble(Console.ReadLine());
                Circle.Position(Radius, X, Y);//вызов мтеода Position

                Console.WriteLine("Нажмите любую клавишу...");
                Console.ReadKey();
            }
            catch (FormatException)//ловим ошибку если то что мы хотели сделать пошло не так
            {
                Console.WriteLine("Не верный ввод!");
                Console.WriteLine("Нажмите любую клавишу...");
                Console.ReadKey();
                return;
            }
        }
    }
    static class Circle
    {
        public static void CircleLength(double Radius)//метод находит длину окружности
        {
            double CircleLength = 2 * Math.PI * Radius;
            Console.WriteLine("Длина окружности равна: {0}\n", CircleLength);
        }
        public static void CircleArea(double Radius)//метод находит площадь окружности
        {
            double CircleArea = Math.PI * Math.Pow(Radius, 2);
            Console.WriteLine("Площадь окружности равна: {0}\n", CircleArea);
        }
        public static void Position(double Radius, double X, double Y)//метод определяет нахождение точки в пределах окружности
        {
            if (X <= Radius && Y <= Radius)
            {
                Console.WriteLine("Точка с координатами X = {0} и Y = {1} находится в окружности с радиусом {2}", X, Y, Radius);
            }
            else
            {
                Console.WriteLine("Точка с координатами X = {0} и Y = {1} находится за пределами окружности с радиусом {2}", X, Y, Radius);
            }
        }
    }
}
