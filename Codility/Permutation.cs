using System.Collections.Generic;

namespace Codility
{
    public class Permutation
    {
        public static int Check(int[] A)
        {
            long expectedSum = 0;
            long actualSum = 0;

            var distinctMap = new HashSet<long>();

            for (var i = 0; i < A.Length; i++)
            {
                expectedSum += (i + 1);
                if (distinctMap.Contains(A[i]))
                    return 0;

                distinctMap.Add(A[i]);

            }

            for (var i = 0; i < A.Length; i++)
            {
                actualSum += A[i];
            }

            return (expectedSum - actualSum == 0) ? 1 : 0;  
        }
    }


    
}
