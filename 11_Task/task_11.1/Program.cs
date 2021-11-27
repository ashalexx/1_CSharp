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
            MyStruct my = new MyStruct { b = 1, k = 4 };//создаем экземпляр структыру
            my.Root();//вызов метода
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
        struct MyStruct//создание сруктуры
        {
            public double k;
            public double b;
            public double x;
            public void Root()//метод в структуре
            {
                x = - b / k;
                Console.WriteLine(x);
            }
        }
    }
}
