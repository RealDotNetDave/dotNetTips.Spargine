
BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 10 (10.0.19045.3570/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-rc.2.23502.2
  [Host]     : .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
  Job-XHVJJL : .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
  Job-SWNUOI : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2

EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  

 Method         | Runtime  | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
--------------- |--------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
 GetAllMessages | .NET 6.0 | 171.4 ns | 0.41 ns | 0.36 ns | 0.10 ns | 170.9 ns | 171.1 ns | 171.3 ns | 171.6 ns | 172.2 ns | 5,835,993.6 |      0.4057 ns |      14.00 |    2.778 |  2.000 |   0.8218 |    1 | *            | No       |     739 B |     144 B |
 GetAllMessages | .NET 7.0 | 174.1 ns | 0.70 ns | 0.62 ns | 0.17 ns | 172.8 ns | 173.9 ns | 174.1 ns | 174.3 ns | 175.0 ns | 5,744,607.3 |      0.7011 ns |      14.00 |    2.610 |  2.000 |  -0.5664 |    2 | *            | No       |     745 B |     144 B |
