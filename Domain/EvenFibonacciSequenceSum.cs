using System.Linq;

namespace Domain
{
    public class EvenFibonacciSequenceSum
    {
        public int Sum(int sequenceLength)
        {
            return new FibonacciSequence(sequenceLength)
                .GetElement()
                .Where(x => x%2 == 0)
                .Sum(x => x);
        }
    }
}