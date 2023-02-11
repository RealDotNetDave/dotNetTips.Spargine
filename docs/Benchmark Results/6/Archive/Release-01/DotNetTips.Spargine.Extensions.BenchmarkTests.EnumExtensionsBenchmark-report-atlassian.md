{noformat}

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.300
  [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  Job-SPYWVM : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 6.0  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

{noformat}
||        Method ||    Mean ||   Error || StdDev || StdErr ||     Min ||      Q1 ||  Median ||      Q3 ||     Max ||       Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline || Gen 0 ||Code Size ||Allocated ||
| *GetDescription* | *248.0 ns* |  *1.65 ns* | *1.46 ns* | *0.39 ns* | *243.9 ns* | *247.4 ns* | *248.0 ns* | *249.1 ns* | *249.9 ns* | *4,032,615.9* |       *1.645 ns* |      *14.00* |    *4.768* |  *2.000* |  *-1.2767* |    *1* |            *** |       *No* | *0.0024* |     *288 B* |      *24 B* |
|       *GetItems* | *855.8 ns* | *10.15 ns* | *9.00 ns* | *2.40 ns* | *842.6 ns* | *850.8 ns* | *853.3 ns* | *861.6 ns* | *876.3 ns* | *1,168,452.5* |      *10.150 ns* |      *14.00* |    *2.562* |  *2.000* |   *0.5946* |    *2* |            *** |       *No* | *0.0563* |     *457 B* |     *512 B* |
