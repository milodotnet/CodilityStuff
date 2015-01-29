using System.Linq;
using NUnit.Framework;

namespace Codility.Tests
{
    public class MaxCountersTests
    {
        [Test]
        public void Solve()
        {
            var A = new []{3,4,4,6,1,4,4};
            var solution = MaxCountersSolution.Solve(5, A);

            Assert.AreEqual(5, solution.Length);
            Assert.AreEqual(3, solution[0]);
            Assert.AreEqual(2, solution[1]);
            Assert.AreEqual(2, solution[2]);
            Assert.AreEqual(4, solution[3]);
            Assert.AreEqual(2, solution[4]);
        }

        [Test]
        public void SolveExtreme()
        {
            var A = new int[100000];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = 100001;
            }
            var solution = MaxCountersSolution.Solve(100000, A);

            Assert.AreEqual(100000, solution.Length);
            Assert.AreEqual(0, solution[0]);
            Assert.AreEqual(0, solution[99999]);
        }

    }
}