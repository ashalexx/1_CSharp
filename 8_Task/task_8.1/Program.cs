using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace task_8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string dirName="D:\\test";
 
            if (Directory.Exists(dirName))
            {
                Console.WriteLine("=============Подкаталоги=============\n");
                string[] dirs = Directory.GetDirectories(dirName, "*", SearchOption.AllDirectories);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);                   

                }
                Console.WriteLine();
                Console.WriteLine("=============Файлы=============\n");
                 
                string[] files = Directory.GetFiles(dirName, "*", SearchOption.AllDirectories);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();

        }
    }
}
