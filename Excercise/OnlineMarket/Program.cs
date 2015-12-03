using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace OnlineMarket
{
    class Program
    {
        static Dictionary<string, List<Product>> productsByType = new Dictionary<string, List<Product>>();
        static Dictionary<double, List<Product>> productsByPrice = new Dictionary<double, List<Product>>();
        static HashSet<string> productsName = new HashSet<string>();
        static StringBuilder result = new StringBuilder();

        static void Main()
        {
            string command = Console.ReadLine();
            while (command != "end")
            {
                ProcessCommand(command);
                command = Console.ReadLine();
            }

            Console.WriteLine(result.ToString());
        }

        private static void ProcessCommand(string command)
        {
            var commandParts = command.Split(' ');
            switch (commandParts[0])
            {
                case "add": ProcessAddCommand(commandParts); break;
                case "filter":
                    if (commandParts.Length == 4)
                    {
                        ProcessFilterCommandByType(commandParts[3]);
                    }
                    else if (commandParts.Length == 7)
                    {
                        ProcessFilterCommandByPriceRange(commandParts[4], commandParts[6]);
                    }
                    else if (commandParts.Length == 5)
                    {
                        ProcessFilterCommandByPrice(commandParts[3], commandParts[4]);
                    }
                    break;

                default: break;
            }
        }

        private static void ProcessFilterCommandByPrice(string fromOrTo, string priceString)
        {
            var price = double.Parse(priceString);
            if (fromOrTo == "from")
            {
                var products = productsByPrice
              .Where(p => p.Key >= price)
              .SelectMany(p => p.Value)
              .OrderBy(pr => pr.Price)
              .ThenBy(pr => pr.Name)
              .ThenBy(pr => pr.Type)
              .Take(10);

                result.AppendLine(string.Format("Ok: {0}", string.Join(", ", products)));
            }
            else
            {
                var products = productsByPrice
                    .Where(p => p.Key <= price)
                    .SelectMany(p => p.Value)
                    .OrderBy(pr => pr.Price)
                    .ThenBy(pr => pr.Name)
                    .ThenBy(pr => pr.Type)
                    .Take(10);
                result.AppendLine(string.Format("Ok: {0}", string.Join(", ", products)));
            }            
        }

        private static void ProcessFilterCommandByPriceRange(string priceFrom, string priceTo)
        {
            double from = double.Parse(priceFrom);
            double to = double.Parse(priceTo);

            var products = productsByPrice
                .Where(p => p.Key >= from && p.Key <= to)
                .SelectMany(p => p.Value)
                .OrderBy(pr => pr.Price)
                .ThenBy(pr => pr.Name)
                .ThenBy(pr => pr.Type)
                .Take(10);

            result.AppendLine(string.Format("Ok: {0}", string.Join(", ", products)));

        }

        private static void ProcessFilterCommandByType(string type)
        {
            if (!productsByType.ContainsKey(type))
            {
                result.AppendLine(string.Format("Error: Type {0} does not exists", type));
                return;
            }

            var productsFilteredByType = productsByType[type]
                .OrderBy(pr => pr.Price)
                .ThenBy(pr => pr.Name)
                .ThenBy(pr => pr.Type)
                .Take(10);

            result.AppendLine(string.Format("Ok: {0}", string.Join(", ", productsFilteredByType)));
        }
        
        private static void ProcessAddCommand(string[] commandParts)
        {
            var price = double.Parse(commandParts[2]);

            if (productsName.Contains(commandParts[1]))
            {
                result.AppendLine(string.Format("Error: Product {0} already exists", commandParts[1]));
                return;
            }

            productsName.Add(commandParts[1]);

            var product = new Product(commandParts[1], price, commandParts[3]);

            if (!productsByType.ContainsKey(commandParts[3]))
            {
                productsByType.Add(commandParts[3], new List<Product>());
            }

            productsByType[commandParts[3]].Add(product);


            if (!productsByPrice.ContainsKey(price))
            {
                productsByPrice.Add(price, new List<Product>());
            }

            productsByPrice[price].Add(product);

            result.AppendLine(string.Format("Ok: Product {0} added successfully", commandParts[1]));
        }
    }

    public class Product
    {
        public Product(string name, double price, string type)
        {
            this.Name = name;
            this.Price = price;
            this.Type = type;
        }
        public string Name { get; set; }

        public double Price { get; set; }

        public string Type { get; set; }

        public override string ToString()
        {
            return string.Format("{0}({1})", this.Name, this.Price);
        }
    }
}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Wintellect.PowerCollections;

//namespace OnlineMarket
//{
//    class Program
//    {
//        static Dictionary<string, List<Product>> productsByType = new Dictionary<string, List<Product>>();
//        static OrderedDictionary<double, List<Product>> productsByPrice = new OrderedDictionary<double, List<Product>>();
//        static HashSet<string> productsName = new HashSet<string>();
//        static StringBuilder result = new StringBuilder();

//        static void Main()
//        {
//            string command = Console.ReadLine();
//            while (command != "end")
//            {
//                ProcessCommand(command);
//                command = Console.ReadLine();
//            }

//            Console.WriteLine(result.ToString());
//        }

//        private static void ProcessCommand(string command)
//        {
//            var commandParts = command.Split(' ');
//            switch (commandParts[0])
//            {
//                case "add": ProcessAddCommand(commandParts); break;
//                case "filter":
//                    if (commandParts.Length == 4)
//                    {
//                        ProcessFilterCommandByType(commandParts[3]);
//                    }
//                    else if (commandParts.Length == 7)
//                    {
//                        ProcessFilterCommandByPriceRange(commandParts[4], commandParts[6]);
//                    }
//                    else if (commandParts.Length == 5)
//                    {
//                        ProcessFilterCommandByPrice(commandParts[3], commandParts[4]);
//                    }
//                    break;

//                default: break;
//            }
//        }

//        private static void ProcessFilterCommandByPrice(string fromOrTo, string priceString)
//        {
//            var price = double.Parse(priceString);

//            if (fromOrTo == "from")
//            {
//                var products = productsByPrice
//                    .RangeFrom(price,true)
//              .Where(p => p.Key >= price)
//              .SelectMany(p => p.Value)
//              .OrderBy(pr => pr.Price)
//              .ThenBy(pr => pr.Name)
//              .ThenBy(pr => pr.Type)
//              .Take(10);

//                result.AppendLine(string.Format("Ok: {0}", string.Join(", ", products)));
//            }
//            else
//            {
//                var products = productsByPrice
//                    .RangeTo(price,true)
//                    .SelectMany(p => p.Value)
//                    .OrderBy(pr => pr.Price)
//                    .ThenBy(pr => pr.Name)
//                    .ThenBy(pr => pr.Type)
//                    .Take(10);
//                result.AppendLine(string.Format("Ok: {0}", string.Join(", ", products)));
//            }            
//        }

//        private static void ProcessFilterCommandByPriceRange(string priceFrom, string priceTo)
//        {
//            double from = double.Parse(priceFrom);
//            double to = double.Parse(priceTo);

//            var products = productsByPrice.Range(from,true,to,true)
//                .SelectMany(p => p.Value)
//                .OrderBy(pr => pr.Price)
//                .ThenBy(pr => pr.Name)
//                .ThenBy(pr => pr.Type)
//                .Take(10);

//            result.AppendLine(string.Format("Ok: {0}", string.Join(", ", products)));

//        }

//        private static void ProcessFilterCommandByType(string type)
//        {
//            if (!productsByType.ContainsKey(type))
//            {
//                result.AppendLine(string.Format("Error: Type {0} does not exists", type));
//                return;
//            }

//            var productsFilteredByType = productsByType[type]
//                .OrderBy(pr => pr.Price)
//                .ThenBy(pr => pr.Name)
//                .ThenBy(pr => pr.Type)
//                .Take(10);

//            result.AppendLine(string.Format("Ok: {0}", string.Join(", ", productsFilteredByType)));
//        }


//        private static void ProcessAddCommand(string[] commandParts)
//        {
//            var price = double.Parse(commandParts[2]);

//            if (productsName.Contains(commandParts[1]))
//            {
//                result.AppendLine(string.Format("Error: Product {0} already exists", commandParts[1]));
//                return;
//            }

//            productsName.Add(commandParts[1]);

//            var product = new Product(commandParts[1], price, commandParts[3]);

//            if (!productsByType.ContainsKey(commandParts[3]))
//            {
//                productsByType.Add(commandParts[3], new List<Product>());
//            }

//            productsByType[commandParts[3]].Add(product);


//            if (!productsByPrice.ContainsKey(price))
//            {
//                productsByPrice.Add(price, new List<Product>());
//            }

//            productsByPrice[price].Add(product);

//            result.AppendLine(string.Format("Ok: Product {0} added successfully", commandParts[1]));
//        }
//    }

//    public class Product
//    {
//        public Product(string name, double price, string type)
//        {
//            this.Name = name;
//            this.Price = price;
//            this.Type = type;
//        }
//        public string Name { get; set; }

//        public double Price { get; set; }

//        public string Type { get; set; }

//        public override string ToString()
//        {
//            return string.Format("{0}({1})", this.Name, this.Price);
//        }
//    }
//}



//ZDRAWKO
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace OnlineMarket
//{
//    class Program
//    {
//        static Dictionary<string, SortedSet<Product>> byType = new Dictionary<string, SortedSet<Product>>();
//        static Dictionary<float, SortedSet<Product>> byPrice = new Dictionary<float, SortedSet<Product>>();

//        static void Main()
//        {
//            string[] line = Console.ReadLine().Split(' ');

//            while (line[0] != "end")
//            {
//                switch (line[0])
//                {
//                    case "add":
//                        AddProduct(line);
//                        break;

//                    case "filter":
//                        FilterProducts(line);
//                        break;
//                }

//                line = Console.ReadLine().Split(' ');
//            }
//        }

//        private static void FilterProducts(string[] line)
//        {
//            var command = line[2];
//            /*
//             •	filter by type PRODUCT_TYPE 
//             •	filter by price from MIN_PRICE to MAX_PRICE 
//             •	filter by price from MIN_PRICE 
//             •	filter by price to MAX_PRICE 
//            */
//            if (command == "price")
//            {
//                var subCommand = line[3];
//                float minPrice;
//                float maxPrice;

//                if (line.Contains("to")) // either FROM - TO, or just TO maxPrice
//                {
//                    minPrice = float.Parse(line[4]);

//                    if (line.Length > 5) // from-to
//                    {
//                        maxPrice = float.Parse(line[6]);

//                        var filtered = byPrice.Where(c => c.Key <= maxPrice && c.Key >= minPrice).Select(c => c.Value);
//                        var products = new SortedSet<Product>();

//                        foreach (var set in filtered)
//                        {
//                            products.UnionWith(set);
//                        }

//                        Console.WriteLine("Ok: {0}", string.Join(", ", products.Take(10)));
//                    }
//                    else // to
//                    {
//                        maxPrice = float.Parse(line[4]);
//                        var filtered = byPrice.Where(c => c.Key <= maxPrice).Select(c => c.Value);
//                        var products = new SortedSet<Product>();

//                        foreach (var set in filtered)
//                        {
//                            products.UnionWith(set);
//                        }

//                        Console.WriteLine("Ok: {0}", string.Join(", ", products.Take(10)));
//                    }
//                }
//                else // FROM min_price
//                {
//                    minPrice = float.Parse(line[4]);

//                    var filtered = byPrice.Where(c => c.Key >= minPrice).Select(c => c.Value);
//                    var products = new SortedSet<Product>();

//                    foreach (var set in filtered)
//                    {
//                        products.UnionWith(set);
//                    }

//                    Console.WriteLine("Ok: {0}", string.Join(", ", products.Take(10)));
//                }
//            }

//            if (command == "type")
//            {
//                var type = line[3];

//                if (!byType.ContainsKey(type))
//                {
//                    Console.WriteLine("Error: Type {0} does not exists", type);
//                }
//                else if (byType[type].Count > 0)
//                {
//                    Console.WriteLine("Ok: {0}", string.Join(", ", byType[type].Take(10)));
//                }
//                else
//                {
//                    Console.WriteLine("Ok: ");
//                }
//            }
//        }

//        private static void AddProduct(string[] line)
//        {
//            string name = line[1];
//            float price = float.Parse(line[2]);
//            string type = line[3];

//            var newProduct = new Product { Name = name, Price = price, Type = type };

//            if (byType.ContainsKey(type))
//            {
//                if (byType[type].Contains(newProduct))
//                {
//                    Console.WriteLine("Error: Product {0} already exists", name);
//                }
//                else
//                {
//                    byType[type].Add(newProduct);
//                    Console.WriteLine("Ok: Product {0} added successfully", name);
//                }
//            }
//            else
//            {
//                var newSet = new SortedSet<Product>();
//                newSet.Add(newProduct);
//                byType.Add(type, newSet);
//                Console.WriteLine("Ok: Product {0} added successfully", name);
//            }

//            if (byPrice.ContainsKey(price))
//            {
//                if (!byPrice[price].Contains(newProduct))
//                {
//                    byPrice[price].Add(newProduct);
//                }
//            }
//            else
//            {
//                var newSet = new SortedSet<Product>();
//                newSet.Add(newProduct);
//                byPrice.Add(price, newSet);
//            }
//        }

//        private class Product : IComparable<Product>
//        {
//            public string Name { get; set; }

//            public string Type { get; set; }

//            public float Price { get; set; }

//            public override string ToString()
//            {
//                return this.Name + "(" + this.Price + ")";
//            }

//            public override int GetHashCode()
//            {
//                return this.Name.GetHashCode();
//            }

//            public override bool Equals(object obj)
//            {
//                var other = obj as Product;

//                if (this.Name.GetHashCode() == other.Name.GetHashCode()) // TODO: check if hashcode == hashcode is faster ??
//                {
//                    return true;
//                }

//                return false;
//            }

//            public int CompareTo(Product other)
//            {
//                var priceResult = this.Price.CompareTo(other.Price);

//                if (priceResult == 0)
//                {
//                    var nameResult = this.Name.CompareTo(other.Name);

//                    if (nameResult == 0)
//                    {
//                        return this.Type.CompareTo(other.Type);
//                    }
//                    else
//                    {
//                        return nameResult;
//                    }
//                }
//                else
//                {
//                    return priceResult;
//                }
//            }
//        }
//    }
//}