using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_15._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arithProgression = new ArithProgression();
            Console.WriteLine("Арифметическая прогрессия:\n");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arithProgression.getNext());
            }
            Console.WriteLine("\nСброс!\n");
            arithProgression.reset();
            Console.WriteLine("Новый цикл\n");
            arithProgression.setStart(20);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arithProgression.getNext());
            }
            Console.WriteLine();
            GeomProgression geomProgression = new GeomProgression();
            Console.WriteLine("Геометрическая прогрессия\n");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(geomProgression.getNext());
            }
            Console.WriteLine("\nСброс!\n");
            geomProgression.reset();
            Console.WriteLine("Новый цикл\n");
            geomProgression.setStart(20);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(geomProgression.getNext());
            }
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
    interface ISeries
    {        
        void setStart(int x);//устананавливает начальное значение
        int getNext();//возвращает следующее число ряда
        int reset();//выполняет сброс к начальному значению
    }
    class ArithProgression : ISeries
    {
        public int start { get; set; }
        public int val { get; set; }
        public int getNext()
        {
            val += 2;//задаем шаг 
            return val;//возвращяем
        }
        public int reset()
        {
            val = start;
            return val;
        }
        public void setStart(int x)
        {
            start = x;
            val = start;
        }
    }
    class GeomProgression : ISeries
    {
        public int start { get; set; }
        public int val = 1;      
        public int getNext()
        {           
            val *= 2;//задаем шаг 
            return val;//возвращяем
        }
        public int reset()
        {
            val = start;
            return val;
        }
        public void setStart(int x)
        {
            start = x;
            val = start;
        }
    }
}
