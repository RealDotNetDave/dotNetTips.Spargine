
    BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19045.2546)
    Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
    .NET SDK=7.0.102
      [Host]     : .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
      Job-URMJSQ : .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
      Job-NCETOA : .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2

    EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  
    Categories=Collections  

             Method |  Runtime |     Mean |   Error |  StdDev |  StdErr |      Min |       Q1 |   Median |       Q3 |      Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
    --------------- |--------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
     **GetDescription** | **.NET 6.0** | **242.9 ns** | **1.00 ns** | **0.89 ns** | **0.24 ns** | **241.9 ns** | **242.3 ns** | **242.7 ns** | **243.4 ns** | **244.7 ns** | **4,116,700.3** |       **1.002 ns** |      **14.00** |    **2.054** |  **2.000** |   **0.7304** |    **2** |            ***** |       **No** |     **347 B** |      **24 B** |
     GetDescription | .NET 7.0 | 177.4 ns | 2.44 ns | 2.04 ns | 0.57 ns | 175.9 ns | 176.0 ns | 176.6 ns | 177.2 ns | 183.1 ns | 5,638,566.4 |       2.444 ns |      13.00 |    5.028 |  2.000 |   1.7007 |    1 |            * |       No |     722 B |      24 B |
           **GetItems** | **.NET 6.0** | **804.4 ns** | **9.38 ns** | **7.83 ns** | **2.17 ns** | **795.9 ns** | **799.6 ns** | **802.0 ns** | **806.1 ns** | **820.7 ns** | **1,243,213.1** |       **9.375 ns** |      **13.00** |    **2.268** |  **2.000** |   **0.8584** |    **4** |            ***** |       **No** |     **516 B** |     **512 B** |
           GetItems | .NET 7.0 | 646.4 ns | 1.39 ns | 1.16 ns | 0.32 ns | 644.5 ns | 645.6 ns | 646.5 ns | 647.1 ns | 648.3 ns | 1,547,112.2 |       1.385 ns |      13.00 |    1.758 |  2.000 |   0.0936 |    3 |            * |       No |     921 B |     512 B |
