namespace LibraryApp
{
    public class Book : MediaItem
    {
        public string Genre { get; set; }
        public string ISBN { get; set; }

        public Book(string title, string author, string genre, string isbn)
            : base(title, author)
        {
            Genre = genre;
            ISBN = isbn;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine(new string('-', 30));
        }
    }
}
