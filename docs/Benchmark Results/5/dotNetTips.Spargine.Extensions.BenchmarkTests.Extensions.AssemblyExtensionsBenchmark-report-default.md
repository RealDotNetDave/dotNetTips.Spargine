
BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1415 (21H1/May2021Update)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.101
  [Host]     : .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
  Job-GTSYRY : .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 5.0  
Namespace=dotNetTips.Spargine.Extensions.BenchmarkTests.Extensions  Categories=Reflection  

           Method |       Mean |    Error |   StdDev |  StdErr |        Min |         Q1 |     Median |         Q3 |        Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size |  Gen 0 | Allocated |
----------------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-------:|----------:|
 **GetAllInterfaces** | **2,184.1 ns** | **18.28 ns** | **17.10 ns** | **4.42 ns** | **2,148.9 ns** | **2,173.8 ns** | **2,183.8 ns** | **2,193.9 ns** | **2,215.1 ns** |   **457,861.8** |      **18.283 ns** |      **15.00** |    **2.548** |  **2.000** |   **0.0485** |    **3** |            ***** |       **No** |     **222 B** | **0.0648** |     **600 B** |
      **GetAllTypes** | **1,283.7 ns** | **17.97 ns** | **16.81 ns** | **4.34 ns** | **1,258.3 ns** | **1,272.4 ns** | **1,279.9 ns** | **1,294.8 ns** | **1,314.8 ns** |   **778,977.0** |      **17.973 ns** |      **15.00** |    **1.971** |  **2.000** |   **0.4299** |    **2** |            ***** |       **No** |     **223 B** | **0.0305** |     **280 B** |
     **GetInstances** |   **649.3 ns** |  **4.30 ns** |  **4.03 ns** | **1.04 ns** |   **642.2 ns** |   **646.4 ns** |   **650.0 ns** |   **651.6 ns** |   **658.0 ns** | **1,540,163.2** |       **4.303 ns** |      **15.00** |    **2.494** |  **2.000** |   **0.1535** |    **1** |            ***** |       **No** |     **199 B** | **0.0057** |      **56 B** |
