``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1826 (21H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=7.0.100-preview.6.22352.1
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
  Job-TRKAEU : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT

EvaluateOverhead=True  Runtime=.NET 6.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests.Extensions  

```
|             Method |         Categories |     Mean |     Error |    StdDev |    StdErr |      Min |       Q1 |   Median |       Q3 |      Max |          Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
|------------------- |------------------- |---------:|----------:|----------:|----------:|---------:|---------:|---------:|---------:|---------:|--------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
|     **&#39;Equals: Guid&#39;** | ****FOR COMPARISON**** | **1.318 ns** | **0.0290 ns** | **0.0271 ns** | **0.0070 ns** | **1.279 ns** | **1.300 ns** | **1.314 ns** | **1.346 ns** | **1.357 ns** | **758,471,682.1** |      **0.0290 ns** |      **15.00** |    **1.435** |  **2.000** |   **0.1893** |    **1** |            ***** |       **No** |      **96 B** |         **-** |
| **&#39;FastEquals: Guid&#39;** |                   **** | **1.597 ns** | **0.0535 ns** | **0.0501 ns** | **0.0129 ns** | **1.532 ns** | **1.559 ns** | **1.587 ns** | **1.619 ns** | **1.693 ns** | **626,277,834.7** |      **0.0535 ns** |      **15.00** |    **2.010** |  **2.000** |   **0.5016** |    **2** |            ***** |       **No** |      **90 B** |         **-** |
