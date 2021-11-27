using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStruct my = new MyStruct { b = 1, k = 4 };
            my.Root();
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
        struct MyStruct
        {
            public double k;
            public double b;
            public double x;
            public void Root()
            {
                x = (0 - b) / k;
                Console.WriteLine(x);
            }
        }
    }
}
