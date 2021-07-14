namespace Interview.Problems._2021.July.FindPeakElement
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
