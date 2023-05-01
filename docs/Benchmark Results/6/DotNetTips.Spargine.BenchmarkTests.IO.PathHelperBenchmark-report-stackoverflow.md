
    BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2846/22H2/2022Update)
    Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
    .NET SDK=7.0.203
      [Host]     : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
      Job-SRBDUW : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
      Job-DTNPHR : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2

    EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.BenchmarkTests.IO  
    Categories=**NEW**,IO  

                    Method |  Runtime |      Mean |    Error |   StdDev |   StdErr |       Min |        Q1 |    Median |        Q3 |       Max |         Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
    ---------------------- |--------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
       **EnsureTrailingSlash** | **.NET 6.0** |  **54.55 ns** | **0.190 ns** | **0.158 ns** | **0.044 ns** |  **54.22 ns** |  **54.46 ns** |  **54.53 ns** |  **54.66 ns** |  **54.82 ns** | **18,331,584.8** |      **0.1898 ns** |      **13.00** |    **2.375** |  **2.000** |  **-0.2854** |    **1** |            ***** |       **No** |     **573 B** |      **96 B** |
       EnsureTrailingSlash | .NET 7.0 |  59.73 ns | 1.159 ns | 1.138 ns | 0.285 ns |  58.43 ns |  58.89 ns |  59.47 ns |  60.33 ns |  62.37 ns | 16,742,851.9 |      1.1587 ns |      16.00 |    2.448 |  2.000 |   0.7875 |    2 |            * |       No |     701 B |      96 B |
     **HasInvalidFilterChars** | **.NET 6.0** | **343.47 ns** | **3.854 ns** | **3.605 ns** | **0.931 ns** | **337.56 ns** | **340.88 ns** | **343.25 ns** | **345.46 ns** | **351.12 ns** |  **2,911,442.2** |      **3.8538 ns** |      **15.00** |    **2.244** |  **2.000** |   **0.3921** |    **5** |            ***** |       **No** |     **285 B** |    **2112 B** |
     HasInvalidFilterChars | .NET 7.0 | 426.24 ns | 2.747 ns | 2.569 ns | 0.663 ns | 419.82 ns | 424.95 ns | 426.38 ns | 427.56 ns | 430.76 ns |  2,346,118.5 |      2.7469 ns |      15.00 |    3.480 |  2.000 |  -0.5918 |    6 |            * |       No |     720 B |    2112 B |
      **PathContainsWildcard** | **.NET 6.0** | **241.87 ns** | **4.617 ns** | **4.319 ns** | **1.115 ns** | **234.74 ns** | **239.72 ns** | **241.61 ns** | **245.48 ns** | **248.75 ns** |  **4,134,535.4** |      **4.6175 ns** |      **15.00** |    **1.852** |  **2.000** |  **-0.0019** |    **3** |            ***** |       **No** |     **314 B** |    **2016 B** |
      PathContainsWildcard | .NET 7.0 | 327.79 ns | 6.409 ns | 6.582 ns | 1.596 ns | 315.73 ns | 326.01 ns | 328.75 ns | 332.42 ns | 337.36 ns |  3,050,687.4 |      6.4093 ns |      17.00 |    2.056 |  2.000 |  -0.5975 |    4 |            * |       No |     445 B |    2016 B |
