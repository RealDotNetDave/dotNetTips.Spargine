
    BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.985 (20H2/October2020Update)
    Unknown processor
    .NET SDK=5.0.300
      [Host]     : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
      Job-PVYZXO : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT

    EvaluateOverhead=True  Server=True  Toolchain=.NET 5.0  
    Namespace=dotNetTips.Spargine.Extensions.BenchmarkTests  Categories=EnumExtensions  

             Method |       Mean |   Error |  StdDev |  StdErr |        Min |         Q1 |     Median |         Q3 |        Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline |  Gen 0 | Gen 1 | Gen 2 | Allocated | Code Size |
    --------------- |-----------:|--------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|------:|------:|----------:|----------:|
     **GetDescription** |   **433.6 ns** | **0.49 ns** | **0.44 ns** | **0.12 ns** |   **432.7 ns** |   **433.3 ns** |   **433.5 ns** |   **434.0 ns** |   **434.3 ns** | **2,306,422.9** |      **0.4938 ns** |      **14.00** |    **1.935** |  **2.000** |  **-0.1941** |    **1** |            ***** |       **No** | **0.0024** |     **-** |     **-** |      **24 B** |     **272 B** |
           **GetItems** | **1,080.2 ns** | **3.33 ns** | **3.12 ns** | **0.80 ns** | **1,075.3 ns** | **1,078.1 ns** | **1,079.5 ns** | **1,083.5 ns** | **1,086.1 ns** |   **925,731.6** |      **3.3318 ns** |      **15.00** |    **1.793** |  **2.000** |   **0.3730** |    **2** |            ***** |       **No** | **0.0553** |     **-** |     **-** |     **512 B** |     **425 B** |
