using System.Collections.Generic;
using System.Diagnostics;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Interview.Problems._2021.July.GrayCode
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
            var solution = new Solution();
            timer.Start();
            var actualOutput = solution.GrayCode(n);
            timer.Stop();
            actualOutput.Should().BeEquivalentTo(output);
            _outputHelper.WriteLine($"Duration = {timer.ElapsedTicks}");
        }

        [Theory]
        [MemberData(nameof(InputAndOutput))]
        public void CheckAnother(int n, List<int> output)
        {
            var timer = Stopwatch.StartNew();
            var solution = new SolutionAnother();
            timer.Start();
            var actualOutput = solution.GrayCode(n);
            timer.Stop();
            actualOutput.Should().BeEquivalentTo(output);
            _outputHelper.WriteLine($"Duration = {timer.ElapsedTicks}");
        }

        public static IEnumerable<object[]> InputAndOutput => new List<object[]>
        {
            new object[]
            {
                1,
                new List<int> {0, 1},
            },
            new object[]
            {
                2,
                new List<int> {0, 1, 3, 2},
            },
            new object[]
            {
                3,
                new List<int> {0, 1, 3, 2, 6, 7, 5, 4},
            },
            new object[]
            {
                4,
                new List<int> {0, 1, 3, 2, 6, 7, 5, 4, 12, 13, 15, 14, 10, 11, 9, 8},
            },
        };
    }
}