namespace Interview.Problems._2021.July.KthSmallest
{
    public class SolutionLibero
    {
        public int KthSmallest(int[][] matrix, int k)
        {
            var size = matrix.Length;
            var low = matrix[0][0];
            var high = matrix[size - 1][size - 1];
            while (low <= high)
            {
                var counter = 0;
                var mid = (low + high) / 2;
                for (var i = 0; i < size; i++)
                {
                    var j = 0;
                    while (j < size && matrix[i][j] <= mid)
                    {
                        j++;
                    }

                    counter += j;
                }

                if (counter < k)
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