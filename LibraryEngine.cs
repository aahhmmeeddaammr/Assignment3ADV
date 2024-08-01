using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal delegate string FuncInBook(Book book);
    internal class LibraryEngine
    {
        public static void ProcessBooks(List<Book> books , FuncInBook func)
        {
            foreach (Book book in books)
            {
                Console.WriteLine(func.Invoke(book));
            }
        }

        public static void ProcessBooksUsingFunc(List<Book> books , Func<Book,string> func)
        {
            foreach (Book book in books)
            {
                Console.WriteLine(func.Invoke(book));
            }
        }
    }
}
