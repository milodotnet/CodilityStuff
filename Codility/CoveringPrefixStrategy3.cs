using System.Collections.Generic;

namespace Codility
{
    public class CoveringPrefixStrategy3 : ICoveringPrefixStrategy
    {
        public  int Find(int[] A)
        {
            var numberMap = new Dictionary<int, int>();
            var indexOfLatestNewNumber = 0;

            for (var i = 0; i < A.Length; i++)
            {
                var currentNumber = A[i];
                //ermaghard, map key lookup so fast
                if (!numberMap.ContainsKey(currentNumber))
                {
                    numberMap.Add(currentNumber, i);
                    indexOfLatestNewNumber = i;
                }

            }
            return indexOfLatestNewNumber;
        }
    }
}