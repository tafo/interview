﻿using System.Collections.Generic;
using System.Diagnostics;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Interview.Problems._2021.July.IsIsomorphic
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
        public void Check(string s, string t, bool output)
        {
            var timer = Stopwatch.StartNew();
            var solution = new Solution();
            timer.Start();
            var actualOutput = solution.IsIsomorphic(s, t);
            timer.Stop();
            actualOutput.Should().Be(output);
            _outputHelper.WriteLine($"Duration = {timer.ElapsedTicks}");
        }

        public static IEnumerable<object[]> InputAndOutput => new List<object[]>
        {
            new object[]
            {
                "egg",
                "add",
                true
            },
            new object[]
            {
                "foo",
                "bar",
                false
            },
            new object[]
            {
                "paper",
                "title",
                true
            },            
            new object[]
            {
                "badc",
                "baba",
                false
            },
        };
    }
}
