using System;
using System.Collections.Generic;
using System.Linq;

namespace Interview.Problems._2021.July.MaxSumSubMatrix
{
    public class Solution
    {
        public int MaxSumSubmatrix(int[][] matrix, int k)
        {
            var output = new List<int>();

            for (var i = 0; i < matrix.Length; i++)
            {
                var rectangle = matrix[i];
                output.AddRange(GetSumListOfRectangles(rectangle));
                for (var j = i + 1; j < matrix.Length; j++)
                {
                    rectangle = rectangle.Zip(matrix[j], (x, y) => x + y).ToArray();
                    output.AddRange(GetSumListOfRectangles(rectangle));
                }
            }

            var filteredList = output.Where(x => x <= k).ToList();

            return filteredList.Max();

            static IEnumerable<int> GetSumListOfRectangles(IReadOnlyList<int> arr)
            {
                var resultList = new List<int>();
                for (var i = 0; i < arr.Count; i++)
                {
                    var sum = arr[i];
                    resultList.Add(sum);
                    for (var j = i + 1; j < arr.Count; j++)
                    {
                        sum += arr[j];
                        resultList.Add(sum);
                    }
                }

                return resultList;
            }
        }
    }
}