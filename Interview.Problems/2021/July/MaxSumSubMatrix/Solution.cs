using System;
using System.Collections.Generic;
using System.Linq;

namespace Interview.Problems._2021.July.MaxSumSubMatrix
{
    public class Solution
    {
        public int MaxSumSubmatrix(int[][] matrix, int k)
        {
            var currentMax = MaxSubArraySum(matrix[0]);
            if (matrix.Length == 1)
            {
                return currentMax;
            }

            var output = currentMax;

            for (var i = 0; i < matrix.Length - 1; i++)
            {
                var summingArray = matrix[i];
                output = Math.Max(output, MaxSubArraySum(summingArray));
                for (var j = i + 1; j < matrix.Length; j++)
                {
                    summingArray = summingArray.Zip(matrix[j], (x, y) => x + y).ToArray();
                    currentMax = MaxSubArraySum(summingArray);
                    output = Math.Max(output, currentMax);
                }
            }

            return output;

            int MaxSubArraySum(IReadOnlyList<int> arr)
            {
                var result = arr[0];
                var max = arr[0];
                for (var i = 1; i < arr.Count; i++)
                {
                    max = Math.Max(arr[i], max + arr[i]);
                    if (max <= k)
                    {
                        result = Math.Max(result, max);
                    }
                }

                return result;
            }
        }
    }
}