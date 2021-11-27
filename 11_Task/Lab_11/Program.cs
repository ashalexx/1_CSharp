using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using bibl;


//Person tom = new Person();  // создание объекта класса Person

//// определение класса Person
//class Person
//{
//    public string name = "Undefined";
//    public int age;

//    public void Print()
//    {
//        Console.WriteLine($"Имя: {name}  Возраст: {age}");
//    }
//}
namespace task_10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass qw = new MyClass(8, 0, 0);//создаем экземпляр класса 
                                              //qw.Gradus = 8;//не забываем про БОЛЬШУЮ заглавную букву
                                              //qw.Min = 0;
                                              //qw.Sec = 0;

            qw.ToRadians();//вызов метода класса MyClass
            Console.WriteLine();

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }   

}
