``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.200-preview.21079.7
  [Host]     : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
  Job-JTTEDA : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 5.0  
Namespace=dotNetTips.Spargine.Extensions.BenchmarkTests.Extensions  Categories=AssemblyExtensions  

```
|        Method |       Mean |    Error |   StdDev |  StdErr |        Min |         Q1 |     Median |         Q3 |        Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-------:|------:|------:|----------:|
|   **GetAllTypes** | **1,210.2 ns** | **10.72 ns** | **10.03 ns** | **2.59 ns** | **1,195.7 ns** | **1,202.1 ns** | **1,209.7 ns** | **1,216.9 ns** | **1,226.7 ns** |   **826,301.8** |      **10.724 ns** |      **15.00** |    **1.691** |  **2.000** |   **0.1509** |    **2** |            ***** |       **No** |     **263 B** | **0.0248** |     **-** |     **-** |     **240 B** |
|  **GetInstances** |   **647.9 ns** |  **6.40 ns** |  **5.98 ns** | **1.55 ns** |   **638.1 ns** |   **643.7 ns** |   **647.4 ns** |   **651.4 ns** |   **659.3 ns** | **1,543,384.9** |       **6.398 ns** |      **15.00** |    **2.174** |  **2.000** |   **0.4099** |    **1** |            ***** |       **No** |     **199 B** | **0.0057** |     **-** |     **-** |      **56 B** |
| **GetInterfaces** | **1,846.0 ns** | **27.31 ns** | **25.54 ns** | **6.59 ns** | **1,819.3 ns** | **1,823.6 ns** | **1,827.5 ns** | **1,872.1 ns** | **1,882.6 ns** |   **541,703.6** |      **27.306 ns** |      **15.00** |    **1.032** |  **2.000** |   **0.1789** |    **3** |            ***** |       **No** |     **256 B** | **0.0324** |     **-** |     **-** |     **312 B** |
