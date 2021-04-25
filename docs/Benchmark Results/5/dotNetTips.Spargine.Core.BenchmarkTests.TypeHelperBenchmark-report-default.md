
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.300-preview.21180.15
  [Host]     : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
  Job-PDALPH : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 5.0  
Namespace=dotNetTips.Spargine.Core.BenchmarkTests  Categories=TypeHelper  

                                     Method |      Mean |     Error |    StdDev |    StdErr |       Min |        Q1 |    Median |        Q3 |       Max |      Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
------------------------------------------- |----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-------:|-------:|------:|----------:|
 **'Looping Collection: Normal StringBuilder'** |  **4.982 μs** | **0.0067 μs** | **0.0063 μs** | **0.0016 μs** |  **4.973 μs** |  **4.977 μs** |  **4.982 μs** |  **4.987 μs** |  **4.994 μs** | **200,717.9** |      **0.0067 μs** |      **15.00** |    **1.654** |  **2.000** |   **0.1739** |    **1** |            ***** |       **No** |   **2.97 KB** | **1.0300** | **0.0076** |     **-** |   **9.47 KB** |
                          **GetPropertyValues** | **16.545 μs** | **0.2160 μs** | **0.2020 μs** | **0.0522 μs** | **16.275 μs** | **16.337 μs** | **16.667 μs** | **16.731 μs** | **16.773 μs** |  **60,440.0** |      **0.2160 μs** |      **15.00** |    **1.087** |  **2.000** |  **-0.1598** |    **2** |            ***** |       **No** |   **1.78 KB** | **0.7019** |      **-** |     **-** |   **6.42 KB** |
