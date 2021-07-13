using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Problems._2021.July.FindPeekElement
{
    public class Solution
    {
        public int FindPeakElement(int[] nums)
        {
            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] < nums[i - 1])
                {
                    return i - 1;
                }
            }

            return nums.Length - 1;
        } 
    }
}
