
    BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
    Unknown processor
    .NET Core SDK=5.0.300-preview.21180.15
      [Host]     : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
      Job-CJSTKQ : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT

    EvaluateOverhead=True  Server=True  Toolchain=.NET Core 5.0  
    Namespace=dotNetTips.Spargine.Extensions.BenchmarkTests.Extensions  Categories=AssemblyExtensions  

               Method |       Mean |    Error |   StdDev |  StdErr |        Min |         Q1 |     Median |         Q3 |        Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size |  Gen 0 | Gen 1 | Gen 2 | Allocated |
    ----------------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-------:|------:|------:|----------:|
     **GetAllInterfaces** | **1,852.6 ns** | **20.20 ns** | **18.90 ns** | **4.88 ns** | **1,806.3 ns** | **1,841.6 ns** | **1,858.7 ns** | **1,865.5 ns** | **1,881.9 ns** |   **539,791.4** |      **20.202 ns** |      **15.00** |    **2.990** |  **2.000** |  **-0.6725** |    **3** |            ***** |       **No** |     **256 B** | **0.0305** |     **-** |     **-** |     **312 B** |
          **GetAllTypes** | **1,270.0 ns** |  **9.25 ns** |  **8.66 ns** | **2.24 ns** | **1,248.2 ns** | **1,265.8 ns** | **1,270.9 ns** | **1,275.7 ns** | **1,283.5 ns** |   **787,423.9** |       **9.255 ns** |      **15.00** |    **3.352** |  **2.000** |  **-0.8814** |    **2** |            ***** |       **No** |     **263 B** | **0.0248** |     **-** |     **-** |     **240 B** |
         **GetInstances** |   **706.4 ns** |  **6.53 ns** |  **6.11 ns** | **1.58 ns** |   **695.8 ns** |   **701.9 ns** |   **707.0 ns** |   **710.6 ns** |   **715.9 ns** | **1,415,685.0** |       **6.528 ns** |      **15.00** |    **1.758** |  **2.000** |  **-0.1483** |    **1** |            ***** |       **No** |     **199 B** | **0.0057** |     **-** |     **-** |      **56 B** |
