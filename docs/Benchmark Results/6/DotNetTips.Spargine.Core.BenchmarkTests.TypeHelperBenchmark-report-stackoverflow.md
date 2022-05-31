
    BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
    Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
    .NET SDK=6.0.300
      [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
      Job-XJCAYH : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

    EvaluateOverhead=True  Server=True  Toolchain=.NET 6.0  
    Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

                                         Method | Categories |      Mean |     Error |    StdDev |    StdErr |       Min |        Q1 |    Median |        Q3 |       Max |      Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline |  Gen 0 | Code Size |  Gen 1 | Allocated |
    ------------------------------------------- |----------- |----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|----------:|-------:|----------:|
     **'Looping Collection: Normal StringBuilder'** |    **Strings** |  **5.080 μs** | **0.0881 μs** | **0.0824 μs** | **0.0213 μs** |  **4.935 μs** |  **5.007 μs** |  **5.120 μs** |  **5.142 μs** |  **5.174 μs** | **196,841.3** |      **0.0881 μs** |      **15.00** |    **1.595** |  **2.000** |  **-0.5149** |    **1** |            ***** |       **No** | **1.1749** |      **3 KB** | **0.0076** |     **11 KB** |
                              **GetPropertyValues** | **Reflection** | **34.494 μs** | **0.2344 μs** | **0.1830 μs** | **0.0528 μs** | **34.148 μs** | **34.477 μs** | **34.507 μs** | **34.583 μs** | **34.790 μs** |  **28,990.5** |      **0.2344 μs** |      **12.00** |    **2.627** |  **2.000** |  **-0.6283** |    **2** |            ***** |       **No** | **0.6714** |      **2 KB** |      **-** |      **6 KB** |
