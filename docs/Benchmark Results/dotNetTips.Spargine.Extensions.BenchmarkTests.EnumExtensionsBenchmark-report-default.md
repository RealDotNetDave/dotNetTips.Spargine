
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.200-preview.21079.7
  [Host]     : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
  Job-XTFHVN : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 5.0  
Namespace=dotNetTips.Spargine.Extensions.BenchmarkTests  Categories=EnumExtensions  

         Method |       Mean |   Error |  StdDev |  StdErr |        Min |         Q1 |     Median |         Q3 |        Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size |  Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------- |-----------:|--------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-------:|------:|------:|----------:|
 **GetDescription** |   **488.4 ns** | **2.82 ns** | **2.63 ns** | **0.68 ns** |   **484.4 ns** |   **486.4 ns** |   **488.9 ns** |   **490.2 ns** |   **492.3 ns** | **2,047,597.9** |       **2.817 ns** |      **15.00** |    **1.597** |  **2.000** |   **0.0062** |    **1** |            ***** |       **No** |     **269 B** | **0.0019** |     **-** |     **-** |      **24 B** |
       **GetItems** | **1,077.7 ns** | **5.85 ns** | **5.47 ns** | **1.41 ns** | **1,066.6 ns** | **1,075.1 ns** | **1,077.2 ns** | **1,081.9 ns** | **1,085.6 ns** |   **927,881.4** |       **5.847 ns** |      **15.00** |    **2.129** |  **2.000** |  **-0.1580** |    **2** |            ***** |       **No** |     **422 B** | **0.0553** |     **-** |     **-** |     **512 B** |
