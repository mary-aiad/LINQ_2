using LINQ.Models;
using System.Diagnostics.Metrics;
using System.Drawing;
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

            #region Question_07
            ///7. Group products by Category and project only product names per group
            //var result = ProductList.GroupBy(p => p.Category)
            //                        .Select(g=> new
            //                        {
            //                            Category = g.Key,
            //                            ProductNames = g.Select(p=> p.ProductName)
            //                        });

            //foreach (var group in result)
            //    {
            //    Console.WriteLine("---------------------------------------------");
            //        Console.Write(group.Category+": ");

            //        foreach (var name in group.ProductNames)
            //        {
            //            Console.WriteLine(name);
            //        }
            //    }


            #endregion

            #region Question_08
            ///8. Find all categories that have MORE THAN 3 products
            //var result = ProductList.GroupBy(p => p.Category)
            //                        .Where(p => p.Count() > 3)
            //                        .Select(p => p.Key);

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"{group}");
            //}
            #endregion

            #region Question_09
            ///9. Using QUERY SYNTAX, group customers by Country, and for each group select { Country, Count, TotalOrderValue }.
            //var result = from c in CustomerList
            //             group c by c.Country into Group
            //             select new
            //             {
            //                Country = Group.Key,
            //                Count = Group.Count(),
            //                TotalOrderValue = Group.SelectMany(c => c.Orders).Sum(o=>o.Total)


            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(
            //        $"{item.Country} - {item.Count} - {item.TotalOrderValue}"
            //    );
            //}
            #endregion

            #region Question_10
            ///10. Calculate the total number of units in stock across all products
            //var result = ProductList.Sum(p => p.UnitsInStock);

            //Console.WriteLine("Total Number of Units in Stock: "+ result);

            #endregion

            #region Question_11
            ///11. Find the CHEAPEST and MOST EXPENSIVE product prices
            //var max = ProductList.Max(p => p.UnitPrice);
            //var min = ProductList.Min(p => p.UnitPrice);

            //Console.WriteLine("Max: "+ max + " Min: "+ min);
            #endregion

            #region Question_12
            ///12. Get a distinct list of all product categories
            //var result = ProductList.Select(p=>p.Category)
            //                        .Distinct();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question_13
            ///13. find product IDs that are in setA but NOT in setB
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var res = setA.Except(setB);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question_14
            ///14. Find countries that appear in list1 but NOT in list2 (case -insensitive).
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var result = list1.Except(list2,StringComparer.OrdinalIgnoreCase);

            //foreach (var country in result)
            //{
            //    Console.WriteLine(country);
            //}
            #endregion

            #region Question_15
            ///15. Build a Dictionary<int, Product> keyed by ProductID. Then retrieve and print the product with ID = 18.
            //var productsDictionary = ProductList.ToDictionary(p => p.ProductID);
            //Console.WriteLine(productsDictionary.ContainsKey(18)? productsDictionary[18].ProductName : "Not Exist" );
            #endregion

            #region Question_16
            ///16. Get the first product whose price is greater than $50.
            //var result = ProductList.First(p => p.UnitPrice > 50);
            //Console.WriteLine(result);
            #endregion

            #region Question_17
            ///17. Try to get the first product with a price > $500. it returns null instead of throwing.
            //var result = ProductList.FirstOrDefault(p => p.UnitPrice > 500);
            //Console.WriteLine(result);
            #endregion

            #region Question_18
            ///18. Generate a multiplication table row for 7
            //var result = Enumerable.Range(1, 12)
            //                        .Select(n => $"7 *  {n} = { 7 * n}");

            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region Question_19
            ///19. Generate even numbers between 1 and 30.
            //var result = Enumerable.Range(1, 30).Where(n => n % 2 ==0);

            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region Question_20
            ///20. Concatenate the first 3 product names with the first 3 customer company names into a single sequence.
            //var res = ProductList.Take(3)
            //                    .Select(p => p.ProductName)
            //                    .Concat(CustomerList.Take(3).Select(p => p.CustomerName));

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question_21
            ///21. Pair each product with a customer (by position) and produce a string "ProductName sold to CompanyName".
            //var res = ProductList.Zip(CustomerList, (p, c) => $"{p.ProductName} Sold to {c.CustomerName}");
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }
    }
}
