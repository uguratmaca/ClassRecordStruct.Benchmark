# ClassRecordStruct.Benchmark
Compare performance of record, class, struct

``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|          Method | iterationCount |       Mean |    Error |    StdDev |   Median |      Gen 0 |      Gen 1 |      Gen 2 | Allocated |
|---------------- |--------------- |-----------:|---------:|----------:|---------:|-----------:|-----------:|-----------:|----------:|
| IterationRecord |             20 | 1,002.6 ms | 34.43 ms | 101.51 ms | 966.7 ms | 43000.0000 | 22000.0000 | 10000.0000 | 253.62 MB |
|  IterationClass |             20 |   930.1 ms | 18.42 ms |  34.14 ms | 926.5 ms | 43000.0000 | 22000.0000 | 10000.0000 | 253.62 MB |
| IterationStruct |             20 |   661.7 ms | 13.05 ms |  20.32 ms | 661.1 ms | 42000.0000 | 34000.0000 | 19000.0000 | 257.33 MB |
