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
                        Console.WriteLine("Choose book type:");
                        Console.WriteLine("1. Full Book");
                        Console.WriteLine("2. Compact Book");
                        Console.Write("Option: ");
                        string typeChoice = Console.ReadLine();
                        Console.WriteLine();

                        string title = ReadValidatedInput("title", 100);
                        string author = ReadValidatedInput("author", 50);
                        string genre = ReadValidatedInput("genre", 30);
                        string isbn = ReadValidatedInput("ISBN", 20);

                        MediaItem item;

                        if (typeChoice == "2")
                            item = new CompactBook(title, author, genre, isbn);
                        else
                            item = new Book(title, author, genre, isbn);

                        library.AddItem(item);
                        break;

                    case "2":
                        library.ShowAllBooks();
                        break;

                    case "3":
                        string searchAuthor = ReadValidatedInput("author name to search", 50);
                        library.SearchByAuthor(searchAuthor);
                        break;

                    case "4":
                        string searchTitle = ReadValidatedInput("title to search", 100);
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

        private static string ReadValidatedInput(string fieldName, int maxLength)
        {
            while (true)
            {
                Console.Write($"Enter {fieldName}: ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Input cannot be empty.\n");
                    continue;
                }

                if (input.Length > maxLength)
                {
                    Console.WriteLine($"Input is too long. Maximum allowed length is {maxLength} characters.\n");
                    continue;
                }

                return input.Trim();
            }
        }
    }
}
