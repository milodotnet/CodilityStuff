using System.Linq;

namespace Codility
{
    public class MissingInteger
    {
        public static int Solve(int[] A)
        {
            var ordered = A.OrderBy(i => i);
            var previousPositive = 0;

            foreach (var num in ordered)
            {
                if (num > 0)
                {
                    var dif = num - previousPositive;
                    if (dif > 1)
                        return previousPositive + 1;
                    previousPositive = num;
                }

            }
            return previousPositive + 1;
        }
    }
}