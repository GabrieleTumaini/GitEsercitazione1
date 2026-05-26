namespace GitEsercitazione1
{
    public class Track
    {
        //For homework screenshot
        private string title;
        private string author;
        private int duration;

        public Track(string title, string author, int duration)
        {
            this.title = title;
            this.author = author;
            this.duration = duration;
        }

        public string getTitle() => title;
        public string getAuthor() => author;
        public int getDuration() => duration;

        public void setTitle(string title) => this.title = title;
        public void setAuthor(string author) => this.author = author;
        public void setDuration(int duration) => this.duration = duration;

        public override string ToString()
        {
            return $"Title: {title} | Author: {author} | Duration: {duration} seconds";
        }

        public bool shortSong(int limitDuration)
        {
            return this.duration < limitDuration;
        }
    }
}
