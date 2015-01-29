namespace Codility
{
    public class FrogRiverCrossing
    {
        public static int Find(int x, int[] A)
        {

            var river = new int?[x + 1];
            int sum = 0;
            for (int i = 1; i <= x; i++)
                sum += i;

            for (int minute = 0; minute < A.Length; minute++)
            {
                var riverPosition = A[minute];
                if (!river[riverPosition].HasValue)
                {
                    river[riverPosition] = minute;
                    sum -= riverPosition;
                }
                if (sum == 0)
                {
                    return minute;
                }
            }

            return -1;


        }
    }
}