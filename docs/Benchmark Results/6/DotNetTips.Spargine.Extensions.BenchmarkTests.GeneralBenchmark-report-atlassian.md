{noformat}

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 10 (10.0.19045.3570/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-rc.2.23502.2
  [Host]     : .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
  Job-XHVJJL : .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
  Job-SWNUOI : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2

EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  
Categories=**FOR COMPARISON**  

{noformat}
||Method         ||Runtime  ||Mean     ||Error     ||StdDev    ||StdErr    ||Min      ||Q1       ||Median   ||Q3       ||Max      ||Op/s          ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline ||Code Size ||Allocated ||
| 'Equals: Guid' | .NET 6.0 | 2.686 ns | 0.0200 ns | 0.0188 ns | 0.0048 ns | 2.654 ns | 2.672 ns | 2.684 ns | 2.703 ns | 2.714 ns | 372,297,401.6 |      0.0200 ns |      15.00 |    1.644 |  2.000 |  -0.0294 |    2 | *            | No       |     117 B |         - |
| 'Equals: Guid' | .NET 7.0 | 2.409 ns | 0.0188 ns | 0.0176 ns | 0.0045 ns | 2.368 ns | 2.399 ns | 2.414 ns | 2.421 ns | 2.428 ns | 415,194,661.9 |      0.0188 ns |      15.00 |    2.527 |  2.000 |  -0.8354 |    1 | *            | No       |     105 B |         - |
