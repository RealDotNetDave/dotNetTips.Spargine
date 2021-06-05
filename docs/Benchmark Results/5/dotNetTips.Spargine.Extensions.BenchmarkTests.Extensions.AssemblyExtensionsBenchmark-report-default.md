
BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.985 (20H2/October2020Update)
Unknown processor
.NET SDK=5.0.300
  [Host]     : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
  Job-PVYZXO : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 5.0  
Namespace=dotNetTips.Spargine.Extensions.BenchmarkTests.Extensions  Categories=AssemblyExtensions  

           Method |       Mean |    Error |   StdDev |  StdErr |        Min |         Q1 |     Median |         Q3 |        Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline |  Gen 0 | Gen 1 | Gen 2 | Allocated | Code Size |
----------------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|------:|------:|----------:|----------:|
 **GetAllInterfaces** | **1,860.4 ns** |  **8.85 ns** |  **8.28 ns** | **2.14 ns** | **1,844.7 ns** | **1,854.5 ns** | **1,862.1 ns** | **1,868.0 ns** | **1,872.4 ns** |   **537,511.6** |       **8.850 ns** |      **15.00** |    **1.767** |  **2.000** |  **-0.3322** |    **3** |            ***** |       **No** | **0.0324** |     **-** |     **-** |     **312 B** |     **256 B** |
      **GetAllTypes** | **1,263.8 ns** | **12.81 ns** | **11.99 ns** | **3.09 ns** | **1,238.1 ns** | **1,256.8 ns** | **1,266.5 ns** | **1,269.9 ns** | **1,283.8 ns** |   **791,275.3** |      **12.814 ns** |      **15.00** |    **2.431** |  **2.000** |  **-0.4089** |    **2** |            ***** |       **No** | **0.0248** |     **-** |     **-** |     **240 B** |     **263 B** |
     **GetInstances** |   **708.9 ns** |  **5.40 ns** |  **5.05 ns** | **1.30 ns** |   **700.0 ns** |   **706.6 ns** |   **708.4 ns** |   **712.6 ns** |   **718.4 ns** | **1,410,682.2** |       **5.403 ns** |      **15.00** |    **2.118** |  **2.000** |   **0.0238** |    **1** |            ***** |       **No** | **0.0057** |     **-** |     **-** |      **56 B** |     **199 B** |
