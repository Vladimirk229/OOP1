namespace LibraryApp
{
    public abstract class MediaItem : IMediaItem
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
