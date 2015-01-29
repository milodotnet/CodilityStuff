using System;
using System.Linq;

namespace Codility
{
    public class EquivalenceIndex
    {
        public static int Find(int[] numbers)
        {
            if (numbers.Length == 0)
                return -1;

            var asLong = numbers.Select(Convert.ToInt64).ToArray();

            long sumBefore = 0;
            long sumAfter = asLong.Skip(1).Sum();

            if (sumAfter == sumBefore) return 0;

            for (var i = 1; i < asLong.Length; i++)
            {


                sumBefore += asLong[i - 1];

                if (i == asLong.Length - 1)
                {
                    sumAfter = 0;
                }
                else
                {
                    sumAfter -= asLong[i];
                }
                if (sumAfter == sumBefore)
                    return i;

            }

            return -1;
        }
    }
}
