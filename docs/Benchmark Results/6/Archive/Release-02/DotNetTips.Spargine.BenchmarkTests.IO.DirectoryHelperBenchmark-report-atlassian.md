{noformat}

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1826 (21H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=7.0.100-preview.6.22352.1
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
  Job-WZHGWU : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT

EvaluateOverhead=True  Runtime=.NET 6.0  Server=True  
Namespace=DotNetTips.Spargine.BenchmarkTests.IO  Categories=IO  

{noformat}
||                   Method ||      Mean ||    Error ||   StdDev ||   StdErr ||       Min ||        Q1 ||    Median ||        Q3 ||       Max ||     Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline || Gen 0 ||Code Size ||Allocated ||
|             *AppDataFolder* |   *2.127 μs* | *0.0411 μs* | *0.0549 μs* | *0.0110 μs* |   *2.046 μs* |   *2.095 μs* |   *2.115 μs* |   *2.146 μs* |   *2.272 μs* | *470,055.0* |      *0.0411 μs* |      *25.00* |    *3.343* |  *2.000* |   *1.0281* |    *1* |            *** |       *No* | *0.0801* |     *395 B* |     *736 B* |
|       *SafeDirectorySearch* |  *58.771 μs* | *1.1392 μs* | *1.4407 μs* | *0.3004 μs* |  *56.744 μs* |  *57.427 μs* |  *59.015 μs* |  *59.818 μs* |  *61.151 μs* |  *17,015.1* |      *1.1392 μs* |      *23.00* |    *1.629* |  *2.000* |   *0.1420* |    *2* |            *** |       *No* |      *-* |     *900 B* |     *480 B* |
| *SetFileAttributesToNormal* | *169.310 μs* | *3.0490 μs* | *2.5461 μs* | *0.7062 μs* | *166.265 μs* | *167.450 μs* | *169.064 μs* | *170.360 μs* | *175.484 μs* |   *5,906.3* |      *3.0490 μs* |      *13.00* |    *3.117* |  *2.000* |   *0.8535* |    *3* |            *** |       *No* |      *-* |     *229 B* |   *1,008 B* |