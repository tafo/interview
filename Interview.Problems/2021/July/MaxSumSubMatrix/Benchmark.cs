﻿using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Jobs;

namespace Interview.Problems._2021.July.MaxSumSubMatrix
{
    [SimpleJob(RunStrategy.Throughput, RuntimeMoniker.Net50)]
    public class Benchmark
    {
        public int[][] Data;

        [GlobalSetup]
        public void GlobalSetup()
        {
            Data = new[]
            {
                new[] {27, 5, -20, -9, 1, 26, 1, 12, 7, -4, 8, 7, -1, 5, 8},
                new[] {16, 28, 8, 3, 16, 28, -10, -7, -5, -13, 7, 9, 20, -9, 26},
                new[] {24, -14, 20, 23, 25, -16, -15, 8, 8, -6, -14, -6, 12, -19, -13},
                new[] {28, 13, -17, 20, -3, -18, 12, 5, 1, 25, 25, -14, 22, 17, 12},
                new[] {7, 29, -12, 5, -5, 26, -5, 10, -5, 24, -9, -19, 20, 0, 18},
                new[] {-7, -11, -8, 12, 19, 18, -15, 17, 7, -1, -11, -10, -1, 25, 17},
                new[] {-3, -20, -20, -7, 14, -12, 22, 1, -9, 11, 14, -16, -5, -12, 14},
                new[] {-20, -4, -17, 3, 3, -18, 22, -13, -1, 16, -11, 29, 17, -2, 22},
                new[] {23, -15, 24, 26, 28, -13, 10, 18, -6, 29, 27, -19, -19, -8, 0},
                new[] {5, 9, 23, 11, -4, -20, 18, 29, -6, -4, -11, 21, -6, 24, 12},
                new[] {13, 16, 0, -20, 22, 21, 26, -3, 15, 14, 26, 17, 19, 20, -5},
                new[] {15, 1, 22, -6, 1, -9, 0, 21, 12, 27, 5, 8, 8, 18, -1},
                new[] {15, 29, 13, 6, -11, 7, -6, 27, 22, 18, 22, -3, -9, 20, 14},
                new[] {26, -6, 12, -10, 0, 26, 10, 1, 11, -10, -16, -18, 29, 8, -8},
                new[] {-19, 14, 15, 18, -10, 24, -9, -7, -19, -14, 23, 23, 17, -5, 6}
            };
        }

        [Benchmark]
        public void SolutionWithBruteForce()
        {
            var solution = new SolutionBruteForce();
            solution.MaxSumSubmatrix(Data, -100);
        }

        [Benchmark]
        public void SolutionWithKadane()
        {
            var solution = new SolutionAnother();
            solution.MaxSumSubmatrix(Data, -100);
        }
    }
}