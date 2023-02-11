``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1826 (21H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=7.0.100-preview.6.22352.1
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
  Job-TRKAEU : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT

EvaluateOverhead=True  Runtime=.NET 6.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  

```
|         Method |     Mean |   Error |  StdDev |  StdErr |      Min |       Q1 |   Median |       Q3 |      Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline |  Gen 0 | Code Size | Allocated |
|--------------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|----------:|----------:|
| GetAllMessages | 185.2 ns | 3.68 ns | 4.52 ns | 0.96 ns | 178.4 ns | 181.7 ns | 184.8 ns | 187.9 ns | 198.0 ns | 5,399,553.5 |       3.683 ns |      22.00 |    3.611 |  2.000 |   0.7826 |    1 |            * |       No | 0.0296 |     446 B |     272 B |
