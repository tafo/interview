using System;
using System.Linq;

namespace Interview.Problems._2021.July.FindLength
{
    public class SolutionAnother
    {
        public int FindLength(int[] nums1, int[] nums2)
        {
            var dp = new int[nums1.Length + 1][];
            dp[0] = new int[nums2.Length + 1];
            for (var i = 1; i < nums1.Length + 1; i++)
            {
                dp[i] = new int[nums2.Length + 1];
                for (var j = 1; j < nums2.Length + 1; j++)
                {
                    if (nums1[i - 1] == nums2[j - 1])
                    {
                        dp[i][j] = dp[i - 1][j - 1] + 1;
                    }
                }
            }

            return dp.Max(row => row.Max(x => x));
        }
    }
}