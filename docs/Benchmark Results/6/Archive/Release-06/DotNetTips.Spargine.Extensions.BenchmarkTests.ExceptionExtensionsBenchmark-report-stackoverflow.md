
    BenchmarkDotNet v0.13.6, Windows 10 (10.0.19045.3208/22H2/2022Update)
    Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
    .NET SDK 8.0.100-preview.6.23330.14
      [Host]     : .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
      Job-RQFQWF : .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
      Job-MOWSHR : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2

    EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  

             Method |  Runtime |     Mean |   Error |  StdDev |  StdErr |      Min |       Q1 |   Median |       Q3 |      Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
    --------------- |--------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
     GetAllMessages | .NET 6.0 | 109.0 ns | 1.70 ns | 1.59 ns | 0.41 ns | 106.6 ns | 107.9 ns | 108.9 ns | 110.3 ns | 111.9 ns | 9,172,696.3 |      1.6983 ns |      15.00 |    1.717 |  2.000 |   0.2097 |    1 |            * |       No |     493 B |     144 B |
     GetAllMessages | .NET 7.0 | 111.1 ns | 0.28 ns | 0.25 ns | 0.07 ns | 110.6 ns | 111.0 ns | 111.1 ns | 111.2 ns | 111.5 ns | 9,000,944.0 |      0.2795 ns |      14.00 |    2.542 |  2.000 |  -0.5112 |    2 |            * |       No |     864 B |     144 B |
