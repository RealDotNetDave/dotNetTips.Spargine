
    BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1645 (21H2)
    Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
    .NET SDK=6.0.300-preview.22204.3
      [Host]     : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
      Job-WQKGXY : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT

    EvaluateOverhead=True  Server=True  Toolchain=.NET 6.0  
    Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

             Method |     Mean |   Error |  StdDev |  StdErr |      Min |       Q1 |   Median |       Q3 |      Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline |  Gen 0 | Code Size | Allocated |
    --------------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|----------:|----------:|
     **GetDescription** | **252.1 ns** | **1.81 ns** | **1.61 ns** | **0.43 ns** | **249.8 ns** | **251.0 ns** | **252.0 ns** | **252.8 ns** | **255.5 ns** | **3,967,411.9** |       **1.813 ns** |      **14.00** |    **2.391** |  **2.000** |   **0.5375** |    **1** |            ***** |       **No** | **0.0024** |     **288 B** |      **24 B** |
           **GetItems** | **861.7 ns** | **8.90 ns** | **6.95 ns** | **2.01 ns** | **852.3 ns** | **857.6 ns** | **859.9 ns** | **867.6 ns** | **874.1 ns** | **1,160,433.8** |       **8.903 ns** |      **12.00** |    **1.626** |  **2.000** |   **0.2765** |    **2** |            ***** |       **No** | **0.0553** |     **457 B** |     **512 B** |
