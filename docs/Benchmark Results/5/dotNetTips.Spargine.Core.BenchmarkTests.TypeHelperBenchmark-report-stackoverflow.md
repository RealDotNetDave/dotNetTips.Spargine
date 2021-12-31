
    BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1415 (21H1/May2021Update)
    Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
    .NET SDK=6.0.101
      [Host]     : .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
      Job-GHFTZK : .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT

    EvaluateOverhead=True  Server=True  Toolchain=.NET 5.0  
    Namespace=dotNetTips.Spargine.Core.BenchmarkTests  

                                         Method | Categories |      Mean |     Error |    StdDev |    StdErr |       Min |        Q1 |    Median |        Q3 |       Max |      Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline |  Gen 0 | Code Size |  Gen 1 | Allocated |
    ------------------------------------------- |----------- |----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|----------:|-------:|----------:|
     **'Looping Collection: Normal StringBuilder'** |    **Strings** |  **5.636 μs** | **0.0352 μs** | **0.0294 μs** | **0.0081 μs** |  **5.590 μs** |  **5.620 μs** |  **5.642 μs** |  **5.655 μs** |  **5.679 μs** | **177,419.1** |      **0.0352 μs** |      **13.00** |    **1.649** |  **2.000** |  **-0.2898** |    **1** |            ***** |       **No** | **1.5564** |      **3 KB** | **0.0229** |     **14 KB** |
                              **GetPropertyValues** | **Reflection** | **16.252 μs** | **0.1375 μs** | **0.1286 μs** | **0.0332 μs** | **16.007 μs** | **16.141 μs** | **16.283 μs** | **16.334 μs** | **16.436 μs** |  **61,530.9** |      **0.1375 μs** |      **15.00** |    **1.790** |  **2.000** |  **-0.1599** |    **2** |            ***** |       **No** | **0.6714** |      **2 KB** |      **-** |      **6 KB** |
