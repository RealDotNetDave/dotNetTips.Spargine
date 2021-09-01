``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Unknown processor
.NET SDK=6.0.100-preview.7.21379.14
  [Host]     : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
  Job-LAXWQE : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 5.0  
Namespace=dotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

```
|         Method |       Mean |   Error |  StdDev |  StdErr |        Min |         Q1 |     Median |         Q3 |        Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline |  Gen 0 | Code Size | Allocated |
|--------------- |-----------:|--------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|----------:|----------:|
| **GetDescription** |   **440.8 ns** | **2.60 ns** | **2.43 ns** | **0.63 ns** |   **437.5 ns** |   **439.1 ns** |   **440.5 ns** |   **442.1 ns** |   **445.7 ns** | **2,268,567.1** |       **2.597 ns** |      **15.00** |    **2.143** |  **2.000** |   **0.4740** |    **1** |            ***** |       **No** | **0.0024** |     **272 B** |      **24 B** |
|       **GetItems** | **1,081.3 ns** | **3.52 ns** | **3.12 ns** | **0.83 ns** | **1,076.5 ns** | **1,079.0 ns** | **1,080.9 ns** | **1,083.8 ns** | **1,085.7 ns** |   **924,845.7** |       **3.520 ns** |      **14.00** |    **1.446** |  **2.000** |  **-0.1311** |    **2** |            ***** |       **No** | **0.0553** |     **425 B** |     **512 B** |
