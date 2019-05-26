using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProduceConsumerOpg
{
    class Bakery
    {
        private List<Product> productsInStore = new List<Product>();
        Random rng = new Random();
        public Bakery()
        {
            for (int i = 0; i < 5; i++)
            {
                FillBakeryWithRandom();
            }
        }
        public void BakeryControl()
        {
            
        }

        public void FillBakeryWithRandom()
        {
            productsInStore.Add(new Product(rng.Next(0, 3)));
        }
    }
}
