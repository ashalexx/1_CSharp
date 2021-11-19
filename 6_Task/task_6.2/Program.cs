using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //честно, нашел код для переворачивания и определене палиндрома на слово в гугле, немного подредактировал

            Console.Write("Введите предложение: ");
            string startString = Console.ReadLine();
            startString = startString.Replace(" ", "");//убираем пробелы в строке
            startString = startString.ToLower();
            char [] e = startString.ToCharArray();
            string reverseStartString = "";
            for(int i = startString.Length-1;i>=0;i--)
            {
            reverseStartString+=startString[i]; // переворачиваем строку
            }
            if (startString==reverseStartString)
	        {
                Console.WriteLine("Введенная строка является палиндромом");                
	        }
            else
	        {
                Console.WriteLine("Введенная строка не является палиндромом");
	        }                               
            
            Console.ReadKey();
        }
    }
}
