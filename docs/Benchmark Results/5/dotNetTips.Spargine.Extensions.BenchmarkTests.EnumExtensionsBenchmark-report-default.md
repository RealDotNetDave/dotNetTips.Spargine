
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.300-preview.21180.15
  [Host]     : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
  Job-CJSTKQ : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 5.0  
Namespace=dotNetTips.Spargine.Extensions.BenchmarkTests  Categories=EnumExtensions  

         Method |       Mean |   Error |  StdDev |  StdErr |        Min |         Q1 |     Median |         Q3 |        Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size |  Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------- |-----------:|--------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-------:|------:|------:|----------:|
 **GetDescription** |   **435.5 ns** | **1.67 ns** | **1.40 ns** | **0.39 ns** |   **432.4 ns** |   **435.0 ns** |   **435.9 ns** |   **436.2 ns** |   **437.7 ns** | **2,296,167.2** |       **1.673 ns** |      **13.00** |    **2.826** |  **2.000** |  **-0.7660** |    **1** |            ***** |       **No** |     **272 B** | **0.0024** |     **-** |     **-** |      **24 B** |
       **GetItems** | **1,118.4 ns** | **3.01 ns** | **2.82 ns** | **0.73 ns** | **1,114.6 ns** | **1,116.4 ns** | **1,117.6 ns** | **1,120.1 ns** | **1,124.1 ns** |   **894,101.7** |       **3.010 ns** |      **15.00** |    **2.038** |  **2.000** |   **0.5930** |    **2** |            ***** |       **No** |     **425 B** | **0.0553** |     **-** |     **-** |     **512 B** |
