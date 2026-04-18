using ConsoleApp1.DataSources;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = Source.ProductList;

            #region Get top 3 most expensive products


            //var result = products.OrderByDescending(p => p.UnitPrice).Take(3);
            //foreach (var item in result) { Console.WriteLine($"Name:{item.ProductName}  |    Price: {item.UnitPrice}q"); }
            #endregion

            #region page 2 of products, with page size = 5

            //int PageSize = 5;
            //int PageNumber = 2;
            //var result = products.OrderBy(p => p.ProductID).Skip((PageNumber - 1) * PageSize).Take(PageSize);
            //foreach (var item in result) { Console.WriteLine($" ID : {item.ProductID}   |   Name : {item.ProductName}"); }
            #endregion

        }
    }
}
