{noformat}

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1682 (21H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.300-preview.22204.3
  [Host]     : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
  Job-URPYHK : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 6.0  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

{noformat}
||                                    Method ||Categories ||     Mean ||    Error ||   StdDev ||   StdErr ||      Min ||       Q1 ||   Median ||       Q3 ||      Max ||     Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline ||Code Size || Gen 0 || Gen 1 ||Allocated ||
| *'Looping Collection: Normal StringBuilder'* |    *Strings* |  *5.348 μs* | *0.1022 μs* | *0.1003 μs* | *0.0251 μs* |  *5.169 μs* |  *5.296 μs* |  *5.306 μs* |  *5.415 μs* |  *5.578 μs* | *186,969.2* |      *0.1022 μs* |      *16.00* |    *2.737* |  *2.000* |   *0.5570* |    *1* |            *** |       *No* |      *3 KB* | *1.4648* | *0.0229* |     *13 KB* |
|                          *GetPropertyValues* | *Reflection* | *32.702 μs* | *0.3815 μs* | *0.3568 μs* | *0.0921 μs* | *32.171 μs* | *32.471 μs* | *32.609 μs* | *32.905 μs* | *33.409 μs* |  *30,579.5* |      *0.3815 μs* |      *15.00* |    *2.265* |  *2.000* |   *0.6534* |    *2* |            *** |       *No* |      *2 KB* | *0.6714* |      *-* |      *6 KB* |
