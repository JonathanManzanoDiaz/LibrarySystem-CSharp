using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem.Models
{
    class Book
    {
        private static int _nextId = 1;
        public int ID { get; }
        public string Title { get; } 
        public string Author { get; }
        public int Year { get; }
        public bool Borrow { get; set;}

        public int? BorrowedByMemberId { get; set; }

        public static List<Book> books = new List<Book>();
        public Book(string title, string author, int year)
        {
            ID = _nextId++;
            Title = title;
            Author = author;
            Year = year;

            Borrow = false;
            BorrowedByMemberId = null;
        }

        public static void AddBook()
        {
           
            try
            {
                Console.WriteLine("What is the name of the book?: ");
                string title = Console.ReadLine();
                Console.WriteLine("What is the name of the author?: ");
                string author = Console.ReadLine();
                Console.WriteLine("What is the year of publication?: ");
                int year = int.Parse(Console.ReadLine());
                Book newBook = new Book(title, author, year);
                books.Add(newBook);
                Console.WriteLine("Book added succesfully!");
            Console.WriteLine("Press a key to continue...");

                Console.ReadKey();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error, try again. " + e.Message);
            }
        }
        public static void ListBooks()
        {
            foreach(var book in books)
            {
                Console.WriteLine($"{book.ID} | {book.Title} by {book.Author}");
            }
            Console.WriteLine("Press a key to continue...");

            Console.ReadKey();
        }
        public static bool SpecificBook(int id)
        {
            ListBooks();
            foreach (var book in books)
            {
                if(id == book.ID)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("We don't have this book.");
                }
            }


            return false;
        }
        
    }
}
