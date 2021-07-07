using System.Collections.Generic;
using System.Linq;

namespace Interview.Problems._2021.July.MaxSumSubMatrix
{
    public class SolutionBruteForce
    {
        public int MaxSumSubmatrix(int[][] matrix, int k)
        {
            var sumList = new List<int>();

            for (var i = 0; i < matrix.Length; i++)
            {
                var rectangle = matrix[i];
                sumList.AddRange(GetSumListOfRectangles(rectangle));
                for (var j = i + 1; j < matrix.Length; j++)
                {
                    rectangle = rectangle.Zip(matrix[j], (x, y) => x + y).ToArray();
                    sumList.AddRange(GetSumListOfRectangles(rectangle));
                }
            }

            return sumList.Where(x => x <= k).Max();

            IEnumerable<int> GetSumListOfRectangles(IReadOnlyList<int> arr)
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