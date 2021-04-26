using BenchmarkDotNet.Running;
using CRS.Benchmark.Helper;
using System;

namespace CRS.Benchmark
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BenchmarkRunner.Run<Runner>();
            Console.ReadLine();
        }
    }
}