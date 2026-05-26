using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitEsercitazione1
{
    public class MusicLabel
    {
        private string labelName;

        public MusicLabel(string labelName)
        {
            this.labelName = labelName;
        }

        public double CalculateProductionCost(CD cd)
        {
            int totalTracks = cd.tracks.Count;
            return 1.50 + (totalTracks * 0.40);
        }
    }
}
