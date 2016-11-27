using System.Collections.Generic;

namespace CK.System.Collections.Generic
{
    /// <summary>
    /// Enumables creating <see cref="HashSet{T}"/> from <see cref="IEnumerable{T}"/> via extension methods
    /// </summary>
    public static class HashSetExt
    {
        /// <summary>
        /// Calls <see cref="HashSet{T}" /> constructor
        /// </summary>
        public static HashSet<T> ToHashSet<T>(IEnumerable<T> items) => new HashSet<T>(items);

        /// <summary>
        /// Calls <see cref="HashSet{T}" /> constructor
        /// </summary>
        public static HashSet<T> ToHashSet<T>(IEnumerable<T> items, IEqualityComparer<T> comparer) => new HashSet<T>(items, comparer);
    }
}
