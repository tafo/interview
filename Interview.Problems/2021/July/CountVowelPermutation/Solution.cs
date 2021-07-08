using System.Collections.Generic;

namespace Interview.Problems._2021.July.CountVowelPermutation
{
    public class Solution
    {
        public int CountVowelPermutation(int n)
        {
            if (n == 1)
            {
                return 5;
            }
            const int mod = 1000000007;
            var charA = new Character {PreviousGrandChildrenCount = 1};
            var charE = new Character {PreviousGrandChildrenCount = 2};
            var charI = new Character {PreviousGrandChildrenCount = 4};
            var charO = new Character {PreviousGrandChildrenCount = 2};
            var charU = new Character {PreviousGrandChildrenCount = 1};

            charA.Children = new List<Character> {charE};
            charE.Children = new List<Character> {charA, charI};
            charI.Children = new List<Character> {charA, charE, charO, charU};
            charO.Children = new List<Character> {charI, charU};
            charU.Children = new List<Character> {charA};

            long result = 0;
            var level = 2;
            var list = new List<Character> { charA, charE, charI, charO, charU };

            while (level < n)
            {
                foreach (var character in list)
                {
                    character.CurrentGrandChildrenCount = 0;
                    foreach (var childCharacter in character.Children)
                    {
                        character.CurrentGrandChildrenCount += childCharacter.PreviousGrandChildrenCount;
                    }
                }

                foreach (var character in list)
                {
                    character.PreviousGrandChildrenCount = character.CurrentGrandChildrenCount % mod;
                }

                level++;
            }

            foreach (var character in list)
            {
                result += character.PreviousGrandChildrenCount;
                if (result > mod)
                {
                    result %= mod;
                }
            }

            return (int)result;
        }
    }

    public class Character
    {
        public List<Character> Children { get; set; }
        public long PreviousGrandChildrenCount { get; set; }
        public long CurrentGrandChildrenCount { get; set; }
    }
}