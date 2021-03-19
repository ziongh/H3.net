﻿using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace H3.Benchmarks
{
    [MemoryDiagnoser]
    public class Program {
        static void Main(string[] args) => BenchmarkSwitcher.FromAssemblies(new[] { typeof(Program).Assembly }).Run(args);
    }

}