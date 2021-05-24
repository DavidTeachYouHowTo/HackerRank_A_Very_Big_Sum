using System.Collections.Generic;

namespace HackerRank_A_Very_Big_Sum
{
    public class Result
    {
        /*
         * Complete the 'aVeryBigSum' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts LONG_INTEGER_ARRAY ar as parameter.
        */

        public static long aVeryBigSum(List<long> ar)
        {
            long sum = 0;

            for (int i = 0; i < ar.Count; i++)
            {
                sum += ar[i];
            }

            return sum;
        }
    }
}
