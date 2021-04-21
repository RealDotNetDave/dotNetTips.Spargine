``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.200-preview.21079.7
  [Host]     : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
  Job-HSBDIC : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 5.0  
Namespace=dotNetTips.Spargine.Extensions.BenchmarkTests  Categories=EnumExtensions  

```
|         Method |       Mean |    Error |   StdDev |  StdErr |        Min |         Q1 |     Median |         Q3 |        Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-------:|------:|------:|----------:|
| **GetDescription** |   **475.7 ns** |  **3.81 ns** |  **2.98 ns** | **0.86 ns** |   **466.4 ns** |   **476.2 ns** |   **476.6 ns** |   **476.7 ns** |   **477.4 ns** | **2,102,029.6** |       **3.812 ns** |      **12.00** |    **8.168** |  **2.000** |  **-2.5552** |    **1** |            ***** |       **No** |     **269 B** | **0.0024** |     **-** |     **-** |      **24 B** |
|       **GetItems** | **1,121.1 ns** | **21.54 ns** | **21.15 ns** | **5.29 ns** | **1,102.8 ns** | **1,103.9 ns** | **1,111.6 ns** | **1,134.5 ns** | **1,176.8 ns** |   **892,010.3** |      **21.538 ns** |      **16.00** |    **3.316** |  **2.000** |   **0.9882** |    **2** |            ***** |       **No** |     **422 B** | **0.0553** |     **-** |     **-** |     **512 B** |
