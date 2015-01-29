using Codility.PerfectChannel;
using NUnit.Framework;

namespace Codility.Tests.PerfectChannel
{
    public class KnightShortestPathShould
    {
        [TestCase(ExpectedResult = 7)]
        public int Should()
        {
            var inputs = new[]
            {
                new[] {0,0,0}, 
                new[] {0,0,1},
                new[] {1,0,0},
                new[] {0,0,0}
            };
            return KnightShortestPath.Solve(inputs);
        }
    }
}