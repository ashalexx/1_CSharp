using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Мурка", "синяя", 23); //создали экземпляр класса
        }
    }
    class Cat
    {
        string name; //поля
        string color;
        int age;

        Cat(string n, string c, int a) //конструктор
        {
            name = n;
            color = c;
            age = a;
        }

        void Say()// методы
        {
            Console.WriteLine("Мяу");
        }
    }
}
