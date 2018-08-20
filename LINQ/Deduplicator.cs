using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Deduplicator
    {
        public Deduplicator()
        {

        }

        public IEnumerable<string> RemoveDuplicates(List<string> listToRemove)
        {
            var deDuplicatedList = listToRemove.Distinct();
            return deDuplicatedList;
        }
    }
}
