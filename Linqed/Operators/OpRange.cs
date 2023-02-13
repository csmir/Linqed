namespace Linqed
{
    public static class OpRange
    {
        public static IEnumerable<T> GetRange<T>(this IList<T> values, int startIndex)
        {
            for (int i = startIndex; i < values.Count; i++)
            {
                yield return values[i];
            }
        }

        public static IEnumerable<T> GetRange<T>(this IList<T> values, Range range)
        {
            for (int i = range.Start.Value; i < range.End.Value; i++)
            {
                yield return values[i];
            }
        }

        public static IEnumerable<T> GetRange<T>(this T[] values, int startIndex)
        {
            for (int i = startIndex; i < values.Length; i++)
            {
                yield return values[i];
            }
        }

        public static IEnumerable<T> GetRange<T>(this T[] values, Range range)
        {
            for (int i = range.Start.Value; i < range.End.Value; i++)
            {
                yield return values[i];
            }
        }

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
