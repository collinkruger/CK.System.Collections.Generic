using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK.System.Collections.Generic
{
    /// <summary>
    /// Static helper for dealing with <see cref="KeyValuePair{TKey, TValue}"/> 
    /// </summary>
    public static class KVP
    {
        /// <summary>
        /// Enumables creating a <see cref="KeyValuePair{TKey, TValue}"/> without having to specify type parameters
        /// </summary>
        public static KeyValuePair<TKey, TValue> Gen<TKey, TValue>(TKey key, TValue value) => new KeyValuePair<TKey, TValue>(key, value);
    }
}
