
    BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1415 (21H1/May2021Update)
    Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
    .NET SDK=6.0.101
      [Host]     : .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
      Job-GTSYRY : .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT

    EvaluateOverhead=True  Server=True  Toolchain=.NET 5.0  
    Namespace=dotNetTips.Spargine.Extensions.BenchmarkTests  

             Method |     Mean |   Error |  StdDev |  StdErr |      Min |       Q1 |   Median |       Q3 |      Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline |  Gen 0 | Code Size | Allocated |
    --------------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|----------:|----------:|
     GetAllMessages | 182.0 ns | 1.90 ns | 1.77 ns | 0.46 ns | 179.3 ns | 180.5 ns | 182.2 ns | 183.0 ns | 185.0 ns | 5,495,744.9 |       1.897 ns |      15.00 |    1.663 |  2.000 |   0.0050 |    1 |            * |       No | 0.0298 |     350 B |     272 B |
