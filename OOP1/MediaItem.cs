namespace LibraryApp
{
    public abstract class MediaItem : IMediaItem //Абстрактний клас, який напряму в програмі не використовується
        //Від нього походять класи Book та CompactBook
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public MediaItem(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public abstract void DisplayInfo();
    }
}
