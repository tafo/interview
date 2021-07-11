using System.Collections.Generic;

namespace Interview.Problems._2021.July.LengthOfLIS
{
    public class Solution
    {
        public int LengthOfLIS(int[] nums)
        {
            var piles = new List<int>();
            foreach (var num in nums)
            {
                var found = false;
                for (var j = 0; j < piles.Count; j++)
                {
                    if (piles[j] > num)
                    {
                        piles[j] = num;
                        found = true;
                        break;
                    }

                    if (piles[j] == num)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    piles.Add(num);
                }
            }

            return piles.Count;
        }
    }
}