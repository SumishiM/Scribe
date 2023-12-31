using Scribe.Entries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scribe
{
    public class Table
    {
        public string Name = string.Empty;

        public List<RuleEntry> Rules = new List<RuleEntry>();
        public List<FactEntry> Facts = new List<FactEntry>();
        public List<EventEntry> Events = new List<EventEntry>();


        public void AddEntry(BaseEntry entry)
        {

        }

        public void RemoveEntry ( BaseEntry entry )
        {

        }
    }
}
