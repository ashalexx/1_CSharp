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
            string str = "(())";
            
            Stack<char> stack = new Stack<char>();
            bool b = true;
            foreach (char item in str)
            {
                switch (item)
                {
                    case '(': stack.Push(')'); break;
                    case '[': stack.Push(']'); break;
                    case '{': stack.Push('}'); break;

                    case ')':
                    case ']':
                    case '}':
                        if (stack.Count() == 0)
                        {
                            b = false;
                            break;
                        }
                        if (stack.Peek() == '(' && item == ')')
                        {
                            continue;
                        }
                        if (stack.Peek() == '[' && item == ']')
                        {
                            continue;
                        }
                        if (stack.Peek() == '{' && item == '}')
                        {
                            continue;
                        }
                        b = false;
                        break;
                    default:
                        break;
                }
            }
            if (b)
                Console.WriteLine("ok");            
            else
                Console.WriteLine("no");

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
