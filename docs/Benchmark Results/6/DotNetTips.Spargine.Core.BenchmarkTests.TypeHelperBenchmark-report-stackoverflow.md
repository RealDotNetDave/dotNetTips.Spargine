
    BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1826 (21H2)
    Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
    .NET SDK=7.0.100-preview.6.22352.1
      [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
      Job-YKIQEX : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT

    EvaluateOverhead=True  Runtime=.NET 6.0  Server=True  
    Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

                                         Method | Categories |      Mean |     Error |    StdDev |    StdErr |    Median |       Min |        Q1 |        Q3 |       Max |      Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size |  Gen 0 | Allocated |
    ------------------------------------------- |----------- |----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-------:|----------:|
     **'Looping Collection: Normal StringBuilder'** |    **Strings** |  **5.046 μs** | **0.1489 μs** | **0.4392 μs** | **0.0439 μs** |  **4.894 μs** |  **4.459 μs** |  **4.728 μs** |  **5.334 μs** |  **6.237 μs** | **198,195.8** |      **0.1489 μs** |     **100.00** |    **3.157** |  **2.524** |   **1.0500** |    **1** |            ***** |       **No** |      **3 KB** | **1.0681** |     **10 KB** |
                              **GetPropertyValues** | **Reflection** | **34.975 μs** | **0.6261 μs** | **0.5856 μs** | **0.1512 μs** | **34.878 μs** | **34.047 μs** | **34.606 μs** | **35.342 μs** | **36.209 μs** |  **28,592.2** |      **0.6261 μs** |      **15.00** |    **2.232** |  **2.000** |   **0.3639** |    **2** |            ***** |       **No** |      **3 KB** | **0.6714** |      **6 KB** |
