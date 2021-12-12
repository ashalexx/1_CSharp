using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_20._1
{
    internal class Program
    {
        delegate double MyDelegate(double x);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = Method1;
            Console.WriteLine(Method1(2));

            MyDelegate myDelegate1 = Method2;
            Console.WriteLine(Method2(2));

            MyDelegate myDelegate2 = Method3;
            Console.WriteLine(Method3(2));

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
        static double Method1(double r)
        {
            double d = 2 * Math.PI * r;
            return d;
        }

        static double Method2(double r)
        {
            double s = Math.PI * Math.Pow(r, 2);
            return s;
        }

        static double Method3(double r)
        {
            double v = 4 / 3 * Math.PI * Math.Pow(r, 3);
            return v;
        }
    }
}
