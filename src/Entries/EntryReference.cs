using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scribe.Entries
{
    /// <summary>
    /// Refer to an entry with it's system id
    /// </summary>
    public struct EntryReference : IEquatable<EntryReference>
    {
        internal int InternalId;
        public readonly int Id => InternalId;
        public readonly bool HasValue => InternalId != 0;


        public readonly BaseEntry? GetEntry()
        {
            if (TryGetEntry(out var entry))
                return entry;
            return null;    
        }

        public readonly T? GetEntry<T>() where T : BaseEntry
        {
            if(TryGetEntry(out T? entry))
                return entry;
            return null;
        }

        public readonly bool TryGetEntry ( [NotNullWhen(true)] out BaseEntry? entry )
        {
            entry = Database.Instance.GetEntry(InternalId);
            return entry != null;
        }

        public readonly bool TryGetEntry<T> ( [NotNullWhen(true)] out T? entry ) where T : BaseEntry
        {
            entry = Database.Instance.GetEntry(InternalId) as T;
            return entry != null;
        }

        public override int GetHashCode ()
            => InternalId;

        public override bool Equals ( object? obj )
            => obj is EntryReference reference && Equals(reference);

        public readonly bool Equals ( EntryReference other )
            => InternalId == other.InternalId;

        public static bool operator == (EntryReference left, EntryReference right)
            => left.InternalId == right.InternalId;

        public static bool operator != ( EntryReference left, EntryReference right )
            => left.InternalId != right.InternalId;

        public static implicit operator int ( EntryReference reference )
            => reference.InternalId;

        public static implicit operator EntryReference ( int id )
            => new() { InternalId = id };

        public static explicit operator EntryReference ( BaseEntry entry )
            => new() { InternalId = entry?.Id ?? 0 };

        public static explicit operator BaseEntry? ( EntryReference reference )
            => reference.GetEntry();
    }
}
