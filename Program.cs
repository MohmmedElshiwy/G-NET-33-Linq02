using ConsoleApp1.DataSources;
using ConsoleApp1.DataSources.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = Source.ProductList;

            #region Q1 Get top 3 most expensive products


            //var result = products.OrderByDescending(p => p.UnitPrice).Take(3);
            //foreach (var item in result) { Console.WriteLine($"Name:{item.ProductName}  |    Price: {item.UnitPrice}q"); }
            #endregion

            #region Q2 page 2 of products, with page size = 5

            //int PageSize = 5;
            //int PageNumber = 2;
            //var result = products.OrderBy(p => p.ProductID).Skip((PageNumber - 1) * PageSize).Take(PageSize);
            //foreach (var item in result) { Console.WriteLine($" ID : {item.ProductID}   |   Name : {item.ProductName}"); }
            #endregion


            #region Q3 Take products from the list as long as Their UnitPrice is less than $25(list is ordered by price).

            //var result = products.OrderBy(p => p.UnitPrice).TakeWhile(p => p.UnitPrice < 25);
            //foreach (var i in result) { Console.WriteLine($"Name : {i.ProductName}    |   Price : {i.UnitPrice}"); }
            #endregion

            #region Q4 Check if ALL products in the "Seafood" category are in stock

            //var result = products.Where(p => p.Category.Equals("Seafood")).All(p => p.UnitsInStock>0);
            //Console.WriteLine(result);
            #endregion

            #region Q5 Check if the ID list contains 9
            //int[] ids = { 3, 9, 13, 18 };

            //var result = ids.Contains(9);
            //Console.WriteLine(result);
            #endregion

            #region Q6 Group all products by Category and print each group with its product count.

            //var result = products.GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //         CategryName = g.Key,
            //         NumberOfProducts = g.Count()
            //    });

            //foreach (var item in result) { Console.WriteLine(item); }

            #endregion


            #region Q7 Group products by Category and project only product names group
            //var result = products.GroupBy(p => p.Category);
            //foreach (var item in result)
            //{
            //    Console.WriteLine("CategoryName :"+item.Key +"\n");

            //    Console.WriteLine("==== Products ====");
            //    foreach (var p in item) { Console.WriteLine($" {p.ProductName}"); }

            //    Console.WriteLine("===================================\n");
            //}

            //var result = products.GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        CategoryName = g.Key,
            //        ProductsName = g.Select(p => p.ProductName).ToList()
            //    });
            //foreach (var item in result)
            //{
            //    Console.WriteLine("┌──────────────────────────────┐");
            //    Console.WriteLine($"│ Category: {item.CategoryName}");
            //    Console.WriteLine("├──────────────────────────────┤");
            //        Console.WriteLine("---- Product Name ----");

            //    foreach (var p in item.ProductsName) {

            //        Console.WriteLine($"{p}");
            //        //Console.WriteLine("└──────────────────────────────┘\n");


            //    }
            //    Console.WriteLine("└──────────────────────────────┘\n");

            //}
            #endregion


            #region Q8 Find all categories that have MORE THAN 3 products
            //var result = products.GroupBy(p => p.Category)
            //  .Where(g => g.Count() > 3)
            //  .Select(g => new
            //  {
            //      CategoryName = g.Key,
            //      ProductName = g.Select(p => p.ProductName)

            //  });
            //foreach (var item in result) {

            //    Console.WriteLine("========================================================");
            //    Console.WriteLine("| Category       | Product                             |");
            //    Console.WriteLine("========================================================");

            //    foreach (var name in item.ProductName)
            //    {
            //        Console.WriteLine($"| {item.CategoryName,-14} | {name,-35} |");
            //    }
            //    Console.WriteLine("========================================================");

            //}

            #endregion


        }
    }
}
