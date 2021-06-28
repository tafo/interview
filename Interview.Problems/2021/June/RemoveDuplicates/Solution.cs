using System.Collections.Generic;
using System.Linq;

namespace Interview.Problems._2021.June.RemoveDuplicates
{
    public class Solution
    {
        public string RemoveDuplicates(string s)
        {
            var letterStack = new Stack<char>();
            letterStack.Push(s[^1]);
            for (var i = s.Length - 2; i >= 0; i--)
            {
                if (letterStack.TryPeek(out var pre) && pre == s[i])
                {
                    letterStack.Pop();
                }
                else
                {
                    letterStack.Push(s[i]);
                }
            }

            return string.Concat(letterStack);
        }
    }
}