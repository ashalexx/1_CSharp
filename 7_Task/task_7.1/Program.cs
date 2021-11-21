using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7._1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {                
            Console.WriteLine("Вычисление площади треугольника\n");

            Double x1 = 2, y1 = 2, z1 = 2, x2 = 1, y2 = 1, z2 = 1;
            Double triangleA = Area(x2, y2, z2);
            Double triangleB = Area(x1, y1, z1);

            if (triangleA>triangleB)
	        {
                Console.WriteLine("Площадь треугольника треугольника \"A\" больше чем площадь треугольника \"B\"\n");
	        }
            else
	        {
                Console.WriteLine("Площадь треугольника треугольника \"B\" больше чем площадь треугольника \"A\"\n");   
	        }            

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }    
        //создаем метод высичления площади треугольника
        static Double Area(Double A, Double B, Double C)
        {    
            
            Double perimeterHalf = Convert.ToDouble((A + B + C) / 2);//вычисляем половину периметра треугольника
            Double triangleArea = Convert.ToDouble(Math.Sqrt(perimeterHalf * (perimeterHalf - A) * (perimeterHalf - B) * (perimeterHalf - C)));//находим периметр треугольника
            return triangleArea;
        }
        
    }
}
