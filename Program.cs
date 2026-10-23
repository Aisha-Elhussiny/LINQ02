using LINQ.DataSources;
using System.Linq;


namespace LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 Get the top 3 most expensive products.

            

            var mostExpensiveProducts = Source.ProductList
                .OrderByDescending(p => p.UnitPrice)
                .Take(3)
                .Select(p => new { p.ProductName, p.UnitPrice });

            foreach (var product in mostExpensiveProducts)
            {
                Console.WriteLine(product);
            }

            #endregion


        }
    }
}
