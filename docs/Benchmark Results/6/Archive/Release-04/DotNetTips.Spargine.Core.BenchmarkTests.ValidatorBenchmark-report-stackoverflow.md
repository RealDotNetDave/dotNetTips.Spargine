
    BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19045.2546)
    Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
    .NET SDK=7.0.102
      [Host]     : .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
      Job-NTYPVS : .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
      Job-UPRYLK : .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2

    EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

                                                    Method |  Runtime |                            Categories |     Mean |     Error |    StdDev |    StdErr |      Min |       Q1 |   Median |       Q3 |      Max |          Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
    ------------------------------------------------------ |--------- |-------------------------------------- |---------:|----------:|----------:|----------:|---------:|---------:|---------:|---------:|---------:|--------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
                    **'Validating Collection: No Validation'** | **.NET 6.0** | **Validation,**NEW**,**FOR COMPARISON**** | **2.316 ns** | **0.0236 ns** | **0.0220 ns** | **0.0057 ns** | **2.281 ns** | **2.302 ns** | **2.311 ns** | **2.332 ns** | **2.367 ns** | **431,753,832.7** |      **0.0236 ns** |      **15.00** |    **2.667** |  **2.000** |   **0.5376** |    **1** |            ***** |       **No** |      **62 B** |         **-** |
                    'Validating Collection: No Validation' | .NET 7.0 | Validation,**NEW**,**FOR COMPARISON** | 2.856 ns | 0.0204 ns | 0.0181 ns | 0.0048 ns | 2.826 ns | 2.847 ns | 2.861 ns | 2.869 ns | 2.885 ns | 350,087,211.6 |      0.0204 ns |      14.00 |    1.789 |  2.000 |  -0.3267 |    2 |            * |       No |      63 B |         - |
            **'Validating Collection: Validation + Inlining'** | **.NET 6.0** |                    **Validation,**NEW**** | **7.569 ns** | **0.1591 ns** | **0.1488 ns** | **0.0384 ns** | **7.383 ns** | **7.443 ns** | **7.552 ns** | **7.709 ns** | **7.805 ns** | **132,121,915.1** |      **0.1591 ns** |      **15.00** |    **1.424** |  **2.000** |   **0.2565** |    **7** |            ***** |       **No** |     **240 B** |         **-** |
            'Validating Collection: Validation + Inlining' | .NET 7.0 |                    Validation,**NEW** | 7.484 ns | 0.0531 ns | 0.0471 ns | 0.0126 ns | 7.407 ns | 7.446 ns | 7.491 ns | 7.522 ns | 7.548 ns | 133,621,947.8 |      0.0531 ns |      14.00 |    1.468 |  2.000 |  -0.2583 |    7 |            * |       No |     227 B |         - |
                       **'Validating Collection: Validation'** | **.NET 6.0** |                    **Validation,**NEW**** | **6.412 ns** | **0.0279 ns** | **0.0261 ns** | **0.0067 ns** | **6.362 ns** | **6.393 ns** | **6.414 ns** | **6.425 ns** | **6.456 ns** | **155,959,634.3** |      **0.0279 ns** |      **15.00** |    **2.062** |  **2.000** |  **-0.0556** |    **4** |            ***** |       **No** |     **240 B** |         **-** |
                       'Validating Collection: Validation' | .NET 7.0 |                    Validation,**NEW** | 7.223 ns | 0.0501 ns | 0.0469 ns | 0.0121 ns | 7.140 ns | 7.197 ns | 7.231 ns | 7.258 ns | 7.301 ns | 138,443,284.7 |      0.0501 ns |      15.00 |    1.851 |  2.000 |  -0.1559 |    6 |            * |       No |     227 B |         - |
             **'Validating Empty/Null String: No Validation'** | **.NET 6.0** | **Validation,**NEW**,**FOR COMPARISON**** | **2.297 ns** | **0.0207 ns** | **0.0194 ns** | **0.0050 ns** | **2.268 ns** | **2.286 ns** | **2.294 ns** | **2.307 ns** | **2.338 ns** | **435,294,744.2** |      **0.0207 ns** |      **15.00** |    **2.402** |  **2.000** |   **0.4253** |    **1** |            ***** |       **No** |      **68 B** |         **-** |
             'Validating Empty/Null String: No Validation' | .NET 7.0 | Validation,**NEW**,**FOR COMPARISON** | 2.950 ns | 0.0270 ns | 0.0252 ns | 0.0065 ns | 2.920 ns | 2.927 ns | 2.947 ns | 2.961 ns | 2.998 ns | 338,998,762.6 |      0.0270 ns |      15.00 |    1.952 |  2.000 |   0.4770 |    3 |            * |       No |      69 B |         - |
     **'Validating Empty/Null String: Validation + Inlining'** | **.NET 6.0** | **Validation,**NEW**,**FOR COMPARISON**** | **6.301 ns** | **0.0450 ns** | **0.0421 ns** | **0.0109 ns** | **6.232 ns** | **6.271 ns** | **6.292 ns** | **6.332 ns** | **6.367 ns** | **158,694,168.5** |      **0.0450 ns** |      **15.00** |    **1.753** |  **2.000** |   **0.2494** |    **4** |            ***** |       **No** |     **485 B** |         **-** |
     'Validating Empty/Null String: Validation + Inlining' | .NET 7.0 | Validation,**NEW**,**FOR COMPARISON** | 6.328 ns | 0.0466 ns | 0.0389 ns | 0.0108 ns | 6.256 ns | 6.302 ns | 6.326 ns | 6.362 ns | 6.390 ns | 158,039,143.1 |      0.0466 ns |      13.00 |    1.824 |  2.000 |  -0.1248 |    4 |            * |       No |     784 B |         - |
                **'Validating Empty/Null String: Validation'** | **.NET 6.0** | **Validation,**NEW**,**FOR COMPARISON**** | **6.227 ns** | **0.0583 ns** | **0.0545 ns** | **0.0141 ns** | **6.120 ns** | **6.197 ns** | **6.237 ns** | **6.259 ns** | **6.339 ns** | **160,593,840.2** |      **0.0583 ns** |      **15.00** |    **2.658** |  **2.000** |  **-0.1473** |    **4** |            ***** |       **No** |     **485 B** |         **-** |
                'Validating Empty/Null String: Validation' | .NET 7.0 | Validation,**NEW**,**FOR COMPARISON** | 6.565 ns | 0.0331 ns | 0.0293 ns | 0.0078 ns | 6.501 ns | 6.549 ns | 6.572 ns | 6.585 ns | 6.608 ns | 152,314,254.2 |      0.0331 ns |      14.00 |    2.356 |  2.000 |  -0.5282 |    5 |            * |       No |     875 B |         - |