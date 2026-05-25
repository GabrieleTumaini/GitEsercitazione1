using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitEsercitazione1
{
    public class CDRack
    {
        private int maxCapacity;
        private List<CD> cdCollection;

        public CDRack(int maxCapacity)
        {
            this.maxCapacity = maxCapacity;
            this.cdCollection = new List<CD>();
        }

        
        public bool AddCD(CD newCD)
        {
            if (cdCollection.Count < maxCapacity)
            {
                cdCollection.Add(newCD);
                return true;
            }
            return false;
        }

        
        public CD? FindCDByTitle(string titleToSearch)
        {
            foreach (CD cd in cdCollection)
            {
                if (cd.getTitle() == titleToSearch)
                {
                    return cd;
                }
            }

            return null;
        }
    }
}
