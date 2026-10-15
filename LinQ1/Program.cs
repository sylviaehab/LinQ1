using static LinQ1.DataSources.Source;
using LinQ1.DataSources;

using LinQ1.Models;
namespace LinQ1


{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //var result = ProductList
            //   .Where(p => p.Category == "Seafood");

            //foreach (var p in result)
            //{
            //    Console.WriteLine(p.ProductName);
            //} 
            #endregion

            #region Q2
            //var result = ProductList
            //      .Select(p => p.ProductName);
            //foreach (var name in result)
            //{
            //    Console.WriteLine(name);
            //} 
            #endregion
            #region Q3

            // var result = ProductList.
            //OrderBy(p => p.UnitPrice);
            // foreach (var item in result)
            // {
            //     Console.WriteLine($"{item.ProductName}--{item.UnitPrice}");

            // } 
            #endregion

            #region Q4
            //var result = ProductList.
            //      Where(p => p.UnitPrice > 10 && p.UnitPrice <= 30);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.ProductName}--{item.UnitPrice}");

            //} 
            #endregion

            #region Q5
            //var result = ProductList.
            //         Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.ProductName}--{item.UnitPrice}");

            //} 
            #endregion

            #region Q6
            //var result = ProductList.
            //    Select(
            //       p => new
            //       {
            //           Name = p.ProductName,
            //           Price = p.UnitPrice,
            //           StockStatus = p.UnitsInStock > 0
            //         ? "Available"
            //         : "Out of Stock"

            //       });
            //foreach (var p in result)
            //{
            //    Console.WriteLine(
            //        $"{p.Name} - {p.Price} - {p.StockStatus}");
            //} 
            #endregion

            #region Q7
            //var result = ProductList
            //       .Select((p, index) => $"{index + 1}. {p.ProductName}");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Q8
            //var result = ProductList.
            //        OrderBy(p => p.Category).
            //        OrderByDescending(p => p.UnitPrice);
            //foreach (var p in result)
            //{
            //    Console.WriteLine($"{p.Category} - {p.ProductName} - {p.UnitPrice}");
            //} 
            #endregion

            #region Q9
            //var result = ProductList.
            //       Where(p => p.Category == "Beverages").
            //       OrderByDescending(p => p.UnitsInStock);

            //foreach (var p in result)
            //{
            //    Console.WriteLine($"{p.ProductName} - Stock: {p.UnitsInStock}");
            //} 
            #endregion

            #region Q10
            //var result = from C in CustomerList
            //             from O in C.Orders
            //             where
            //              O.OrderDate.Year >= 1997
            //             select new
            //             {

            //                 C.CustomerID,
            //                 O.OrderDate
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.CustomerID} - {item.OrderDate:d}");
            //} 
            #endregion
            #region Q11
            //var result = ProductList
            //       .Select((p, index) =>
            //       new
            //       {
            //           Position = index + 1,
            //           Name = p.ProductName,
            //       }
            //       );
            //foreach (var p in result)
            //{
            //    Console.WriteLine($"{p.Position}. {p.ProductName}");
            //} 
            #endregion

            #region Q12
            String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.
            //    OrderBy(s => s.Length).
            //ThenBy(s => s, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //} 
            #endregion
            var result = Arr.
                Where(s => s[1] == 'i').
                Reverse();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
    }
}
;