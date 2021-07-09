using System;
using System.Collections.Generic;
using System.Linq;

namespace Interview.Problems._2021.July.LengthOfLIS
{
    public class SolutionAnother
    {
        public int LengthOfLIS(int[] nums)
        {
            var maxList = new List<int> {1};

            for (var i = 1; i < nums.Length; i++)
            {
                var max = 1;
                for (var j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        max = Math.Max(max, maxList[j] + 1);
                    }
                }

                maxList.Add(max);
            }

            return maxList.Max();
        }
    }
}