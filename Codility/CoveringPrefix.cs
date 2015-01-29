using System;

namespace Codility
{
    public class CoveringPrefix
    {

        public static int Find<T>(int[] A) where T : ICoveringPrefixStrategy
        {
            return Activator.CreateInstance<T>().Find(A);
        }
    }
}