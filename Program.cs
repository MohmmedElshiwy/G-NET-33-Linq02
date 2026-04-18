using ConsoleApp1.DataSources;

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
        }
    }
}
