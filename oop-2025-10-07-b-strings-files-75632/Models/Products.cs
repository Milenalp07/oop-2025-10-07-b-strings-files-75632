using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace oop_2025_10_07_b_strings_files_75632.Models
{
    // A classe base NÃO pode ser static se tiver propriedades e construtor
    public abstract class Product
    {
        protected Product(string name, string price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public string Price { get; set; }

        public virtual string Describe()
        {
            return $"Product: {Name}, Price: {Price}";
        }
    }

    // Classe derivada
    public class ListProduct : Product
    {
        public ListProduct(string name, string price) : base(name, price) { }
    }

    public static class Products
    {
        public static void Run()
        {
            Console.WriteLine("List of Cars:\n");

            List<Product> products = new List<Product>
            {
                new ListProduct("Honda", "999.99"),
                new ListProduct("Fiat", "777.77"),
                new ListProduct("Hyundai", "199.50")
            };

            foreach (var product in products)
            {
                Console.WriteLine(product.Describe());

                Console.WriteLine($"|{produt,15}|{price,-10}|");
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            Products.Run();
        }
    }
}
