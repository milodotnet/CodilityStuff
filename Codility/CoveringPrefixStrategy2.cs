using System.Collections.Generic;

namespace Codility
{
    public class CoveringPrefixStrategy2 : ICoveringPrefixStrategy
    {
        public int Find(int[] A)
        {
            var numbersCovered = new List<int>();
            var indexOfLatestNewNumber = 0;

            for (var i = 0; i < A.Length; i++)
            {
                var currentNumber = A[i];

                if (!numbersCovered.Contains(currentNumber))
                {
                    numbersCovered.Add(currentNumber);
                    indexOfLatestNewNumber = i;
                }

            }
            return indexOfLatestNewNumber;
        }
    }
}