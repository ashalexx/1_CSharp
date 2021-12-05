using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Text.Json.Serialization;
using System.IO;

namespace task_16._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\Папка\\text.json";

            StreamReader sr = new StreamReader(path);

            Product[] jsonShop = JsonSerializer.Deserialize<Product[]>(sr.ReadToEnd());
            //var max = jsonShop.OrderByDescending(x => x.productPrice).FirstOrDefault().productName;
            //Console.WriteLine("Самая высокая цена = {0}", max);
            Product maxProduct = jsonShop[4];//берем первый экземпляр в массиве
            foreach (Product product in jsonShop)//проходимся по этому массиву циклом
            {
                if (product.productPrice > maxProduct.productPrice)//если в этом массиве productPrice больше чем цена в массиве maxProductPrice
                {
                    maxProduct = product; //то, maxProduct становится массивом из цикла
                }

            }
            Console.WriteLine("Товар с самой высокой ценой = {0}", maxProduct.productName); 
            Console.WriteLine();

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
    class Product
    {
        public int productCode { get; set; }
        public string productName { get; set; }
        public int productPrice { get; set; }
    }
}
