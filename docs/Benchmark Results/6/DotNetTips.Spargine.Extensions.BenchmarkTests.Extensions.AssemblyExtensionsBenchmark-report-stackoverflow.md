
    BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1682 (21H2)
    Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
    .NET SDK=6.0.300-preview.22204.3
      [Host]     : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
      Job-LWZYFI : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT

    EvaluateOverhead=True  Server=True  Toolchain=.NET 6.0  
    Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests.Extensions  Categories=Reflection  

               Method |        Mean |     Error |    StdDev |    StdErr |         Min |          Q1 |      Median |          Q3 |         Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline |  Gen 0 | Code Size | Allocated |
    ----------------- |------------:|----------:|----------:|----------:|------------:|------------:|------------:|------------:|------------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|----------:|----------:|
     **GetAllInterfaces** | **73,925.2 ns** | **888.27 ns** | **830.89 ns** | **214.53 ns** | **72,079.9 ns** | **73,654.8 ns** | **73,866.2 ns** | **74,454.7 ns** | **75,220.7 ns** |    **13,527.2** |     **888.268 ns** |      **15.00** |    **2.654** |  **2.000** |  **-0.3544** |    **3** |            ***** |       **No** | **0.2441** |     **364 B** |   **2,777 B** |
          **GetAllTypes** |  **1,197.1 ns** |   **9.16 ns** |   **8.12 ns** |   **2.17 ns** |  **1,188.2 ns** |  **1,191.6 ns** |  **1,194.3 ns** |  **1,200.7 ns** |  **1,213.2 ns** |   **835,330.9** |       **9.158 ns** |      **14.00** |    **2.071** |  **2.000** |   **0.8253** |    **2** |            ***** |       **No** | **0.0248** |     **319 B** |     **240 B** |
         **GetInstances** |    **669.8 ns** |   **3.60 ns** |   **3.37 ns** |   **0.87 ns** |    **661.7 ns** |    **669.3 ns** |    **669.7 ns** |    **671.9 ns** |    **674.0 ns** | **1,492,908.2** |       **3.605 ns** |      **15.00** |    **2.954** |  **2.000** |  **-0.7960** |    **1** |            ***** |       **No** | **0.0057** |     **118 B** |      **56 B** |
