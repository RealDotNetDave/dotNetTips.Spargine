
    BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 10 (10.0.19045.3570/22H2/2022Update)
    Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
    .NET SDK 8.0.100-rc.2.23502.2
      [Host]     : .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
      Job-XHVJJL : .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
      Job-SWNUOI : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2

    EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  
    Categories=Collections  

     Method           | Runtime  | Count | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
    ----------------- |--------- |------ |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
     DoesNotHaveItems | .NET 6.0 | 10    |  48.47 ns | 0.078 ns | 0.073 ns | 0.019 ns |  48.39 ns |  48.41 ns |  48.47 ns |  48.52 ns |  48.63 ns | 20,629,370.9 |      0.0780 ns |      15.00 |    2.145 |  2.000 |   0.6397 |    1 | *            | No       |     177 B |      32 B |
     DoesNotHaveItems | .NET 7.0 | 10    |  56.91 ns | 0.164 ns | 0.154 ns | 0.040 ns |  56.62 ns |  56.82 ns |  56.92 ns |  56.97 ns |  57.16 ns | 17,573,050.2 |      0.1642 ns |      15.00 |    2.313 |  2.000 |  -0.1301 |    2 | *            | No       |     173 B |      32 B |
     DoesNotHaveItems | .NET 6.0 | 20    |  99.35 ns | 1.794 ns | 1.678 ns | 0.433 ns |  96.72 ns |  97.88 ns | 100.18 ns | 100.60 ns | 101.48 ns | 10,065,690.6 |      1.7941 ns |      15.00 |    1.518 |  2.000 |  -0.4699 |    5 | *            | No       |     177 B |      32 B |
     DoesNotHaveItems | .NET 7.0 | 20    |  88.16 ns | 0.316 ns | 0.247 ns | 0.071 ns |  87.80 ns |  87.97 ns |  88.18 ns |  88.24 ns |  88.72 ns | 11,343,223.1 |      0.3158 ns |      12.00 |    2.762 |  2.000 |   0.6561 |    3 | *            | No       |     173 B |      32 B |
     DoesNotHaveItems | .NET 6.0 | 25    |  93.68 ns | 0.274 ns | 0.229 ns | 0.064 ns |  93.38 ns |  93.55 ns |  93.65 ns |  93.74 ns |  94.22 ns | 10,674,650.6 |      0.2744 ns |      13.00 |    2.900 |  2.000 |   0.7885 |    4 | *            | No       |     177 B |      32 B |
     DoesNotHaveItems | .NET 7.0 | 25    |  94.20 ns | 0.287 ns | 0.268 ns | 0.069 ns |  93.80 ns |  93.96 ns |  94.22 ns |  94.35 ns |  94.79 ns | 10,615,982.5 |      0.2870 ns |      15.00 |    2.429 |  2.000 |   0.4885 |    4 | *            | No       |     173 B |      32 B |
     DoesNotHaveItems | .NET 6.0 | 50    | 160.59 ns | 0.503 ns | 0.470 ns | 0.121 ns | 159.73 ns | 160.26 ns | 160.63 ns | 160.94 ns | 161.51 ns |  6,227,071.6 |      0.5028 ns |      15.00 |    2.133 |  2.000 |  -0.0315 |    7 | *            | No       |     177 B |      32 B |
     DoesNotHaveItems | .NET 7.0 | 50    | 150.30 ns | 0.827 ns | 0.645 ns | 0.186 ns | 149.24 ns | 149.99 ns | 150.24 ns | 150.91 ns | 151.06 ns |  6,653,327.8 |      0.8266 ns |      12.00 |    1.607 |  2.000 |  -0.3525 |    6 | *            | No       |     173 B |      32 B |
     DoesNotHaveItems | .NET 6.0 | 75    | 245.90 ns | 0.886 ns | 0.829 ns | 0.214 ns | 244.94 ns | 245.31 ns | 245.64 ns | 246.30 ns | 247.45 ns |  4,066,673.5 |      0.8858 ns |      15.00 |    1.870 |  2.000 |   0.5810 |    9 | *            | No       |     177 B |      32 B |
     DoesNotHaveItems | .NET 7.0 | 75    | 226.44 ns | 0.785 ns | 0.734 ns | 0.190 ns | 225.15 ns | 226.11 ns | 226.38 ns | 226.92 ns | 227.85 ns |  4,416,186.6 |      0.7849 ns |      15.00 |    2.221 |  2.000 |   0.1150 |    8 | *            | No       |     173 B |      32 B |
     DoesNotHaveItems | .NET 6.0 | 100   | 318.64 ns | 1.038 ns | 0.971 ns | 0.251 ns | 317.01 ns | 318.16 ns | 318.54 ns | 319.25 ns | 320.52 ns |  3,138,298.6 |      1.0382 ns |      15.00 |    2.242 |  2.000 |   0.0122 |   11 | *            | No       |     177 B |      32 B |
     DoesNotHaveItems | .NET 7.0 | 100   | 293.78 ns | 1.964 ns | 1.837 ns | 0.474 ns | 289.84 ns | 292.91 ns | 293.61 ns | 294.70 ns | 297.23 ns |  3,403,951.5 |      1.9640 ns |      15.00 |    2.696 |  2.000 |  -0.1030 |   10 | *            | No       |     173 B |      32 B |
     DoesNotHaveItems | .NET 6.0 | 250   | 757.07 ns | 4.285 ns | 4.008 ns | 1.035 ns | 745.33 ns | 755.22 ns | 758.11 ns | 758.84 ns | 763.26 ns |  1,320,887.8 |      4.2849 ns |      15.00 |    5.356 |  2.000 |  -1.4070 |   12 | *            | No       |     177 B |      32 B |
     DoesNotHaveItems | .NET 7.0 | 250   | 814.93 ns | 3.175 ns | 2.815 ns | 0.752 ns | 806.23 ns | 814.60 ns | 815.68 ns | 816.24 ns | 818.17 ns |  1,227,096.3 |      3.1754 ns |      14.00 |    6.699 |  2.000 |  -1.9558 |   13 | *            | No       |     173 B |      32 B |
