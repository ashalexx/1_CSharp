using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();

            int maxLen = 0; 
            int minLen = 0; 
            int indexMax = 0;
            int indexMin = 0;

            for (int i = 0; i < stringArray.Length; i++)
			{              
                if (stringArray[i].Length > maxLen)
                {
                    maxLen = stringArray[i].Length;
                    indexMax = i;
                }
                else if (stringArray[i].Length < minLen)
                {
                    minLen = stringArray[i].Length;
                    indexMin = i;
                }
                
			}
            Console.WriteLine("Самое длинное слово в строке: {0}", stringArray[indexMax]);

            Console.ReadKey();

        }
    }
}
