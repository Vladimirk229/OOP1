namespace LibraryApp
{
    public class Library
    {
        private Book[] books = new Book[100];
        private int count = 0;

        public void AddBook(Book book)
        {
            if (count < books.Length)
            {
                books[count] = book;
                count++;
                Console.WriteLine("Book added successfully.\n");
            }
            else
            {
                Console.WriteLine("Library is full.\n");
            }
        }

        public void ShowAllBooks()
        {
            if (count == 0)
            {
                Console.WriteLine("Library is empty.\n");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                books[i].DisplayInfo();
            }
        }

        public void SearchByAuthor(string author)
        {
            bool found = false;
            for (int i = 0; i < count; i++)
            {
                if (books[i].Author.Contains(author, StringComparison.OrdinalIgnoreCase))
                {
                    books[i].DisplayInfo();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No books found by this author.\n");
            }
        }

        public void SearchByTitle(string title)
        {
            bool found = false;
            for (int i = 0; i < count; i++)
            {
                if (books[i].Title.Contains(title, StringComparison.OrdinalIgnoreCase))
                {
                    books[i].DisplayInfo();
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("No books found with this title.\n");
        }
    }
}
