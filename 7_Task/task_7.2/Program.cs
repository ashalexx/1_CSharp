using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите размер грани куба: ");
            Double a = Convert.ToDouble(Console.ReadLine());

            calculationCubeVolumeArea(a);
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
        static void calculationCubeVolumeArea(Double a)
        {            
            if (a>0)
	        {
                Double S = 6*Math.Pow(a, 2);
                Double V = Math.Pow(a, 3);
                Console.WriteLine("Грань куба a = {0}\n Площадь S = {1}\n Объем V = {2}", a, S, V);
	        }     
            else
	        {
                Console.WriteLine("Вы ввели отрицательное значение грани.");
	        }
                        
        }

    }
}
