using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//что? ка коплучилось? может и не правильно
namespace task_14._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.AnimalType = "Кошка";
            cat.ShowInfo();
            Dog dog = new Dog();
            dog.AnimalType = "Собака";
            dog.ShowInfo();

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public string AnimalType { get; set; }

        public abstract void Say();
        public void ShowInfo()
        {
            Console.WriteLine(AnimalType);
            Say();            
        }
    }
    class Cat: Animal
    {
        //public string AnimalCat { get; set; }
        public override void Say()
        {
            Console.WriteLine("Мяу Мяу");           
        }
    }
    class Dog : Animal
    {
       // public string AnimalDog { get; set; }
        public override void Say()
        {
            Console.WriteLine("Гав Гав");            
        }
    }
}
