using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======Программа-калькулятор=======\n");
            Console.Write("Введите число A: ");
            double A = Convert.ToDouble(Console.ReadLine()); 
            Console.Write("Введите число B: ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Что вы хотите сделать?:\n 1 - сложение\n 2 - вычитание\n 3 - произведение\n 4 - частное\n");
            int enteredNumber = Convert.ToInt32(Console.ReadLine());
            int[] vs = {1, 2, 3, 4};
            try 
	        {                
                enteredNumber = vs[enteredNumber-1];                
	            switch(enteredNumber)
	            {
                    case 1:
                        Console.WriteLine("Вы ввели {0}\nСумма чисел равна {1}", enteredNumber, (A+B)); 
                        break;
                    case 2:
                        Console.WriteLine("Вы ввели {0}\nРазность чисел равна {1}", enteredNumber, (A-B));	   
                        break;
                    case 3:
                        Console.WriteLine("Вы ввели {0}\nПроизведение чисел равна {1}", enteredNumber, (A*B));
	                    break;
                    case 4:
                        Console.WriteLine("Вы ввели {0}\nЧастное чисел равна {1}", enteredNumber, (A/B));
                        break;
	                }	
                
	        }
	        catch 
            {
                Console.WriteLine("Вы ввели число {0}", enteredNumber);
                Console.WriteLine("Возникло исключение!");
                
            }
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
