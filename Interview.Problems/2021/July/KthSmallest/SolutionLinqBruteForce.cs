using System.Collections.Generic;
using System.Linq;

namespace Interview.Problems._2021.July.KthSmallest
{
    public class SolutionLinqBruteForce
    {
        public int KthSmallest(int[][] matrix, int k)
        {
            var set = new List<int>();
            
            for (var colIndex = 0; colIndex < matrix.Length; colIndex++)
                set.AddRange(matrix.Select(row => row[colIndex]));

            return set.OrderBy(x => x).Skip(k - 1).Take(1).Single();
        }
    }
}