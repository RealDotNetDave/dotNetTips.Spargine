``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.200-preview.21079.7
  [Host]     : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
  Job-JTTEDA : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 5.0  
Namespace=dotNetTips.Spargine.Extensions.BenchmarkTests  Categories=EnumExtensions  

```
|         Method |       Mean |   Error |  StdDev |  StdErr |        Min |         Q1 |     Median |         Q3 |        Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline |  Gen 0 | Gen 1 | Gen 2 | Allocated | Code Size |
|--------------- |-----------:|--------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|------:|------:|----------:|----------:|
| **GetDescription** |   **422.9 ns** | **4.17 ns** | **3.48 ns** | **0.97 ns** |   **419.7 ns** |   **421.0 ns** |   **421.6 ns** |   **422.9 ns** |   **431.0 ns** | **2,364,864.6** |       **4.168 ns** |      **13.00** |    **3.520** |  **2.000** |   **1.4017** |    **1** |            ***** |       **No** | **0.0024** |     **-** |     **-** |      **24 B** |     **269 B** |
|       **GetItems** | **1,068.8 ns** | **3.77 ns** | **3.53 ns** | **0.91 ns** | **1,063.0 ns** | **1,066.6 ns** | **1,068.3 ns** | **1,072.1 ns** | **1,073.3 ns** |   **935,622.3** |       **3.770 ns** |      **15.00** |    **1.603** |  **2.000** |  **-0.1243** |    **2** |            ***** |       **No** | **0.0572** |     **-** |     **-** |     **512 B** |     **422 B** |
