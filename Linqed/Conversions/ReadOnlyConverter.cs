using System.Collections.Immutable;
using System.Collections.ObjectModel;

namespace Linqed
{
    public static class ReadOnlyConverter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dictionary"></param>
        /// <returns></returns>
        public static ReadOnlyDictionary<TKey, TValue> AsReadOnly<TKey, TValue>(this IDictionary<TKey, TValue> dictionary)
            where TKey : notnull
            => new(dictionary);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dictionary"></param>
        /// <returns></returns>
        public static IReadOnlyDictionary<TKey, TValue> AsTrueReadOnly<TKey, TValue>(this IDictionary<TKey, TValue> dictionary)
            where TKey : notnull
            => ImmutableDictionary.CreateRange(dictionary);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable"></param>
        /// <param name="keySelector"></param>
        /// <returns></returns>
        public static IReadOnlyDictionary<TKey, T> ToReadOnlyDictionary<TKey, T>(this IEnumerable<T> enumerable, Func<T, TKey> keySelector)
            where TKey : notnull
            => enumerable.ToDictionary(keySelector).AsTrueReadOnly();

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns></returns>
        public static ReadOnlyCollection<T> AsReadOnly<T>(this T[] array)
            => new(array);

        /// <summary>
        ///     
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns></returns>
        public static IReadOnlyCollection<T> AsTrueReadOnly<T>(this T[] array)
            => ImmutableArray.CreateRange(array);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable"></param>
        /// <returns></returns>
        public static IReadOnlyCollection<T> ToReadOnlyCollection<T>(this IEnumerable<T> enumerable)
            => enumerable.ToArray().AsTrueReadOnly();

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static IReadOnlyList<T> AsTrueReadOnly<T>(this IList<T> list)
            => ImmutableList.CreateRange(list);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable"></param>
        /// <returns></returns>
        public static IReadOnlyList<T> ToReadOnlyList<T>(this IEnumerable<T> enumerable)
            => enumerable.ToList().AsTrueReadOnly();

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="set"></param>
        /// <returns></returns>
        public static IReadOnlySet<T> AsTrueReadOnly<T>(this ISet<T> set)
            => ImmutableHashSet.CreateRange(set) ;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable"></param>
        /// <returns></returns>
        public static IReadOnlySet<T> ToReadOnlySet<T>(this IEnumerable<T> enumerable)
            => enumerable.ToHashSet().AsTrueReadOnly();
    }
}
