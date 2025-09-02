using System.Linq.Expressions;
using System.Threading;
using System.Xml.Linq;
using static LINQ01.ListGenerator;

namespace LINQ01
{

    
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Element Operators

            #region 1. Get first Product out of Stock

            //var result = ProductList.First(p => p.UnitsInStock == 0);
            //Console.WriteLine(result);
            #endregion

            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var result = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(result);
            #endregion

            #region 3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(n => n > 5).OrderBy(n => n).ElementAt(1);
            //Console.WriteLine(result);
            #endregion


            #endregion

            #region Aggregate Operators

            #region 1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count(n => n % 2 == 1);
            //Console.WriteLine(result);
            #endregion

            #region 2. Return a list of customers and how many orders each has.
            //var result = CustomerList.Select(c => new { c.CustomerName, OrdersCount = c.Orders.Count() });
            //foreach (var item in result) Console.WriteLine(item);
            #endregion

            #region 3. Return a list of categories and how many products each has
            //var result = ProductList.GroupBy(p => p.Category)
            //                        .Select(c => new { CategoryName = c.Key, ProductsCount = c.Count() });

            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region 4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Sum();
            //Console.WriteLine(result);

            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            string[] EnglishDictionary = File.ReadAllLines("dictionary_english.txt");
            //var result = EnglishDictionary.Sum(w=>w.Length);
            //Console.WriteLine(result);
            #endregion

            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var result = EnglishDictionary.Min(w=> w.Length);
            //Console.WriteLine(result);
            #endregion

            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var result = EnglishDictionary?.Max(w=> w.Length);
            //Console.WriteLine(result);
            #endregion

            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var result = EnglishDictionary.Average(w => w.Length);
            //Console.WriteLine(result);
            #endregion

            #region 9. Get the total units in stock for each product category.
            //var result = ProductList.GroupBy(p => p.Category)
            //                        .Select(c => new { CategoryName = c.Key, TotalUnitsInStock = c.Sum(u => u.UnitsInStock) });

            //foreach (var item in result) Console.WriteLine(item);
            #endregion

            #region 10. Get the cheapest price among each category's products
            //var result = ProductList.GroupBy(p => p.Category)
            //                        .Select(c => new { CategoryName = c.Key, CheapestProductPrice = c.Min(x=> x.UnitPrice) });

            //foreach (var item in result) Console.WriteLine(item);
            #endregion

            #region 11. Get the products with the cheapest price in each category (Use Let)
            //var result = from p in ProductList
            //             group p by p.Category
            //             into Category
            //             let minPrice = Category.Min(x => x.UnitPrice)
            //             from c in Category
            //             where c.UnitPrice == minPrice
            //             select new {  c.Category, c.ProductName , c.UnitPrice };

            //foreach (var item in result) Console.WriteLine(item);
            #endregion

            #region 12. Get the most expensive price among each category's products.
            //var result = ProductList.GroupBy(p => p.Category)
            //                        .Select(c => new { CategoryName = c.Key, MostExpPrice = c.Max(x => x.UnitPrice) });

            //foreach (var item in result) Console.WriteLine(item);

            #endregion

            #region 13. Get the products with the most expensive price in each category.
            //var result = from p in ProductList
            //             group p by p.Category
            //             into Category
            //             let maxPrice = Category.Max(x => x.UnitPrice)
            //             from c in Category
            //             where c.UnitPrice == maxPrice
            //             select new { c.Category, c.ProductName, c.UnitPrice };

            //foreach (var item in result) Console.WriteLine(item);

            #endregion

            #region 14. Get the average price of each category's products.
            //var result = ProductList.GroupBy(p => p.Category)
            //                        .Select(c => new { CategoryName = c.Key, AveragePrice = c.Average(x => x.UnitPrice) });

            //foreach (var item in result) Console.WriteLine(item);

            #endregion



            #endregion

            #region Ordering Operators

            #region 1. Sort a list of products by name
            //var result = ProductList.OrderBy(p => p.ProductName);

            //foreach (var item in result) Console.WriteLine(item);
            #endregion

            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(w => w, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in result) Console.WriteLine(item);
            #endregion

            #region 3. Sort a list of products by units in stock from highest to lowest.
            //var result = ProductList.OrderByDescending(p => p.UnitsInStock);
            //foreach (var item in result) Console.WriteLine(item);
            #endregion

            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.OrderBy(x => x.Length)
            //             .ThenBy(x => x);

            //foreach (var item in result) Console.Write(item + " ");

            #endregion

            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(x => x.Length)
            //                  .ThenBy(x => x, StringComparer.OrdinalIgnoreCase);

            //foreach (var item in result) Console.Write(item + " ");

            #endregion

            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var result = ProductList.OrderBy(p => p.Category)
            //    .ThenByDescending(p => p.UnitPrice);
            //foreach (var item in result) Console.WriteLine(item);
            #endregion

            #region 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(x => x.Length)
            //                  .ThenByDescending(x => x, StringComparer.OrdinalIgnoreCase);

            //foreach (var item in result) Console.Write(item + " ");

            #endregion

            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var result = Arr.Where(a=>a.ElementAt(1) == 'i').Reverse().ToList();
            //foreach (var item in result) Console.WriteLine(item);
            #endregion



            #endregion

            #region Transformation Operators

            #region 1. Return a sequence of just the names of a list of products.
            //var result = ProductList.Select(p => p.ProductName);
            //foreach (var item in result) Console.WriteLine(item);
            #endregion

            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var result = words.Select(w=> new {Lowercase =w.ToLower(), Uppercase = w.ToUpper() });
            //foreach (var item in result) Console.WriteLine(item);
            #endregion

            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var result = ProductList.Select(p=> new {p.ProductID, p.ProductName, Price = p.UnitPrice});
            //foreach (var item in result) Console.WriteLine(item);
            #endregion

            #region 4. Determine if the value of int in an array matches their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.SelectMany((a, i) => new[] { $"{a}: {(a == i ? "True" : "False")}" });

            //Console.WriteLine("Number: In-place?");
            //foreach (var item in result) Console.WriteLine(item);
            #endregion

            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var result = numbersA.SelectMany(a => numbersB.Where(b => a < b)
            //, (a, b) => $"{a} is less than {b}");

            //Console.WriteLine("Pairs where a < b");
            //foreach (var item in result) Console.WriteLine(item);


            #endregion

            #region 6. Select all orders where the order total is less than 500.00.
            //var result = CustomerList.SelectMany(c => c.Orders.Where(o => o.Total < 500));
            //foreach (var item in result) Console.WriteLine(item);
            #endregion

            #region 7. Select all orders where the order was made in 1998 or later.
            var result = CustomerList.SelectMany(c => c.Orders.Where(o => o.OrderDate >= DateTime.Parse("1-1-1998")));
            foreach (var item in result) Console.WriteLine(item);
            #endregion
            #endregion
        }
    }
}
