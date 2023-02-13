using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqed
{
    public static class OpCast
    {
        /// <summary>
        ///     Casts the values held by this enumerable into the target type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <returns></returns>
        public static IEnumerable<T> Cast<T>(this IEnumerable values)
        {
            foreach (var item in values)
                yield return (T)item;
        }

        /// <summary>
        ///     Casts the values held by this enumerable into the target type. Given it is tolerant, this handle will skip values that do not match the target type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <returns></returns>
        public static IEnumerable<T> TolerantCast<T>(this IEnumerable values)
        {
            foreach (var item in values)
                if (item is T tItem)
                    yield return tItem;
        }

        /// <summary>
        ///     Casts the values held by this enumerable into the target type. 
        ///     This handle is tolerant, and will check <paramref name="predicate"/> to ensure the value validity.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public static IEnumerable<T> PredicateCast<T>(this IEnumerable values, Func<T, bool> predicate)
        {
            foreach (var item in values)
                if (item is T tItem && predicate(tItem))
                    yield return tItem;
        }
    }
}
