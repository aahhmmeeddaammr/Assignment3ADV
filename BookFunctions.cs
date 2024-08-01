using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class BookFunctions
    {
        public static string GetTitle(Book book)
        {
                        if (book is null) throw new ArgumentNullException();

            return book.Title;
        }
        public static string GetAutors(Book book)
        {
            if (book is null) throw new ArgumentNullException();

            return book.GetAuthors();
        }
        public static string GetPrice(Book book)
        {
            if (book is null) throw new ArgumentNullException();
            return book.Price.ToString();
        }
    }
}
