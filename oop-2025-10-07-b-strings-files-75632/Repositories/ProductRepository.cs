using oop_2025_10_07_b_strings_files_75632.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2025_10_07_b_strings_files_75632.Repositories
{
    public static class ProductRepository
    {
        public static List<Product> GetAllProducts()
        {
            Product product = new Product() { name = "Laptop", price = 999.99 };
            Product product2 = new Product() { name = "Piano", price = 777.77 };
            Product product3 = new Product() { name = "Smartphone", price = 499.49 };
            Product product4 = new Product() { name = "Tablet", price = 299.29 };

            List<Product> products = new List<Product>();
            products.Add(product);
            products.Add(product2);
            products.Add(product3);
            products.Add(product4);

            return products;
        }
    }

}