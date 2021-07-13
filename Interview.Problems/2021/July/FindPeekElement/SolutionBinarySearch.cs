using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Problems._2021.July.FindPeekElement
{
    public class SolutionBinarySearch
    {
        public int FindPeakElement(int[] nums)
        {
            var left = 0;
            var right = nums.Length - 1;
            while (left < right)
            {
                var mid = (left + right) / 2;
                if (nums[mid] > nums[mid + 1])
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return left;
        }
    }
}
