using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_18._1
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var str = "([][()])";
            
            Stack<char> stack = new Stack<char>();
            stack.Push(str[0]);// помещаем в стек первый символ в строке str
            for (int i = 1; i < str.Length; i++) // проходимся циклом по строке, выбирая каждый символ
            {
                if (str[i] == '(' || str[i] == '[' || str[i] == '{') // если встечается симол '(' или '[' или '{' то ->
                {
                    stack.Push(str[i]);// в стэк помещаем символ который встретился(одна из открывающихся скобок)
                }
                else if(str[i] == ')')
                {
                    if (stack.Peek() == '(')// если в вершине стека стоит скобка ')', то ->
                        stack.Pop();        // убираем его из стека 
                    else if (stack.Peek() == '[' || stack.Peek() == '{')
                        break;
                }
                else if (str[i] == ']')
                {
                    if (stack.Peek() == '[')
                        stack.Pop();
                    else if (stack.Peek() == '(' || stack.Peek() == '{')
                        break;
                }
                else if (str[i] == '}')
                {
                    if (stack.Peek() == '{')
                        stack.Pop();
                    else if (stack.Peek() == '(' || stack.Peek() == '[')
                        break;
                }
            }
            if (stack.Count() == 0)
                Console.WriteLine("Скобки выствлены правильно");
            else
                Console.WriteLine("Скобки выставлены не корректно");
            
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
