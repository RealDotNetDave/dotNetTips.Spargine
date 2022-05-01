{noformat}

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1682 (21H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.300-preview.22204.3
  [Host]     : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
  Job-FLIPTB : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 6.0  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

{noformat}
||                                    Method ||Categories ||     Mean ||    Error ||   StdDev ||   StdErr ||      Min ||       Q1 ||   Median ||       Q3 ||      Max ||     Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline ||Code Size || Gen 0 || Gen 1 ||Allocated ||
| *'Looping Collection: Normal StringBuilder'* |    *Strings* |  *4.965 μs* | *0.0800 μs* | *0.0748 μs* | *0.0193 μs* |  *4.838 μs* |  *4.914 μs* |  *4.968 μs* |  *5.027 μs* |  *5.073 μs* | *201,423.8* |      *0.0800 μs* |      *15.00* |    *1.670* |  *2.000* |  *-0.1047* |    *1* |            *** |       *No* |      *3 KB* | *1.4648* | *0.0076* |     *13 KB* |
|                          *GetPropertyValues* | *Reflection* | *31.916 μs* | *0.2119 μs* | *0.1879 μs* | *0.0502 μs* | *31.592 μs* | *31.782 μs* | *31.956 μs* | *32.033 μs* | *32.180 μs* |  *31,331.9* |      *0.2119 μs* |      *14.00* |    *1.776* |  *2.000* |  *-0.3153* |    *2* |            *** |       *No* |      *2 KB* | *0.6714* |      *-* |      *6 KB* |
