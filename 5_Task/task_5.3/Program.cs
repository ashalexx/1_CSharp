using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            Random random = new Random();
            Console.Write("Дан рандомный массив: ");
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = random.Next(-50, 50);
                Console.Write("{0} ", numbers[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < 4; i++)
			{
                for (int j = i+1; j < 5; j++)
			    {
                    if (numbers[i]>numbers[j])
	                {
                        int t=numbers[i];
                        numbers[i]=numbers[j];
                        numbers[j]=t;
	                }
			    }
			}

            Console.WriteLine();

            Console.Write("Первые 5 элементов массива по возрастанию: ");
            for (int i = 0; i < 5; i++)
			{
                Console.Write("{0} ", numbers[i]);
			}            
            Console.WriteLine();
            for (int i = 5; i < 9; i++)
			{
                for (int j = i+1; j < 10; j++)
			    {
                    if (numbers[i]<numbers[j])
	                {
                        int t=numbers[i];
                        numbers[i]=numbers[j];
                        numbers[j]=t;
	                }
			    }
			}            
           
            Console.Write("Вторые 5 элементов массива по убыванию: ");
            for (int i = 5; i < 10; i++)
			{
                Console.Write("{0} ", numbers[i]);
			}
            Console.WriteLine();
            
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
