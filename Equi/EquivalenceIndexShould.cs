using System.Collections.Generic;
using NUnit.Framework;

namespace Codility.Tests
{
    public class EquivalenceIndexShould
    {

        [TestCase(new[] {-1, 3, -4, 5, 1, -6, 2, 1}, ExpectedResult = 1)]
        [TestCase(new[] {int.MinValue, int.MaxValue, int.MaxValue}, ExpectedResult = -1)]
        [TestCase(new[] {int.MinValue + 1, int.MaxValue, int.MaxValue}, ExpectedResult = 2)]
        [TestCase(new[] {int.MinValue}, ExpectedResult = 0)]
        public int ShouldRun(int[] numbers)
        {
            return EquivalenceIndex.Find(numbers);
        }

        [TestCase(ExpectedResult = -1)]
        public int RunEmpty()
        {
            int[] numbers = new int[0];
            return EquivalenceIndex.Find(numbers);
        }

        [TestCase(ExpectedResult = -1)]
        public int RunLong()
        {
            var numbers = new List<int>();
            for (var i = 0; i < 100000; i++)
            {
                numbers.Add(1);
            }

            return EquivalenceIndex.Find(numbers.ToArray());
        }
    }
}
  