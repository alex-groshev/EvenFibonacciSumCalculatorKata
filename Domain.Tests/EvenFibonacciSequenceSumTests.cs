using NUnit.Framework;

namespace Domain.Tests
{
    [TestFixture]
    public class EvenFibonacciSequenceSumTests
    {
        [TestCase(7, 10)]
        [TestCase(8, 10)]
        [TestCase(9, 10)]
        [TestCase(10, 44)]
        public void Should_sum_even_numbers(int sequenceLength, int expected)
        {
            Assert.AreEqual(expected, new EvenFibonacciSequenceSum().Sum(sequenceLength));
        }
    }
}
