
    BenchmarkDotNet=v0.13.2.2004-nightly, OS=Windows 10 (10.0.19044.2251/21H2/November2021Update)
    Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
    .NET SDK=7.0.100
      [Host]     : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
      Job-WEHCHX : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
      Job-NCASFT : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2

    EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  
    Categories=Reflection  

               Method |  Runtime |       Mean |   StdErr |        Min |         Q1 |         Q3 |        Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
    ----------------- |--------- |-----------:|---------:|-----------:|-----------:|-----------:|-----------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
     **GetAllInterfaces** | **.NET 6.0** | **2,862.2 ns** | **16.23 ns** | **2,679.7 ns** | **2,789.6 ns** | **2,903.3 ns** | **3,155.8 ns** |   **349,384.2** |      **56.953 ns** |      **48.00** |    **2.840** |  **2.000** |   **0.6816** |    **6** |            ***** |       **No** |     **348 B** |     **681 B** |
     GetAllInterfaces | .NET 7.0 | 2,484.0 ns | 15.68 ns | 2,320.4 ns | 2,368.7 ns | 2,567.2 ns | 2,991.6 ns |   402,578.4 |      53.239 ns |      96.00 |    4.197 |  2.195 |   1.3210 |    5 |            * |       No |     693 B |     689 B |
          **GetAllTypes** | **.NET 6.0** | **1,625.9 ns** | **18.41 ns** | **1,425.3 ns** | **1,488.2 ns** | **1,748.8 ns** | **2,187.0 ns** |   **615,031.0** |      **62.690 ns** |      **88.00** |    **3.372** |  **2.722** |   **0.9704** |    **4** |            ***** |       **No** |     **337 B** |     **392 B** |
          GetAllTypes | .NET 7.0 | 1,450.9 ns |  7.99 ns | 1,400.4 ns | 1,417.7 ns | 1,461.7 ns | 1,599.0 ns |   689,250.2 |      28.842 ns |      34.00 |    4.746 |  2.000 |   1.4538 |    3 |            * |       No |     706 B |     400 B |
         **GetInstances** | **.NET 6.0** |   **673.7 ns** |  **4.93 ns** |   **624.6 ns** |   **642.1 ns** |   **695.1 ns** |   **820.6 ns** | **1,484,319.7** |      **16.795 ns** |      **88.00** |    **4.098** |  **2.146** |   **1.3785** |    **2** |            ***** |       **No** |     **152 B** |      **56 B** |
         GetInstances | .NET 7.0 |   581.6 ns |  1.14 ns |   574.9 ns |   579.0 ns |   583.2 ns |   590.1 ns | 1,719,393.1 |       4.924 ns |      13.00 |    2.370 |  2.000 |   0.2996 |    1 |            * |       No |     155 B |      56 B |
