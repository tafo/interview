using System;
using System.Collections.Generic;

namespace Interview.Problems._2021.July.GrayCode
{
    public class Solution
    {
        public IList<int> GrayCode(int n)
        {
            var result = new List<int> {0, 1};
            var i = 1;
            while (i < n)
            {
                var list = new List<int>(result);
                list.Reverse();
                for (var j = 0; j < result.Count; j++)
                {
                    list[j] += (int)Math.Pow(2, i);
                }
                result.AddRange(list);
                i++;
            }

            return result;
        }
    }

    public class SolutionAnother
    {
        public IList<int> GrayCode(int n)
        {
            var result = new List<int> {0, 1};
            var i = 1;
            while (i < n)
            {
                for (var j = result.Count - 1; j >= 0; j--)
                {
                    result.Add(result[j] + (int)Math.Pow(2, i));    
                }
                i++;
            }

            return result;
        }
    }
}