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

namespace task_16._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonString = "{\"productCode\": 0,\"productName\":\"\",\"productPrice\": 0}";
            Product product = JsonSerializer.Deserialize<Product>(jsonString);

            Console.Write("Введите код товара 1: ");
            int code1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите Наименование  товара 1: ");
            string name1 = Console.ReadLine();
            Console.Write("Введите цену  товара 1: ");
            double price1 = Convert.ToDouble(Console.ReadLine());
            Product product1 = new Product()
            {
                productCode = code1,
                productName = name1,
                productPrice = price1
            };           

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };           

            Console.Write("Введите код товара 2: ");
            int code2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите Наименование  товара 2: ");
            string name2 = Console.ReadLine();
            Console.Write("Введите цену  товара 2: ");
            double price2 = Convert.ToDouble(Console.ReadLine());
            Product product2 = new Product()
            {
                productCode = code2,
                productName = name2,
                productPrice = price2
            };

            Console.Write("Введите код товара 3: ");
            int code3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите Наименование  товара 3: ");
            string name3 = Console.ReadLine();
            Console.Write("Введите цену  товара 3: ");
            double price3 = Convert.ToDouble(Console.ReadLine());
            Product product3 = new Product()
            {
                productCode = code3,
                productName = name3,
                productPrice = price3
            };

            Console.Write("Введите код товара 4: ");
            int code4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите Наименование  товара 4: ");
            string name4 = Console.ReadLine();
            Console.Write("Введите цену  товара 4: ");
            double price4 = Convert.ToDouble(Console.ReadLine());
            Product product4 = new Product()
            {
                productCode = code4,
                productName = name4,
                productPrice = price4
            };            

            Console.Write("Введите код товара 5: ");
            int code5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите Наименование  товара 5: ");
            string name5 = Console.ReadLine();
            Console.Write("Введите цену  товара 5: ");
            double price5 = Convert.ToDouble(Console.ReadLine());
            Product product5 = new Product()
            {
                productCode = code5,
                productName = name5,
                productPrice = price5
            };           

            Product[] shop = new Product[] { product1, product2, product3, product4, product5 };//создаем массив из экземпляров класса Product

            string jsonShop = JsonSerializer.Serialize(shop, options);//сериализуем массив shop

            //создаем файл json
            string path = "D:\\Папка\\text.json";//задаем путь к папке
            if (!File.Exists(path))//услови, если этого файла нет
            {
                File.Create(path).Close(); //создать файл
            }
            StreamWriter sw = new StreamWriter(path);

            sw.WriteLine(jsonShop);//записываем в файл сериализованный файл
            sw.Close();//закрываем файл после записи                      
            
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
    class Product
    {        
        public int productCode { get; set; }
        public string productName { get; set; }
        public double productPrice { get; set; }          
    }
}
