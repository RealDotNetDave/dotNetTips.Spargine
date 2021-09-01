{noformat}

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Unknown processor
.NET SDK=6.0.100-preview.7.21379.14
  [Host]     : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
  Job-YNYGDE : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 5.0  
Namespace=dotNetTips.Spargine.Core.BenchmarkTests  Categories=Collections  

{noformat}
||                              Method ||Count ||    Mean ||   Error ||  StdDev ||  StdErr ||     Min ||      Q1 ||  Median ||      Q3 ||     Max ||        Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline ||Code Size || Gen 0 ||Allocated ||
| 'CachedEnumerable.Create: From List' |    10 | 18.47 ns | 0.031 ns | 0.027 ns | 0.007 ns | 18.42 ns | 18.46 ns | 18.47 ns | 18.48 ns | 18.52 ns | 54,144,075.2 |      0.0306 ns |      14.00 |    2.134 |  2.000 |  -0.0434 |    1 |            * |       No |     372 B | 0.0087 |      80 B |
| 'CachedEnumerable.Create: From List' |    25 | 18.50 ns | 0.020 ns | 0.018 ns | 0.005 ns | 18.48 ns | 18.48 ns | 18.49 ns | 18.51 ns | 18.54 ns | 54,065,036.1 |      0.0203 ns |      14.00 |    3.589 |  2.000 |   1.0991 |    1 |            * |       No |     372 B | 0.0087 |      80 B |
| 'CachedEnumerable.Create: From List' |    50 | 18.27 ns | 0.030 ns | 0.028 ns | 0.007 ns | 18.24 ns | 18.25 ns | 18.27 ns | 18.29 ns | 18.34 ns | 54,719,718.5 |      0.0304 ns |      15.00 |    2.425 |  2.000 |   0.6147 |    1 |            * |       No |     372 B | 0.0087 |      80 B |
| 'CachedEnumerable.Create: From List' |   100 | 18.62 ns | 0.032 ns | 0.030 ns | 0.008 ns | 18.57 ns | 18.60 ns | 18.62 ns | 18.64 ns | 18.67 ns | 53,699,787.3 |      0.0316 ns |      15.00 |    1.889 |  2.000 |  -0.1257 |    1 |            * |       No |     372 B | 0.0087 |      80 B |
| 'CachedEnumerable.Create: From List' |   250 | 18.34 ns | 0.033 ns | 0.029 ns | 0.008 ns | 18.30 ns | 18.32 ns | 18.34 ns | 18.37 ns | 18.39 ns | 54,516,748.3 |      0.0330 ns |      14.00 |    1.648 |  2.000 |   0.0975 |    1 |            * |       No |     372 B | 0.0089 |      80 B |
| 'CachedEnumerable.Create: From List' |   500 | 20.47 ns | 0.437 ns | 0.893 ns | 0.125 ns | 18.43 ns | 20.60 ns | 20.80 ns | 20.90 ns | 21.33 ns | 48,850,457.4 |      0.4373 ns |      51.00 |    3.895 |  2.000 |  -1.5747 |    2 |            * |       No |     372 B | 0.0086 |      80 B |
| 'CachedEnumerable.Create: From List' |  1000 | 20.80 ns | 0.199 ns | 0.186 ns | 0.048 ns | 20.44 ns | 20.81 ns | 20.83 ns | 20.95 ns | 21.01 ns | 48,074,129.7 |      0.1986 ns |      15.00 |    2.421 |  2.000 |  -0.9549 |    2 |            * |       No |     372 B | 0.0087 |      80 B |
