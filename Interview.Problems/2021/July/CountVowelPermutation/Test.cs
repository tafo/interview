using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Interview.Problems._2021.July.CountVowelPermutation
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
        public void Check(int n, int output)
        {
            var timer = Stopwatch.StartNew();
            var solution = new Solution();
            timer.Start();
            var actualOutput = solution.CountVowelPermutation(n);
            timer.Stop();
            actualOutput.Should().Be(output);
            _outputHelper.WriteLine($"Duration = {timer.ElapsedTicks}");
        }

        public static IEnumerable<object[]> InputAndOutput => new List<object[]>
        {
            new object[]
            {
                1,
                5,
            },
            new object[]
            {
                2,
                10,
            },
            new object[]
            {
                4,
                35,
            },
            new object[]
            {
                8,
                474,
            },
            new object[]
            {
                16,
                85691,
            },
            new object[]
            {
                32,
                789289148,
            },
            new object[]
            {
                64,
                439539116,
            },
            new object[]
            {
                128,
                388863806,
            },
            new object[]
            {
                256,
                153577260,
            },
        };
    }
}