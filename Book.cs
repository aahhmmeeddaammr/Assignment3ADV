using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{

    internal class Book
    {
        public string ISBN { get; set; }
        public string Title {get; set; }
        public string[] Authors{get; set;}
        public DateTime publicationDate {get; set;}
        public decimal Price { get; set; }

        public Book()
        {
            
        }
        public Book(string isbn , string title, string[] authors , decimal price)
        {
            if (isbn == null || title is null || authors is null || price < 0) throw new ArgumentNullException();
            ISBN = isbn;
            Title = title;
            Authors = authors;
            Price = price;
        }

        public string  GetAuthors()
        {
            string s = "";
            for (int i = 0; i < Authors.Length; i++)
            {
                s += $"\n\t{i+1}.{Authors[i]}";
            }
            return s;
        }
        public override string ToString()
        {
            
            return $"\nBook ISBN : {ISBN}\nBook Tiltle : {Title}\nBook Authors : {GetAuthors()}\nBookPrice : {Price}";
        }

    }

}
