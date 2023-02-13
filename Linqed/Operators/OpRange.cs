namespace Linqed
{
    public static class OpRange
    {
        /// <summary>
        ///     Gets the range following after <paramref name="startIndex"/> from the provided collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <param name="startIndex">The starting index to begin grabbing entries from.</param>
        /// <returns>A new <see cref="IEnumerable{T}"/> from the specified range of entries.</returns>
        public static IEnumerable<T> GetRange<T>(this IList<T> values, int startIndex)
        {
            for (int i = startIndex; i < values.Count; i++)
            {
                yield return values[i];
            }
        }

        /// <summary>
        ///     Gets the range between the start and end of <paramref name="range"/> from the provided collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <param name="range">The range between which values will be pushed out.</param>
        /// <returns>A new <see cref="IEnumerable{T}"/> from the specified range of entries.</returns>
        public static IEnumerable<T> GetRange<T>(this IList<T> values, Range range)
        {
            for (int i = range.Start.Value; i < range.End.Value; i++)
            {
                yield return values[i];
            }
        }

        /// <summary>
        ///     Gets the range following after <paramref name="startIndex"/> from the provided collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <param name="startIndex">The starting index to begin pushing out entries from.</param>
        /// <returns>A new <see cref="IEnumerable{T}"/> from the specified range of entries.</returns>
        public static IEnumerable<T> GetRange<T>(this T[] values, int startIndex)
        {
            for (int i = startIndex; i < values.Length; i++)
            {
                yield return values[i];
            }
        }

        /// <summary>
        ///     Gets the range between the start and end of <paramref name="range"/> from the provided collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <param name="range">The range between which values will be pushed out.</param>
        /// <returns>A new <see cref="IEnumerable{T}"/> from the specified range of entries.</returns>
        public static IEnumerable<T> GetRange<T>(this T[] values, Range range)
        {
            for (int i = range.Start.Value; i < range.End.Value; i++)
            {
                yield return values[i];
            }
        }

        /// <summary>
        ///     Gets the range following after <paramref name="startIndex"/> from the provided collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <param name="startIndex">The starting index to begin pushing out entries from.</param>
        /// <returns>A new <see cref="IEnumerable{T}"/> from the specified range of entries.</returns>
        public static IEnumerable<T> GetRange<T>(this IEnumerable<T> values, int startIndex)
        {
            int currentIndex = 0;
            foreach (var value in values)
            {
                if (currentIndex == startIndex)
                {
                    yield return value;
                }

                currentIndex++;
            }
        }

        /// <summary>
        ///     Gets the range between <paramref name="startIndex"/> until <paramref name="count"/> from the provided collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <param name="startIndex">The starting index to begin pushing out entries from.</param>
        /// <param name="count">The amount of entries after <paramref name="startIndex"/> to fetch.</param>
        /// <returns>A new <see cref="IEnumerable{T}"/> from the specified range of entries.</returns>
        public static IEnumerable<T> GetRange<T>(this IEnumerable<T> values, int startIndex, int count)
        {
            int currentIndex = 0;
            foreach (var value in values)
            {
                if (currentIndex == startIndex)
                {
                    yield return value;
                }

                if (currentIndex == startIndex + count)
                {
                    yield return value;
                    break;
                }

                currentIndex++;
            }
        }

        /// <summary>
        ///     Gets the range between the start and end of <paramref name="range"/> from the provided collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <param name="range">The range between which values will be pushed out.</param>
        /// <returns>A new <see cref="IEnumerable{T}"/> from the specified range of entries.</returns>
        public static IEnumerable<T> GetRange<T>(this IEnumerable<T> values, Range range)
        {
            int currentIndex = 0;
            foreach (var value in values)
            {
                if (currentIndex == range.Start.Value)
                {
                    yield return value;
                }

                if (currentIndex == range.End.Value)
                {
                    yield return value;
                    break;
                }

                currentIndex++;
            }
        }
    }
}
