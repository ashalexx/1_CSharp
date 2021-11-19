using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //не смог решить задачу

            string S = "{текст заключенный в фигурные скобки} текст без скобок }текс в скобках на оборот{";
            string newS = "";
            for (int i = 0; i < S.Length; i++)
            {
                newS = Convert.ToString(S[i]);
                if (S[i]=='{')
                {                    
                    
                    
                }
                Console.Write(newS);
            }
            Console.WriteLine();
            
            
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
