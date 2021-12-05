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

            //string json = JsonSerializer.Serialize<Product>(sr.Read();
            //Console.WriteLine(sr.ReadToEnd());

            //string jsonString = File.ReadAllText(path);
            Product json = JsonSerializer.Deserialize<Product>(sr.ReadToEnd());
            //Console.WriteLine(json);
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
