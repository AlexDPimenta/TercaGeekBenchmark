```

BenchmarkDotNet v0.13.6, Windows 10 (10.0.19045.2965/22H2/2022Update)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.203
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2


```
|                      Method |       Mean |     Error |     StdDev |   Gen0 | Allocated |
|---------------------------- |-----------:|----------:|-----------:|-------:|----------:|
|       FindOcorrenciesByList | 403.737 ns | 8.0937 ns | 12.6008 ns | 0.0215 |     136 B |
| FindOcorrenciesByListPedrao |   9.843 ns | 0.2297 ns |  0.4258 ns |      - |         - |
