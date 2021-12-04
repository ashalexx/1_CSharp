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

            string[] shop = new string[5];            

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

            string jsonString1 = JsonSerializer.Serialize(product1, options);
            shop[0] =  jsonString1;            

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
            string jsonString2 = JsonSerializer.Serialize(product2, options);
            shop[1] = jsonString2;

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

            string jsonString3 = JsonSerializer.Serialize(product3, options);
            shop[2] = jsonString3;

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
            string jsonString4 = JsonSerializer.Serialize(product4, options);
            shop[3] = jsonString4;

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
            string jsonString5 = JsonSerializer.Serialize(product5, options);
            shop[4] = jsonString5;



            //создаем файл json
            string path = "D:\\Папка\\text.json";
            if (!File.Exists(path))//услови, если этого файла нет
            {
                File.Create(path).Close(); //создать файл
            }
            StreamWriter sw = new StreamWriter(path, true);

            sw.WriteLine(string.Join(" ", shop));
            sw.Close();//закрываем файл после записи                      
            
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
    class Product
    {
        [JsonPropertyName("Код продукта")]
        public int productCode { get; set; }
        [JsonPropertyName("Наименование продукта")]
        public string productName { get; set; }
        [JsonPropertyName("Цена продукта")]
        public double productPrice { get; set; }
        public void print()
        {
            Console.WriteLine("Код товара: {0}", productCode);
            Console.WriteLine("Наименование товара: {0}", productName);
            Console.WriteLine("Цена товара: {0}", productPrice);
        }
        public string getProduct()
        {
            return productCode + " " + productName + " " + productPrice;
        }        
    }
}
