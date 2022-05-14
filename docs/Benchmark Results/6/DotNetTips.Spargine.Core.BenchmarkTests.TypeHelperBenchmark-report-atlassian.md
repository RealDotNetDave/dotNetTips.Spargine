{noformat}

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.300
  [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  Job-BDXZTS : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 6.0  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

{noformat}
||                                    Method ||Categories ||     Mean ||    Error ||   StdDev ||   StdErr ||      Min ||       Q1 ||   Median ||       Q3 ||      Max ||     Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline || Gen 0 ||Code Size || Gen 1 ||Allocated ||
| *'Looping Collection: Normal StringBuilder'* |    *Strings* |  *4.951 μs* | *0.0537 μs* | *0.0503 μs* | *0.0130 μs* |  *4.882 μs* |  *4.914 μs* |  *4.953 μs* |  *4.977 μs* |  *5.061 μs* | *201,966.3* |      *0.0537 μs* |      *15.00* |    *2.351* |  *2.000* |   *0.5271* |    *1* |            *** |       *No* | *1.0300* |      *3 KB* | *0.0076* |      *9 KB* |
|                          *GetPropertyValues* | *Reflection* | *32.730 μs* | *0.3829 μs* | *0.3582 μs* | *0.0925 μs* | *32.140 μs* | *32.439 μs* | *32.692 μs* | *32.960 μs* | *33.404 μs* |  *30,553.3* |      *0.3829 μs* |      *15.00* |    *1.900* |  *2.000* |   *0.0570* |    *2* |            *** |       *No* | *0.6104* |      *2 KB* |      *-* |      *6 KB* |
