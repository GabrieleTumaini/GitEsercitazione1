using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitEsercitazione1
{
    public class ArtistDetails
    {
        public string StageName { get; set; }
        public string Country { get; set; }
        public int ActiveSince { get; set; }

        public ArtistDetails(string stageName, string country, int activeSince)
        {
            StageName = stageName;
            Country = country;
            ActiveSince = activeSince;
        }

        public string GetProfileSummary()
        {
            return $"Artist: {StageName} ({Country}), active since {ActiveSince}.";
        }
    }
}
