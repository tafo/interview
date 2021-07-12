using System.Collections.Generic;
using System.Linq;

namespace Interview.Problems._2021.July.IsIsomorphic
{
    public class Solution
    {
        public bool IsIsomorphic(string s, string t)
        {
            var charSet = new Dictionary<char, char>();
            for (var i = 0; i < s.Length; i++)
            {
                if (charSet.ContainsKey(s[i]))
                {
                    if(charSet[s[i]] == t[i])continue;
                    return false;
                }

                if (charSet.Values.Contains(t[i])) return false;
                charSet.Add(s[i], t[i]);
            }
            
            return true;
        }
    }
}
