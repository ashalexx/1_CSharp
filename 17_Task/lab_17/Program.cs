using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apartment apartment = new  Apartment();
            apartment.Num = 1;
            int next = (int)apartment.Num + 1;


            Apartment apartment1 = new Apartment();
            apartment1.Num = "01";  

        }
    }
    class Apartment
    {
        public int Level { get; set; }
        public Object Num { get; set; }
    }
}
