{noformat}

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Unknown processor
.NET SDK=6.0.100-preview.7.21379.14
  [Host]     : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
  Job-UTOYIO : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 5.0  
Namespace=dotNetTips.Spargine.Core.BenchmarkTests  Categories=CachedEnumerable Class  

{noformat}
||                              Method ||Count ||    Mean ||   Error ||  StdDev ||  StdErr ||     Min ||      Q1 ||  Median ||      Q3 ||     Max ||        Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline ||Code Size || Gen 0 ||Allocated ||
| 'CachedEnumerable.Create: From List' |    10 | 14.72 ns | 0.078 ns | 0.061 ns | 0.018 ns | 14.56 ns | 14.73 ns | 14.74 ns | 14.75 ns | 14.78 ns | 67,916,095.5 |      0.0781 ns |      12.00 |    4.389 |  2.000 |  -1.5226 |    3 |            * |       No |     128 B | 0.0086 |      80 B |
| 'CachedEnumerable.Create: From List' |    25 | 14.42 ns | 0.307 ns | 0.440 ns | 0.083 ns | 13.88 ns | 14.12 ns | 14.23 ns | 14.67 ns | 15.43 ns | 69,339,415.9 |      0.3070 ns |      28.00 |    2.459 |  2.471 |   0.9196 |    2 |            * |       No |     128 B | 0.0087 |      80 B |
| 'CachedEnumerable.Create: From List' |    50 | 14.83 ns | 0.067 ns | 0.059 ns | 0.016 ns | 14.71 ns | 14.81 ns | 14.85 ns | 14.87 ns | 14.92 ns | 67,414,432.4 |      0.0670 ns |      14.00 |    2.419 |  2.000 |  -0.6825 |    3 |            * |       No |     128 B | 0.0086 |      80 B |
| 'CachedEnumerable.Create: From List' |   100 | 14.07 ns | 0.024 ns | 0.023 ns | 0.006 ns | 14.02 ns | 14.05 ns | 14.07 ns | 14.08 ns | 14.11 ns | 71,095,468.5 |      0.0244 ns |      15.00 |    2.355 |  2.000 |   0.0649 |    1 |            * |       No |     128 B | 0.0086 |      80 B |
| 'CachedEnumerable.Create: From List' |   250 | 14.34 ns | 0.029 ns | 0.027 ns | 0.007 ns | 14.29 ns | 14.33 ns | 14.34 ns | 14.36 ns | 14.39 ns | 69,724,668.6 |      0.0294 ns |      15.00 |    2.227 |  2.000 |   0.1894 |    2 |            * |       No |     128 B | 0.0086 |      80 B |
| 'CachedEnumerable.Create: From List' |   500 | 16.64 ns | 0.166 ns | 0.147 ns | 0.039 ns | 16.48 ns | 16.55 ns | 16.61 ns | 16.66 ns | 17.01 ns | 60,080,295.9 |      0.1659 ns |      14.00 |    3.309 |  2.000 |   1.1101 |    4 |            * |       No |     128 B | 0.0086 |      80 B |
| 'CachedEnumerable.Create: From List' |  1000 | 18.01 ns | 0.210 ns | 0.196 ns | 0.051 ns | 17.76 ns | 17.82 ns | 18.01 ns | 18.16 ns | 18.38 ns | 55,525,105.5 |      0.2097 ns |      15.00 |    1.681 |  2.000 |   0.1995 |    5 |            * |       No |     128 B | 0.0086 |      80 B |
