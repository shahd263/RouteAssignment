using System.Reflection.Metadata.Ecma335;

namespace ADV04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region a)UserDefindedDelegate
            ////a) Create User Defined Delegate with the same signature of methods existed in Bookfunctions class.
            var book01 = new Book("b01", "Book01", ["Author01", "Author02"], DateTime.Parse("2023-05-20"), 150);
            var book02 = new Book("b02", "Book02", ["Author03", "Author02"], DateTime.Parse("2025-01-01"), 250);
            var book03 = new Book("b03", "Book03", ["Author04", "Author02"], DateTime.Parse("2024-03-26"), 200);

            var booksList = new List<Book>() { book01, book02, book03 };

            //LibraryEngine.ProcessBooks(booksList,BookFunctions.GetTitle);
            //LibraryEngine.ProcessBooks(booksList,BookFunctions.GetPrice);
            //LibraryEngine.ProcessBooks(booksList, BookFunctions.GetAuthors);

            #endregion

            #region b)BuiltInDelegate
            ////b) Use the Proper build in delegate.
            //Func<Book, string> func = BookFunctions.GetTitle;

            //LibraryEngine.ProcessBooks(booksList,func);
            #endregion

            #region c)AnonymousMethod
            ////c) Anonymous Method (GetISBN).
            //Func<Book, string> GetISBN = delegate (Book B) { return $"Book ISBN :: {B.ISBN}"; };
            //LibraryEngine.ProcessBooks(booksList,GetISBN);
            #endregion

            #region d)LambdaExpression
            //d) Lambda Expression (GetPublicationDate).
            Func<Book, string> GetPublicationDate = (B) => $"PublicationDate :: {B.PublicationDate}";
            LibraryEngine.ProcessBooks(booksList, GetPublicationDate);
            #endregion
        }
    }
}
