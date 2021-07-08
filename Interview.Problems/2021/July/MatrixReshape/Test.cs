using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Interview.Problems._2021.July.MatrixReshape
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
        public void Check(int[][] input, int r, int c, int[][] output)
        {
            var timer = Stopwatch.StartNew();
            var solution = new Solution();
            timer.Start();
            var actualOutput = solution.MatrixReshape(input, r, c);
            timer.Stop();
            for (var i = 0; i < actualOutput.Length; i++)
            {
                actualOutput[i].SequenceEqual(output[i]).Should().BeTrue();
            }

            _outputHelper.WriteLine($"Duration = {timer.ElapsedTicks}");
        }

        public static IEnumerable<object[]> InputAndOutput => new List<object[]>
        {
            new object[]
            {
                new[] {new[] {1, 2}, new[] {3, 4}},
                1,
                4,
                new[] {new[] {1, 2, 3, 4}}
            },
            new object[]
            {
                new[] {new[] {1, 2}, new[] {3, 4}},
                2,
                4,
                new[] {new[] {1, 2}, new[] {3, 4}},
            },
        };
    }
}