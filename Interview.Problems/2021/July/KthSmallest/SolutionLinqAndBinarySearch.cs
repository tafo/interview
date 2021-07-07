using System;
using System.Collections.Generic;
using System.Linq;

namespace Interview.Problems._2021.July.KthSmallest
{
    public class SolutionLinqAndBinarySearch
    {
        public int KthSmallest(int[][] matrix, int k)
        {
            var low = matrix.First().First();
            var high = matrix.Last().Last();

            while (low <= high)
            {
                var mid = (low + high) / 2;

                var count = matrix.Sum(row => row.Count(x => x <= mid));

                if (count < k)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return low;
        }
    }
}