using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Jobs;

namespace Interview.Problems._2021.July.MaxSumSubMatrix
{
    [SimpleJob(RunStrategy.Throughput, RuntimeMoniker.Net50)]
    public class Benchmark
    {
        public IList<int[][]> Data;

        [GlobalSetup]
        public void GlobalSetup()
        {
            Data = new List<int[][]>();
            for (var i = 0; i < 10; i++)
            {
                Data.Add(GetMatrix(i + 1));
            }
        }

        [Benchmark]
        public void SolutionDoe()
        {
            var solution = new Solution();
            foreach (var matrix in Data)
            {
                solution.MaxSumSubmatrix(matrix, 0);   
            }
        }

        [Benchmark]
        public void SolutionAnother()
        {
            var solution = new SolutionBest();
            foreach (var matrix in Data)
            {
                solution.MaxSumSubmatrix(matrix, 0);   
            }
        }
        
        private static int[][] GetMatrix(int size)
        {
            var random = new Random();
            var matrix = new int[size][];

            for (var i = 0; i < size; ++i)
            {
                matrix[i] = new int[size];
                for (var j = 0; j < size; ++j)
                    matrix[i][j] = random.Next(-100, 100);
            }

            return matrix;
        }
    }
}