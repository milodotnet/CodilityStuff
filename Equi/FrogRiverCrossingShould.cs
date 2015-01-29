using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Codility.Tests
{
    public class FrogRiverCrossingShould
    {

        [TestCase(5,new[] {1, 3, 1, 4, 2, 3, 5, 4},  ExpectedResult = 6)]
        [TestCase(5, new[] { 1, 3, 1, 3, 2, 5, 4, 5, 4 }, ExpectedResult = 6)]
        [TestCase(5, new[] { 1, 2, 3, 4, 5 }, ExpectedResult = 4)]
        [TestCase(5, new[] { 5, 4, 3, 2, 1 }, ExpectedResult = 4)]
        [TestCase(5, new[] { 1, 1, 1, 1, 1, 1, 5, 4 }, ExpectedResult = -1)]
        public int Find(int x,int[] inputSet)
        {
            return FrogRiverCrossing.Find(x, inputSet);
        }
    }
}