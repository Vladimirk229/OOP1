namespace LibraryApp
{
    public class CompactBook : Book
    {
        public CompactBook(string title, string author, string genre, string isbn) //Конструктор класу, наслідує функціонал від класу Book
            : base(title, author, genre, isbn)
        {
        }

        public override void DisplayInfo() //Перевизначення методу DisplayInfo, на відміну від реалізації в класі Book, цей метод відображає скорочену інформацію
        {
            Console.WriteLine($"{Title} — {Author}");
            Console.WriteLine(new string('-', 30));
        }
    }
}
