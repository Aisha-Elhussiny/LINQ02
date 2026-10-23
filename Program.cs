using LINQ.DataSources;
using System.Linq;


namespace LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 Get the top 3 most expensive products.



            //var mostExpensiveProducts = Source.ProductList
            //    .OrderByDescending(p => p.UnitPrice)
            //    .Take(3)
            //    .Select(p => new { p.ProductName, p.UnitPrice });

            //foreach (var product in mostExpensiveProducts)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion
            #region Q2 Show page 2 with a page size of 5.

            //var secondPage = Source.ProductList
            //    .Skip(5)
            //    .Take(5)
            //    .Select(p => new { p.ProductID, p.ProductName });

            //foreach (var product in secondPage)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion
            #region Q3  Order by price, then take products while price is below 25.

            //var productsBelow25 = Source.ProductList
            //    .OrderBy(p => p.UnitPrice)
            //    .TakeWhile(p => p.UnitPrice < 25)
            //    .Select(p => new { p.ProductName, p.UnitPrice });

            //foreach (var product in productsBelow25)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion
            #region Q4  Check whether all Seafood products are in stock.

            //bool allSeafoodInStock = Source.ProductList
            //    .Where(p => p.Category == "Seafood")
            //    .All(p => p.UnitsInStock > 0);

            //Console.WriteLine(allSeafoodInStock);
            ////kolhom in stock 

            #endregion
            #region Q5  Check whether the ID list contains 9.

            //int[] ids = { 3, 9, 13, 18 };

            //bool contains = ids.Contains(9);

            //Console.WriteLine(contains);

            #endregion


        }
    }
}
