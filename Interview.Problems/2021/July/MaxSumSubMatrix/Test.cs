using System.Collections.Generic;
using System.Diagnostics;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Interview.Problems._2021.July.MaxSumSubMatrix
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
        public void Check(int[][] input, int k, int output)
        {
            var timer = Stopwatch.StartNew();
            var solution = new Solution();
            timer.Start();
            var actualOutput = solution.MaxSumSubmatrix(input, k);
            timer.Stop();
            actualOutput.Should().Be(output);
            _outputHelper.WriteLine($"Duration = {timer.ElapsedTicks}");
        }

        public static IEnumerable<object[]> InputAndOutput => new List<object[]>
        {
            new object[]
            {
                new[] {new[] {1, 0, 1}, new[] {0, -2, 3}},
                2,
                2,
            },
            new object[]
            {
                new[] {new[] {2, 2, -1}},
                3,
                3,
            },
            new object[]
            {
                new[] {new[] {2, 2, -1}},
                0,
                -1,
            },
            new object[]
            {
                new[] {new[] {4, 4, 2}},
                3,
                2,
            },
            new object[]
            {
                new[]
                {
                    new[] {2, 1, -3, -4, 5}, new[] {0, 6, 3, 4, 1}, new[] {2, -2, -1, 4, -5}, new[] {-3, 3, 1, 0, 3}
                },
                30,
                18,
            },
        };
    }
}