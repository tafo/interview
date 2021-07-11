using System.Collections.Generic;
using System.Diagnostics;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Interview.Problems._2021.July.NumDecodings
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
        public void Check(string input, int output)
        {
            var timer = Stopwatch.StartNew();
            var solution = new Solution();
            timer.Start();
            var actualOutput = solution.NumDecodings(input);
            timer.Stop();
            actualOutput.Should().Be(output);
            _outputHelper.WriteLine($"Duration = {timer.ElapsedTicks}");
        }

        public static IEnumerable<object[]> InputAndOutput => new List<object[]>
        {
            new object[]
            {
                "12*",
                24
            },
            new object[]
            {
                "12*3",
                28
            },
            new object[]
            {
                "12*3*",
                252
            },
            new object[]
            {
                "12*3*7",
                280
            },
            new object[]
            {
                "12*3*1",
                308
            },
            new object[]
            {
                "3",
                1
            },
            new object[]
            {
                "3*",
                9
            },
            new object[]
            {
                "3*3",
                11
            },
            new object[]
            {
                "3*3*",
                99
            },
            new object[]
            {
                "*",
                9
            },
            new object[]
            {
                "**",
                96
            },
            new object[]
            {
                "***",
                999
            },
            new object[]
            {
                "****",
                10431
            },
            new object[]
            {
                "*1",
                11
            },
            new object[]
            {
                "1*",
                18
            },
            new object[]
            {
                "2*",
                15
            },
            new object[]
            {
                "1*1",
                20
            },
            new object[]
            {
                "*1*",
                180
            },
            new object[]
            {
                "1*1*",
                342
            },
            new object[]
            {
                "1*1*1",
                382
            },
            new object[]
            {
                "2*2*2",
                277
            },
            new object[]
            {
                "7*9*3*6*3*0*5*4*9*7*3*7*1*8*3*2*0*0*6*",
                196465252
            },
        };
    }
}