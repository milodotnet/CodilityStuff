using System.Threading;

namespace Codility.Tests
{
    /// <summary>
    /// Codility Lesson3
    /// </summary>
    public class MaxCountersSolution
    {
        public static int[] Solve(int N, int[] A)
        {
            var M = A.Length;
            var max = 0;
            var maxChanged = false;

            int[] counters = new int[N];

            for (int k = 0; k < M; k++)
            {
                
                var Ak = A[k];
                if (Ak >= 1 && Ak <= N)
                {
                    //increase counter K
                    counters[Ak-1] += 1;
                    if (counters[Ak-1] > max)
                    { 
                        max = counters[Ak-1];
                        maxChanged = true;
                    }
                }
                if (Ak == N + 1 && maxChanged)
                {
                    //max counter                    
                    for (int i = 0; i < counters.Length; i++)
                    {
                        counters[i] = max;
                        maxChanged = false;
                    }
                }
            }

            return counters;
        }
    }
}