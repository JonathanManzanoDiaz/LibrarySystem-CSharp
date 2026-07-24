using LibrarySystem.Menus;
using LibrarySystem.Services;
using LibrarySystem.Models;


namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string prompt = "Menu Library System";
            string[] options = { "Add Book", "Add Member", "List Books", "List Members", "Borrow Book", "Return Book", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            bool appRunning = true;
            while (appRunning)
            {
                int SelectedIndex = mainMenu.Run();
                switch (SelectedIndex)
                {
                    case 0:
                        Book.AddBook();
                        break;
                    case 1:
                        Member.AddMember();
                        break;
                    case 2:
                        Book.ListBooks();
                        break;
                    case 3:
                        Member.ListMembers();
                        break;
                    case 4:
                        LibraryService.BorrowBook();
                        break;
                    case 5:
                        LibraryService.ReturnBook();
                        break;
                    case 6:
                        Console.WriteLine("Goodbye! Welcome back!");
                        appRunning = false;
                        break;
                }
            }
        }
    }
}
