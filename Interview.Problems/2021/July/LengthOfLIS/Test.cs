using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Interview.Problems._2021.July.LengthOfLIS
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
        public void Check(int[] nums1, int output)
        {
            var timer = Stopwatch.StartNew();
            var solution = new Solution();
            timer.Start();
            var actualOutput = solution.LengthOfLIS(nums1);
            timer.Stop();
            actualOutput.Should().Be(output);
            _outputHelper.WriteLine($"Duration = {timer.ElapsedTicks}");
        }


        [Theory]
        [MemberData(nameof(InputAndOutput))]
        public void CheckAnother(int[] nums1, int output)
        {
            var timer = Stopwatch.StartNew();
            var solution = new SolutionAnother();
            timer.Start();
            var actualOutput = solution.LengthOfLIS(nums1);
            timer.Stop();
            actualOutput.Should().Be(output);
            _outputHelper.WriteLine($"Duration = {timer.ElapsedTicks}");
        }

        public static IEnumerable<object[]> InputAndOutput => new List<object[]>
        {
            new object[]
            {
                new[] {10, 5, 8, 3, 9, 4, 12, 11},
                4
            },
            new object[]
            {
                new[] {3, 2, 1, 4, 7},
                3
            },
            new object[]
            {
                new[] {0, 0, 0, 0, 0},
                1
            },
            new object[]
            {
                new[] {0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
                2
            },
            new object[]
            {
                new[] {10, 9, 2, 5, 3, 7, 101, 18},
                4
            },
            new object[]
            {
                new[] {0, 1, 0, 3, 2, 3},
                4
            },
            new object[]
            {
                new[] {7, 7, 7, 7, 7, 7, 7},
                1
            },
            new object[]
            {
                Enumerable.Range(1, 4).ToArray(),
                4
            },
            new object[]
            {
                Enumerable.Range(1, 8).ToArray(),
                8
            },
            new object[]
            {
                Enumerable.Range(1, 16).ToArray(),
                16
            },
            new object[]
            {
                Enumerable.Range(1, 32).ToArray(),
                32
            },
            new object[]
            {
                Enumerable.Range(1, 64).ToArray(),
                64
            },
            new object[]
            {
                Enumerable.Range(1, 2048).ToArray(),
                2048
            },
        };
    }
}