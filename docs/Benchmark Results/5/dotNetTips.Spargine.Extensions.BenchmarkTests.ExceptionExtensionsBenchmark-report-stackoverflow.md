
    BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
    Unknown processor
    .NET SDK=6.0.100-preview.7.21379.14
      [Host]     : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
      Job-LAXWQE : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT

    EvaluateOverhead=True  Server=True  Toolchain=.NET 5.0  
    Namespace=dotNetTips.Spargine.Extensions.BenchmarkTests  

             Method |     Mean |   Error |  StdDev |  StdErr |      Min |       Q1 |   Median |       Q3 |      Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline |  Gen 0 | Code Size | Allocated |
    --------------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|----------:|----------:|
     GetAllMessages | 192.4 ns | 0.87 ns | 0.81 ns | 0.21 ns | 191.4 ns | 191.8 ns | 192.4 ns | 192.9 ns | 194.0 ns | 5,198,272.5 |      0.8657 ns |      15.00 |    1.891 |  2.000 |   0.4119 |    1 |            * |       No | 0.0300 |     350 B |     272 B |
