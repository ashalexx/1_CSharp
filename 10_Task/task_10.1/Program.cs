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
            
            MyClass qw = new MyClass();
            qw.Gradus = 8;//не забываем про БОЛЬШУЮ заглавную букву
            qw.Min = 1;
            qw.Sec = 45;
            
            qw.ToRadians();
            Console.WriteLine();
                              
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
    public class MyClass
    {
        private int gradus;
        private int min;
        private int sec;
                
        public int Gradus
        {
            set
            {
                if (value > 0)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Значение gradus отрицательное\n");
                }
            }
            get
            {
                return gradus;
            }
        }
        public int Min
        {
            set
            {
                if (value > 0)
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
        public int Sec
        {
            set
            {
                if (value > 0)
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

        public void ToRadians()
            {
                if (true)
                {

                }
                double Radians = Convert.ToDouble((gradus + min / 60 + sec / 3600) * (Math.PI) / 180);
                Console.WriteLine("{0} Радиан", Radians);
            }
    }
	    
}
