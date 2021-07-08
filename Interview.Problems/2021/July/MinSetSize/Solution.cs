using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Interview.Problems._2021.July.MinSetSize
{
    public class Solution
    {
        public int MinSetSize(int[] arr)
        {
            var dict = new Dictionary<int, int>();
            foreach (var number in arr)
            {
                if (dict.ContainsKey(number))
                {
                    dict[number]++;
                }
                else
                {
                    dict.Add(number, 1);
                }
            }

            var counters = dict.OrderByDescending(x => x.Value);

            var i = 0;
            var size = 0;
            var target = arr.Length / 2;
            foreach (var pair in counters)
            {
                if (size < target)
                {
                    size += pair.Value;
                    i++;
                }
                else
                {
                    return i;
                }
            }

            return i;
        }
    }
}