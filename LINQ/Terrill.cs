using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Terrill
    {
        public Terrill()
        {

        }

        public string GetFrequency(string name)
        {
            var terrill = string.Join("", (name.ToUpper().Select(x => $"{x}{name.ToUpper().Count(y => y == x)}").Distinct().OrderBy(l => l)));


            return terrill;
        }
    }
}
