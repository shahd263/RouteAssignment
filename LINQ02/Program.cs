using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using static LINQ02.ListGenerator;
using static System.Net.Mime.MediaTypeNames;



namespace LINQ02


{
    class MatchStringComparer : IEqualityComparer<String>
    {
        public bool Equals(string? x, string? y)
        {
            if (x is not null && y is not null)
            {
                string X = string.Concat(x.OrderBy(c => c));
                string Y = string.Concat(y.OrderBy(c => c));

                return Y == X;

            }
           return false;
                
        }

        public int GetHashCode([DisallowNull] string obj)
        {
            if (obj is not null) 
               return new string(obj.OrderBy(c => c).ToArray()).GetHashCode(); 
            return -1;
        }

      
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Element Operators
            //Answered In Assignment01
            #endregion

            #region Aggregate Operators
            //Answered In Assignment01
            #endregion

            #region Set Operators

            #region 1. Find the unique Category names from Product List
            //var result = ProductList.DistinctBy(p => p.Category);
            //foreach (var item in result) Console.WriteLine(item);
            #endregion

            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.
            //var result = ProductList.Select(p=> p.ProductName[0]).Union(CustomerList.Select(c => c.CustomerName[0]));
            //foreach (var item in result) Console.WriteLine(item);

            #endregion

            #region 3. Create one sequence that contains the common first letter from both product and customer names.
            //var result = ProductList.Select(p => p.ProductName[0]).Intersect(CustomerList.Select(c => c.CustomerName[0]));
            //foreach (var item in result) Console.WriteLine(item);
            #endregion

            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var result = ProductList.Select(p => p.ProductName[0]).Except(CustomerList.Select(c => c.CustomerName[0]));
            //foreach (var item in result) Console.WriteLine(item);
            #endregion

            #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var result = ProductList.Select(p => p.ProductName.TakeLast(3).ToArray())
            //    .Concat(CustomerList.Select(c => c.CustomerName.TakeLast(3).ToArray()));
            //foreach (var item in result) Console.WriteLine(item);
            #endregion
            #endregion

            #region Quantifiers

            #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            string[] EnglishDictionary = File.ReadAllLines("dictionary_english.txt");
            //var result = EnglishDictionary.Any(w => w.Contains("ei"));
            //Console.WriteLine(result);
            #endregion

            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.
            //var result = from p in ProductList
            //             group p by p.Category
            //             into c
            //             where c.Any(c => c.UnitsInStock == 0)
            //             from P in c
            //             select new { Category = c.Key, Product = P };


            //foreach (var item in result) Console.WriteLine(item);


            #endregion

            #region 3. Return a grouped a list of products only for categories that have all of their products in stock.
            //var result = from p in ProductList
            //             group p by p.Category
            //             into c
            //             where c.All(c => c.UnitsInStock > 0)
            //             from P in c
            //             select new { Category = c.Key, Product = P };

            //foreach (var item in result) Console.WriteLine(item);
            #endregion

            #endregion

            #region Grouping Operators

            #region 1. Use group by to partition a list of numbers by their remainder when divided by 5
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var result = numbers.GroupBy(n => n % 5).Select(c=> new {c.Key , c});

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Number with remaider of {item.Key} when divided by 5 ");
            //    foreach (var n in item.c)
            //    {
            //        Console.WriteLine(n);
            //    }
            //}

            #endregion

            #region 2. Uses group by to partition a list of words by their first letter. Use dictionary_english.txt for Input
            //var result = EnglishDictionary.GroupBy(w => w[0]).Select(w => new { w.Key, w });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var w in item.w)
            //        Console.WriteLine($"----{w}");
            //}


            #endregion

            #region 3. Consider this Array as an Input
            string[] Arr = { "from", "salt", "earn", "last", "near", "form" };

            var result = Arr.GroupBy(a => a, new MatchStringComparer()).Select(x=>new { x.Key , x});
            foreach (var item in result)
            {
                foreach (var w in item.x)
                    Console.WriteLine(w);
                Console.WriteLine("------");
            }

            #endregion

            #endregion

        }
    }
}
