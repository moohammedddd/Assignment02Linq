
using LINQ;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
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
            var result = ProductList.Select(p => new
            {
                p.Category,
              CountOfProduct =   p.Category.Count()
            });
            foreach(var item in result) Console.WriteLine(item);
            #endregion
            #endregion
        }
    }
}
