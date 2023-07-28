
    BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2846/22H2/2022Update)
    Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
    .NET SDK=7.0.203
      [Host]     : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
      Job-ICYIAI : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
      Job-QAMYPG : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2

    EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  
    Categories=Collections  

               Method |  Runtime | Count |      Mean |    Error |   StdDev |   StdErr |       Min |        Q1 |    Median |        Q3 |       Max |         Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
    ----------------- |--------- |------ |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
     DoesNotHaveItems | .NET 6.0 |    10 |  40.79 ns | 0.148 ns | 0.131 ns | 0.035 ns |  40.55 ns |  40.71 ns |  40.79 ns |  40.86 ns |  41.07 ns | 24,515,441.1 |      0.1476 ns |      14.00 |    2.600 |  2.000 |   0.1625 |    2 |            * |       No |     186 B |      32 B |
     DoesNotHaveItems | .NET 7.0 |    10 |  36.55 ns | 0.163 ns | 0.153 ns | 0.039 ns |  36.29 ns |  36.45 ns |  36.57 ns |  36.64 ns |  36.80 ns | 27,361,969.9 |      0.1633 ns |      15.00 |    1.855 |  2.000 |  -0.0772 |    1 |            * |       No |     177 B |      32 B |
     DoesNotHaveItems | .NET 6.0 |    20 |  65.70 ns | 0.219 ns | 0.204 ns | 0.053 ns |  65.41 ns |  65.56 ns |  65.71 ns |  65.85 ns |  66.01 ns | 15,219,650.4 |      0.2186 ns |      15.00 |    1.592 |  2.000 |   0.1720 |    3 |            * |       No |     186 B |      32 B |
     DoesNotHaveItems | .NET 7.0 |    20 |  65.92 ns | 0.209 ns | 0.175 ns | 0.049 ns |  65.63 ns |  65.81 ns |  65.94 ns |  66.07 ns |  66.15 ns | 15,169,208.7 |      0.2095 ns |      13.00 |    1.674 |  2.000 |  -0.3522 |    3 |            * |       No |     177 B |      32 B |
     DoesNotHaveItems | .NET 6.0 |    25 |  87.20 ns | 0.332 ns | 0.311 ns | 0.080 ns |  86.65 ns |  86.98 ns |  87.23 ns |  87.46 ns |  87.78 ns | 11,467,330.1 |      0.3322 ns |      15.00 |    1.909 |  2.000 |  -0.0179 |    4 |            * |       No |     186 B |      32 B |
     DoesNotHaveItems | .NET 7.0 |    25 |  86.86 ns | 0.267 ns | 0.237 ns | 0.063 ns |  86.37 ns |  86.76 ns |  86.84 ns |  86.96 ns |  87.30 ns | 11,512,564.0 |      0.2674 ns |      14.00 |    2.877 |  2.000 |   0.1197 |    4 |            * |       No |     177 B |      32 B |
     DoesNotHaveItems | .NET 6.0 |    50 | 155.84 ns | 1.276 ns | 1.132 ns | 0.302 ns | 154.30 ns | 155.05 ns | 155.53 ns | 156.04 ns | 158.00 ns |  6,417,024.2 |      1.2765 ns |      14.00 |    2.110 |  2.000 |   0.6934 |    6 |            * |       No |     186 B |      32 B |
     DoesNotHaveItems | .NET 7.0 |    50 | 133.27 ns | 0.571 ns | 0.506 ns | 0.135 ns | 132.60 ns | 132.98 ns | 133.20 ns | 133.52 ns | 134.32 ns |  7,503,509.7 |      0.5710 ns |      14.00 |    2.184 |  2.000 |   0.5329 |    5 |            * |       No |     177 B |      32 B |
     DoesNotHaveItems | .NET 6.0 |    75 | 206.52 ns | 0.477 ns | 0.446 ns | 0.115 ns | 205.84 ns | 206.17 ns | 206.71 ns | 206.81 ns | 207.35 ns |  4,842,104.2 |      0.4768 ns |      15.00 |    1.800 |  2.000 |  -0.0728 |    8 |            * |       No |     186 B |      32 B |
     DoesNotHaveItems | .NET 7.0 |    75 | 186.84 ns | 0.690 ns | 0.645 ns | 0.167 ns | 185.67 ns | 186.44 ns | 186.83 ns | 187.32 ns | 187.85 ns |  5,352,120.3 |      0.6900 ns |      15.00 |    1.930 |  2.000 |  -0.2818 |    7 |            * |       No |     177 B |      32 B |
     DoesNotHaveItems | .NET 6.0 |   100 | 267.89 ns | 1.027 ns | 0.961 ns | 0.248 ns | 266.16 ns | 267.50 ns | 268.06 ns | 268.51 ns | 269.41 ns |  3,732,943.1 |      1.0273 ns |      15.00 |    2.081 |  2.000 |  -0.4053 |   10 |            * |       No |     186 B |      32 B |
     DoesNotHaveItems | .NET 7.0 |   100 | 241.05 ns | 0.682 ns | 0.638 ns | 0.165 ns | 239.88 ns | 240.56 ns | 241.18 ns | 241.53 ns | 242.01 ns |  4,148,487.8 |      0.6821 ns |      15.00 |    1.790 |  2.000 |  -0.1719 |    9 |            * |       No |     177 B |      32 B |
     DoesNotHaveItems | .NET 6.0 |   250 | 638.01 ns | 2.400 ns | 2.128 ns | 0.569 ns | 635.23 ns | 636.17 ns | 637.76 ns | 639.44 ns | 642.00 ns |  1,567,385.0 |      2.4004 ns |      14.00 |    1.723 |  2.000 |   0.3366 |   11 |            * |       No |     186 B |      32 B |
     DoesNotHaveItems | .NET 7.0 |   250 | 692.49 ns | 1.322 ns | 1.172 ns | 0.313 ns | 690.34 ns | 691.75 ns | 692.60 ns | 693.10 ns | 694.54 ns |  1,444,058.1 |      1.3219 ns |      14.00 |    2.191 |  2.000 |   0.1006 |   12 |            * |       No |     177 B |      32 B |
