{noformat}

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1865 (21H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=7.0.100-preview.6.22352.1
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
  Job-NFVFZF : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT

EvaluateOverhead=True  Runtime=.NET 6.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Reflection  

{noformat}
||          Method ||      Mean ||   Error ||  StdDev ||  StdErr ||       Min ||        Q1 ||    Median ||        Q3 ||       Max ||       Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline ||Code Size || Gen 0 ||Allocated ||
| *GetAllInterfaces* | *3,469.2 ns* | *43.21 ns* | *38.31 ns* | *10.24 ns* | *3,406.2 ns* | *3,435.4 ns* | *3,476.1 ns* | *3,499.3 ns* | *3,518.2 ns* |   *288,254.4* |       *43.21 ns* |      *14.00* |    *1.429* |  *2.000* |  *-0.2764* |    *3* |            *** |       *No* |     *354 B* | *0.4082* |   *3,651 B* |
|      *GetAllTypes* | *1,503.9 ns* | *22.94 ns* | *20.34 ns* |  *5.43 ns* | *1,461.5 ns* | *1,491.1 ns* | *1,510.9 ns* | *1,518.3 ns* | *1,537.0 ns* |   *664,942.8* |       *22.94 ns* |      *14.00* |    *2.221* |  *2.000* |  *-0.4144* |    *2* |            *** |       *No* |     *303 B* | *0.0420* |     *392 B* |
|     *GetInstances* |   *654.1 ns* | *11.49 ns* | *10.74 ns* |  *2.77 ns* |   *641.5 ns* |   *646.3 ns* |   *651.6 ns* |   *659.9 ns* |   *673.6 ns* | *1,528,770.5* |       *11.49 ns* |      *15.00* |    *1.937* |  *2.000* |   *0.6856* |    *1* |            *** |       *No* |     *118 B* | *0.0057* |      *56 B* |
