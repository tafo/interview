using System;
using System.Collections.Generic;
using System.Linq;

namespace Interview.Problems._2021.July.MaxSumSubMatrix
{
    public class Solution
    {
        public int MaxSumSubmatrix(int[][] matrix, int k)
        {
            var sumList = new List<int>();
            for (var i = 0; i < matrix.Length; i++)
            {
                var rectangle = matrix[i];
                sumList.Add(CalculateMax(rectangle));
                for (var j = i + 1; j < matrix.Length; j++)
                {
                    rectangle = Zip(rectangle, matrix[j]);
                    sumList.Add(CalculateMax(rectangle));
                }
            }

            return sumList.Max();

            int CalculateMax(IReadOnlyList<int> rowSum)
            {
                var max = int.MinValue;
                for (var i = 0; i < rowSum.Count; i++)
                {
                    var sum = 0;
                    for (var j = i; j < rowSum.Count; j++)
                    {
                        sum += rowSum[j];
                        if (sum <= k)
                        {
                            max = Math.Max(sum, max);
                        }
                    }
                }
                return max;
            }

            int[] Zip(int[] arr1, int[] arr2)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    arr1[i] += arr2[i];
                }

                return arr1;
            }
        }
    }
}