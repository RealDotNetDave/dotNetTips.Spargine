
    BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
    Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
    .NET SDK=6.0.300
      [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
      Job-SPYWVM : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

    EvaluateOverhead=True  Server=True  Toolchain=.NET 6.0  
    Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  

             Method |     Mean |   Error |  StdDev |  StdErr |      Min |       Q1 |   Median |       Q3 |      Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline |  Gen 0 | Code Size | Allocated |
    --------------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|----------:|----------:|
     GetAllMessages | 180.8 ns | 3.59 ns | 3.18 ns | 0.85 ns | 176.1 ns | 177.9 ns | 180.9 ns | 184.1 ns | 184.4 ns | 5,531,897.6 |       3.589 ns |      14.00 |    1.317 |  2.000 |  -0.1661 |    1 |            * |       No | 0.0298 |     423 B |     272 B |
