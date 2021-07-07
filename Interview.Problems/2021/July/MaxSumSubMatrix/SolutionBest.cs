using System;

namespace Interview.Problems._2021.July.MaxSumSubMatrix
{
    public class SolutionBest
    {
        public int MaxSumSubmatrix(int[][] matrix, int k)
        {
            var ans = int.MinValue;

            for (var i = 0; i < matrix[0].Length; i++)
            {
                var rowSum = new int[matrix.Length];
                for (var colIndex = i; colIndex < matrix[0].Length; colIndex++)
                {
                    for (var rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
                    {
                        rowSum[rowIndex] += matrix[rowIndex][colIndex];
                    }

                    var max = CalculateMax(rowSum);
                    if (max <= k)
                        ans = Math.Max(ans, max);
                }
            }

            return ans;

            int CalculateMax(int[] rowSum)
            {
                var max = int.MinValue;
                for (var i = 0; i < rowSum.Length; i++)
                {
                    var sum = 0;
                    for (var j = i; j < rowSum.Length; j++)
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
        }
    }
}