using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            int[] vs = new int[] { 1, 2, 3 };
            list.AddRange(vs);
            list.RemoveAt(3);
            list.Reverse();

            for (int i = 0; i < list.Count; i++)
            {
                list[i]++;
            }

            foreach (int l in list)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine("Нажмте любую клавишу...");
            Console.ReadKey();
        }
    }
}
