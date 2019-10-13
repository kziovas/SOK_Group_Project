using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidAppDev
{
    public class visitor
    {
        public string Username;
        public string Visits;
        public List<string> History = new List<string>();
        public bool Visited(String pageName) {
            return this.History.Contains(pageName);

        }

        public void UpdHist(String newPage)
        {

            this.History.Add(newPage);
        }
    }
}
