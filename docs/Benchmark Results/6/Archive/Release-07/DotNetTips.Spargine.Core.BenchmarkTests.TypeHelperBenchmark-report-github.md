```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 10 (10.0.19045.3570/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-rc.2.23502.2
  [Host]     : .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
  Job-XGXFJX : .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
  Job-TJKJTW : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2

EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

```
| Method                                     | Runtime  | Categories | Mean        | Error     | StdDev    | StdErr   | Min         | Q1          | Median      | Q3          | Max         | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
|------------------------------------------- |--------- |----------- |------------:|----------:|----------:|---------:|------------:|------------:|------------:|------------:|------------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
| **&#39;Looping Collection: Normal StringBuilder&#39;** | **.NET 6.0** | **Strings**    |  **4,019.6 ns** |  **11.95 ns** |  **11.18 ns** |  **2.89 ns** |  **4,001.7 ns** |  **4,012.0 ns** |  **4,019.7 ns** |  **4,025.5 ns** |  **4,038.6 ns** | **248,782.2** |       **11.95 ns** |      **15.00** |    **1.814** |  **2.000** |   **0.1546** |    **2** | *****            | **No**       |   **3,254 B** |   **8.16 KB** |
| &#39;Looping Collection: Normal StringBuilder&#39; | .NET 7.0 | Strings    |  3,920.2 ns |  14.58 ns |  13.64 ns |  3.52 ns |  3,895.1 ns |  3,909.6 ns |  3,915.6 ns |  3,932.0 ns |  3,940.6 ns | 255,089.2 |       14.58 ns |      15.00 |    1.596 |  2.000 |  -0.0703 |    1 | *            | No       |   3,028 B |   7.95 KB |
| **GetPropertyValues**                          | **.NET 6.0** | **Reflection** | **46,435.2 ns** | **136.43 ns** | **120.94 ns** | **32.32 ns** | **46,184.3 ns** | **46,366.9 ns** | **46,450.0 ns** | **46,501.7 ns** | **46,637.8 ns** |  **21,535.4** |      **136.43 ns** |      **14.00** |    **2.371** |  **2.000** |  **-0.2907** |    **3** | *****            | **No**       |   **2,894 B** |   **4.57 KB** |
| GetPropertyValues                          | .NET 7.0 | Reflection | 47,065.4 ns | 317.08 ns | 296.59 ns | 76.58 ns | 46,520.7 ns | 46,919.6 ns | 47,142.9 ns | 47,302.9 ns | 47,439.2 ns |  21,247.0 |      317.08 ns |      15.00 |    1.926 |  2.000 |  -0.6401 |    4 | *            | No       |   2,876 B |   4.57 KB |
