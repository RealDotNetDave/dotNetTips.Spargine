
    BenchmarkDotNet=v0.13.2.2004-nightly, OS=Windows 10 (10.0.19044.2251/21H2/November2021Update)
    Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
    .NET SDK=7.0.100
      [Host]     : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
      Job-FOHVKI : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
      Job-FJLZQV : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2

    EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  
    Categories=Collections  

               Method |  Runtime | Count |        Mean |   StdErr |         Min |          Q1 |          Q3 |         Max |         Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
    ----------------- |--------- |------ |------------:|---------:|------------:|------------:|------------:|------------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
     DoesNotHaveItems | .NET 6.0 |    10 |    46.10 ns | 0.274 ns |    42.86 ns |    44.31 ns |    47.31 ns |    51.41 ns | 21,692,051.0 |      0.9507 ns |      57.00 |    2.496 |  2.588 |   0.3877 |    2 |            * |       No |     186 B |      32 B |
     DoesNotHaveItems | .NET 7.0 |    10 |    35.60 ns | 0.198 ns |    33.92 ns |    34.66 ns |    36.26 ns |    38.36 ns | 28,092,534.6 |      0.7101 ns |      36.00 |    2.315 |  3.143 |   0.4133 |    1 |            * |       No |     177 B |      32 B |
     DoesNotHaveItems | .NET 6.0 |    25 |    81.44 ns | 0.376 ns |    79.70 ns |    80.28 ns |    82.32 ns |    84.48 ns | 12,278,489.9 |      1.5571 ns |      15.00 |    1.955 |  2.000 |   0.5086 |    3 |            * |       No |     186 B |      32 B |
     DoesNotHaveItems | .NET 7.0 |    25 |    81.91 ns | 0.428 ns |    79.21 ns |    80.39 ns |    83.75 ns |    85.19 ns | 12,208,151.2 |      1.6470 ns |      21.00 |    1.431 |  2.000 |   0.2738 |    3 |            * |       No |     177 B |      32 B |
     DoesNotHaveItems | .NET 6.0 |    50 |   148.27 ns | 0.508 ns |   146.15 ns |   146.96 ns |   148.65 ns |   152.47 ns |  6,744,392.3 |      2.1424 ns |      14.00 |    2.443 |  2.000 |   0.7791 |    5 |            * |       No |     186 B |      32 B |
     DoesNotHaveItems | .NET 7.0 |    50 |   137.92 ns | 0.335 ns |   136.18 ns |   136.65 ns |   138.94 ns |   139.76 ns |  7,250,715.7 |      1.3870 ns |      15.00 |    1.441 |  2.000 |  -0.0374 |    4 |            * |       No |     177 B |      32 B |
     DoesNotHaveItems | .NET 6.0 |   100 |   252.04 ns | 0.378 ns |   250.57 ns |   250.97 ns |   252.89 ns |   255.40 ns |  3,967,625.6 |      1.6332 ns |      13.00 |    3.196 |  2.000 |   0.9481 |    6 |            * |       No |     186 B |      32 B |
     DoesNotHaveItems | .NET 7.0 |   100 |   254.21 ns | 0.484 ns |   251.12 ns |   252.79 ns |   255.38 ns |   257.54 ns |  3,933,829.6 |      2.0423 ns |      14.00 |    1.857 |  2.000 |   0.0116 |    6 |            * |       No |     177 B |      32 B |
     DoesNotHaveItems | .NET 6.0 |   250 |   603.85 ns | 1.479 ns |   589.26 ns |   601.38 ns |   607.54 ns |   613.12 ns |  1,656,053.8 |      6.1243 ns |      15.00 |    3.523 |  2.000 |  -0.7462 |    7 |            * |       No |     186 B |      32 B |
     DoesNotHaveItems | .NET 7.0 |   250 |   605.40 ns | 0.900 ns |   599.25 ns |   603.18 ns |   608.68 ns |   610.85 ns |  1,651,790.2 |      3.7982 ns |      14.00 |    1.862 |  2.000 |   0.1659 |    7 |            * |       No |     177 B |      32 B |
     DoesNotHaveItems | .NET 6.0 |   500 | 1,052.78 ns | 3.187 ns | 1,031.77 ns | 1,041.39 ns | 1,060.63 ns | 1,074.26 ns |    949,868.9 |     13.1955 ns |      15.00 |    1.785 |  2.000 |  -0.0756 |    8 |            * |       No |     186 B |      32 B |
     DoesNotHaveItems | .NET 7.0 |   500 | 1,193.97 ns | 1.302 ns | 1,181.54 ns | 1,192.24 ns | 1,196.58 ns | 1,199.95 ns |    837,539.6 |      5.3902 ns |      15.00 |    3.401 |  2.000 |  -1.1387 |    9 |            * |       No |     177 B |      32 B |
     DoesNotHaveItems | .NET 6.0 |  1000 | 2,372.71 ns | 9.452 ns | 2,326.18 ns | 2,347.89 ns | 2,394.36 ns | 2,460.37 ns |    421,458.6 |     39.1364 ns |      15.00 |    2.752 |  2.000 |   0.8212 |   10 |            * |       No |     186 B |      32 B |
     DoesNotHaveItems | .NET 7.0 |  1000 | 2,610.68 ns | 0.803 ns | 2,605.91 ns | 2,608.95 ns | 2,613.00 ns | 2,616.40 ns |    383,042.1 |      3.3896 ns |      14.00 |    2.009 |  2.000 |   0.0078 |   11 |            * |       No |     177 B |      32 B |
     DoesNotHaveItems | .NET 6.0 |  2500 | 5,891.64 ns | 2.578 ns | 5,875.72 ns | 5,885.45 ns | 5,897.40 ns | 5,906.88 ns |    169,732.0 |     10.6740 ns |      15.00 |    1.713 |  2.000 |   0.0264 |   12 |            * |       No |     186 B |      32 B |
     DoesNotHaveItems | .NET 7.0 |  2500 | 5,850.36 ns | 2.595 ns | 5,834.02 ns | 5,845.63 ns | 5,854.45 ns | 5,870.42 ns |    170,929.5 |     10.9538 ns |      14.00 |    2.432 |  2.000 |  -0.0017 |   12 |            * |       No |     177 B |      32 B |
