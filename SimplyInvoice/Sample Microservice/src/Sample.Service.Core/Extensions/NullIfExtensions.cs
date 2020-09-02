using System.Collections.Generic;
using System.Linq;

namespace Sample.Service.Core.Extensions
{
    public static class NullIfExtensions
    {
        public static string NullIfNullOrWhitespace(this string value) => string.IsNullOrWhiteSpace(value) ? null : value;

        public static IReadOnlyDictionary<TKey, TValue> NullIfEmpty<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> value) => !value.Any() ? null : value;

        public static IReadOnlyList<T> NullIfEmpty<T>(this IReadOnlyList<T> value) => !value.Any() ? null : value;
    }
}