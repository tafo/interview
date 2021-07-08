namespace Interview.Problems._2021.July.MatrixReshape
{
    public class Solution
    {
        public int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            var counter = mat.Length * mat[0].Length;
            if (counter != r * c)
            {
                return mat;
            }

            var result = new int[r][];
            result[0] = new int[c];
            var rowIndex = 0;
            var colIndex = 0;
            var colSize = mat[0].Length;
            for (var i = 0; i < r; i++)
            {
                result[i] = new int[c];
                for(var j = 0; j < c; j++)
                {
                    result[i][j] = mat[rowIndex][colIndex++];
                    if (colIndex == colSize)
                    {
                        colIndex = 0;
                        rowIndex++;
                    }
                }
            }

            return result;
        }
    }
}