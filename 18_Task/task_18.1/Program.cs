using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_18._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "([al(s)kdv{lam}v{]})";
            
            Stack<char> stack = new Stack<char>();

            foreach (char item in str)
            {                
                switch (item)
                {
                    case '(': stack.Push(')'); break;
                    case '[': stack.Push(']'); break;
                    case '{': stack.Push('}'); break;

                    //case ')':
                    //case ']':
                    //case '}':
                    //    if (stack.Count == 0)
                    //    {
                    //        Console.WriteLine("Дана строка {0}\n", str);
                    //        Console.WriteLine("Расположение скобок не правильное.");
                    //    }
                    //    stack.Pop();
                    //    break;
                    //default:
                    //    break;
                }
            }
            

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
