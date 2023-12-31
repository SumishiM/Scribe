using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scribe.Entries
{
    public class BaseEntry
    {
        public int Id;
        public string Key = string.Empty;

        public bool Consume;
    }
}
