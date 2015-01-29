using System.Diagnostics;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Codility.Tests
{
    public class MissingIntShould
    {
        [TestCase(new[]{1,3,6,4,1,2}, ExpectedResult=5)]
        [TestCase(new[] { 1, 3, 6, 4, 1, 2,5 }, ExpectedResult = 7)]
        [TestCase(new[] { int.MaxValue }, ExpectedResult = 1)]
        [TestCase(new[] { int.MinValue, int.MaxValue }, ExpectedResult = 1)]
        public int Should(int[] inputs)
        {
            return MissingInteger.Solve(inputs);
        }
    }
}