using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem
{
    public class Book
    {
        private static int idCounter = 1;
        public int ID;
        public string Title { get; set; }
        public int Year { get; set; }
        public string Author { get; set; }
        public bool Available { get; set; } = true;
        private static List<Book> books = new List<Book>();
        public Book(string title, string author, int year)
        {
            ID = idCounter++;
            Title = title;
            Author = author;
            Year = year;

        }
        public static void ListBooks()
        {
            if (books.Count() == 0)
            {
                Console.WriteLine("The list of books is empty.");
            } else
            {
                foreach (var book in books)
                {
                    Console.WriteLine($"{book.ID} | {book.Title} by {book.Author}. Created in {book.Year} Available: {book.Available}");
                    
                }

            }
            Console.WriteLine();
        }
        public static void AddBook()
        {
            Console.WriteLine("Name of the book: ");
            string title = Console.ReadLine();

            Console.WriteLine("Author of the book: ");
            string author = Console.ReadLine();

            Console.WriteLine("Year of creation: ");
            int.TryParse(Console.ReadLine(), out int year);
            Book book = new Book(title, author, year);

            books.Add(book);
            Console.WriteLine("Book added succesfully!\n");
            
        }

        public static void RemoveBook()
        {
            ListBooks();
            if (books.Count == 0) return;

            Console.WriteLine("Type the ID number of the book that you want to eliminate and press Enter: ");

            if (int.TryParse(Console.ReadLine(), out int bookID))
            {
                Book bookToRemove = null;

                foreach (var book in books)
                {
                    if (bookID == book.ID)
                    {
                        bookToRemove = book;
                        break;
                    }
                }

                if (bookToRemove != null)
                {
                    books.Remove(bookToRemove);
                    Console.WriteLine("Book removed successfully!");
                }
                else
                {
                    Console.WriteLine("There is not a book with that ID.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please type a valid number.");
            }
        }
        public static bool CheckStatus(int id)
        {
            foreach(var book in books)
            {
                if (book.ID == id)
                {
                    return book.Available;
                }
            }
            return false;
        }
        public static void ChangeStatus(int id)
        {
            foreach (var book in books)
            {
                if (id == book.ID)
                {
                    book.Available = !book.Available;
                    break; 
                }
            }
        }
    }
}
