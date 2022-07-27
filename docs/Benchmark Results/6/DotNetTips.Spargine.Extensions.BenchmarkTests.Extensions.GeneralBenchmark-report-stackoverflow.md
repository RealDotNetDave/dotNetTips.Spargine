
    BenchmarkDotNet=v0.13.1.1819-nightly, OS=Windows 10 (10.0.19044.1826/21H2/November2021Update)
    Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
    .NET SDK=7.0.100-preview.6.22352.1
      [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
      Job-VIFSJL : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
      Job-VGZOLO : .NET 7.0.0 (7.0.22.32404), X64 RyuJIT

    EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests.Extensions  

              Method |        Job |  Runtime |     Mean |   Error |   StdDev |  StdErr |   Median |      Min |       Q1 |       Q3 |      Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
    ---------------- |----------- |--------- |---------:|--------:|---------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
     FastEquals:Guid | Job-VIFSJL | .NET 6.0 | 147.4 ns | 3.00 ns |  5.41 ns | 0.85 ns | 145.7 ns | 138.8 ns | 144.4 ns | 151.6 ns | 159.2 ns | 6,782,235.5 |       3.002 ns |      41.00 |    2.496 |  2.615 |   0.6599 |    1 |            * |       No |     206 B |         - |
     FastEquals:Guid | Job-VGZOLO | .NET 7.0 | 154.3 ns | 4.09 ns | 11.53 ns | 1.20 ns | 150.7 ns | 140.1 ns | 145.6 ns | 160.2 ns | 186.8 ns | 6,481,159.0 |       4.087 ns |      92.00 |    3.846 |  2.500 |   1.2636 |    2 |            * |       No |     329 B |         - |
