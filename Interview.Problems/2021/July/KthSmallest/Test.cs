using System.Collections.Generic;
using System.Diagnostics;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Interview.Problems._2021.July.KthSmallest
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
            var solution = new SolutionLinqBruteForce();
            timer.Start();
            var actualOutput = solution.KthSmallest(input, k);
            timer.Stop();
            actualOutput.Should().Be(output);
            _outputHelper.WriteLine($"Duration = {timer.ElapsedTicks}");
        }

        [Theory]
        [MemberData(nameof(InputAndOutput))]
        public void CheckBest(int[][] input, int k, int output)
        {
            var timer = Stopwatch.StartNew();
            var solution = new SolutionLinqAndBinarySearch();
            timer.Start();
            var actualOutput = solution.KthSmallest(input, k);
            timer.Stop();
            actualOutput.Should().Be(output);
            _outputHelper.WriteLine($"Duration = {timer.ElapsedTicks}");
        }

        [Theory]
        [MemberData(nameof(InputAndOutput))]
        public void CheckLibero(int[][] input, int k, int output)
        {
            var timer = Stopwatch.StartNew();
            var solution = new SolutionLibero();
            timer.Start();
            var actualOutput = solution.KthSmallest(input, k);
            timer.Stop();
            actualOutput.Should().Be(output);
            _outputHelper.WriteLine($"Duration = {timer.ElapsedTicks}");
        }

        public static IEnumerable<object[]> InputAndOutput => new List<object[]>
        {
            new object[]
            {
                new[] {new[] {1, 5, 9}, new[] {10, 11, 13}, new []{12, 13, 15}},
                8,
                13,
            },
            new object[]
            {
                new[] {new[] {1, 5, 9, 11}, new[] {10, 11, 13, 14}, new []{12, 13, 15, 17}, new []{17, 19, 20, 22}},
                10,
                14,
            },
            new object[]
            {
                new[] {new[] {1,4,7,11,15}, new[] {2,5,8,12,19}, new []{3,6,9,16,22}, new []{10,13,14,17,24}, new []{18,21,23,26,30}},
                5,
                5,
            },
            new object[]
            {
                new[] {new[] {-5}},
                1,
                -5,
            },
            new object[]
            {
                new[] {new[] {1, 2}, new []{1, 3}},
                4,
                3,
            },
        };
    }
}