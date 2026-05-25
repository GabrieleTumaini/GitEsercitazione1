using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitEsercitazione1
{
    public class MusicalGenre
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public MusicalGenre(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
