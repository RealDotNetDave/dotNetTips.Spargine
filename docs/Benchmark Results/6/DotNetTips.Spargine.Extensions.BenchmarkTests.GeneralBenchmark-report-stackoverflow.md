
    BenchmarkDotNet v0.13.6, Windows 10 (10.0.19045.3208/22H2/2022Update)
    Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
    .NET SDK 8.0.100-preview.6.23330.14
      [Host]     : .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
      Job-RQFQWF : .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
      Job-MOWSHR : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2

    EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  
    Categories=**FOR COMPARISON**  

             Method |  Runtime |     Mean |     Error |    StdDev |    StdErr |      Min |       Q1 |   Median |       Q3 |      Max |          Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
    --------------- |--------- |---------:|----------:|----------:|----------:|---------:|---------:|---------:|---------:|---------:|--------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
     'Equals: Guid' | .NET 6.0 | 2.605 ns | 0.0281 ns | 0.0262 ns | 0.0068 ns | 2.555 ns | 2.587 ns | 2.608 ns | 2.630 ns | 2.642 ns | 383,872,432.5 |      0.0281 ns |      15.00 |    1.715 |  2.000 |  -0.1183 |    2 |            * |       No |     117 B |         - |
     'Equals: Guid' | .NET 7.0 | 2.203 ns | 0.0041 ns | 0.0039 ns | 0.0010 ns | 2.198 ns | 2.200 ns | 2.202 ns | 2.205 ns | 2.211 ns | 453,902,733.4 |      0.0041 ns |      15.00 |    2.027 |  2.000 |   0.5524 |    1 |            * |       No |     105 B |         - |
