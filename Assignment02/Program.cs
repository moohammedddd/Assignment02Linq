
using LINQ;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading;
using static LINQ.ListGenerator;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Element Operator
            #region Q1 Get first Product out of Stock
            //var result0 = ProductList.First(p => p.UnitsInStock == 0);
            //Console.WriteLine(result0);
            #endregion

            #region Q2  2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var result = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(result);
            #endregion

            #region Q3 Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(x => x > 5).ElementAt(1);
            //Console.WriteLine(result);
            #endregion



            #endregion

            #region Aggergate Operators 
            #region Q1 Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count(p => p %2 == 0);
            //var result01 = Arr.Count(p =>  p %2  == 1);
            //Console.WriteLine(result);
            //Console.WriteLine(result01);
            #endregion
            #region Q2 2. Return a list of customers and how many orders each has.
            //var result = CustomerList.Select(p => p.CustomerName && p.Order.Count() );

            // var result = from p in CustomerList
            //              select new
            //              {
            //                 OrderName=  p.CustomerName,
            //                 OrderCount =  p.Orders.Count(),
            //             };
            //foreach(var item in result) Console.WriteLine(item);

            // // Using Flued Syntax 
            // var result01 = CustomerList.Select(p => new
            // {
            //   CustomerName =  p.CustomerName,
            //    OrderCount =  p.Orders.Count()
            // });
            #endregion
            #region Q3 . Return a list of categories and how many products each has
            //var result = ProductList.Select(p => new
            //{
            //    p.Category,
            //  CountOfProduct =   p.Category.Count()
            //});
            //foreach(var item in result) Console.WriteLine(item);
            #endregion

            #region Q4  Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Sum();
            //Console.WriteLine(result);

            #endregion
            #region Q5
            var words = File.ReadAllLines("dictionary_english.txt");
            //var result = words.Sum(p => p.Length);
            //Console.WriteLine(result);
            #endregion
            #region Q6
            //var result = words.Select(p => p.Length).Min();
            //Console.WriteLine(result);


            #endregion
            #region Q7
            //var result = words.Select(p => p.Length).Max();
            //Console.WriteLine(result);
            #endregion
            #region Q8
            //var result = words.Select(p => p.Length).Average();
            //Console.WriteLine(result);
            #endregion
            #region Q9
            //var result = from p in ProductList
            //             group p by p.Category into g
            //             select new
            //             {
            //                 Category = g.Key,
            //                 TotalUnitStock = g.Sum(p => p.UnitsInStock)
            //             };
            //foreach (var item in result) Console.WriteLine(item);
            #endregion
            #region Q10
            //var result = from p in ProductList
            //             group p by p.Category into g
            //             select new
            //             {
            //                 Category = g.Key,
            //                 ChepestSalary = g.Min(g => g.UnitPrice)
            //             };
            //foreach (var item in result) Console.WriteLine(item);
            #endregion
            #region Q11
            //var result = from p in ProductList
            //             group p by p.Category into g
            //             let minPrice = g.Min(p => p.UnitPrice)
            //             select new
            //             {
            //                 Category = g.Key,
            //                 price = minPrice
            //             };

            //foreach(var item in result) Console.WriteLine(item);

            #endregion
            #region Q12
            //var result = ProductList.GroupBy(p => p.Category).Select( g => new
            //{
            //    Category = g.Key,
            //    CheapestPrice = g.Max(p => p.UnitPrice)
            //});

            #endregion
            #region Q13
            //var result = ProductList.GroupBy(p => p.Category).Select(g => new
            //{
            //    Category = g.Key,
            //    Product = ProductList.Where(p => p.UnitPrice == g.Max(p => p.UnitPrice))
            //});
            #endregion
            #region Q14
            //var result = ProductList.GroupBy(p => p.Category).Select(p => new
            //{
            //    Average = p.Average(p => p.UnitPrice),
            //});
            #endregion
            #endregion

            #region Order Operaors
            #region Q1
            //var result = ProductList.OrderBy(p => p.ProductName);
            //foreach (var item in result) Console.WriteLine(item);
            #endregion

            #region Q2
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(p => p);
            //foreach (var item in result) Console.WriteLine(item);
            #endregion
            #region Q3
            //var result = ProductList.OrderByDescending(p => p.UnitsInStock);    
            #endregion
            #region Q4
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var result = Arr.OrderBy(p => p.Length).ThenBy(p => p);
            //foreach (var item in result) Console.WriteLine(item);
            #endregion
            #region Q5
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(p => p.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in result) Console.WriteLine(item);
            #endregion
            #region Q6
            //var result = ProductList.OrderByDescending(p => p.Category).ThenBy(p => p.UnitPrice);
            //foreach (var item in result) Console.WriteLine(item);
            #endregion
            #region Q7
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedWords = Arr
            //.OrderBy(w => w.Length)
            //.ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);
            #endregion
            #region Q8
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr
            //    .Where(d => d.Length > 1 && d[1] == 'i') 
            //    .Reverse()                               
            //    .ToList();
            //foreach (var item in result) Console.WriteLine(item);
            #endregion

            #endregion


            #region – Transformation Operators
            #region Q1
            //var result = ProductList.Select(p => p.ProductName);
            //foreach(var item in result) Console.WriteLine(item);
            #endregion
            #region Q2
            String[] word = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            var result = words.Select(p => new
            {
                Upper = p.ToUpper(),
                Lower = p.ToLower()
            });
            #endregion
            #endregion
        }
    }
}
