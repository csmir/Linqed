using System.Collections;

namespace Linqed.Collections
{
    public class RollingDictionary<TKey, TValue> : IDictionary<TKey, TValue>, IDisposable, ICloneable
        where TKey : notnull
    {

    }

    public class RollingDictionary : IDictionary, IDisposable, ICloneable
    {
    }
}
