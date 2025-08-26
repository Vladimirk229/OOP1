namespace LibraryApp
{
    public class Library
    {
        private MediaItem[] items = new MediaItem[100]; //Масив з об'єктами MediaItem. Містить цей тип замість Book адже окрім звичайних книг тут можуть бути об'єкти класу CompactBook
        private int count = 0;

        //=====================================================================

        public void AddItem(MediaItem item)
        {
            if (count < items.Length)
            {
                items[count] = item;
                count++;
                Console.WriteLine("Book added successfully.\n");
            }
            else
            {
                Console.WriteLine("Library is full.\n");
            }
        }

        //=====================================================================

        public void ShowAllBooks()
        {
            if (count == 0)
            {
                Console.WriteLine("Library is empty.\n");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                items[i].DisplayInfo();
            }
        }

        //=====================================================================

        public void SearchByAuthor(string author)
        {
            bool found = false;
            for (int i = 0; i < count; i++)
            {
                if (items[i].Author.Contains(author, StringComparison.OrdinalIgnoreCase))
                {
                    items[i].DisplayInfo();
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("No books found by this author.\n");
        }

        //=====================================================================

        public void SearchByTitle(string title)
        {
            bool found = false;
            for (int i = 0; i < count; i++)
            {
                if (items[i].Title.Contains(title, StringComparison.OrdinalIgnoreCase))
                {
                    items[i].DisplayInfo();
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("No books found with this title.\n");
        }
    }
}
