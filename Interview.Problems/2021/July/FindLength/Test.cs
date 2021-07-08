using System.Collections.Generic;
using System.Diagnostics;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Interview.Problems._2021.July.FindLength
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
        public void Check(int n, List<int> output)
        {
            var timer = Stopwatch.StartNew();
            var solution = new GrayCode.Solution();
            timer.Start();
            var actualOutput = solution.GrayCode(n);
            timer.Stop();
            actualOutput.Should().BeEquivalentTo(output);
            _outputHelper.WriteLine($"Duration = {timer.ElapsedTicks}");
        }

        [Theory]
        [MemberData(nameof(InputAndOutput))]
        public void CheckAnother(int[] nums1, int[] nums2, int output)
        {
            var timer = Stopwatch.StartNew();
            var solution = new Solution();
            timer.Start();
            var actualOutput = solution.FindLength(nums1, nums2);
            timer.Stop();
            actualOutput.Should().Be(output);
            _outputHelper.WriteLine($"Duration = {timer.ElapsedTicks}");
        }

        public static IEnumerable<object[]> InputAndOutput => new List<object[]>
        {
            new object[]
            {
                new[] {1, 2, 3, 2, 1},
                new[] {3, 2, 1, 4, 7},
                3
            },
            new object[]
            {
                new[] {0, 0, 0, 0, 0},
                new[] {0, 0, 0, 0, 0},
                5
            },
        };
    }
}