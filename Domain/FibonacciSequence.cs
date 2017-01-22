using System;
using System.Collections.Generic;

namespace Domain
{
    public class FibonacciSequence
    {
        private readonly int _length;

        public FibonacciSequence(int length)
        {
            if (length == 0)
                throw new ArgumentException("Sequence length must be greater than zero.");

            _length = length;
        }

        public IEnumerable<int> GetElement()
        {
            if (_length == 1)
                yield return 0;

            if (_length == 2)
                yield return 1;

            int x = 0, y = 1;

            for (var i = 3; i <= _length; i++)
            {
                var temp = x;
                x = y;
                y = temp + y;
                yield return y;
            }
        }
    }
}
