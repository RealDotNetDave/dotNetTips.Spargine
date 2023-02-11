
    BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19045.2546)
    Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
    .NET SDK=7.0.102
      [Host]     : .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
      Job-NTYPVS : .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
      Job-UPRYLK : .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2

    EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

                                         Method |  Runtime | Categories |        Mean |     Error |    StdDev |    StdErr |         Min |          Q1 |      Median |          Q3 |         Max |      Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
    ------------------------------------------- |--------- |----------- |------------:|----------:|----------:|----------:|------------:|------------:|------------:|------------:|------------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
     **'Looping Collection: Normal StringBuilder'** | **.NET 6.0** |    **Strings** |  **4,091.7 ns** |  **77.93 ns** |  **86.61 ns** |  **19.87 ns** |  **3,923.2 ns** |  **4,033.8 ns** |  **4,079.2 ns** |  **4,165.7 ns** |  **4,215.8 ns** | **244,397.2** |       **77.93 ns** |      **19.00** |    **1.903** |  **2.000** |  **-0.1987** |    **1** |            ***** |       **No** |   **3,143 B** |   **9.28 KB** |
     'Looping Collection: Normal StringBuilder' | .NET 7.0 |    Strings |  4,230.0 ns |  81.41 ns | 108.68 ns |  21.74 ns |  4,063.2 ns |  4,135.2 ns |  4,249.0 ns |  4,287.8 ns |  4,484.9 ns | 236,404.0 |       81.41 ns |      25.00 |    2.246 |  2.000 |   0.4244 |    2 |            * |       No |   2,900 B |   9.94 KB |
                              **GetPropertyValues** | **.NET 6.0** | **Reflection** | **31,710.6 ns** | **201.34 ns** | **178.48 ns** |  **47.70 ns** | **31,432.6 ns** | **31,624.2 ns** | **31,653.8 ns** | **31,793.9 ns** | **32,048.8 ns** |  **31,535.2** |      **201.34 ns** |      **14.00** |    **2.320** |  **2.000** |   **0.5802** |    **3** |            ***** |       **No** |   **2,756 B** |   **4.71 KB** |
                              GetPropertyValues | .NET 7.0 | Reflection | 31,442.3 ns | 579.33 ns | 541.91 ns | 139.92 ns | 30,778.8 ns | 31,119.6 ns | 31,225.8 ns | 31,703.6 ns | 32,528.7 ns |  31,804.3 |      579.33 ns |      15.00 |    2.175 |  2.000 |   0.8169 |    3 |            * |       No |   3,124 B |   4.71 KB |
