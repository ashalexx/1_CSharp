using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace task_8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\Папка\\text.txt";//путь и название файла
            Random rand = new Random();//создает рандомные числа
            if (!File.Exists(path))//услови, если этого файла нет
	        {                
                File.Create(path).Close(); //создать файл
	        }
            for (int i = 0; i < 3; i++)//записываем в новую строку рандомные числа определенное число раз(в данном случае 3 раза)
			{           
                StreamWriter sw = new StreamWriter(path, true);
                
                sw.WriteLine(rand.Next(0, 1000));//задаем так сказать ширину массива
                sw.Close();//закрываем файл после записи
			}
            
            string[] lines = File.ReadAllLines(path);//создаем ммассисв lines с записанными числами в файле(каждая строка - новая позиция в массиве)
            int sum = 0;
            for (int i = 0; i < lines.Length ; i++)//цыкл выводит сумму всех чисел в массиве(расчет идет расчитывая из длинны массива(Length))
            {
                sum = sum + Convert.ToInt32(lines[i]);
            }
			Console.WriteLine("Сумма всех чисел записанных в text.txt = {0}\n", sum);
              
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
