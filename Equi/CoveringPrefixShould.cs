using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Codility.Tests
{
    public class CoveringPrefixShould
    {
        [TestCase(ExpectedResult = 0)]
        public int RunLongCP()
        {
            var numbers = new List<int>();
            for (var i = 0; i < 100000; i++)
            {
                numbers.Add(1);
            }

            return CoveringPrefix.Find<CoveringPrefixStrategy1>(numbers.ToArray());
        }

        [TestCase(ExpectedResult = 99999)]
        public int RunLongCP2()
        {
            var numbers = new List<int>();
            for (var i = 0; i < 100000; i++)
            {
                numbers.Add(i);
            }

            return CoveringPrefix.Find<CoveringPrefixStrategy2>(numbers.ToArray());
        }

        [TestCase(ExpectedResult = 99999)]
        public int RunLongCP3()
        {
            var numbers = new List<int>();
            for (var i = 0; i < 100000; i++)
            {
                numbers.Add(i);
            }

            return CoveringPrefix.Find<CoveringPrefixStrategy3>(numbers.ToArray());
        }




        [TestCase(new[] {2, 2, 1, 0, 1}, ExpectedResult = 3)]
        public int RunCp(int[] numbers)
        {

            return CoveringPrefix.Find<CoveringPrefixStrategy2>(numbers.ToArray());
        }


    }

}