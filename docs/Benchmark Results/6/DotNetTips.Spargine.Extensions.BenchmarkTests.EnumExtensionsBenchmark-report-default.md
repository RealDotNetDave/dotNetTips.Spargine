
BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1826 (21H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=7.0.100-preview.6.22352.1
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
  Job-TRKAEU : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT

EvaluateOverhead=True  Runtime=.NET 6.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

         Method |     Mean |    Error |   StdDev |  StdErr |      Min |       Q1 |   Median |       Q3 |      Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline |  Gen 0 | Code Size | Allocated |
--------------- |---------:|---------:|---------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|----------:|----------:|
 **GetDescription** | **259.3 ns** |  **3.02 ns** |  **2.83 ns** | **0.73 ns** | **255.5 ns** | **257.0 ns** | **259.8 ns** | **260.6 ns** | **265.1 ns** | **3,856,785.2** |       **3.021 ns** |      **15.00** |    **2.076** |  **2.000** |   **0.2541** |    **1** |            ***** |       **No** | **0.0024** |     **222 B** |      **24 B** |
       **GetItems** | **887.8 ns** | **14.08 ns** | **13.17 ns** | **3.40 ns** | **864.2 ns** | **878.9 ns** | **890.2 ns** | **898.4 ns** | **902.7 ns** | **1,126,398.3** |      **14.076 ns** |      **15.00** |    **1.719** |  **2.000** |  **-0.5121** |    **2** |            ***** |       **No** | **0.0563** |     **391 B** |     **512 B** |
