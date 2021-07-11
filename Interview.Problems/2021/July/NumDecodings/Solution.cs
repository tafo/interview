namespace Interview.Problems._2021.July.NumDecodings
{
 public class Solution
    {
        public int NumDecodings(string s)
        {
            const int modulo = 1000000007;
            long result = 1;
            long previousWays = 1;
            var one = false;
            var two = false;
            foreach (var ch in s)
            {
                long ways;
                if (ch == '*')
                {
                    ways = result * 9;
                    if (one)
                    {
                        ways += 9 * previousWays;
                    }

                    if (two)
                    {
                        ways += 6 * previousWays;
                    }

                    one = true;
                    two = true;
                }
                else
                {
                    ways = ch > '0' ? result : 0;
                    if (one)
                    {
                        ways += previousWays;
                    }

                    if (two && ch <= '6')
                    {
                        ways += previousWays;
                    }

                    one = ch == '1';
                    two = ch == '2';
                }

                previousWays = result;
                result = ways % modulo;
            }

            return (int)result;
        }
    }
}