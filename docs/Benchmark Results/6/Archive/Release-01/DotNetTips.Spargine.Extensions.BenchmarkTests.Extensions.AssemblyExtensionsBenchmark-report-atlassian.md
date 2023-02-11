{noformat}

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.300
  [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  Job-SPYWVM : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 6.0  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests.Extensions  Categories=Reflection  

{noformat}
||          Method ||       Mean ||    Error ||   StdDev ||   StdErr ||        Min ||         Q1 ||     Median ||         Q3 ||        Max ||       Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline || Gen 0 ||Code Size ||Allocated ||
| *GetAllInterfaces* | *71,152.2 ns* | *827.47 ns* | *774.02 ns* | *199.85 ns* | *70,169.1 ns* | *70,423.9 ns* | *71,186.1 ns* | *71,690.1 ns* | *72,415.0 ns* |    *14,054.4* |     *827.473 ns* |      *15.00* |    *1.605* |  *2.000* |   *0.1820* |    *3* |            *** |       *No* | *0.2441* |     *329 B* |   *2,777 B* |
|      *GetAllTypes* |  *1,194.7 ns* |  *11.64 ns* |  *10.89 ns* |   *2.81 ns* |  *1,174.5 ns* |  *1,187.4 ns* |  *1,193.7 ns* |  *1,202.9 ns* |  *1,213.0 ns* |   *837,057.1* |      *11.639 ns* |      *15.00* |    *1.896* |  *2.000* |  *-0.0756* |    *2* |            *** |       *No* | *0.0248* |     *286 B* |     *240 B* |
|     *GetInstances* |    *611.7 ns* |   *6.75 ns* |   *6.31 ns* |   *1.63 ns* |    *602.3 ns* |    *607.2 ns* |    *612.8 ns* |    *616.3 ns* |    *623.8 ns* | *1,634,904.0* |       *6.747 ns* |      *15.00* |    *1.880* |  *2.000* |   *0.0295* |    *1* |            *** |       *No* | *0.0057* |     *118 B* |      *56 B* |
