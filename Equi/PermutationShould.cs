using System.Dynamic;
using System.Linq;
using NUnit.Framework;

namespace Codility.Tests
{
    public class PermutationShould
    {
        [TestCase(new[] { 4,1,3,2},ExpectedResult = 1)]
        [TestCase(new[] { 4,  3, 2 }, ExpectedResult = 0)]
        public int FindPermutations(int[] inputSet)
        {
            return Permutation.Check(inputSet);
        }

    }
}