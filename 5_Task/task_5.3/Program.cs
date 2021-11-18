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


            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-50, 50);
                Console.Write("{0} ", numbers[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < 9; i++)
			{
                for (int j = i+1; j < 10; j++)
			{

			}
			}


            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
