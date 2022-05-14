{noformat}

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.300
  [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  Job-WORVYS : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 6.0  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  

{noformat}
||        Method ||    Mean ||  Error || StdDev || StdErr ||     Min ||      Q1 ||  Median ||      Q3 ||     Max ||       Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline || Gen 0 ||Code Size ||Allocated ||
| GetAllMessages | 181.8 ns | 2.75 ns | 2.44 ns | 0.65 ns | 178.2 ns | 180.2 ns | 181.7 ns | 183.9 ns | 185.9 ns | 5,500,685.9 |       2.751 ns |      14.00 |    1.606 |  2.000 |   0.1497 |    1 |            * |       No | 0.0296 |     453 B |     272 B |
