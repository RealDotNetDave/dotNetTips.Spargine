
    BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2846/22H2/2022Update)
    Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
    .NET SDK=7.0.203
      [Host]     : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
      Job-ICYIAI : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
      Job-QAMYPG : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2

    EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  
    Categories=Collections  

             Method |  Runtime |     Mean |    Error |   StdDev |  StdErr |      Min |       Q1 |   Median |       Q3 |      Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
    --------------- |--------- |---------:|---------:|---------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
     **GetDescription** | **.NET 6.0** | **234.3 ns** |  **1.22 ns** |  **1.14 ns** | **0.29 ns** | **231.6 ns** | **234.3 ns** | **234.6 ns** | **235.0 ns** | **235.9 ns** | **4,267,368.2** |      **1.2199 ns** |      **15.00** |    **3.209** |  **2.000** |  **-1.1108** |    **2** |            ***** |       **No** |     **357 B** |      **24 B** |
     GetDescription | .NET 7.0 | 163.3 ns |  0.46 ns |  0.43 ns | 0.11 ns | 162.9 ns | 163.0 ns | 163.0 ns | 163.6 ns | 164.1 ns | 6,123,092.3 |      0.4637 ns |      15.00 |    1.831 |  2.000 |   0.7092 |    1 |            * |       No |     732 B |      24 B |
           **GetItems** | **.NET 6.0** | **802.8 ns** | **11.99 ns** | **21.62 ns** | **3.38 ns** | **779.3 ns** | **789.1 ns** | **797.1 ns** | **805.9 ns** | **868.6 ns** | **1,245,693.8** |     **11.9875 ns** |      **41.00** |    **5.312** |  **2.000** |   **1.6762** |    **4** |            ***** |       **No** |     **526 B** |     **512 B** |
           GetItems | .NET 7.0 | 644.1 ns |  1.74 ns |  1.55 ns | 0.41 ns | 641.9 ns | 643.1 ns | 644.0 ns | 645.1 ns | 647.6 ns | 1,552,478.0 |      1.7443 ns |      14.00 |    2.543 |  2.000 |   0.5675 |    3 |            * |       No |     931 B |     512 B |
