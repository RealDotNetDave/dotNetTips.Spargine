
BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.3930/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.200-preview.23624.5
  [Host]     : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
  Job-LJBPBB : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
  Job-GJRVUV : .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2

EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

 Method                                     | Runtime  | Categories | Mean        | Error     | StdDev    | StdErr   | Min         | Q1          | Median      | Q3          | Max         | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
------------------------------------------- |--------- |----------- |------------:|----------:|----------:|---------:|------------:|------------:|------------:|------------:|------------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
 **'Looping Collection: Normal StringBuilder'** | **.NET 6.0** | **Strings**    |  **3,628.8 ns** |  **10.73 ns** |  **10.04 ns** |  **2.59 ns** |  **3,609.7 ns** |  **3,620.7 ns** |  **3,627.0 ns** |  **3,636.6 ns** |  **3,646.6 ns** | **275,575.9** |       **10.73 ns** |      **15.00** |    **1.969** |  **2.000** |   **0.0003** |    **2** | *****            | **No**       |   **3,148 B** |   **7.98 KB** |
 'Looping Collection: Normal StringBuilder' | .NET 7.0 | Strings    |  3,554.9 ns |  22.63 ns |  21.17 ns |  5.47 ns |  3,530.8 ns |  3,538.9 ns |  3,545.5 ns |  3,564.4 ns |  3,599.1 ns | 281,303.0 |       22.63 ns |      15.00 |    2.251 |  2.000 |   0.7980 |    1 | *            | No       |   2,905 B |   7.86 KB |
 **GetPropertyValues**                          | **.NET 6.0** | **Reflection** | **40,107.0 ns** | **274.52 ns** | **256.79 ns** | **66.30 ns** | **39,745.8 ns** | **39,882.1 ns** | **40,174.3 ns** | **40,349.0 ns** | **40,552.6 ns** |  **24,933.3** |      **274.52 ns** |      **15.00** |    **1.483** |  **2.000** |   **0.0745** |    **4** | *****            | **No**       |   **2,585 B** |   **4.56 KB** |
 GetPropertyValues                          | .NET 7.0 | Reflection | 38,953.5 ns | 168.82 ns | 149.65 ns | 40.00 ns | 38,789.2 ns | 38,830.4 ns | 38,932.9 ns | 39,033.7 ns | 39,291.7 ns |  25,671.6 |      168.82 ns |      14.00 |    2.594 |  2.000 |   0.8183 |    3 | *            | No       |   2,993 B |   4.56 KB |
