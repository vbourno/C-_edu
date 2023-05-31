using System.Diagnostics;
using System.Threading.Channels;

namespace ComparerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new() {
                new Product() { Description = "Milk", Price = 12.5, Quantity = 5 },
                new Product() { Description = "Honey", Price = 42.5, Quantity = 9 },
                new Product() { Description = "Oranges", Price = 3.75, Quantity = 2 },
                new Product() { Description = "Eggs", Price = 10.2, Quantity = 4 }
        };
            /*products.Sort();

            products.ForEach(p => Console.WriteLine(p));
            Console.WriteLine();

            products.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));
            products.ForEach(p => Console.WriteLine(p));

            Console.WriteLine();

            products.Sort((p1, p2) => p1.Quantity - p2.Quantity);
            products.ForEach(p => Console.WriteLine(p));*/

            var orderedByQuantityProducts = from product in products 
                                                             orderby product.Quantity 
                                                             select product;

            foreach (var product in orderedByQuantityProducts) 
            {
                Console.WriteLine(product);
            }

            var honeyProducts = from product in products
                                            where product.Description == "Honey"
                                            select product;

            foreach (var product in honeyProducts)
            {
                Console.WriteLine(product);
            }

            IEnumerable<Product> sortedProducts = products.OrderBy(product => product.Price)
                                                    .ThenByDescending(product => product.Quantity);

            List<Product> sortedProductsList = products.OrderBy(product => product.Price)
                                                    .ThenByDescending (product => product.Quantity)
                                                    .ToList();

            sortedProductsList.ForEach(p => Console.WriteLine(p));

            var sum = products.Where(p => p.Description == "Milk").Select(p => p.Price).Sum();
        }
    }
}
