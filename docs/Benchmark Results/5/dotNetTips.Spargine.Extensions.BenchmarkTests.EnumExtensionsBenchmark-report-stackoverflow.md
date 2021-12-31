
    BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1415 (21H1/May2021Update)
    Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
    .NET SDK=6.0.101
      [Host]     : .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
      Job-GTSYRY : .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT

    EvaluateOverhead=True  Server=True  Toolchain=.NET 5.0  
    Namespace=dotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

             Method |       Mean |    Error |   StdDev |  StdErr |        Min |         Q1 |     Median |         Q3 |        Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline |  Gen 0 | Code Size | Allocated |
    --------------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|----------:|----------:|
     **GetDescription** |   **427.5 ns** |  **3.72 ns** |  **3.11 ns** | **0.86 ns** |   **422.9 ns** |   **425.3 ns** |   **427.0 ns** |   **429.0 ns** |   **433.6 ns** | **2,339,080.9** |       **3.719 ns** |      **13.00** |    **2.139** |  **2.000** |   **0.4755** |    **1** |            ***** |       **No** | **0.0024** |     **272 B** |      **24 B** |
           **GetItems** | **1,075.1 ns** | **18.58 ns** | **17.38 ns** | **4.49 ns** | **1,041.3 ns** | **1,066.3 ns** | **1,072.4 ns** | **1,086.5 ns** | **1,111.6 ns** |   **930,153.0** |      **18.579 ns** |      **15.00** |    **2.644** |  **2.000** |   **0.1566** |    **2** |            ***** |       **No** | **0.0553** |     **425 B** |     **512 B** |
