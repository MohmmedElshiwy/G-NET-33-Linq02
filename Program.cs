using ConsoleApp1.DataSources;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = Source.ProductList;

            #region Get top 3 most expensive products


            var result = products.OrderByDescending(p => p.UnitPrice).Take(3);
            foreach (var item in result) { Console.WriteLine($"Name:{item.ProductName}  |    Price: {item.UnitPrice}q"); }
            #endregion
        }
    }
}
