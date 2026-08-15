namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool appActive = true;
            while(appActive)
            {
                int final = Library.Menu() - 48;
                switch (final)
                {
                    case 0:
                        appActive = false;
                        break;
                    case 1:
                        ClearConsole();

                        Book.ListBooks();
                        break;
                    case 2:
                        Book.AddBook();
                        ClearConsole();

                        break;
                    case 3:
                        Book.RemoveBook();
                        ClearConsole();
                        break;
                    case 4:
                        Library.BorrowBook();
                        break;
                    case 5:
                        Library.ReturnBook();
                        break;
                    default:
                        Console.WriteLine("Please, select an option of the options given.");
                        ClearConsole();
                        break;

                }

            }
        }
        static void ClearConsole()
        {
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
