``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1645 (21H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.300-preview.22204.3
  [Host]     : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
  Job-WQKGXY : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 6.0  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  

```
|         Method |     Mean |   Error |  StdDev |  StdErr |      Min |       Q1 |   Median |       Q3 |      Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline |  Gen 0 | Code Size | Allocated |
|--------------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|----------:|----------:|
| GetAllMessages | 169.5 ns | 2.71 ns | 2.41 ns | 0.64 ns | 164.3 ns | 168.3 ns | 170.1 ns | 170.8 ns | 174.0 ns | 5,898,122.1 |       2.714 ns |      14.00 |    2.751 |  2.000 |  -0.3591 |    1 |            * |       No | 0.0300 |     423 B |     272 B |
