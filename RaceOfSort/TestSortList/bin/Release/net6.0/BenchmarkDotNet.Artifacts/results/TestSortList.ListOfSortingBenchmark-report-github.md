``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1826 (21H2)
Intel Celeron CPU G1840 2.80GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=6.0.302
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
  DefaultJob : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT


```
|              Method |        Mean |    Error |   StdDev | Rank |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
|-------------------- |------------:|---------:|---------:|-----:|---------:|---------:|---------:|----------:|
|       TestQuickSort |    54.29 μs | 0.408 μs | 0.381 μs |    2 |   3.8452 |        - |        - |      4 KB |
|      TestBubbleSort | 1,160.36 μs | 3.043 μs | 2.846 μs |    6 |   1.9531 |        - |        - |      4 KB |
|   TestSelectionSort |   469.17 μs | 1.476 μs | 1.308 μs |    4 |   3.4180 |        - |        - |      4 KB |
|    TestCountingSort |   355.23 μs | 2.314 μs | 2.051 μs |    3 | 124.5117 | 124.5117 | 124.5117 |    394 KB |
|      TestShakerSort |   980.52 μs | 9.145 μs | 8.554 μs |    5 |   1.9531 |        - |        - |      4 KB |
| TestQuickDotnetSort |    29.47 μs | 0.134 μs | 0.126 μs |    1 |   3.8452 |        - |        - |      4 KB |
