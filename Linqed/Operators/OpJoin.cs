namespace Linqed
{
    public static class OpJoin
    {
        /// <summary>
        ///     Joins the values inside the enumerable into a string, dividing by <paramref name="seperator"/>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <param name="seperator">The seperator which is used to join values together.</param>
        /// <returns>A string of values from <paramref name="values"/> joined by the <paramref name="seperator"/>.</returns>
        public static string Join<T>(this IEnumerable<T> values, string seperator)
        {
            return string.Join(seperator, values);
        }

        /// <summary>
        ///     Joins the values inside the enumerable into a string, dividing by <paramref name="seperator"/>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <param name="seperator">The seperator which is used to join values together.</param>
        /// <returns>A string of values from <paramref name="values"/> joined by the <paramref name="seperator"/>.</returns>
        public static string Join<T>(this IEnumerable<T> values, char seperator)
        {
            return string.Join(seperator, values);
        }

        /// <summary>
        ///     Joins the values inside the enumerable into a string, dividing by <paramref name="seperator"/> after selecting them from <paramref name="func"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <param name="seperator">The seperator which is used to join values together.</param>
        /// <param name="func">A functor used to convert the type to string format, rather than using the <see cref="object.Equals(object?)"/> defaults.</param>
        /// <returns>A string of values from <paramref name="values"/> joined by the <paramref name="seperator"/>.</returns>
        public static string SelectJoin<T>(this IEnumerable<T> values, string seperator, Func<T, string> func)
        {
            return string.Join(seperator, values.Select(func));
        }

        /// <summary>
        ///     Joins the values inside the enumerable into a string, dividing by <paramref name="seperator"/> after selecting them from <paramref name="func"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <param name="seperator">The seperator which is used to join values together.</param>
        /// <param name="func">A functor used to convert the type to string format, rather than using the <see cref="object.Equals(object?)"/> defaults.</param>
        /// <returns>A string of values from <paramref name="values"/> joined by the <paramref name="seperator"/>.</returns>
        public static string SelectJoin<T>(this IEnumerable<T> values, char seperator, Func<T, string> func)
        {
            return string.Join(seperator, values.Select(func));
        }
    }
}
