namespace Linqed
{
    public static class OpForEach
    {
        /// <summary>
        ///     Loops over all entries of the enumerable and executes provided <paramref name="action"/> on its values.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> values, Action<T> action)
        {
            foreach (var item in values)
            {
                action(item);
                yield return item;
            }
        }

        /// <summary>
        ///     Loops over all entries of the enumerable and executes provided <paramref name="action"/> on its values.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <param name="action"></param>
        /// <param name="recreateEnumerable"></param>
        /// <returns></returns>
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> values, Action<T> action, bool recreateEnumerable = false)
        {
            if (recreateEnumerable)
                return ForEach(values, action);
            else
            {
                foreach (var item in values)
                    action(item);

                return values;
            }
        }
    }
}
