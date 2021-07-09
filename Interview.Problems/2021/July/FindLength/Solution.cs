using System;

namespace Interview.Problems._2021.July.FindLength
{
    public class Solution
    {
        public int FindLength(int[] nums1, int[] nums2)
        {
            var result = 0;

            var dp = new int[nums1.Length + 1][];

            for (var i = 0; i < nums1.Length + 1; i++)
            {
                dp[i] = new int[nums2.Length + 1];
                for (var j = 0; j < nums2.Length + 1; j++)
                {
                    if (i == 0 || j == 0) continue;
                    if (nums1[i - 1] != nums2[j - 1]) continue;
                    dp[i][j] = dp[i - 1][j - 1] + 1;
                    result = Math.Max(result, dp[i][j]);
                }
            }

            return result;
        }
    }
}