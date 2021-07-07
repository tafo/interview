using System;
using System.Collections.Generic;
using System.Linq;

namespace Interview.Problems._2021.July.MaxSumSubMatrix
{
    public class SolutionAnother
    {
        public int MaxSumSubmatrix(int[][] matrix, int k)
        {
            var result = int.MinValue;
            var rowSum = new int[matrix[0].Length];
            for (var i = 0; i < matrix.Length; i++)
            {
                Array.Fill(rowSum, 0);
                for (var row = i; row < matrix.Length; row++)
                {
                    for (var col = 0; col < matrix[0].Length; col++)
                        rowSum[col] += matrix[row][col];

                    var sum = 0;

                    var sortedSum = new SortedSet<int> {0};

                    foreach (var num in rowSum) {
                        sum += num;

                        var view = sortedSum.GetViewBetween(sum - k, int.MaxValue);

                        if (view.Count > 0)
                            result = Math.Max(result, sum - view.First());

                        sortedSum.Add(sum);
                    }

                    if (result == k)
                        return result;
                }
            }

            return result;
        }
    }
}