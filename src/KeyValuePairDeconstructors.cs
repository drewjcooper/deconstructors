using System.Collections.Generic;

namespace Extensions.Generic.Deconstructors
{
    public static class KeyValuePairDeconstructors
    {
        public static void Deconstruct<TKey, TValue>(this KeyValuePair<TKey, TValue> kvp, out TKey key, out TValue value)
        {
            key = kvp.Key;
            value = kvp.Value;
        }
    }
}