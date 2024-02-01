{noformat}

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.3930/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.200-preview.23624.5
  [Host]     : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
  Job-IJMHXV : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
  Job-SQLDLM : .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2

EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  
Categories=Collections  

{noformat}
||Method           ||Runtime  ||Count ||Mean      ||Error    ||StdDev   ||StdErr   ||Min       ||Q1        ||Median    ||Q3        ||Max       ||Op/s         ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline ||Code Size ||Allocated ||
| DoesNotHaveItems | .NET 6.0 | 10    |  40.99 ns | 0.110 ns | 0.103 ns | 0.027 ns |  40.83 ns |  40.90 ns |  41.02 ns |  41.08 ns |  41.12 ns | 24,393,289.0 |      0.1098 ns |      15.00 |    1.369 |  2.000 |  -0.1795 |    2 | *            | No       |     186 B |      32 B |
| DoesNotHaveItems | .NET 7.0 | 10    |  40.22 ns | 0.192 ns | 0.180 ns | 0.046 ns |  40.01 ns |  40.09 ns |  40.18 ns |  40.34 ns |  40.58 ns | 24,864,577.5 |      0.1920 ns |      15.00 |    1.943 |  2.000 |   0.6834 |    1 | *            | No       |     177 B |      32 B |
| DoesNotHaveItems | .NET 6.0 | 20    |  58.66 ns | 0.145 ns | 0.113 ns | 0.033 ns |  58.51 ns |  58.58 ns |  58.62 ns |  58.72 ns |  58.91 ns | 17,048,631.1 |      0.1446 ns |      12.00 |    2.537 |  2.000 |   0.7577 |    3 | *            | No       |     186 B |      32 B |
| DoesNotHaveItems | .NET 7.0 | 20    |  63.91 ns | 0.314 ns | 0.279 ns | 0.074 ns |  63.54 ns |  63.71 ns |  63.84 ns |  64.04 ns |  64.59 ns | 15,647,119.8 |      0.3143 ns |      14.00 |    3.131 |  2.000 |   0.9289 |    4 | *            | No       |     177 B |      32 B |
| DoesNotHaveItems | .NET 6.0 | 25    |  81.63 ns | 0.287 ns | 0.269 ns | 0.069 ns |  81.31 ns |  81.39 ns |  81.64 ns |  81.89 ns |  82.11 ns | 12,250,170.3 |      0.2875 ns |      15.00 |    1.430 |  2.000 |   0.3116 |    6 | *            | No       |     186 B |      32 B |
| DoesNotHaveItems | .NET 7.0 | 25    |  77.27 ns | 0.311 ns | 0.291 ns | 0.075 ns |  76.89 ns |  77.05 ns |  77.23 ns |  77.49 ns |  77.75 ns | 12,941,307.5 |      0.3115 ns |      15.00 |    1.516 |  2.000 |   0.3076 |    5 | *            | No       |     177 B |      32 B |
| DoesNotHaveItems | .NET 6.0 | 50    | 142.97 ns | 0.799 ns | 0.748 ns | 0.193 ns | 142.05 ns | 142.26 ns | 142.93 ns | 143.64 ns | 144.21 ns |  6,994,380.9 |      0.7993 ns |      15.00 |    1.390 |  2.000 |   0.2053 |    7 | *            | No       |     186 B |      32 B |
| DoesNotHaveItems | .NET 7.0 | 50    | 150.61 ns | 1.391 ns | 1.301 ns | 0.336 ns | 148.97 ns | 149.77 ns | 150.09 ns | 151.47 ns | 153.62 ns |  6,639,723.6 |      1.3912 ns |      15.00 |    2.529 |  2.000 |   0.7849 |    8 | *            | No       |     177 B |      32 B |
| DoesNotHaveItems | .NET 6.0 | 75    | 202.02 ns | 1.050 ns | 0.982 ns | 0.254 ns | 201.10 ns | 201.22 ns | 201.57 ns | 202.68 ns | 204.54 ns |  4,949,992.3 |      1.0496 ns |      15.00 |    3.240 |  2.000 |   1.0413 |    9 | *            | No       |     186 B |      32 B |
| DoesNotHaveItems | .NET 7.0 | 75    | 216.36 ns | 0.765 ns | 0.678 ns | 0.181 ns | 215.31 ns | 215.85 ns | 216.23 ns | 216.86 ns | 217.72 ns |  4,621,857.7 |      0.7652 ns |      14.00 |    1.933 |  2.000 |   0.2929 |   10 | *            | No       |     177 B |      32 B |
| DoesNotHaveItems | .NET 6.0 | 100   | 261.58 ns | 0.596 ns | 0.528 ns | 0.141 ns | 260.92 ns | 261.29 ns | 261.50 ns | 261.62 ns | 262.52 ns |  3,822,988.2 |      0.5956 ns |      14.00 |    2.055 |  2.000 |   0.6667 |   12 | *            | No       |     186 B |      32 B |
| DoesNotHaveItems | .NET 7.0 | 100   | 236.84 ns | 1.164 ns | 0.972 ns | 0.269 ns | 235.71 ns | 236.24 ns | 236.64 ns | 237.06 ns | 239.47 ns |  4,222,198.7 |      1.1636 ns |      13.00 |    4.405 |  2.000 |   1.3946 |   11 | *            | No       |     177 B |      32 B |
| DoesNotHaveItems | .NET 6.0 | 250   | 621.16 ns | 2.611 ns | 2.314 ns | 0.619 ns | 618.78 ns | 619.60 ns | 620.55 ns | 621.39 ns | 625.98 ns |  1,609,881.8 |      2.6107 ns |      14.00 |    2.414 |  2.000 |   0.8935 |   14 | *            | No       |     186 B |      32 B |
| DoesNotHaveItems | .NET 7.0 | 250   | 559.28 ns | 2.563 ns | 2.272 ns | 0.607 ns | 555.52 ns | 558.01 ns | 559.78 ns | 560.63 ns | 563.98 ns |  1,788,007.0 |      2.5633 ns |      14.00 |    2.498 |  2.000 |  -0.0009 |   13 | *            | No       |     177 B |      32 B |
