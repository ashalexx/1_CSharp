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
            Bank<int> bank = new Bank<int>(1, "Глебков Василий Алексеевич", 45);
            Bank<string> bank1 = new Bank<string>("34", "Зигулин Глеб Федорович", 3256);
            Bank<double> bank2 = new Bank<double>(57, "Жимухина Нина Петровна", 98);

            bank.Print();
            bank1.Print();
            bank2.Print();

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
    public class Bank<T>
    {
        public T AccountNumber { get; private set; }
        public string Name { get; private set; }
        public int Balans { get; private set; }

        public Bank(T AccountNumber, string Name, int Balans)
        {
            this.AccountNumber = AccountNumber;
            this.Name = Name;
            this.Balans = Balans;
        }      
        public void Print()
        {
            Console.WriteLine("Номер счета: {0}\nФИО: {1}\nБаланс: {2} коп.\n", AccountNumber, Name, Balans);
        }
    }
}
