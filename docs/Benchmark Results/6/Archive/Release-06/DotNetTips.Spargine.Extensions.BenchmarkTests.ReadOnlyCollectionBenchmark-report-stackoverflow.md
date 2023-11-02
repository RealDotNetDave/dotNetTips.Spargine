
    BenchmarkDotNet v0.13.6, Windows 10 (10.0.19045.3208/22H2/2022Update)
    Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
    .NET SDK 8.0.100-preview.6.23330.14
      [Host]     : .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
      Job-RQFQWF : .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
      Job-MOWSHR : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2

    EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  
    Categories=Collections  

               Method |  Runtime | Count |      Mean |    Error |   StdDev |   StdErr |       Min |        Q1 |    Median |        Q3 |       Max |         Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
    ----------------- |--------- |------ |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
     DoesNotHaveItems | .NET 6.0 |    10 |  39.89 ns | 0.099 ns | 0.088 ns | 0.023 ns |  39.76 ns |  39.82 ns |  39.87 ns |  39.98 ns |  40.02 ns | 25,069,482.3 |      0.0989 ns |      14.00 |    1.391 |  2.000 |   0.1402 |    2 |            * |       No |     186 B |      32 B |
     DoesNotHaveItems | .NET 7.0 |    10 |  36.47 ns | 0.121 ns | 0.113 ns | 0.029 ns |  36.33 ns |  36.38 ns |  36.45 ns |  36.52 ns |  36.70 ns | 27,421,924.1 |      0.1209 ns |      15.00 |    2.518 |  2.000 |   0.7694 |    1 |            * |       No |     177 B |      32 B |
     DoesNotHaveItems | .NET 6.0 |    20 |  60.19 ns | 0.125 ns | 0.117 ns | 0.030 ns |  59.97 ns |  60.13 ns |  60.19 ns |  60.25 ns |  60.41 ns | 16,614,077.7 |      0.1254 ns |      15.00 |    2.263 |  2.000 |  -0.0838 |    3 |            * |       No |     186 B |      32 B |
     DoesNotHaveItems | .NET 7.0 |    20 |  65.90 ns | 0.124 ns | 0.110 ns | 0.029 ns |  65.72 ns |  65.80 ns |  65.92 ns |  65.95 ns |  66.16 ns | 15,175,409.7 |      0.1243 ns |      14.00 |    2.980 |  2.000 |   0.4953 |    4 |            * |       No |     177 B |      32 B |
     DoesNotHaveItems | .NET 6.0 |    25 |  78.89 ns | 0.130 ns | 0.122 ns | 0.031 ns |  78.74 ns |  78.82 ns |  78.85 ns |  78.96 ns |  79.13 ns | 12,675,380.8 |      0.1304 ns |      15.00 |    2.024 |  2.000 |   0.4902 |    5 |            * |       No |     186 B |      32 B |
     DoesNotHaveItems | .NET 7.0 |    25 |  87.74 ns | 0.282 ns | 0.264 ns | 0.068 ns |  87.37 ns |  87.56 ns |  87.72 ns |  87.90 ns |  88.25 ns | 11,397,125.3 |      0.2823 ns |      15.00 |    2.117 |  2.000 |   0.3915 |    6 |            * |       No |     177 B |      32 B |
     DoesNotHaveItems | .NET 6.0 |    50 | 148.07 ns | 0.136 ns | 0.114 ns | 0.032 ns | 147.89 ns | 147.99 ns | 148.08 ns | 148.14 ns | 148.29 ns |  6,753,421.2 |      0.1361 ns |      13.00 |    2.019 |  2.000 |   0.1508 |    7 |            * |       No |     186 B |      32 B |
     DoesNotHaveItems | .NET 7.0 |    50 | 154.90 ns | 0.285 ns | 0.267 ns | 0.069 ns | 154.53 ns | 154.70 ns | 154.85 ns | 155.04 ns | 155.40 ns |  6,455,981.5 |      0.2850 ns |      15.00 |    2.117 |  2.000 |   0.6462 |    8 |            * |       No |     177 B |      32 B |
     DoesNotHaveItems | .NET 6.0 |    75 | 209.35 ns | 0.394 ns | 0.369 ns | 0.095 ns | 208.89 ns | 209.11 ns | 209.26 ns | 209.54 ns | 210.14 ns |  4,776,695.1 |      0.3941 ns |      15.00 |    2.482 |  2.000 |   0.7435 |   10 |            * |       No |     186 B |      32 B |
     DoesNotHaveItems | .NET 7.0 |    75 | 189.34 ns | 0.309 ns | 0.258 ns | 0.071 ns | 188.98 ns | 189.16 ns | 189.34 ns | 189.36 ns | 189.82 ns |  5,281,459.4 |      0.3086 ns |      13.00 |    2.165 |  2.000 |   0.4523 |    9 |            * |       No |     177 B |      32 B |
     DoesNotHaveItems | .NET 6.0 |   100 | 270.57 ns | 0.457 ns | 0.405 ns | 0.108 ns | 269.89 ns | 270.25 ns | 270.63 ns | 270.79 ns | 271.28 ns |  3,695,851.3 |      0.4569 ns |      14.00 |    1.880 |  2.000 |   0.0605 |   12 |            * |       No |     186 B |      32 B |
     DoesNotHaveItems | .NET 7.0 |   100 | 244.70 ns | 0.492 ns | 0.460 ns | 0.119 ns | 244.00 ns | 244.32 ns | 244.81 ns | 245.06 ns | 245.40 ns |  4,086,681.6 |      0.4923 ns |      15.00 |    1.438 |  2.000 |   0.0326 |   11 |            * |       No |     177 B |      32 B |
     DoesNotHaveItems | .NET 6.0 |   250 | 645.39 ns | 6.965 ns | 6.175 ns | 1.650 ns | 640.51 ns | 641.26 ns | 641.78 ns | 649.09 ns | 659.66 ns |  1,549,458.4 |      6.9654 ns |      14.00 |    2.654 |  2.000 |   1.0582 |   13 |            * |       No |     186 B |      32 B |
     DoesNotHaveItems | .NET 7.0 |   250 | 697.23 ns | 1.024 ns | 0.908 ns | 0.243 ns | 695.66 ns | 696.70 ns | 697.17 ns | 697.87 ns | 699.00 ns |  1,434,248.5 |      1.0242 ns |      14.00 |    2.032 |  2.000 |   0.1504 |   14 |            * |       No |     177 B |      32 B |