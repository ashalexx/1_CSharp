using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_17._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank<int> bank = new Bank<int>(1, "Вася", 45);
            Bank<int> bank1 = new Bank<int>(34, "Глеб", 3256);
            Bank<int> bank2 = new Bank<int>(57, "Нина", 98);
            
            bank.Write();


            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
    public class Bank<T>
    {
        public T AccountNumber { get; private set; }
        public string Name { get; private set; }
        public double Balans { get; private set; }

        public Bank(T AccountNumber, string Name, double Balans)
        {
            this.AccountNumber = AccountNumber;
            this.Name = Name;
            this.Balans = Balans;
        }

        public void Write()
        {
            Console.Write("Введите номер счета: ");
            var AccountNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите имя: ");
            var Name = Convert.ToString(Console.ReadLine());
            Console.Write("Введите баланс: ");
            var Balans = Convert.ToInt32(Console.ReadLine());
            
        }
        static void Reade()
        {

        }
    }
}
