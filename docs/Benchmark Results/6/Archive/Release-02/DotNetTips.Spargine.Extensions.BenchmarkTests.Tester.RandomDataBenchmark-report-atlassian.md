{noformat}

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1826 (21H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=7.0.100-preview.6.22352.1
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
  Job-TRKAEU : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT

EvaluateOverhead=True  Runtime=.NET 6.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests.Tester  

{noformat}
||                              Method ||    Mean ||   Error ||  StdDev ||  StdErr ||     Min ||      Q1 ||  Median ||      Q3 ||     Max ||    Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline ||Code Size || Gen 0 ||Allocated ||
|                   *'Creating: Person'* | *25.40 μs* | *0.400 μs* | *0.374 μs* | *0.097 μs* | *24.90 μs* | *25.14 μs* | *25.31 μs* | *25.58 μs* | *26.14 μs* | *39,375.8* |      *0.3998 μs* |      *15.00* |    *2.119* |  *2.000* |   *0.5984* |    *1* |            *** |       *No* |      *1 KB* | *0.3052* |      *3 KB* |
|             *'Creating: PersonProper'* | *25.54 μs* | *0.421 μs* | *0.394 μs* | *0.102 μs* | *24.86 μs* | *25.31 μs* | *25.44 μs* | *25.76 μs* | *26.27 μs* | *39,152.3* |      *0.4210 μs* |      *15.00* |    *2.133* |  *2.000* |   *0.2429* |    *1* |            *** |       *No* |      *1 KB* | *0.3052* |      *3 KB* |
|             *'Creating: PersonRecord'* | *31.82 μs* | *0.389 μs* | *0.304 μs* | *0.088 μs* | *31.09 μs* | *31.74 μs* | *31.83 μs* | *32.07 μs* | *32.23 μs* | *31,423.7* |      *0.3891 μs* |      *12.00* |    *3.328* |  *2.000* |  *-0.9250* |    *2* |            *** |       *No* |      *2 KB* | *0.4272* |      *4 KB* |
| *'PropertiesToString(): PersonProper'* | *46.79 μs* | *0.653 μs* | *0.671 μs* | *0.163 μs* | *46.03 μs* | *46.25 μs* | *46.65 μs* | *47.01 μs* | *48.41 μs* | *21,372.4* |      *0.6532 μs* |      *17.00* |    *2.817* |  *2.000* |   *0.9085* |    *3* |            *** |       *No* |      *1 KB* | *3.4790* |     *31 KB* |
| *'PropertiesToString(): PersonRecord'* | *63.22 μs* | *1.194 μs* | *2.518 μs* | *0.343 μs* | *59.03 μs* | *61.44 μs* | *62.76 μs* | *64.72 μs* | *70.08 μs* | *15,818.6* |      *1.1937 μs* |      *54.00* |    *2.519* |  *2.000* |   *0.5223* |    *4* |            *** |       *No* |      *2 KB* | *5.0049* |     *44 KB* |
