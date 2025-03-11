
using LINQ;
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
            var result = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            Console.WriteLine(result);
            #endregion
            #endregion

        }
    }
}
