using Scribe.Entries;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scribe.Blackboards
{
    public class Blackboard
    {
        public struct Pair
        {
            public EntryReference Key;
            public int Value;
        }

        public List<Pair> Pairs = new List<Pair>();
        private Dictionary<int, int> _lookup = new Dictionary<int, int>();

        public void Set ( int key, float value)
        {
           Set(key, BitConverter.SingleToInt32Bits(value));
        }

        public void Set( int key, bool value)
        {
            Set(key, value ? 1 : 0);
        }

        public void Set(int key, int value)
        {
            if (_lookup.TryGetValue(key, out var index))
            {
                Pair pair = Pairs[index];
                pair.Value = value;
                Pairs[index] = pair;
            }
            else
            {
                index = Pairs.Count;
                Pairs.Add(new Pair
                {
                    Key = key,
                    Value = value
                });
                _lookup.Add(key, index);
            }
        }
    }
}
