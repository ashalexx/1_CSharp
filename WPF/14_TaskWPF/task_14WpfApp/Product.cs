using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_14WpfApp
{
    public enum ProductTypes
    {
        Food,
        Appliances
    }

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Image { get; set; }
        public ProductTypes ProductType { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }


}
