using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp3.Models
{
    internal class Book
    {
        // 
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public bool IsBorrowed { get; set; }

        public Book() : this("No title","No Author",00)
        {

        }
        public Book(string title,string author,int year)
        {
            Title = title;
            Author = author;
            Year = year;
            IsBorrowed = false; // En bok är tillgänglig som default 
        }

        
        public void Display()
        {
            string status = IsBorrowed ? "Utlånad" : "Tillgänglig";
            Console.WriteLine($"{Title} av {Author}({Year}) - {status}.");
        }
    }
}
