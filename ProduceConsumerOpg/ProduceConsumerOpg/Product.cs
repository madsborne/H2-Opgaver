using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduceConsumerOpg
{
    class Product
    {
        private string productName;
        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
            }
        }

        string[] products = new string[] { "cake", "skumbanan", "øl", "faxekondi" };

        public Product(int productId)
        {
            ProductName = products[productId];
        }
    }
}
