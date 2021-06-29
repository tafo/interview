using System.Collections.Generic;
using System.Linq;

namespace Interview.Problems._2021.June.LongestOnes
{
    public class Solution
    {
        public int LongestOnes(int[] nums, int k)
        {
            int i = 0, j;
            for (j = 0; j < nums.Length; j++)
            {
                if (nums[j] == 0) k--;
                if (k < 0 && nums[i++] == 0) k++;
            }
            return j - i;
        }
    }
}