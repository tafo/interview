using System.Collections.Generic;
using System.Linq;

namespace Interview.Problems._2021.July.CustomSortString
{
    public class Solution
    {
        public string CustomSortString(string order, string str)
        {
            return string.Join("", str.OrderBy(x => x, new CharComparer(order)));
        }
    }

    public class CharComparer : IComparer<char>
    {
        private readonly string _order;
        
        public CharComparer(string order)
        {
            _order = order;
        }

        public int Compare(char x, char y)
        {
            return _order.IndexOf(x).CompareTo(_order.IndexOf(y));
        }
    }
}
