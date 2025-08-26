namespace LibraryApp
{
    public class CompactBook : Book
    {
        public CompactBook(string title, string author, string genre, string isbn)
            : base(title, author, genre, isbn)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{Title} — {Author}");
            Console.WriteLine(new string('-', 30));
        }
    }
}
