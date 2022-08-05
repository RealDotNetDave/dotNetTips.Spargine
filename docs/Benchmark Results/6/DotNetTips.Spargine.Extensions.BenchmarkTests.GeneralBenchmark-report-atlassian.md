{noformat}

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1865 (21H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=7.0.100-preview.6.22352.1
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
  Job-NFVFZF : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT

EvaluateOverhead=True  Runtime=.NET 6.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  

{noformat}
||            Method ||        Categories ||    Mean ||    Error ||   StdDev ||   StdErr ||     Min ||      Q1 ||  Median ||      Q3 ||     Max ||         Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline ||Code Size ||Allocated ||
|     *'Equals: Guid'* | ***FOR COMPARISON*** | *1.350 ns* | *0.0380 ns* | *0.0356 ns* | *0.0092 ns* | *1.305 ns* | *1.324 ns* | *1.342 ns* | *1.379 ns* | *1.419 ns* | *740,482,678.0* |      *0.0380 ns* |      *15.00* |    *1.778* |  *2.000* |   *0.5056* |    *1* |            *** |       *No* |      *96 B* |         *-* |
| *'FastEquals: Guid'* |                   ** | *1.614 ns* | *0.0377 ns* | *0.0353 ns* | *0.0091 ns* | *1.574 ns* | *1.588 ns* | *1.600 ns* | *1.642 ns* | *1.686 ns* | *619,582,565.8* |      *0.0377 ns* |      *15.00* |    *2.109* |  *2.000* |   *0.7192* |    *2* |            *** |       *No* |      *90 B* |         *-* |
