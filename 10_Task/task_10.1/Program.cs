using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


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
    public class MyClass//конструктор
    {
        private int gradus;
        private int min;
        private int sec;
        public int Gradus//определение свойства с проверкой
        {
            set
            {
                if (value > 0)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Значение gradus отрицательное или равно 0\n");
                }
            }
            get
            {
                return gradus;
            }
        }
        public int Min//определение свойства с проверкой
        {
            set
            {
                if (value >= 0)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Значение min отрицательное\n");
                }
            }
            get
            {
                return min;
            }
        }
        public int Sec//определение свойства с проверкой
        {
            set
            {
                if (value >= 0)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Значение sec отрицательное\n");
                }
            }
            get
            {
                return sec;
            }
        }
        public MyClass(int gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }
        public void ToRadians()
        {
            if (gradus > 0 && min >= 0 && sec >= 0)
            {
                double Radians = Convert.ToDouble((gradus + min / 60 + sec / 3600) * (Math.PI) / 180);
                Console.WriteLine("{0} Радиан", Radians);
            }

        }
    }

}
