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

            #region Q6  Group products by Category and print each group's count.

            //var productGroups = Source.ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new { Category = g.Key, Count = g.Count() });

            //foreach (var group in productGroups)
            //{
            //    Console.WriteLine(group);
            //}

            #endregion
            #region Q7 Group by Category and project only product names.

            //var productNameGroups = Source.ProductList
            //    .GroupBy(p => p.Category, p => p.ProductName);

            //foreach (var group in productNameGroups)
            //{
            //    Console.WriteLine($"Category: {group.Key}");

            //    foreach (var name in group)
            //    {
            //        Console.WriteLine(name);
            //    }

            //    Console.WriteLine();
            //}

            #endregion

            #region Q8 Find categories containing more than 3 products.

            //var categoriesWithManyProducts = Source.ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(p => p.Count() > 3)
            //    .Select(p => p.Key);

            //foreach (var category in categoriesWithManyProducts)
            //{
            //    Console.WriteLine(category);
            //}

            #endregion

            #region Q9  Use query syntax to group customers by Country. Return Country, customer count and total order value.


            //var customersByCountry =
            //    from customer in Source.CustomerList
            //    group customer by customer.Country into countryGroup
            //    select new
            //    {
            //        Country = countryGroup.Key,
            //        Count = countryGroup.Count(),
            //        TotalOrderValue = countryGroup
            //            .SelectMany(customer => customer.Orders)
            //            .Sum(order => order.Total)
            //    };

            //foreach (var group in customersByCountry)
            //{

            //    Console.WriteLine(group);
            //}



            #endregion

            #region Q10 Calculate the total number of units in stock.

            //var totalStock = Source.ProductList
            //    .Sum(p => p.UnitsInStock);

            //Console.WriteLine($"Total Stock: {totalStock}");

            #endregion
            #region Q11 Find the cheapest and most expensive prices.


            //var cheapestPrice = Source.ProductList
            //    .Min(p => p.UnitPrice);

            //var highestPrice = Source.ProductList
            //    .Max(p => p.UnitPrice);

            //Console.WriteLine($"Cheapest Price: {cheapestPrice}");
            //Console.WriteLine($"Most Expensive Price: {highestPrice}");

            #endregion
            #region Q12 Get distinct product categories.


            //var distinctCategories = Source.ProductList
            //    .Select(p => p.Category)
            //    .Distinct();

            //foreach (var category in distinctCategories)
            //{
            //    Console.WriteLine(category);
            //}

            #endregion




        }
    }
}
