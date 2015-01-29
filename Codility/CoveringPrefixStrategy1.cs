using System.Linq;

namespace Codility
{
    public class CoveringPrefixStrategy1 : ICoveringPrefixStrategy
    {
        public int Find(int[] A)
        {
            var distinctVals = A.Distinct().ToArray();

            for (var i = 0; i <= A.Length; i++)
            {
                var prefix = A.Take(i + 1);

                if (!distinctVals.Except(prefix).Any())
                    return i;

            }
            return A.Length - 1;
        }
    }
}