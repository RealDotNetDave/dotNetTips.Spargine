{noformat}

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.3930/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.200-preview.23624.5
  [Host]     : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
  Job-NOURTH : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
  Job-UZHQTL : .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2

EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  

{noformat}
||Method         ||Runtime  ||Mean     ||Error   ||StdDev  ||StdErr  ||Min      ||Q1       ||Median   ||Q3       ||Max      ||Op/s        ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline ||Code Size ||Allocated ||
| GetAllMessages | .NET 6.0 | 101.0 ns | 0.72 ns | 0.64 ns | 0.17 ns | 100.3 ns | 100.5 ns | 100.8 ns | 101.1 ns | 102.5 ns | 9,902,353.9 |      0.7225 ns |      14.00 |    2.880 |  2.000 |   1.0924 |    1 | *            | No       |     493 B |     144 B |
| GetAllMessages | .NET 7.0 | 104.2 ns | 0.41 ns | 0.38 ns | 0.10 ns | 103.4 ns | 103.9 ns | 104.2 ns | 104.4 ns | 104.7 ns | 9,600,980.2 |      0.4095 ns |      15.00 |    1.848 |  2.000 |  -0.3635 |    2 | *            | No       |     864 B |     144 B |
