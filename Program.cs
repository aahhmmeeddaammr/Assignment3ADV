namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1
            //List<Book>x =new List<Book>{
            //    new Book("111" , "Hello World" , new string[] {"Ahmed Amr" , "Nada"} , 1111.2M),
            //    new Book("011" , "DK" , new string[] {"Omar Ahmed" , "Samy Nasr"} , 111.2M),
            //    new Book("101" , "XXXXXXXXXXXX" , new string[] {"Fawzi Hamada" , "Alaa Ola"} , 191.2M),
            //    new Book("110" , "DDDDDDDDD" , new string[] {"Samir Zaky" , "Khairy Mahmoud"} , 111.2M),
            //    new Book("000" , "KKKKKKKKKKKKK" , new string[] {"Maher Samer" , "Safaa Ali"} , 1198.2M),
            //};

            //LibraryEngine engine = new LibraryEngine();
            //LibraryEngine.ProcessBooks(x , BookFunctions.GetTitle);

            //Console.WriteLine("*****************************************");

            //Func<Book, string> GetTitle = (Book book) => book.Title;
            //LibraryEngine.ProcessBooksUsingFunc(x, GetTitle);

            //Console.WriteLine("*****************************************");

            //LibraryEngine.ProcessBooks(x, (Book) => Book.ToString());

            //Console.WriteLine("*****************************************");

            //FuncInBook GetPublicationDate = book => book.publicationDate.ToString();
            //LibraryEngine.ProcessBooks(x, GetPublicationDate);

            //Console.WriteLine("*****************************************");

            //FuncInBook GetISBN = delegate (Book book)
            //{
            //    return book.ISBN;
            //};
            //LibraryEngine.ProcessBooks(x, GetISBN);
            //Console.WriteLine("*****************************************");

            #endregion

            #region Part 2
            //CustomList<int> customList = new CustomList<int>(10);
            //customList.Add(1);
            //customList.Add(2);    
            //customList.Add(3);
            //customList.Add(4);
            //customList.Add(5);
            //customList.Add(6);
            //customList.Add(7);
            //customList.Add(8);
            //customList.Add(9);
            //customList.Add(10);
            //customList.Add(11);
            //Console.WriteLine(customList.Capacity);  
            #endregion
        }
    }
}