using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EnumeratorPretender
{
    public class EnuPretender2 : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            for (int i = 1; i < 10; i++)
                yield return (int)System.Math.Pow(2, i);
            yield break;
        }
    }
}
