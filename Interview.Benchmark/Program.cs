using System;
using BenchmarkDotNet.Running;

namespace Interview.Benchmark
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ReadLine();
            BenchmarkRunner.Run(typeof(Problems._2021.July.MaxSumSubMatrix.Benchmark));
            Console.ReadLine();
        }
    }
}
