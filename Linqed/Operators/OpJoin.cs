namespace Linqed
{
    public static class OpJoin
    {
        /// <summary>
        ///     Joins the values inside the enumerable into a string, dividing by <paramref name="seperator"/>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <param name="seperator"></param>
        /// <returns></returns>
        public static string Join<T>(this IEnumerable<T> values, string seperator)
        {
            return string.Join(seperator, values);
        }

        /// <summary>
        ///     Joins the values inside the enumerable into a string, dividing by <paramref name="seperator"/>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <param name="seperator"></param>
        /// <returns></returns>
        public static string Join<T>(this IEnumerable<T> values, char seperator)
        {
            return string.Join(seperator, values);
        }

        /// <summary>
        ///     Joins the values inside the enumerable into a string, dividing by <paramref name="seperator"/> after selecting them from <paramref name="func"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <param name="seperator"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static string SelectJoin<T>(this IEnumerable<T> values, string seperator, Func<T, string> func)
        {
            return string.Join(seperator, values.Select(func));
        }

        /// <summary>
        ///     Joins the values inside the enumerable into a string, dividing by <paramref name="seperator"/> after selecting them from <paramref name="func"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <param name="seperator"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static string SelectJoin<T>(this IEnumerable<T> values, char seperator, Func<T, string> func)
        {
            return string.Join(seperator, values.Select(func));
        }
    }
}
