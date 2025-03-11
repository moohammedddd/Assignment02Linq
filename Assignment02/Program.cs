
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
            var result0 = ProductList.First(p => p.UnitsInStock == 0);
            Console.WriteLine(result0);
            #endregion
            #endregion

        }
    }
}
