using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EnumeratorPretender
{
    public class EnuPretender : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            return new EnuPretenderEnumerator();
        }
    }

    public class EnuPretenderEnumerator : IEnumerator
    {
        private int _index = 0;

        public object Current {
            get { 
                return (int)System.Math.Pow(2, _index); 
            }
        }

        public bool MoveNext()
        {
            _index++;

            if (_index > 10)
                return false;
            else
                return true;
        }

        public void Reset()
        {
            _index = 0;
        }
    }
}
