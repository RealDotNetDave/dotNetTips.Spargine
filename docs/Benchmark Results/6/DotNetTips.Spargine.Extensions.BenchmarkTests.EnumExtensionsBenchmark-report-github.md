``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1682 (21H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.300-preview.22204.3
  [Host]     : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
  Job-LWZYFI : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 6.0  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

```
|         Method |     Mean |   Error |  StdDev |  StdErr |      Min |       Q1 |   Median |       Q3 |      Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline |  Gen 0 | Code Size | Allocated |
|--------------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|----------:|----------:|
| **GetDescription** | **253.8 ns** | **2.78 ns** | **2.60 ns** | **0.67 ns** | **249.2 ns** | **252.4 ns** | **253.6 ns** | **255.7 ns** | **258.1 ns** | **3,940,710.6** |       **2.785 ns** |      **15.00** |    **1.892** |  **2.000** |  **-0.2234** |    **1** |            ***** |       **No** | **0.0024** |     **319 B** |      **24 B** |
|       **GetItems** | **895.9 ns** | **7.11 ns** | **6.31 ns** | **1.69 ns** | **884.7 ns** | **893.3 ns** | **894.6 ns** | **898.1 ns** | **909.3 ns** | **1,116,227.7** |       **7.114 ns** |      **14.00** |    **2.622** |  **2.000** |   **0.3770** |    **2** |            ***** |       **No** | **0.0572** |     **484 B** |     **512 B** |
