{noformat}

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.985 (20H2/October2020Update)
Unknown processor
.NET SDK=5.0.300
  [Host]     : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
  Job-PVYZXO : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 5.0  
Namespace=dotNetTips.Spargine.Extensions.BenchmarkTests  Categories=ExceptionExtensions  

{noformat}
||        Method ||    Mean ||  Error || StdDev || StdErr ||     Min ||      Q1 ||  Median ||      Q3 ||     Max ||       Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline || Gen 0 ||Gen 1 ||Gen 2 ||Allocated ||Code Size ||
| GetAllMessages | 198.4 ns | 0.51 ns | 0.48 ns | 0.12 ns | 197.1 ns | 198.4 ns | 198.5 ns | 198.6 ns | 198.9 ns | 5,040,482.9 |      0.5128 ns |      15.00 |    4.548 |  2.000 |   -1.584 |    1 |            * |       No | 0.0298 |     - |     - |     272 B |     384 B |
