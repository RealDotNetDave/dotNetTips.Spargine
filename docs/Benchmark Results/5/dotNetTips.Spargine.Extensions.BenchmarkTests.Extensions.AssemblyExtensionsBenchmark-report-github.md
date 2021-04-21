``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.200-preview.21079.7
  [Host]     : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
  Job-HSBDIC : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 5.0  
Namespace=dotNetTips.Spargine.Extensions.BenchmarkTests.Extensions  Categories=AssemblyExtensions  

```
|        Method |       Mean |    Error |   StdDev |  StdErr |        Min |         Q1 |     Median |         Q3 |        Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-------:|------:|------:|----------:|
|   **GetAllTypes** | **1,159.7 ns** |  **3.97 ns** |  **3.52 ns** | **0.94 ns** | **1,154.5 ns** | **1,157.4 ns** | **1,159.0 ns** | **1,161.7 ns** | **1,165.7 ns** |   **862,312.9** |       **3.975 ns** |      **14.00** |    **1.682** |  **2.000** |   **0.2242** |    **2** |            ***** |       **No** |     **263 B** | **0.0248** |     **-** |     **-** |     **240 B** |
|  **GetInstances** |   **647.1 ns** |  **4.08 ns** |  **3.82 ns** | **0.99 ns** |   **643.8 ns** |   **644.4 ns** |   **645.4 ns** |   **649.5 ns** |   **654.2 ns** | **1,545,272.6** |       **4.083 ns** |      **15.00** |    **1.880** |  **2.000** |   **0.8402** |    **1** |            ***** |       **No** |     **199 B** | **0.0057** |     **-** |     **-** |      **56 B** |
| **GetInterfaces** | **1,747.1 ns** | **17.77 ns** | **16.62 ns** | **4.29 ns** | **1,712.3 ns** | **1,746.9 ns** | **1,752.3 ns** | **1,756.6 ns** | **1,765.6 ns** |   **572,365.4** |      **17.767 ns** |      **15.00** |    **2.590** |  **2.000** |  **-1.0559** |    **3** |            ***** |       **No** |     **256 B** | **0.0343** |     **-** |     **-** |     **312 B** |
