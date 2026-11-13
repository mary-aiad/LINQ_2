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
        }
    }
}
