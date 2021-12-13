using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab_21
{
    internal class Program
    {
        static void Print1()
        {
            while (true)
            {
                Console.WriteLine("Primary");
            }
        }
        static void Print2() // метод который мы хотим запустить в отдельном потоке не должен принимать аргументы и не возвращает значение
        {
            while (true)
            {
                Console.WriteLine(new string(' ', 20)+"Secondary");
            }
        }
        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(Print2); // создаем переменную деленгата ThreadStart.В качестве конструктора передем метод который хотим хапустить в потоке.
            Thread thread = new Thread(threadStart); // создаем экземпляр класса Thread.Аргументом конструктора перадем переменную делегата. 
            thread.Start(); // вызываем поток на исполенение
            Print1();
        }
    }
}
