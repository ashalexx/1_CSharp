using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Text.Json.Serialization;

namespace task_16._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonString = "{\"productCode\": 0,\"productName\":\"\",\"productPrice\": 0}";
            Product product = JsonSerializer.Deserialize<Product>(jsonString);            
            
            Product product1 = new Product()
            {
                productCode = Convert.ToInt32(Console.ReadLine()),
                productName = Convert.ToString(Console.ReadLine()),
                productPrice = Convert.ToDouble(Console.ReadLine())
            };
            string jsonString1 = JsonSerializer.Serialize(product1);
            Console.WriteLine("Код товара: {0}", product1.productCode); 
            Console.WriteLine("Наименование товара: {0}", product1.productName);
            Console.WriteLine("Цена товара: {0}", product1.productPrice);



            //string[] shop = new string[5];
            //Product product = new Product();
            //Console.Write("Введите код товара: ");
            //product.productCode = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите наименование товара: ");
            //product.productName = Convert.ToString(Console.ReadLine());
            //Console.Write("Введите цену товара: ");
            //product.productPrice = Convert.ToDouble(Console.ReadLine());
            //shop[0] = product.getPtoduct();
            //Console.WriteLine();

            //Product product1 = new Product();
            //Console.Write("Введите код товара: ");
            //product1.productCode = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите наименование товара: ");
            //product1.productName = Convert.ToString(Console.ReadLine());
            //Console.Write("Введите цену товара: ");
            //product1.productPrice = Convert.ToDouble(Console.ReadLine());
            //shop[1] = product1.getPtoduct();
            //Console.WriteLine();

            //Product product2 = new Product();
            //Console.Write("Введите код товара: ");
            //product2.productCode = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите наименование товара: ");
            //product2.productName = Convert.ToString(Console.ReadLine());
            //Console.Write("Введите цену товара: ");
            //product2.productPrice = Convert.ToDouble(Console.ReadLine());
            //shop[2] = product2.getPtoduct();
            //Console.WriteLine();

            //Product product3 = new Product();
            //Console.Write("Введите код товара: ");
            //product3.productCode = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите наименование товара: ");
            //product3.productName = Convert.ToString(Console.ReadLine());
            //Console.Write("Введите цену товара: ");
            //product3.productPrice = Convert.ToDouble(Console.ReadLine());
            //shop[3] = product3.getPtoduct();
            //Console.WriteLine();

            //Product product4 = new Product();
            //Console.Write("Введите код товара: ");
            //product4.productCode = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите наименование товара: ");
            //product4.productName = Convert.ToString(Console.ReadLine());
            //Console.Write("Введите цену товара: ");
            //product4.productPrice = Convert.ToDouble(Console.ReadLine());
            //shop[4] = product4.getPtoduct();
            //Console.WriteLine();



            //Product[] product_arr = new Product[5];
            //product_arr[0] = product; 

            //Console.WriteLine(product_arr[0]);
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
    class Product
    {
        public int productCode { get; set; }
        public string productName { get; set; }
        public double productPrice { get; set; }

        //public Product(int productCode, string productName, double productPrise)
        //{
        //    this.productCode = productCode;
        //    this.productName = productName;
        //    this.productPrice = productPrise;
        //}
        //public Product()
        //{
        //}
        //public string getPtoduct()
        //{
        //    return "Код товара: " + productCode + "\n" + "Название товара: " + productName + "\n" + "Цена товара: " + productPrice;
        //}
    }
}
