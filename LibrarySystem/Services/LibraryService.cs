using LibrarySystem.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;


namespace LibrarySystem.Services
{
    class LibraryService
    {
        public static void ListBooks()
        {
            foreach (var book in Book.books)
            {
                Console.WriteLine($"{book.ID} | {book.Title} by {book.Author} in {book.Year}");
            }
        }
        public static void BorrowBook()
        {
            Console.Clear();
            Member.ListMembers();
            Console.WriteLine();
            Console.WriteLine("Enter member ID:");

            if (!int.TryParse(Console.ReadLine(), out int memberId))
            {
                Console.WriteLine("Please enter a valid member ID");
                Console.ReadKey();
                return;
            }

            Member selectedMember = null;
            foreach(Member member in Member.members)
            {
                if (member.ID ==  memberId)
                {
                    selectedMember = member;
                    break;
                }
            }
            if (selectedMember == null)
            {
                Console.WriteLine("There is not member with that ID");
                Console.ReadKey();
                return;
            }
            Console.WriteLine();
            Console.WriteLine("Books: ");
            foreach(Book book in Book.books)
            {
                string status;
                if(book.Borrow)
                {
                    status = "Borrowed";
                }
                else
                {
                    status = "Available";
                }
                Book.ListBooks();
            }
            Console.WriteLine();
            Console.WriteLine("Enter book ID");

            if (!int.TryParse(Console.ReadLine(), out int BookId))
            {
                Console.WriteLine("Please enter a valid Book ID");
                Console.ReadKey();
                return;
            }
            Book selectedBook = null;
            foreach(Book book in Book.books)
            {
                if(book.ID == BookId)
                {
                    selectedBook = book;
                    break;
                }
            }
            if (selectedBook == null)
            {
                Console.WriteLine("There is not book with that ID");
            } 
            else if(selectedBook.Borrow)
            {
                Console.WriteLine("The book has already been borrowed");
            }
            else
            {
                selectedBook.Borrow = true;
                selectedBook.BorrowedByMemberId = selectedMember.ID;
                Console.WriteLine($"{selectedBook.Title} has been borrowed by {selectedMember.FullName}");

            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        public static void ReturnBook()
        {
            Console.Clear();

            if (Member.members.Count == 0)
            {
                Console.WriteLine("There are no registered members.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Members: ");

            Member.ListMembers();

            Console.WriteLine();
            Console.WriteLine("Enter the member ID:");

            if (!int.TryParse(Console.ReadLine(), out int memberId))
            {
                Console.WriteLine("Please enter a valid member ID.");
                Console.ReadKey();
                return;
            }

            Member selectedMember = null;

            foreach (var member in Member.members)
            {
                if (member.ID == memberId)
                {
                    selectedMember = member;
                    break;
                }
            }

            if (selectedMember == null)
            {
                Console.WriteLine("There is no member with that ID.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine();
            Console.WriteLine($"Books borrowed by {selectedMember.FullName}:");

            bool hasBorrowedBooks = false;

            foreach (Book book in Book.books)
            {
                if (book.BorrowedByMemberId == selectedMember.ID)
                {
                    Console.WriteLine(
                        $"{book.ID} | {book.Title} by {book.Author}"
                    );

                    hasBorrowedBooks = true;
                }
            }

            if (!hasBorrowedBooks)
            {
                Console.WriteLine("This member has no borrowed books.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Enter the book ID to return:");

            if (!int.TryParse(Console.ReadLine(), out int bookId))
            {
                Console.WriteLine("Please enter a valid book ID.");
                Console.ReadKey();
                return;
            }

            Book? selectedBook = null;

            foreach (Book book in Book.books)
            {
                if (book.ID == bookId)
                {
                    selectedBook = book;
                    break;
                }
            }

            if (selectedBook == null)
            {
                Console.WriteLine("There is no book with that ID.");
            }
            else if (!selectedBook.Borrow)
            {
                Console.WriteLine("That book is not currently borrowed.");
            }
            else if (selectedBook.BorrowedByMemberId != selectedMember.ID)
            {
                Console.WriteLine(
                    "That book was borrowed by a different member."
                );
            }
            else
            {
                selectedBook.Borrow = false;
                selectedBook.BorrowedByMemberId = null;

                Console.WriteLine(
                    $"{selectedBook.Title} has been returned successfully."
                );
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
