
    BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
    Unknown processor
    .NET SDK=6.0.100-preview.7.21379.14
      [Host]     : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
      Job-DBSZBQ : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT

    EvaluateOverhead=True  Server=True  Toolchain=.NET 5.0  
    Namespace=dotNetTips.Spargine.Extensions.BenchmarkTests.Extensions  Categories=AssemblyExtensions  

               Method |       Mean |    Error |   StdDev |  StdErr |        Min |         Q1 |     Median |         Q3 |        Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline |  Gen 0 | Code Size | Allocated |
    ----------------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|----------:|----------:|
     **GetAllInterfaces** | **2,031.6 ns** | **12.29 ns** | **10.26 ns** | **2.85 ns** | **2,014.2 ns** | **2,024.7 ns** | **2,027.2 ns** | **2,041.6 ns** | **2,048.9 ns** |   **492,228.7** |      **12.286 ns** |      **13.00** |    **1.626** |  **2.000** |   **0.1087** |    **3** |            ***** |       **No** | **0.0305** |     **256 B** |     **312 B** |
          **GetAllTypes** | **1,368.2 ns** |  **5.68 ns** |  **5.31 ns** | **1.37 ns** | **1,357.8 ns** | **1,363.4 ns** | **1,370.8 ns** | **1,372.2 ns** | **1,375.3 ns** |   **730,888.0** |       **5.675 ns** |      **15.00** |    **1.760** |  **2.000** |  **-0.5069** |    **2** |            ***** |       **No** | **0.0248** |     **263 B** |     **240 B** |
         **GetInstances** |   **737.8 ns** |  **3.81 ns** |  **3.37 ns** | **0.90 ns** |   **731.6 ns** |   **735.6 ns** |   **738.2 ns** |   **738.8 ns** |   **744.5 ns** | **1,355,404.1** |       **3.807 ns** |      **14.00** |    **2.443** |  **2.000** |   **0.1092** |    **1** |            ***** |       **No** | **0.0057** |     **199 B** |      **56 B** |
