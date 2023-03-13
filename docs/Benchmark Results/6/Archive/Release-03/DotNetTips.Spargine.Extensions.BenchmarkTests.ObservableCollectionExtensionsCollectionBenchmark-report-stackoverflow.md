
    BenchmarkDotNet=v0.13.2.2004-nightly, OS=Windows 10 (10.0.19044.2251/21H2/November2021Update)
    Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
    .NET SDK=7.0.100
      [Host]     : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
      Job-FOHVKI : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
      Job-FJLZQV : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2

    EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  
    Categories=Collections  

                         Method |  Runtime | Count |         Mean |    StdErr |          Min |           Q1 |           Q3 |          Max |         Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
    --------------------------- |--------- |------ |-------------:|----------:|-------------:|-------------:|-------------:|-------------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
         **'HasItems: With Count'** | **.NET 6.0** |    **10** |     **77.29 ns** |  **0.278 ns** |     **75.42 ns** |     **76.73 ns** |     **78.22 ns** |     **78.84 ns** | **12,937,899.5** |      **1.1749 ns** |      **14.00** |    **1.772** |  **2.000** |  **-0.2635** |    **2** |            ***** |       **No** |     **199 B** |      **40 B** |
         'HasItems: With Count' | .NET 7.0 |    10 |     81.33 ns |  0.414 ns |     78.77 ns |     80.01 ns |     83.16 ns |     84.39 ns | 12,295,444.5 |      1.6639 ns |      17.00 |    1.579 |  2.000 |   0.1919 |    3 |            * |       No |     175 B |      40 B |
         'HasItems: With Count' | .NET 6.0 |    25 |    165.23 ns |  0.309 ns |    163.22 ns |    164.25 ns |    166.01 ns |    167.16 ns |  6,052,040.0 |      1.3023 ns |      14.00 |    1.629 |  2.000 |  -0.0695 |    5 |            * |       No |     199 B |      40 B |
         'HasItems: With Count' | .NET 7.0 |    25 |    175.21 ns |  0.472 ns |    172.86 ns |    173.52 ns |    176.39 ns |    178.70 ns |  5,707,478.6 |      1.9524 ns |      15.00 |    1.756 |  2.000 |   0.2738 |    6 |            * |       No |     175 B |      40 B |
         'HasItems: With Count' | .NET 6.0 |    50 |    303.44 ns |  0.755 ns |    298.89 ns |    301.51 ns |    304.85 ns |    309.87 ns |  3,295,582.6 |      3.1859 ns |      14.00 |    2.701 |  2.000 |   0.4977 |    7 |            * |       No |     199 B |      40 B |
         'HasItems: With Count' | .NET 7.0 |    50 |    317.46 ns |  0.834 ns |    311.62 ns |    315.76 ns |    319.28 ns |    323.91 ns |  3,149,995.6 |      3.4550 ns |      15.00 |    2.304 |  2.000 |   0.0738 |    8 |            * |       No |     175 B |      40 B |
         'HasItems: With Count' | .NET 6.0 |   100 |    577.28 ns |  1.041 ns |    570.85 ns |    574.90 ns |    579.19 ns |    584.57 ns |  1,732,262.5 |      4.4953 ns |      13.00 |    2.203 |  2.000 |   0.0584 |    9 |            * |       No |     199 B |      40 B |
         'HasItems: With Count' | .NET 7.0 |   100 |    605.12 ns |  1.346 ns |    598.99 ns |    602.19 ns |    606.46 ns |    616.68 ns |  1,652,578.0 |      5.6832 ns |      14.00 |    2.755 |  2.000 |   0.8852 |   10 |            * |       No |     175 B |      40 B |
         'HasItems: With Count' | .NET 6.0 |   250 |  1,392.41 ns |  4.031 ns |  1,367.06 ns |  1,382.60 ns |  1,400.00 ns |  1,420.84 ns |    718,177.0 |     16.6913 ns |      15.00 |    2.042 |  2.000 |   0.1058 |   11 |            * |       No |     199 B |      40 B |
         'HasItems: With Count' | .NET 7.0 |   250 |  1,471.14 ns |  2.823 ns |  1,458.43 ns |  1,463.65 ns |  1,480.77 ns |  1,488.66 ns |    679,745.9 |     12.1909 ns |      13.00 |    1.439 |  2.000 |   0.3260 |   12 |            * |       No |     175 B |      40 B |
         'HasItems: With Count' | .NET 6.0 |   500 |  2,886.12 ns |  4.231 ns |  2,870.30 ns |  2,873.83 ns |  2,892.28 ns |  2,916.69 ns |    346,485.8 |     17.5199 ns |      15.00 |    2.023 |  2.000 |   0.7986 |   13 |            * |       No |     199 B |      40 B |
         'HasItems: With Count' | .NET 7.0 |   500 |  2,953.97 ns |  5.652 ns |  2,878.15 ns |  2,954.68 ns |  2,961.96 ns |  2,972.32 ns |    338,527.9 |     23.4033 ns |      15.00 |    9.651 |  2.000 |  -2.6882 |   14 |            * |       No |     175 B |      40 B |
         'HasItems: With Count' | .NET 6.0 |  1000 |  5,236.27 ns |  5.013 ns |  5,215.60 ns |  5,220.49 ns |  5,243.65 ns |  5,271.57 ns |    190,975.7 |     21.1583 ns |      14.00 |    1.858 |  2.000 |   0.5417 |   15 |            * |       No |     199 B |      40 B |
         'HasItems: With Count' | .NET 7.0 |  1000 |  5,994.88 ns |  6.229 ns |  5,979.65 ns |  5,980.39 ns |  5,992.23 ns |  6,044.85 ns |    166,808.9 |     26.2899 ns |      14.00 |    2.652 |  2.000 |   1.2202 |   16 |            * |       No |     175 B |      40 B |
         'HasItems: With Count' | .NET 6.0 |  2500 | 13,708.23 ns | 13.410 ns | 13,653.52 ns | 13,666.99 ns | 13,731.78 ns | 13,824.01 ns |     72,948.9 |     56.6002 ns |      14.00 |    2.643 |  2.000 |   0.8248 |   19 |            * |       No |     199 B |      40 B |
         'HasItems: With Count' | .NET 7.0 |  2500 | 15,365.45 ns | 28.955 ns | 15,211.12 ns | 15,314.89 ns | 15,371.75 ns | 15,567.76 ns |     65,081.1 |    122.2129 ns |      14.00 |    2.209 |  2.000 |   0.7003 |   20 |            * |       No |     175 B |      40 B |
     **'HasItems: With Predicate'** | **.NET 6.0** |    **10** |     **59.71 ns** |  **0.292 ns** |     **58.07 ns** |     **58.79 ns** |     **60.61 ns** |     **62.26 ns** | **16,747,970.8** |      **1.1708 ns** |      **17.00** |    **2.135** |  **2.000** |   **0.4784** |    **1** |            ***** |       **No** |     **696 B** |      **40 B** |
     'HasItems: With Predicate' | .NET 7.0 |    10 |     63.06 ns |  0.379 ns |     58.18 ns |     60.58 ns |     64.35 ns |     72.23 ns | 15,858,066.7 |      1.2980 ns |      77.00 |    3.444 |  2.000 |   1.0476 |    1 |            * |       No |     495 B |      40 B |
     'HasItems: With Predicate' | .NET 6.0 |    25 |     60.02 ns |  0.256 ns |     58.02 ns |     59.57 ns |     60.64 ns |     61.60 ns | 16,660,213.1 |      1.0599 ns |      15.00 |    2.266 |  2.000 |  -0.3023 |    1 |            * |       No |     696 B |      40 B |
     'HasItems: With Predicate' | .NET 7.0 |    25 |     61.88 ns |  0.353 ns |     58.98 ns |     60.23 ns |     63.11 ns |     67.59 ns | 16,161,232.6 |      1.2607 ns |      38.00 |    3.139 |  2.000 |   0.8507 |    1 |            * |       No |     495 B |      40 B |
     'HasItems: With Predicate' | .NET 6.0 |    50 |     60.12 ns |  0.335 ns |     57.57 ns |     58.78 ns |     61.28 ns |     64.41 ns | 16,632,313.0 |      1.2361 ns |      28.00 |    2.645 |  2.000 |   0.6991 |    1 |            * |       No |     696 B |      40 B |
     'HasItems: With Predicate' | .NET 7.0 |    50 |     62.32 ns |  0.355 ns |     58.57 ns |     60.69 ns |     63.72 ns |     68.05 ns | 16,045,539.0 |      1.2591 ns |      42.00 |    2.913 |  2.000 |   0.6248 |    1 |            * |       No |     495 B |      40 B |
     'HasItems: With Predicate' | .NET 6.0 |   100 |     59.39 ns |  0.293 ns |     57.90 ns |     58.42 ns |     60.66 ns |     61.26 ns | 16,836,904.7 |      1.1918 ns |      16.00 |    1.477 |  2.000 |   0.4012 |    1 |            * |       No |     696 B |      40 B |
     'HasItems: With Predicate' | .NET 7.0 |   100 |     59.50 ns |  0.240 ns |     58.09 ns |     58.68 ns |     60.20 ns |     61.23 ns | 16,807,079.9 |      0.9943 ns |      15.00 |    1.743 |  2.000 |   0.2871 |    1 |            * |       No |     495 B |      40 B |
     'HasItems: With Predicate' | .NET 6.0 |   250 |     60.09 ns |  0.315 ns |     58.19 ns |     58.96 ns |     61.20 ns |     64.02 ns | 16,640,845.4 |      1.1944 ns |      23.00 |    2.831 |  2.571 |   0.8555 |    1 |            * |       No |     696 B |      40 B |
     'HasItems: With Predicate' | .NET 7.0 |   250 |     61.01 ns |  0.296 ns |     59.68 ns |     60.08 ns |     61.80 ns |     62.93 ns | 16,390,850.3 |      1.2053 ns |      16.00 |    1.582 |  2.222 |   0.4749 |    1 |            * |       No |     495 B |      40 B |
     'HasItems: With Predicate' | .NET 6.0 |   500 |     59.76 ns |  0.174 ns |     58.93 ns |     59.23 ns |     60.32 ns |     61.04 ns | 16,734,414.5 |      0.7214 ns |      15.00 |    1.837 |  2.000 |   0.4728 |    1 |            * |       No |     696 B |      40 B |
     'HasItems: With Predicate' | .NET 7.0 |   500 |     60.42 ns |  0.197 ns |     58.90 ns |     59.99 ns |     60.80 ns |     61.63 ns | 16,551,697.5 |      0.8326 ns |      14.00 |    2.307 |  2.000 |  -0.0819 |    1 |            * |       No |     495 B |      40 B |
     'HasItems: With Predicate' | .NET 6.0 |  1000 |     60.52 ns |  0.242 ns |     59.30 ns |     59.71 ns |     61.29 ns |     62.10 ns | 16,524,518.0 |      1.0024 ns |      15.00 |    1.443 |  2.000 |   0.1235 |    1 |            * |       No |     696 B |      40 B |
     'HasItems: With Predicate' | .NET 7.0 |  1000 |     60.92 ns |  0.277 ns |     59.06 ns |     60.36 ns |     61.36 ns |     62.87 ns | 16,414,070.9 |      1.1711 ns |      14.00 |    2.242 |  2.000 |   0.1535 |    1 |            * |       No |     495 B |      40 B |
     'HasItems: With Predicate' | .NET 6.0 |  2500 |     59.73 ns |  0.281 ns |     58.11 ns |     58.95 ns |     60.05 ns |     61.70 ns | 16,741,840.5 |      1.1644 ns |      15.00 |    2.035 |  2.000 |   0.4940 |    1 |            * |       No |     696 B |      40 B |
     'HasItems: With Predicate' | .NET 7.0 |  2500 |     61.15 ns |  0.322 ns |     59.02 ns |     60.08 ns |     62.23 ns |     66.40 ns | 16,353,445.8 |      1.1723 ns |      31.00 |    3.535 |  2.000 |   1.0492 |    1 |            * |       No |     495 B |      40 B |
                       **HasItems** | **.NET 6.0** |    **10** |     **91.61 ns** |  **0.532 ns** |     **84.94 ns** |     **88.49 ns** |     **94.18 ns** |     **99.62 ns** | **10,916,091.5** |      **1.8528 ns** |      **55.00** |    **1.956** |  **2.000** |   **0.2536** |    **4** |            ***** |       **No** |     **198 B** |      **40 B** |
                       HasItems | .NET 7.0 |    10 |     81.05 ns |  0.440 ns |     77.65 ns |     79.57 ns |     82.69 ns |     85.78 ns | 12,338,068.2 |      1.6232 ns |      28.00 |    2.116 |  2.000 |   0.5132 |    3 |            * |       No |     178 B |      40 B |
                       HasItems | .NET 6.0 |    25 |    173.29 ns |  0.398 ns |    170.85 ns |    172.70 ns |    174.36 ns |    175.17 ns |  5,770,590.5 |      1.7172 ns |      13.00 |    1.759 |  2.000 |  -0.4202 |    6 |            * |       No |     198 B |      40 B |
                       HasItems | .NET 7.0 |    25 |    176.28 ns |  0.447 ns |    173.30 ns |    175.15 ns |    177.71 ns |    178.04 ns |  5,672,873.6 |      1.8879 ns |      14.00 |    1.623 |  2.000 |  -0.5385 |    6 |            * |       No |     178 B |      40 B |
                       HasItems | .NET 6.0 |    50 |    300.63 ns |  0.639 ns |    296.44 ns |    299.22 ns |    302.24 ns |    306.22 ns |  3,326,359.8 |      2.6457 ns |      15.00 |    2.686 |  2.000 |   0.3324 |    7 |            * |       No |     198 B |      40 B |
                       HasItems | .NET 7.0 |    50 |    318.39 ns |  0.703 ns |    314.47 ns |    316.91 ns |    319.38 ns |    323.38 ns |  3,140,758.3 |      2.9663 ns |      14.00 |    2.322 |  2.000 |   0.6181 |    8 |            * |       No |     178 B |      40 B |
                       HasItems | .NET 6.0 |   100 |    595.00 ns |  1.003 ns |    589.33 ns |    592.40 ns |    596.88 ns |    601.21 ns |  1,680,683.0 |      4.4490 ns |      12.00 |    1.825 |  2.000 |  -0.0394 |   10 |            * |       No |     198 B |      40 B |
                       HasItems | .NET 7.0 |   100 |    604.07 ns |  1.826 ns |    594.32 ns |    599.36 ns |    608.56 ns |    620.74 ns |  1,655,431.9 |      7.5598 ns |      15.00 |    2.649 |  2.000 |   0.6024 |   10 |            * |       No |     178 B |      40 B |
                       HasItems | .NET 6.0 |   250 |  1,451.21 ns |  4.256 ns |  1,426.55 ns |  1,437.29 ns |  1,466.96 ns |  1,477.11 ns |    689,078.4 |     17.6200 ns |      15.00 |    1.538 |  2.000 |   0.0058 |   12 |            * |       No |     198 B |      40 B |
                       HasItems | .NET 7.0 |   250 |  1,455.47 ns |  1.663 ns |  1,446.07 ns |  1,451.95 ns |  1,460.09 ns |  1,465.62 ns |    687,064.1 |      7.0185 ns |      14.00 |    1.779 |  2.000 |  -0.2569 |   12 |            * |       No |     178 B |      40 B |
                       HasItems | .NET 6.0 |   500 |  2,880.26 ns |  2.659 ns |  2,868.77 ns |  2,871.42 ns |  2,886.21 ns |  2,903.67 ns |    347,191.0 |     11.0091 ns |      15.00 |    2.337 |  2.000 |   0.6663 |   13 |            * |       No |     198 B |      40 B |
                       HasItems | .NET 7.0 |   500 |  2,887.62 ns |  1.836 ns |  2,879.43 ns |  2,883.52 ns |  2,891.88 ns |  2,899.30 ns |    346,305.5 |      8.1470 ns |      12.00 |    1.694 |  2.000 |   0.3042 |   13 |            * |       No |     178 B |      40 B |
                       HasItems | .NET 6.0 |  1000 |  5,217.57 ns |  2.948 ns |  5,197.61 ns |  5,211.11 ns |  5,220.99 ns |  5,239.54 ns |    191,660.0 |     12.4427 ns |      14.00 |    2.441 |  2.000 |   0.3389 |   15 |            * |       No |     198 B |      40 B |
                       HasItems | .NET 7.0 |  1000 |  6,229.20 ns |  3.541 ns |  6,211.27 ns |  6,219.62 ns |  6,235.34 ns |  6,252.99 ns |    160,534.2 |     14.9462 ns |      14.00 |    1.869 |  2.000 |   0.5007 |   17 |            * |       No |     178 B |      40 B |
                       HasItems | .NET 6.0 |  2500 | 13,012.08 ns | 23.276 ns | 12,793.32 ns | 13,017.36 ns | 13,062.91 ns | 13,086.73 ns |     76,851.7 |     96.3723 ns |      15.00 |    4.277 |  2.000 |  -1.6386 |   18 |            * |       No |     198 B |      40 B |
                       HasItems | .NET 7.0 |  2500 | 15,289.48 ns | 15.758 ns | 15,202.92 ns | 15,237.92 ns | 15,319.65 ns | 15,421.41 ns |     65,404.5 |     65.2458 ns |      15.00 |    2.412 |  2.000 |   0.5825 |   20 |            * |       No |     178 B |      40 B |