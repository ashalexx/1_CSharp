using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int a;
            int b;
            string word = "";

            Console.WriteLine("Введите число от 20 до 69:");

            x = Convert.ToInt32(Console.ReadLine());

            if (x >= 20 && x <= 69)
            {
                a = x % 10;
                b = x - a;

                switch (a)
                {
                    case 0:
                        {
                            word = "лет";
                            break;
                        }
                    case 1:
                        {
                            word = "один год";
                            break;
                        }
                    case 2:
                        {
                            word = "два года";
                            break;
                        }
                    case 3:
                        {
                            word = "три года";
                            break;
                        }
                    case 4:
                        {
                            word = "четыре года";
                            break;
                        }
                    case 5:
                        {
                            word = "пять лет";
                            break;
                        }
                    case 6:
                        {
                            word = "шесть лет";
                            break;
                        }
                    case 7:
                        {
                            word = "семь лет";
                            break;
                        }
                    case 8:
                        {
                            word = "восемь лет";
                            break;
                        }
                    case 9:
                        {
                            word = "девять лет";
                            break;
                        }
                    default:
                        break;
                }

                if (b == 20)
                {
                    Console.WriteLine("Двадцать {0}", word);
                }
                else if (b == 30)
                {
                    Console.WriteLine("Тридцать {0}", word);
                }
                else if (b == 40)
                {
                    Console.WriteLine("Сорок {0}", word);
                }
                else if (b == 50)
                {
                    Console.WriteLine("Пятьдесят {0}", word);
                }
                else if (b == 60)
                {
                    Console.WriteLine("Шестьдесят {0}", word);
                }
            }

            else
            {
                Console.WriteLine("Ваше число не входит в диапазон от 20 до 69.");
            }

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();

            }
        }
    }
