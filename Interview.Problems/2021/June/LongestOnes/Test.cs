using System.Collections.Generic;
using System.Diagnostics;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Interview.Problems._2021.June.LongestOnes
{
    public class Test
    {
        private readonly ITestOutputHelper _outputHelper;

        public Test(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Theory]
        [MemberData(nameof(InputAndOutput))]
        public void Check(int[] input, int k, int output)
        {
            var timer = Stopwatch.StartNew();
            var solution = new Solution();
            timer.Start();
            var actualOutput = solution.LongestOnes(input, k);
            timer.Stop();
            actualOutput.Should().Be(output);
            _outputHelper.WriteLine($"Duration = {timer.ElapsedTicks}");
        }

        public static IEnumerable<object[]> InputAndOutput => new List<object[]>
        {
            new object[]
            {
                new[] {1,1,1,0,0,0,1,1,1,1,0},
                2,
                6
            },
            new object[]
            {
                new[] {0,0,1,1,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1},
                3,
                10
            },
            new object[]
            {
                new[] {1,0,1,0,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1},
                3,
                9
            },
            new object[]
            {
                new[] {1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1},
                3,
                7
            },
        };
    }
}