using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem
{
    public class Library
    {
        public static int Menu()
        {
            Console.WriteLine("Hello, welcome to Library System");
            Console.WriteLine("Select an option:");
            Console.WriteLine("1.- List Books");
            Console.WriteLine("2.- Add a Book");
            Console.WriteLine("3.- Remove a Book");
            Console.WriteLine("4.- Borrow a Book");
            Console.WriteLine("5.- Return a Book");
            Console.WriteLine("0.- Exit\n");

            ConsoleKeyInfo option = Console.ReadKey(true);
            int final = Convert.ToInt32(option.KeyChar);
            return final;
        }
        public static void BorrowBook()
        {
            Console.WriteLine("What book do you want to borrow?");
            Book.ListBooks();
            ConsoleKeyInfo option = Console.ReadKey(true);
            int final = Convert.ToInt32(option.KeyChar - 48);
            if (Book.CheckStatus(final) == true) {
                Book.ChangeStatus(final);
            } else
            {
                Console.WriteLine("This book is already borrowed, wait to the book to be returned.");
               
            }
        }
        public static void ReturnBook()
        {
            Console.WriteLine("What book do you want to borrow?");
            Book.ListBooks();
            ConsoleKeyInfo option = Console.ReadKey(true);
            int final = Convert.ToInt32(option.KeyChar - 48);
            if (Book.CheckStatus(final) == false) {
                Book.ChangeStatus(final);
            } else
            {
                Console.WriteLine("This book is already returned, first borrow the book.");
               
            }
        }
    }
}
