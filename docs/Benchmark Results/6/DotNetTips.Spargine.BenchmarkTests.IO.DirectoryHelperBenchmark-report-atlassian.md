{noformat}

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.300
  [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  Job-SCQMIF : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 6.0  
Namespace=DotNetTips.Spargine.BenchmarkTests.IO  Categories=IO  

{noformat}
||                   Method ||      Mean ||    Error ||   StdDev ||   StdErr ||       Min ||        Q1 ||    Median ||        Q3 ||       Max ||     Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline || Gen 0 ||Code Size ||Allocated ||
|             *AppDataFolder* |   *2.281 μs* | *0.0347 μs* | *0.0307 μs* | *0.0082 μs* |   *2.247 μs* |   *2.260 μs* |   *2.265 μs* |   *2.303 μs* |   *2.352 μs* | *438,474.3* |      *0.0347 μs* |      *14.00* |    *2.515* |  *2.000* |   *0.8175* |    *1* |            *** |       *No* | *0.0801* |     *395 B* |     *736 B* |
|       *LoadOneDriveFolders* |  *84.313 μs* | *1.4688 μs* | *2.1530 μs* | *0.3998 μs* |  *81.621 μs* |  *82.898 μs* |  *83.729 μs* |  *85.214 μs* |  *91.195 μs* |  *11,860.5* |      *1.4688 μs* |      *29.00* |    *4.360* |  *2.000* |   *1.1842* |    *3* |            *** |       *No* | *0.3662* |   *1,089 B* |   *3,761 B* |
|       *SafeDirectorySearch* |  *64.921 μs* | *1.2274 μs* | *1.1481 μs* | *0.2964 μs* |  *63.247 μs* |  *63.845 μs* |  *64.897 μs* |  *65.565 μs* |  *66.687 μs* |  *15,403.3* |      *1.2274 μs* |      *15.00* |    *1.614* |  *2.000* |   *0.1872* |    *2* |            *** |       *No* |      *-* |     *974 B* |     *448 B* |
|            *SafeFileSearch* | *601.129 μs* | *8.3220 μs* | *7.3772 μs* | *1.9716 μs* | *588.580 μs* | *597.761 μs* | *600.630 μs* | *607.279 μs* | *611.834 μs* |   *1,663.5* |      *8.3220 μs* |      *14.00* |    *1.879* |  *2.000* |  *-0.2230* |    *5* |            *** |       *No* | *5.8594* |     *720 B* |  *58,562 B* |
| *SetFileAttributesToNormal* | *191.012 μs* | *3.0559 μs* | *2.7090 μs* | *0.7240 μs* | *185.690 μs* | *189.699 μs* | *191.116 μs* | *193.075 μs* | *195.500 μs* |   *5,235.3* |      *3.0559 μs* |      *14.00* |    *2.107* |  *2.000* |  *-0.2882* |    *4* |            *** |       *No* |      *-* |     *249 B* |   *1,008 B* |
