{noformat}

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.300
  [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  Job-WORVYS : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 6.0  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests.Extensions  Categories=Reflection  

{noformat}
||          Method ||       Mean ||    Error ||   StdDev ||   StdErr ||        Min ||         Q1 ||     Median ||         Q3 ||        Max ||       Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline || Gen 0 ||Code Size ||Allocated ||
| *GetAllInterfaces* | *70,827.1 ns* | *600.45 ns* | *561.66 ns* | *145.02 ns* | *69,997.3 ns* | *70,447.0 ns* | *70,828.3 ns* | *71,181.9 ns* | *71,758.2 ns* |    *14,118.9* |     *600.449 ns* |      *15.00* |    *1.738* |  *2.000* |   *0.0603* |    *3* |            *** |       *No* | *0.2441* |     *364 B* |   *2,777 B* |
|      *GetAllTypes* |  *1,188.7 ns* |   *8.34 ns* |   *6.96 ns* |   *1.93 ns* |  *1,174.3 ns* |  *1,185.1 ns* |  *1,188.7 ns* |  *1,194.1 ns* |  *1,198.6 ns* |   *841,256.5* |       *8.337 ns* |      *13.00* |    *2.137* |  *2.000* |  *-0.3783* |    *2* |            *** |       *No* | *0.0248* |     *319 B* |     *240 B* |
|     *GetInstances* |    *635.8 ns* |   *7.49 ns* |   *7.01 ns* |   *1.81 ns* |    *626.4 ns* |    *629.4 ns* |    *635.4 ns* |    *642.3 ns* |    *645.7 ns* | *1,572,844.4* |       *7.494 ns* |      *15.00* |    *1.142* |  *2.000* |  *-0.0098* |    *1* |            *** |       *No* | *0.0057* |     *118 B* |      *56 B* |
