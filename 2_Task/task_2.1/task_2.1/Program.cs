using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину окружности: ");

            int L = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Длина окружности равна: {0}", L);

            double r = (L / (2 * Math.PI));
            double S = (Math.Pow(r, 2) * Math.PI);

            Console.WriteLine("Радиус окружности с длиной = {1}, равен: {0}", r, L);

            Console.WriteLine("Площадь окружности с длиной = {1}, равна: {0}", S, L);
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
