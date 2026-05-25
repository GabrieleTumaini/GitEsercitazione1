using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitEsercitazione1
{
    public class CD
    {
        private string title;
        private string author;
        private List<Track> tracks;
        public CD(string title, string author)
        {
            this.title = title;
            this.tracks = new List<Track>();
            this.author = author;
        }
        public string getTitle() => title;
        public string getAuthor() => author;
        public void setTitle(string title) => this.title = title;
        public void setAuthor(string author) => this.author = author;
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CD Title: {title}");
            sb.AppendLine("Tracks:");
            foreach (var track in tracks)
            {
                sb.AppendLine(track.ToString());
            }
            return sb.ToString();
        }

        public int Duration()
        {
            int totalDuration = 0;
            foreach (var track in tracks)
            {
                totalDuration += track.getDuration();
            }

            return totalDuration;
        }
    }
}
