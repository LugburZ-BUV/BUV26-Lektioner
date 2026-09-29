using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Models
{
    internal class Library
    {
        private List<Book> Books = new List<Book>();
        private List<Member> Members = new List<Member>();


        // Displays all books in the library
        public void ShowAllBooks()
        {
            if(Books.Count == 0)
            {
                Console.WriteLine("Det finns inga böcker i listan.");
            }
            for(int i = 0; i < Books.Count; i++)
            {
                Console.WriteLine($"{i + 1}.");
                Books[i].Display();
            }
        }

        public void ShowAvailableBooks()
        {
            int amount = 0;
            foreach(Book book in Books)
            {
                if (!book.IsBorrowed)
                {
                    book.Display();
                    amount++;
                }
            }
            if (amount == 0)
            {
                Console.WriteLine("Inga böcker är tillgängliga just nu.");
            }
        }

        // Adds some test data
        public void AddTestData()
        {
            Books.Add(new Book("C# för nybörjare","Kalle Anka",2024));
            Books.Add(new Book("Clean Code", "Anna Pallas", 2021));
            Books.Add(new Book("Klipptidens gyllene årtionde", "Figaroo", 1927));
        }

    }
}
