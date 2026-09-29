using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Models
{
    internal class Member
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Book> BorrowedBooks{ get; set; }

        public Member(int id,string name)
        {
            ID = id;
            Name = name;
            BorrowedBooks = new List<Book>();
        }
        public const int MaxBorrowedBooks = 3;


        public bool CanBorrow()
        {
            return BorrowedBooks.Count < MaxBorrowedBooks;
        }

        public void Display()
        {
            Console.WriteLine($"{ID} : {Name} - Lånade böcker: {BorrowedBooks.Count}");
            foreach (Book b in BorrowedBooks)
            {
                Console.WriteLine($"         -{b.Title}");
            }
        }

    }


}
