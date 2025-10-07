namespace oop_2025_10_07_b_strings_files_75632.Models
{
    public static class StringDriver
    {
        public static void Run()
        {
            Console.WriteLine("String Driver Running...");
            DisplayProducts();
            FormattingDemo();

        } // end of Run()

        public static void FormattingDemo()
        {
            string name = "Alice";
            string city = "Seattle";
            Console.WriteLine($"{name}:{city}");
            Console.WriteLine($"{name.PadLeft(10)}");
            Console.WriteLine($"{city.PadLeft(10)}");
            Console.WriteLine($"{name.PadLeft(30)}");
            Console.WriteLine($"{city.PadLeft(30)}");
            Console.WriteLine($"{name.PadLeft(10)}{city.PadLeft(30)}");

            //// right aligning, and filling out the spaces with an * 
            Console.WriteLine($"{name.PadLeft(10, '*')}");
            Console.WriteLine($"{city.PadLeft(10, '*')}");

            string product = "Laptop";
            double price = 999.99;
            string product2 = "Piano";
            double price2 = 777.77;

            // product, 15: aligns the product to the right with 15 chars
            // price, -10 aligns price to the left with width of 10 chars
            Console.WriteLine($"|{product,15}|{price,-10} |");
            Console.WriteLine($"|{product2,15}|{price2,-10} |");



        } // end of FormattingDemo()

        public static void DisplayProducts()
        {
            Console.WriteLine("=".PadLeft(35, '='));

            List<Product> products = ProductRepository.GetAllProducts();

            foreach (var item in products)
            {
                Console.WriteLine($"{item.name,10}:{item.price,-10}");
            }
            Console.WriteLine("=".PadLeft(35, '='));
        }

    } // end of StringDriver class
}
