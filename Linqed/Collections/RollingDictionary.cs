using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
