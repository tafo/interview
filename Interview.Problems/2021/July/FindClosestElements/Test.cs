using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Interview.Problems._2021.July.FindClosestElements
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
        public void Check(int[] input, int k, int x, IList<int> output)
        {
            var timer = Stopwatch.StartNew();
            var solution = new Solution();
            timer.Start();
            var actualOutput = solution.FindClosestElements(input, k, x);
            timer.Stop();
            actualOutput.Should().BeEquivalentTo(output);
            _outputHelper.WriteLine($"Duration = {timer.ElapsedTicks}");
        }

        public static IEnumerable<object[]> InputAndOutput => new List<object[]>
        {
            new object[]
            {
                new[] {1,2,3,4,5},
                4,
                3,
                new[] {1,2,3,4}.ToList()
            },
            new object[]
            {
                new[] {1,2,3,4,5},
                4,
                -1,
                new[] {1,2,3,4}.ToList()
            },
        };
    }
}