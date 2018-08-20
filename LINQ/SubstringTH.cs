using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class SubstringTH
    {
        public SubstringTH()
        {

        }
        public IEnumerable<string> GetTH(List<string> listOfNames)
        {
            var namesWithTH = listOfNames.Where(l => l.Contains("th"));
            return namesWithTH;
        }
    }
}
