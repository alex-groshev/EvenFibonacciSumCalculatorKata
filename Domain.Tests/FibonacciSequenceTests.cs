using System.Linq;
using NUnit.Framework;

namespace Domain.Tests
{
    [TestFixture]
    public class FibonacciSequenceTests
    {
        [TestCase(1, 0)]
        [TestCase(2, 1)]
        [TestCase(3, 1)]
        [TestCase(4, 2)]
        [TestCase(5, 3)]
        [TestCase(6, 5)]
        [TestCase(7, 8)]
        public void Should_return_fibonacci_sequence(int length, int lastElement)
        {
            var result = new FibonacciSequence(length).GetElement().Last();
            Assert.AreEqual(lastElement, result);
        }
    }
}
