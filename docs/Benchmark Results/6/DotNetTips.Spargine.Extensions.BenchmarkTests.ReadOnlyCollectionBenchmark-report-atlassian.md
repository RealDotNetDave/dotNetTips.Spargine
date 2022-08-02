{noformat}

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1826 (21H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=7.0.100-preview.6.22352.1
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
  Job-TRKAEU : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT

EvaluateOverhead=True  Runtime=.NET 6.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

{noformat}
||          Method ||Count ||       Mean ||    Error ||   StdDev ||  StdErr ||        Min ||         Q1 ||     Median ||         Q3 ||        Max ||        Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline || Gen 0 ||Code Size ||Allocated ||
| DoesNotHaveItems |    10 |    40.16 ns |  0.817 ns |  1.062 ns | 0.217 ns |    38.54 ns |    39.38 ns |    39.79 ns |    40.87 ns |    42.60 ns | 24,900,211.9 |      0.8167 ns |      24.00 |    2.483 |  2.000 |   0.6489 |    1 |            * |       No | 0.0035 |     162 B |      32 B |
| DoesNotHaveItems |    25 |    89.94 ns |  1.155 ns |  1.023 ns | 0.274 ns |    88.21 ns |    89.19 ns |    90.19 ns |    90.52 ns |    91.81 ns | 11,118,709.4 |      1.1545 ns |      14.00 |    1.978 |  2.000 |  -0.0546 |    2 |            * |       No | 0.0035 |     162 B |      32 B |
| DoesNotHaveItems |    50 |   156.59 ns |  2.956 ns |  2.621 ns | 0.700 ns |   153.37 ns |   154.64 ns |   155.79 ns |   158.63 ns |   162.12 ns |  6,385,936.5 |      2.9564 ns |      14.00 |    2.038 |  2.000 |   0.5343 |    3 |            * |       No | 0.0033 |     162 B |      32 B |
| DoesNotHaveItems |   100 |   288.08 ns |  5.466 ns |  5.113 ns | 1.320 ns |   280.23 ns |   284.21 ns |   287.91 ns |   291.85 ns |   296.08 ns |  3,471,306.8 |      5.4656 ns |      15.00 |    1.729 |  2.000 |   0.0935 |    4 |            * |       No | 0.0033 |     162 B |      32 B |
| DoesNotHaveItems |   250 |   680.29 ns |  7.015 ns |  6.219 ns | 1.662 ns |   665.79 ns |   676.90 ns |   681.27 ns |   684.25 ns |   689.69 ns |  1,469,967.5 |      7.0149 ns |      14.00 |    2.777 |  2.000 |  -0.5907 |    5 |            * |       No | 0.0029 |     162 B |      32 B |
| DoesNotHaveItems |   500 | 1,381.49 ns | 24.292 ns | 37.097 ns | 6.663 ns | 1,309.95 ns | 1,347.16 ns | 1,393.20 ns | 1,397.92 ns | 1,469.61 ns |    723,858.1 |     24.2923 ns |      31.00 |    2.696 |  2.105 |   0.0126 |    6 |            * |       No | 0.0019 |     162 B |      32 B |
| DoesNotHaveItems |  1000 | 2,218.20 ns | 26.747 ns | 25.020 ns | 6.460 ns | 2,180.43 ns | 2,197.05 ns | 2,217.54 ns | 2,235.49 ns | 2,266.33 ns |    450,816.7 |     26.7474 ns |      15.00 |    1.845 |  2.000 |   0.1742 |    7 |            * |       No |      - |     162 B |      32 B |
| DoesNotHaveItems |  2500 | 6,105.79 ns | 38.641 ns | 34.254 ns | 9.155 ns | 6,059.07 ns | 6,080.23 ns | 6,096.29 ns | 6,128.88 ns | 6,169.19 ns |    163,778.9 |     38.6406 ns |      14.00 |    1.699 |  2.000 |   0.3349 |    8 |            * |       No |      - |     162 B |      32 B |
