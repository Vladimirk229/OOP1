namespace LibraryApp
{
    internal class Program
    {
        static void Main()
        {
            Library library = new Library();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("=== Library Menu ===");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Show All Books");
                Console.WriteLine("3. Search by Author");
                Console.WriteLine("4. Search by Title");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Enter title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter author: ");
                        string author = Console.ReadLine();

                        Console.Write("Enter genre: ");
                        string genre = Console.ReadLine();

                        Console.Write("Enter ISBN: ");
                        string isbn = Console.ReadLine();

                        Book book = new Book(title, author, genre, isbn);
                        library.AddBook(book);
                        break;

                    case "2":
                        library.ShowAllBooks();
                        break;

                    case "3":
                        Console.Write("Enter author name to search: ");
                        string searchAuthor = Console.ReadLine();
                        library.SearchByAuthor(searchAuthor);
                        break;

                    case "4":
                        Console.Write("Enter title to search: ");
                        string searchTitle = Console.ReadLine();
                        library.SearchByTitle(searchTitle);
                        break;

                    case "5":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option.\n");
                        break;
                }
            }

            Console.WriteLine("Program exited.");
        }
    }
}
