
    BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
    Unknown processor
    .NET SDK=6.0.100-preview.7.21379.14
      [Host]     : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
      Job-DBSZBQ : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT

    EvaluateOverhead=True  Server=True  Toolchain=.NET 5.0  
    Namespace=dotNetTips.Spargine.Extensions.BenchmarkTests  Categories=EnumExtensions  

             Method |       Mean |   Error |  StdDev |  StdErr |        Min |         Q1 |     Median |         Q3 |        Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size |  Gen 0 | Allocated |
    --------------- |-----------:|--------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-------:|----------:|
     **GetDescription** |   **469.0 ns** | **1.39 ns** | **1.30 ns** | **0.34 ns** |   **467.8 ns** |   **468.1 ns** |   **468.5 ns** |   **469.6 ns** |   **471.7 ns** | **2,132,352.8** |       **1.393 ns** |      **15.00** |    **2.756** |  **2.000** |   **1.0659** |    **1** |            ***** |       **No** |     **272 B** | **0.0024** |      **24 B** |
           **GetItems** | **1,170.5 ns** | **2.13 ns** | **1.78 ns** | **0.49 ns** | **1,167.8 ns** | **1,169.4 ns** | **1,170.5 ns** | **1,171.6 ns** | **1,174.1 ns** |   **854,317.0** |       **2.133 ns** |      **13.00** |    **2.097** |  **2.000** |   **0.2238** |    **2** |            ***** |       **No** |     **425 B** | **0.0553** |     **512 B** |
