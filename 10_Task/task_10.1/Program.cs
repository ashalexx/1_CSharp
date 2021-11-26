using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task_10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MyClass qw = new MyClass();
            qw.gradus = -8;
            qw.min = 1;
            qw.sec = 45;            
            qw.ToRadians();         
                              
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }              
	}
    public class MyClass
	    {
            public int gradus;
            public int min { get; set; }
            public int sec { get; set; }

        public int Gradus
            {
                set 
                { 
                    if (value>0)
	                {
                        gradus = value;
                    }
                    else
                    {
                        Console.WriteLine("Значение gradus отрицательно");
                    }	
                }
                get 
                { 
                    return gradus; 
                }
            }

            public void ToRadians()
            {
                int Radians = Convert.ToInt32((gradus + min / 60 + sec / 3600) * (Math.PI) / 180);
                Console.WriteLine(Radians);
            }
        }
	    
}
