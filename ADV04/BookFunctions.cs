using ADV04;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV04
{
    internal class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return $"Book Title :: {B.Title}";
        }
        public static string GetAuthors(Book B)
        {
            return $"Authors :: {string.Join(",", B.Authors)}";
        }
        public static string GetPrice(Book B)
        {
            return $"Price Of The Book :: {B.Price}";
        }


       








    }
}
