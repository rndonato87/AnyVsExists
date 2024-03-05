```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.23620.1000)
AMD Ryzen 5 2600, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2


```
| Method                     | Mean         | Error      | StdDev     | Gen0   | Allocated |
|--------------------------- |-------------:|-----------:|-----------:|-------:|----------:|
| AnyEnumerable              |     5.810 ns |  0.1459 ns |  0.1364 ns |      - |         - |
| AnyEnumerableWithPredicate | 5,707.402 ns | 54.7897 ns | 45.7518 ns | 0.0076 |      40 B |
| AnyList                    |     3.316 ns |  0.0668 ns |  0.0592 ns |      - |         - |
| AnyListWithPredicate       | 5,250.500 ns | 16.4932 ns | 13.7725 ns | 0.0076 |      40 B |
| ExistsListWithPredicate    | 2,800.803 ns | 37.8324 ns | 35.3885 ns |      - |         - |
