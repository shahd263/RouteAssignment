using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV04
{
    //Create User Defined Delegate with the same signature of methods existed in Bookfunctions class.

    public delegate string BookFunctionsDelegate(Book book);
    internal class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList,/*BookFunctionsDelegate bFunction*/ Func<Book,string>bFunction )

        {
            if (bList?.Count > 0 && bFunction is not null)
            {
                foreach (Book b in bList)
                {
                    Console.WriteLine(bFunction(b));
                }
            }
        }
    }
}
