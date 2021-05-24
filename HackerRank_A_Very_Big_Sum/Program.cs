using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank_A_Very_Big_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

            long result = Result.aVeryBigSum(ar);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
