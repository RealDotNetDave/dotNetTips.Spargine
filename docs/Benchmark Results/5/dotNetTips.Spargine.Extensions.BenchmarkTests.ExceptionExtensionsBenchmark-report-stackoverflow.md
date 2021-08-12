
    BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
    Unknown processor
    .NET SDK=6.0.100-preview.7.21379.14
      [Host]     : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
      Job-DBSZBQ : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT

    EvaluateOverhead=True  Server=True  Toolchain=.NET 5.0  
    Namespace=dotNetTips.Spargine.Extensions.BenchmarkTests  Categories=ExceptionExtensions  

             Method |     Mean |   Error |  StdDev |  StdErr |      Min |       Q1 |   Median |       Q3 |      Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size |  Gen 0 | Allocated |
    --------------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-------:|----------:|
     GetAllMessages | 213.2 ns | 0.78 ns | 0.73 ns | 0.19 ns | 211.9 ns | 212.8 ns | 213.1 ns | 213.9 ns | 214.3 ns | 4,689,357.8 |      0.7784 ns |      15.00 |    1.666 |  2.000 |  -0.1491 |    1 |            * |       No |     384 B | 0.0296 |     272 B |
