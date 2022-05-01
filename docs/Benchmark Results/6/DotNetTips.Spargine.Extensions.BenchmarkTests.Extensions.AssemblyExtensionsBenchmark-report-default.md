
BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1682 (21H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.300-preview.22204.3
  [Host]     : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
  Job-PASGMM : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 6.0  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests.Extensions  Categories=Reflection  

           Method |        Mean |       Error |      StdDev |    StdErr |         Min |          Q1 |      Median |          Q3 |         Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size |  Gen 0 | Allocated |
----------------- |------------:|------------:|------------:|----------:|------------:|------------:|------------:|------------:|------------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-------:|----------:|
 **GetAllInterfaces** | **70,318.9 ns** | **1,381.90 ns** | **1,225.02 ns** | **327.40 ns** | **69,217.3 ns** | **69,642.2 ns** | **69,872.4 ns** | **70,491.0 ns** | **73,089.3 ns** |    **14,220.9** |   **1,381.902 ns** |      **14.00** |    **3.625** |  **2.000** |   **1.4338** |    **3** |            ***** |       **No** |     **329 B** | **0.2441** |   **2,777 B** |
      **GetAllTypes** |  **1,134.6 ns** |    **14.17 ns** |    **13.25 ns** |   **3.42 ns** |  **1,118.3 ns** |  **1,124.1 ns** |  **1,131.6 ns** |  **1,143.2 ns** |  **1,164.9 ns** |   **881,400.3** |      **14.166 ns** |      **15.00** |    **2.434** |  **2.000** |   **0.6344** |    **2** |            ***** |       **No** |     **286 B** | **0.0248** |     **240 B** |
     **GetInstances** |    **612.9 ns** |     **4.05 ns** |     **3.79 ns** |   **0.98 ns** |    **608.1 ns** |    **609.5 ns** |    **612.7 ns** |    **615.2 ns** |    **620.5 ns** | **1,631,702.4** |       **4.055 ns** |      **15.00** |    **1.823** |  **2.000** |   **0.3881** |    **1** |            ***** |       **No** |     **118 B** | **0.0057** |      **56 B** |
