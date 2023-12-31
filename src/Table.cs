using Scribe.Entries;
using System.Collections.Immutable;

namespace Scribe
{
    public class Table
    {
        public string Name = string.Empty;

        public List<RuleEntry> Rules = new List<RuleEntry>();
        public List<FactEntry> Facts = new List<FactEntry>();
        public List<EventEntry> Events = new List<EventEntry>();

        public readonly ImmutableHashSet<int> EntryIndex = [];

        public void AddEntry(BaseEntry entry)
        {

        }

        public void RemoveEntry ( BaseEntry entry )
        {

        }
    }
}
