using LINQ.Models;
using static LINQ.DataSources.Source;

namespace LINQ_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question_01
            ///1. Get top 3 most expensive products
            //var result = ProductList.OrderByDescending(p => p.UnitPrice)
            //                        .Take(3);
            //foreach (var p in result)
            //{
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            //}
            #endregion

            #region Question_02
            ///2. show page 2 of products, with page size = 5
            //int pageSize = 5;
            //int pageNumber = 2;

            //var result = ProductList
            //    .Skip((pageNumber - 1) * pageSize)
            //    .Take(pageSize);

            //foreach (var p in result)
            //{
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            //}
            #endregion

            #region Question_03
            ///3. Take products from the list as long as Their UnitPrice is less than $25 (list is ordered by price).
            //var result = ProductList.OrderBy(p => p.UnitPrice)
            //                        .TakeWhile(p => p.UnitPrice < 25);

            //foreach (var p in result)
            //{
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            //}
            #endregion

            #region Question_04
            ///4. Check if ALL products in the "Seafood" category are in stock
            //bool result = ProductList.Where(p => p.Category == "Seafood")
            //                        .All(p => p.UnitsInStock > 0);


            //Console.WriteLine(result);
            #endregion

            #region Question_05
            ///5. Check if the ID list contains 9
            //int[] ids = { 3, 9, 13, 18 };
            //bool check = ids.Contains(9);

            //Console.WriteLine(check);
            #endregion

            #region Question_06
            ///6. Group all products by Category and print each group with its product count.
            //var result = ProductList.GroupBy(g => g.Category);

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"{group.Key} - { group.Count()}");
            //}
            #endregion
        }
    }
}
