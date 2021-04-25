``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.300-preview.21180.15
  [Host]     : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
  Job-PDALPH : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 5.0  
Namespace=dotNetTips.Spargine.Core.BenchmarkTests  Categories=CachedEnumerable Class  

```
|                               Method | Count |     Mean |    Error |   StdDev |   StdErr |      Min |       Q1 |   Median |       Q3 |      Max |         Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline |  Gen 0 | Gen 1 | Gen 2 | Allocated | Code Size |
|------------------------------------- |------ |---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|------:|------:|----------:|----------:|
| &#39;CachedEnumerable.Create: From List&#39; |    10 | 14.42 ns | 0.029 ns | 0.027 ns | 0.007 ns | 14.35 ns | 14.40 ns | 14.42 ns | 14.44 ns | 14.45 ns | 69,346,315.5 |      0.0293 ns |      15.00 |    3.078 |  2.000 |  -0.8877 |    2 |            * |       No | 0.0088 |     - |     - |      80 B |     128 B |
| &#39;CachedEnumerable.Create: From List&#39; |    25 | 13.81 ns | 0.030 ns | 0.028 ns | 0.007 ns | 13.77 ns | 13.79 ns | 13.81 ns | 13.83 ns | 13.86 ns | 72,397,079.7 |      0.0297 ns |      15.00 |    1.612 |  2.000 |   0.1165 |    1 |            * |       No | 0.0088 |     - |     - |      80 B |     128 B |
| &#39;CachedEnumerable.Create: From List&#39; |    50 | 14.26 ns | 0.039 ns | 0.036 ns | 0.009 ns | 14.18 ns | 14.24 ns | 14.26 ns | 14.29 ns | 14.31 ns | 70,111,641.9 |      0.0388 ns |      15.00 |    2.458 |  2.000 |  -0.4818 |    2 |            * |       No | 0.0089 |     - |     - |      80 B |     128 B |
| &#39;CachedEnumerable.Create: From List&#39; |   100 | 14.24 ns | 0.025 ns | 0.022 ns | 0.006 ns | 14.20 ns | 14.22 ns | 14.24 ns | 14.25 ns | 14.28 ns | 70,232,895.4 |      0.0250 ns |      14.00 |    2.081 |  2.000 |   0.1446 |    2 |            * |       No | 0.0089 |     - |     - |      80 B |     128 B |
| &#39;CachedEnumerable.Create: From List&#39; |   250 | 14.30 ns | 0.015 ns | 0.014 ns | 0.004 ns | 14.27 ns | 14.29 ns | 14.30 ns | 14.31 ns | 14.32 ns | 69,947,410.1 |      0.0154 ns |      15.00 |    1.839 |  2.000 |  -0.1138 |    2 |            * |       No | 0.0089 |     - |     - |      80 B |     128 B |
| &#39;CachedEnumerable.Create: From List&#39; |   500 | 13.78 ns | 0.036 ns | 0.030 ns | 0.008 ns | 13.71 ns | 13.76 ns | 13.77 ns | 13.79 ns | 13.82 ns | 72,582,497.8 |      0.0364 ns |      13.00 |    2.432 |  2.000 |  -0.2167 |    1 |            * |       No | 0.0088 |     - |     - |      80 B |     128 B |
| &#39;CachedEnumerable.Create: From List&#39; |  1000 | 14.41 ns | 0.059 ns | 0.055 ns | 0.014 ns | 14.32 ns | 14.36 ns | 14.41 ns | 14.44 ns | 14.52 ns | 69,415,599.9 |      0.0586 ns |      15.00 |    2.135 |  2.000 |   0.1905 |    2 |            * |       No | 0.0086 |     - |     - |      80 B |     128 B |
