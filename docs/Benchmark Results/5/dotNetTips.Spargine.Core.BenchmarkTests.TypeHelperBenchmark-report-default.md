
BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Unknown processor
.NET SDK=6.0.100-preview.7.21379.14
  [Host]     : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
  Job-UTOYIO : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 5.0  
Namespace=dotNetTips.Spargine.Core.BenchmarkTests  Categories=TypeHelper  

                                     Method |      Mean |     Error |    StdDev |    StdErr |       Min |        Q1 |    Median |        Q3 |       Max |      Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline |  Gen 0 | Code Size |  Gen 1 | Allocated |
------------------------------------------- |----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|----------:|-------:|----------:|
 **'Looping Collection: Normal StringBuilder'** |  **5.073 μs** | **0.0278 μs** | **0.0260 μs** | **0.0067 μs** |  **5.040 μs** |  **5.046 μs** |  **5.072 μs** |  **5.096 μs** |  **5.110 μs** | **197,126.9** |      **0.0278 μs** |      **15.00** |    **1.424** |  **2.000** |   **0.1033** |    **1** |            ***** |       **No** | **1.1826** |      **3 KB** | **0.0076** |     **10 KB** |
                          **GetPropertyValues** | **16.774 μs** | **0.0714 μs** | **0.0633 μs** | **0.0169 μs** | **16.641 μs** | **16.736 μs** | **16.768 μs** | **16.821 μs** | **16.866 μs** |  **59,615.5** |      **0.0714 μs** |      **14.00** |    **2.143** |  **2.000** |  **-0.3263** |    **2** |            ***** |       **No** | **0.7019** |      **2 KB** |      **-** |      **6 KB** |
