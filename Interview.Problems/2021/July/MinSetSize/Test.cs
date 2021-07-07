using System.Collections.Generic;
using System.Diagnostics;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Interview.Problems._2021.July.MinSetSize
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
        public void Check(int[] input, int output)
        {
            var timer = Stopwatch.StartNew();
            var solution = new Solution();
            timer.Start();
            var actualOutput = solution.MinSetSize(input);
            timer.Stop();
            actualOutput.Should().Be(output);
            _outputHelper.WriteLine($"Duration = {timer.ElapsedTicks}");
        }

        public static IEnumerable<object[]> InputAndOutput => new List<object[]>
        {
            new object[]
            {
                new[] {3, 3, 3, 3, 5, 5, 5, 2, 2, 7},
                2
            },
            new object[]
            {
                new[] {7, 7, 7, 7, 7, 7},
                1
            },
            new object[]
            {
                new[] {1, 9},
                1
            },
            new object[]
            {
                new[] {1000, 1000, 3, 7},
                1
            },
            new object[]
            {
                new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                5
            },
            new object[]
            {
                new[] {9, 77, 63, 22, 92, 9, 14, 54, 8, 38, 18, 19, 38, 68, 58, 19},
                5
            },
        };
    }
}