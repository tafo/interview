using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Interview.Problems._2021.July.FindPeekElement
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
        public void Check(int[] nums, int[] expectedOutputs)
        {
            var timer = Stopwatch.StartNew();
            var solution = new Solution();
            timer.Start();
            var actualOutput = solution.FindPeakElement(nums);
            timer.Stop();
            expectedOutputs.Contains(actualOutput).Should().BeTrue();
            _outputHelper.WriteLine($"Duration = {timer.ElapsedTicks}");
        }
        [Theory]
        [MemberData(nameof(InputAndOutput))]
        public void CheckAnother(int[] nums, int[] expectedOutputs)
        {
            var timer = Stopwatch.StartNew();
            var solution = new SolutionBinarySearch();
            timer.Start();
            var actualOutput = solution.FindPeakElement(nums);
            timer.Stop();
            expectedOutputs.Contains(actualOutput).Should().BeTrue();
            _outputHelper.WriteLine($"Duration = {timer.ElapsedTicks}");
        }

        public static IEnumerable<object[]> InputAndOutput => new List<object[]>
        {
            new object[]
            {
                new[] {1, 2, 3, 1},
                new[] {2}
            },
            new object[]
            {
                new[] {1, 2, 1, 3, 5, 6, 4},
                new[] {1, 5}
            },     
            new object[]
            {
                new[] {1},
                new[] {0}
            },
            new object[]
            {
                new[] {1, 2},
                new[] {1}
            },
        };
    }
}
