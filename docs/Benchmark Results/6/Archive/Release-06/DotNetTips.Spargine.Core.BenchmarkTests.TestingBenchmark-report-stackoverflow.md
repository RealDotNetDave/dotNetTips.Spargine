
    BenchmarkDotNet v0.13.6, Windows 10 (10.0.19045.3208/22H2/2022Update)
    Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
    .NET SDK 8.0.100-preview.6.23330.14
      [Host]     : .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
      Job-TPLMSH : .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
      Job-KEOQYR : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2

    EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Core.BenchmarkTests  
    Categories=**NEW**,Work in Progress  

            Method |  Runtime | Count |         Mean |      Error |     StdDev |     StdErr |          Min |           Q1 |       Median |           Q3 |          Max |          Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
    -------------- |--------- |------ |-------------:|-----------:|-----------:|-----------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
     **'AddIf() Ref'** | **.NET 6.0** |    **10** |     **3.802 ns** |  **0.0101 ns** |  **0.0090 ns** |  **0.0024 ns** |     **3.788 ns** |     **3.797 ns** |     **3.800 ns** |     **3.804 ns** |     **3.822 ns** | **263,045,043.0** |      **0.0101 ns** |      **14.00** |    **2.677** |  **2.000** |   **0.6687** |    **7** |            ***** |       **No** |     **279 B** |         **-** |
     'AddIf() Ref' | .NET 7.0 |    10 |     3.518 ns |  0.0078 ns |  0.0073 ns |  0.0019 ns |     3.503 ns |     3.514 ns |     3.519 ns |     3.522 ns |     3.530 ns | 284,291,210.7 |      0.0078 ns |      15.00 |    2.437 |  2.000 |  -0.3329 |    6 |            * |       No |     325 B |         - |
     'AddIf() Ref' | .NET 6.0 |    20 |     2.807 ns |  0.0063 ns |  0.0056 ns |  0.0015 ns |     2.796 ns |     2.805 ns |     2.808 ns |     2.810 ns |     2.817 ns | 356,190,116.9 |      0.0063 ns |      14.00 |    2.265 |  2.000 |  -0.2303 |    2 |            * |       No |     279 B |         - |
     'AddIf() Ref' | .NET 7.0 |    20 |     3.521 ns |  0.0047 ns |  0.0040 ns |  0.0011 ns |     3.514 ns |     3.519 ns |     3.522 ns |     3.524 ns |     3.527 ns | 283,987,955.9 |      0.0047 ns |      13.00 |    2.044 |  2.000 |  -0.5113 |    6 |            * |       No |     325 B |         - |
     'AddIf() Ref' | .NET 6.0 |    25 |     2.811 ns |  0.0043 ns |  0.0040 ns |  0.0010 ns |     2.802 ns |     2.808 ns |     2.811 ns |     2.814 ns |     2.816 ns | 355,774,449.8 |      0.0043 ns |      15.00 |    2.269 |  2.000 |  -0.4344 |    2 |            * |       No |     279 B |         - |
     'AddIf() Ref' | .NET 7.0 |    25 |     3.515 ns |  0.0053 ns |  0.0049 ns |  0.0013 ns |     3.506 ns |     3.512 ns |     3.514 ns |     3.518 ns |     3.523 ns | 284,507,794.5 |      0.0053 ns |      15.00 |    2.115 |  2.000 |   0.0491 |    6 |            * |       No |     325 B |         - |
     'AddIf() Ref' | .NET 6.0 |    50 |     2.873 ns |  0.0056 ns |  0.0050 ns |  0.0013 ns |     2.862 ns |     2.870 ns |     2.875 ns |     2.877 ns |     2.879 ns | 348,033,592.5 |      0.0056 ns |      14.00 |    2.241 |  2.000 |  -0.5579 |    3 |            * |       No |     279 B |         - |
     'AddIf() Ref' | .NET 7.0 |    50 |     3.498 ns |  0.0077 ns |  0.0068 ns |  0.0018 ns |     3.488 ns |     3.495 ns |     3.498 ns |     3.502 ns |     3.511 ns | 285,838,443.8 |      0.0077 ns |      14.00 |    2.108 |  2.000 |   0.0912 |    6 |            * |       No |     325 B |         - |
     'AddIf() Ref' | .NET 6.0 |    75 |     2.766 ns |  0.0036 ns |  0.0030 ns |  0.0008 ns |     2.760 ns |     2.764 ns |     2.765 ns |     2.767 ns |     2.771 ns | 361,591,688.5 |      0.0036 ns |      13.00 |    2.199 |  2.000 |   0.1841 |    1 |            * |       No |     279 B |         - |
     'AddIf() Ref' | .NET 7.0 |    75 |     3.538 ns |  0.0066 ns |  0.0059 ns |  0.0016 ns |     3.526 ns |     3.534 ns |     3.541 ns |     3.543 ns |     3.545 ns | 282,609,722.4 |      0.0066 ns |      14.00 |    2.104 |  2.000 |  -0.7386 |    6 |            * |       No |     325 B |         - |
     'AddIf() Ref' | .NET 6.0 |   100 |     2.770 ns |  0.0040 ns |  0.0036 ns |  0.0010 ns |     2.761 ns |     2.768 ns |     2.770 ns |     2.772 ns |     2.775 ns | 361,069,315.8 |      0.0040 ns |      14.00 |    2.736 |  2.000 |  -0.5107 |    1 |            * |       No |     279 B |         - |
     'AddIf() Ref' | .NET 7.0 |   100 |     3.342 ns |  0.0096 ns |  0.0085 ns |  0.0023 ns |     3.325 ns |     3.337 ns |     3.343 ns |     3.347 ns |     3.357 ns | 299,246,537.9 |      0.0096 ns |      14.00 |    2.241 |  2.000 |  -0.1756 |    5 |            * |       No |     325 B |         - |
     'AddIf() Ref' | .NET 6.0 |   250 |     3.234 ns |  0.0072 ns |  0.0056 ns |  0.0016 ns |     3.224 ns |     3.231 ns |     3.233 ns |     3.239 ns |     3.242 ns | 309,182,872.9 |      0.0072 ns |      12.00 |    1.646 |  2.000 |  -0.1132 |    4 |            * |       No |     279 B |         - |
     'AddIf() Ref' | .NET 7.0 |   250 |     3.522 ns |  0.0060 ns |  0.0053 ns |  0.0014 ns |     3.514 ns |     3.518 ns |     3.520 ns |     3.524 ns |     3.532 ns | 283,956,781.1 |      0.0060 ns |      14.00 |    2.284 |  2.000 |   0.7059 |    6 |            * |       No |     325 B |         - |
     **'AddIf() Val'** | **.NET 6.0** |    **10** |   **196.168 ns** |  **1.1421 ns** |  **1.0683 ns** |  **0.2758 ns** |   **193.857 ns** |   **195.450 ns** |   **196.301 ns** |   **197.017 ns** |   **197.616 ns** |   **5,097,662.6** |      **1.1421 ns** |      **15.00** |    **2.172** |  **2.000** |  **-0.4697** |    **8** |            ***** |       **No** |     **577 B** |    **1256 B** |
     'AddIf() Val' | .NET 7.0 |    10 |   250.542 ns |  1.9408 ns |  1.8155 ns |  0.4688 ns |   247.564 ns |   249.351 ns |   250.428 ns |   251.724 ns |   253.959 ns |   3,991,346.6 |      1.9408 ns |      15.00 |    2.007 |  2.000 |   0.3185 |    9 |            * |       No |     929 B |    1256 B |
     'AddIf() Val' | .NET 6.0 |    20 |   293.928 ns |  0.9467 ns |  0.8856 ns |  0.2286 ns |   291.843 ns |   293.490 ns |   294.056 ns |   294.513 ns |   295.587 ns |   3,402,188.4 |      0.9467 ns |      15.00 |    3.110 |  2.000 |  -0.4079 |   10 |            * |       No |     577 B |    2376 B |
     'AddIf() Val' | .NET 7.0 |    20 |   395.785 ns |  2.3269 ns |  2.1766 ns |  0.5620 ns |   393.092 ns |   393.595 ns |   395.992 ns |   397.528 ns |   398.984 ns |   2,526,621.6 |      2.3269 ns |      15.00 |    1.182 |  2.000 |   0.0707 |   12 |            * |       No |     929 B |    2376 B |
     'AddIf() Val' | .NET 6.0 |    25 |   343.304 ns |  1.3401 ns |  1.1880 ns |  0.3175 ns |   341.056 ns |   342.331 ns |   343.409 ns |   344.060 ns |   345.538 ns |   2,912,871.8 |      1.3401 ns |      14.00 |    2.198 |  2.000 |  -0.1096 |   11 |            * |       No |     577 B |    2936 B |
     'AddIf() Val' | .NET 7.0 |    25 |   468.884 ns |  2.7603 ns |  2.5819 ns |  0.6667 ns |   463.124 ns |   467.714 ns |   468.712 ns |   470.919 ns |   473.139 ns |   2,132,723.6 |      2.7603 ns |      15.00 |    2.551 |  2.000 |  -0.3624 |   13 |            * |       No |     929 B |    2936 B |
     'AddIf() Val' | .NET 6.0 |    50 |   599.604 ns |  1.8770 ns |  1.7557 ns |  0.4533 ns |   596.887 ns |   598.497 ns |   599.990 ns |   600.837 ns |   602.331 ns |   1,667,766.6 |      1.8770 ns |      15.00 |    1.684 |  2.000 |   0.0272 |   14 |            * |       No |     577 B |    5736 B |
     'AddIf() Val' | .NET 7.0 |    50 |   844.863 ns |  6.5328 ns |  6.1108 ns |  1.5778 ns |   834.462 ns |   840.466 ns |   844.126 ns |   847.755 ns |   855.978 ns |   1,183,623.2 |      6.5328 ns |      15.00 |    2.196 |  2.000 |   0.3990 |   16 |            * |       No |     929 B |    5736 B |
     'AddIf() Val' | .NET 6.0 |    75 |   787.490 ns |  3.1963 ns |  2.9898 ns |  0.7720 ns |   782.889 ns |   785.182 ns |   787.347 ns |   789.292 ns |   793.432 ns |   1,269,858.0 |      3.1963 ns |      15.00 |    2.044 |  2.000 |   0.2633 |   15 |            * |       No |     577 B |    8536 B |
     'AddIf() Val' | .NET 7.0 |    75 | 1,153.668 ns |  9.4076 ns |  8.7998 ns |  2.2721 ns | 1,137.598 ns | 1,148.102 ns | 1,155.062 ns | 1,161.069 ns | 1,165.248 ns |     866,800.5 |      9.4076 ns |      15.00 |    1.707 |  2.000 |  -0.2667 |   18 |            * |       No |     929 B |    8536 B |
     'AddIf() Val' | .NET 6.0 |   100 |   989.629 ns |  3.7396 ns |  3.3151 ns |  0.8860 ns |   981.225 ns |   987.722 ns |   990.225 ns |   991.752 ns |   993.827 ns |   1,010,479.8 |      3.7396 ns |      14.00 |    3.421 |  2.000 |  -0.8855 |   17 |            * |       No |     577 B |   11336 B |
     'AddIf() Val' | .NET 7.0 |   100 | 1,551.327 ns | 14.1207 ns | 12.5176 ns |  3.3455 ns | 1,527.804 ns | 1,546.301 ns | 1,547.610 ns | 1,558.331 ns | 1,576.246 ns |     644,609.3 |     14.1207 ns |      14.00 |    2.458 |  2.000 |   0.2743 |   19 |            * |       No |     929 B |   11336 B |
     'AddIf() Val' | .NET 6.0 |   250 | 2,546.916 ns | 17.4376 ns | 16.3111 ns |  4.2115 ns | 2,524.339 ns | 2,535.179 ns | 2,544.495 ns | 2,555.993 ns | 2,578.424 ns |     392,631.7 |     17.4376 ns |      15.00 |    2.106 |  2.000 |   0.4843 |   20 |            * |       No |     577 B |   28136 B |
     'AddIf() Val' | .NET 7.0 |   250 | 3,882.277 ns | 41.9213 ns | 39.2133 ns | 10.1248 ns | 3,811.112 ns | 3,858.899 ns | 3,890.389 ns | 3,904.536 ns | 3,954.753 ns |     257,580.8 |     41.9213 ns |      15.00 |    2.177 |  2.000 |  -0.1651 |   21 |            * |       No |     929 B |   28136 B |