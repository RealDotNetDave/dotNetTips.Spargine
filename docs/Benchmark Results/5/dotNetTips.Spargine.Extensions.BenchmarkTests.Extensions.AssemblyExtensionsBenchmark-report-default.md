
BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Unknown processor
.NET SDK=6.0.100-preview.7.21379.14
  [Host]     : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
  Job-LAXWQE : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 5.0  
Namespace=dotNetTips.Spargine.Extensions.BenchmarkTests.Extensions  Categories=Reflection  

           Method |       Mean |   Error |  StdDev |  StdErr |        Min |         Q1 |     Median |         Q3 |        Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size |  Gen 0 | Allocated |
----------------- |-----------:|--------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-------:|----------:|
 **GetAllInterfaces** | **1,899.1 ns** | **7.05 ns** | **6.60 ns** | **1.70 ns** | **1,889.7 ns** | **1,894.8 ns** | **1,898.0 ns** | **1,903.6 ns** | **1,910.7 ns** |   **526,566.1** |       **7.051 ns** |      **15.00** |    **1.787** |  **2.000** |   **0.1472** |    **3** |            ***** |       **No** |     **222 B** | **0.0324** |     **312 B** |
      **GetAllTypes** | **1,286.6 ns** | **7.63 ns** | **7.14 ns** | **1.84 ns** | **1,268.5 ns** | **1,285.9 ns** | **1,288.0 ns** | **1,291.1 ns** | **1,294.0 ns** |   **777,216.0** |       **7.630 ns** |      **15.00** |    **3.634** |  **2.000** |  **-1.2608** |    **2** |            ***** |       **No** |     **223 B** | **0.0248** |     **240 B** |
     **GetInstances** |   **722.5 ns** | **4.87 ns** | **4.56 ns** | **1.18 ns** |   **714.5 ns** |   **719.2 ns** |   **723.4 ns** |   **724.9 ns** |   **732.3 ns** | **1,384,105.8** |       **4.871 ns** |      **15.00** |    **2.495** |  **2.000** |   **0.1468** |    **1** |            ***** |       **No** |     **199 B** | **0.0057** |      **56 B** |
