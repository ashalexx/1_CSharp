using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_16._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(1, "Телевизор", 45);
            
            Product[] product_arr = new Product[5];
            product_arr[0] = product; //это я пробовал заосить экземпляр класса в массив 
            
            

            Console.WriteLine(product_arr[1]);
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
    class Product
    {
        public int productCode { get; set; }
        public string productName { get; set; }
        public double productPrice { get; set; }

        public Product(int productCode, string productName, double productPrise)
        {
            this.productCode = productCode;
            this.productName = productName;
            this.productPrice = productPrise;
        }        
    }
}
