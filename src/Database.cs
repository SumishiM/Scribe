using Scribe.Entries;
using System.Collections.Immutable;

namespace Scribe
{
    public class Database
    {
        public readonly ImmutableDictionary<int, Table> Tables
            = new Dictionary<int, Table>().ToImmutableDictionary();

        public readonly ImmutableDictionary<int, ImmutableHashSet<int>> TableEntryIndex
            = new Dictionary<int, ImmutableHashSet<int>>().ToImmutableDictionary(); 

        private static Database? _instance;

        public static Database Instance
        {
            get
            {
                _instance ??= new Database();
                return _instance;
            }
        }

        public BaseEntry? GetEntry(int id)
        {
            return null;
        }
    }
}
