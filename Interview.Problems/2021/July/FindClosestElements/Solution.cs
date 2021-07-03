using System;
using System.Collections.Generic;
using System.Linq;

namespace Interview.Problems._2021.July.FindClosestElements
{
    public class Solution
    {
        public IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            return null;
        }

        public IList<int> FindClosestElementsLinq(int[] arr, int k, int x)
        {
            return arr
                .Select(num => new Number {Original = num, Difference = Math.Abs(num - x)})
                .OrderBy(n => n.Difference)
                .Take(k).Select(n => n.Original).OrderBy(n => n).ToList();
        }
    }

    public class Number
    {
        public int Difference { get; set; }
        public int Original { get; set; }
    }
}