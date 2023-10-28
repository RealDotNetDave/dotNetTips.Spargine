{noformat}

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 10 (10.0.19045.3570/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-rc.2.23502.2
  [Host]     : .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
  Job-CXSZNQ : .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
  Job-DTMEWR : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2

EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.BenchmarkTests.IO  
Categories=**NEW**,IO  

{noformat}
||Method                ||Runtime  ||Mean      ||Error    ||StdDev   ||StdErr   ||Min       ||Q1        ||Median    ||Q3        ||Max       ||Op/s         ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline ||Code Size ||Allocated ||
| *EnsureTrailingSlash*   | *.NET 6.0* |  *64.06 ns* | *0.199 ns* | *0.176 ns* | *0.047 ns* |  *63.67 ns* |  *64.02 ns* |  *64.05 ns* |  *64.09 ns* |  *64.35 ns* | *15,610,417.8* |      *0.1987 ns* |      *14.00* |    *2.870* |  *2.000* |  *-0.3226* |    *1* | ***            | *No*       |     *518 B* |      *96 B* |
| EnsureTrailingSlash   | .NET 7.0 |  71.17 ns | 0.253 ns | 0.237 ns | 0.061 ns |  70.74 ns |  71.03 ns |  71.07 ns |  71.36 ns |  71.52 ns | 14,051,362.1 |      0.2535 ns |      15.00 |    1.668 |  2.000 |  -0.0324 |    2 | *            | No       |     527 B |      96 B |
| *HasInvalidFilterChars* | *.NET 6.0* | *352.24 ns* | *2.289 ns* | *1.911 ns* | *0.530 ns* | *347.36 ns* | *351.91 ns* | *352.52 ns* | *353.05 ns* | *355.34 ns* |  *2,838,981.4* |      *2.2886 ns* |      *13.00* |    *3.984* |  *2.000* |  *-1.0062* |    *5* | ***            | *No*       |     *314 B* |    *2112 B* |
| HasInvalidFilterChars | .NET 7.0 | 429.82 ns | 1.674 ns | 1.566 ns | 0.404 ns | 426.54 ns | 428.91 ns | 429.70 ns | 430.75 ns | 432.26 ns |  2,326,577.0 |      1.6741 ns |      15.00 |    2.313 |  2.000 |  -0.2843 |    6 | *            | No       |     318 B |    2112 B |
| *PathContainsWildcard*  | *.NET 6.0* | *241.46 ns* | *1.633 ns* | *1.448 ns* | *0.387 ns* | *239.32 ns* | *240.14 ns* | *241.65 ns* | *242.28 ns* | *244.45 ns* |  *4,141,470.9* |      *1.6334 ns* |      *14.00* |    *2.144* |  *2.000* |   *0.2490* |    *3* | ***            | *No*       |     *386 B* |    *2016 B* |
| PathContainsWildcard  | .NET 7.0 | 318.99 ns | 2.083 ns | 1.948 ns | 0.503 ns | 315.06 ns | 317.84 ns | 319.31 ns | 320.55 ns | 321.28 ns |  3,134,887.3 |      2.0830 ns |      15.00 |    1.963 |  2.000 |  -0.5471 |    4 | *            | No       |     388 B |    2016 B |
