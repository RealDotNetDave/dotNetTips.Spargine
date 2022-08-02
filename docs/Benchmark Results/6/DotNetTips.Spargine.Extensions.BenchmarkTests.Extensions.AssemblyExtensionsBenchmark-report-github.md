``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1826 (21H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=7.0.100-preview.6.22352.1
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
  Job-TRKAEU : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT

EvaluateOverhead=True  Runtime=.NET 6.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests.Extensions  Categories=Reflection  

```
|           Method |       Mean |    Error |   StdDev |   StdErr |        Min |         Q1 |     Median |         Q3 |        Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size |  Gen 0 | Allocated |
|----------------- |-----------:|---------:|---------:|---------:|-----------:|-----------:|-----------:|-----------:|-----------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-------:|----------:|
| **GetAllInterfaces** | **2,676.3 ns** | **51.73 ns** | **48.39 ns** | **12.49 ns** | **2,623.7 ns** | **2,653.9 ns** | **2,662.5 ns** | **2,678.3 ns** | **2,810.1 ns** |   **373,656.2** |      **51.733 ns** |      **15.00** |    **4.369** |  **2.000** |   **1.4694** |    **3** |            ***** |       **No** |     **354 B** | **0.2632** |   **2,346 B** |
|      **GetAllTypes** | **1,383.5 ns** | **23.55 ns** | **22.03 ns** |  **5.69 ns** | **1,339.5 ns** | **1,376.6 ns** | **1,382.0 ns** | **1,394.0 ns** | **1,418.7 ns** |   **722,819.5** |      **23.552 ns** |      **15.00** |    **2.246** |  **2.000** |  **-0.1164** |    **2** |            ***** |       **No** |     **303 B** | **0.0343** |     **328 B** |
|     **GetInstances** |   **637.2 ns** |  **7.20 ns** |  **6.73 ns** |  **1.74 ns** |   **626.1 ns** |   **632.9 ns** |   **637.7 ns** |   **641.7 ns** |   **650.3 ns** | **1,569,362.5** |       **7.196 ns** |      **15.00** |    **1.993** |  **2.000** |   **0.1320** |    **1** |            ***** |       **No** |     **118 B** | **0.0057** |      **56 B** |
