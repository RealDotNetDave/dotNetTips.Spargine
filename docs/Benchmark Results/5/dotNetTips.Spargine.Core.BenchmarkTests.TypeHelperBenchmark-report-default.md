
BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.985 (20H2/October2020Update)
Unknown processor
.NET SDK=5.0.300
  [Host]     : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
  Job-IWICPT : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 5.0  
Namespace=dotNetTips.Spargine.Core.BenchmarkTests  Categories=TypeHelper  

                                     Method |      Mean |     Error |    StdDev |    StdErr |       Min |        Q1 |    Median |        Q3 |       Max |      Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
------------------------------------------- |----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-------:|-------:|------:|----------:|
 **'Looping Collection: Normal StringBuilder'** |  **4.866 μs** | **0.0073 μs** | **0.0065 μs** | **0.0017 μs** |  **4.857 μs** |  **4.862 μs** |  **4.866 μs** |  **4.871 μs** |  **4.877 μs** | **205,499.7** |      **0.0073 μs** |      **14.00** |    **1.743** |  **2.000** |   **0.3948** |    **1** |            ***** |       **No** |      **3 KB** | **1.4648** | **0.0229** |     **-** |     **13 KB** |
                          **GetPropertyValues** | **16.840 μs** | **0.0356 μs** | **0.0333 μs** | **0.0086 μs** | **16.791 μs** | **16.814 μs** | **16.842 μs** | **16.865 μs** | **16.889 μs** |  **59,381.6** |      **0.0356 μs** |      **15.00** |    **1.521** |  **2.000** |  **-0.1166** |    **2** |            ***** |       **No** |      **2 KB** | **0.7019** |      **-** |     **-** |      **6 KB** |
