{noformat}

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1682 (21H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.300-preview.22204.3
  [Host]     : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
  Job-LWZYFI : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 6.0  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  

{noformat}
||        Method ||    Mean ||  Error || StdDev || StdErr ||     Min ||      Q1 ||  Median ||      Q3 ||     Max ||       Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline || Gen 0 ||Code Size ||Allocated ||
| GetAllMessages | 191.4 ns | 3.01 ns | 2.82 ns | 0.73 ns | 185.5 ns | 189.5 ns | 191.7 ns | 193.7 ns | 195.3 ns | 5,225,612.8 |       3.014 ns |      15.00 |    2.114 |  2.000 |  -0.5308 |    1 |            * |       No | 0.0298 |     453 B |     272 B |