
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.200-preview.21079.7
  [Host]     : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
  Job-FKHTBO : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 5.0  
Namespace=dotNetTips.Spargine.Core.BenchmarkTests  Categories=CachedEnumerable Class  

                               Method | Count |     Mean |    Error |   StdDev |   StdErr |   Median |      Min |       Q1 |       Q3 |      Max |         Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline |  Gen 0 | Gen 1 | Gen 2 | Allocated | Code Size |
------------------------------------- |------ |---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|------:|------:|----------:|----------:|
 'CachedEnumerable.Create: From List' |     2 | 22.63 ns | 0.337 ns | 0.315 ns | 0.081 ns | 22.74 ns | 22.00 ns | 22.42 ns | 22.83 ns | 23.00 ns | 44,196,807.2 |      0.3372 ns |      15.00 |    2.178 |  2.000 |  -0.7524 |    5 |            * |       No | 0.0086 |     - |     - |      80 B |     128 B |
 'CachedEnumerable.Create: From List' |     5 | 21.50 ns | 0.255 ns | 0.283 ns | 0.065 ns | 21.54 ns | 21.03 ns | 21.35 ns | 21.65 ns | 22.01 ns | 46,522,310.3 |      0.2545 ns |      19.00 |    2.001 |  2.000 |  -0.0535 |    4 |            * |       No | 0.0086 |     - |     - |      80 B |     128 B |
 'CachedEnumerable.Create: From List' |    10 | 19.94 ns | 0.320 ns | 0.299 ns | 0.077 ns | 19.91 ns | 19.33 ns | 19.81 ns | 20.16 ns | 20.40 ns | 50,147,254.0 |      0.3196 ns |      15.00 |    2.316 |  2.000 |  -0.4769 |    1 |            * |       No | 0.0086 |     - |     - |      80 B |     128 B |
 'CachedEnumerable.Create: From List' |    25 | 20.67 ns | 0.191 ns | 0.159 ns | 0.044 ns | 20.75 ns | 20.41 ns | 20.48 ns | 20.77 ns | 20.82 ns | 48,387,132.2 |      0.1909 ns |      13.00 |    1.505 |  2.000 |  -0.6879 |    1 |            * |       No | 0.0086 |     - |     - |      80 B |     128 B |
 'CachedEnumerable.Create: From List' |    50 | 20.39 ns | 0.364 ns | 0.341 ns | 0.088 ns | 20.35 ns | 19.89 ns | 20.11 ns | 20.54 ns | 21.07 ns | 49,043,248.0 |      0.3641 ns |      15.00 |    2.294 |  2.000 |   0.5309 |    1 |            * |       No | 0.0086 |     - |     - |      80 B |     128 B |
 'CachedEnumerable.Create: From List' |   100 | 20.17 ns | 0.412 ns | 0.423 ns | 0.103 ns | 20.11 ns | 19.46 ns | 19.89 ns | 20.43 ns | 20.97 ns | 49,576,298.1 |      0.4116 ns |      17.00 |    2.117 |  2.000 |   0.3798 |    1 |            * |       No | 0.0087 |     - |     - |      80 B |     128 B |
 'CachedEnumerable.Create: From List' |   250 | 20.98 ns | 0.901 ns | 2.420 ns | 0.264 ns | 20.13 ns | 18.93 ns | 19.69 ns | 20.65 ns | 29.94 ns | 47,669,162.4 |      0.9007 ns |      84.00 |    7.512 |  2.000 |   2.3099 |    2 |            * |       No | 0.0087 |     - |     - |      80 B |     128 B |
 'CachedEnumerable.Create: From List' |   500 | 20.28 ns | 0.357 ns | 0.334 ns | 0.086 ns | 20.30 ns | 19.63 ns | 20.04 ns | 20.44 ns | 20.97 ns | 49,319,762.6 |      0.3568 ns |      15.00 |    2.578 |  2.000 |   0.0791 |    1 |            * |       No | 0.0086 |     - |     - |      80 B |     128 B |
 'CachedEnumerable.Create: From List' |  1000 | 21.01 ns | 0.246 ns | 0.230 ns | 0.059 ns | 20.90 ns | 20.76 ns | 20.83 ns | 21.18 ns | 21.45 ns | 47,596,156.5 |      0.2463 ns |      15.00 |    1.802 |  2.000 |   0.5446 |    3 |            * |       No | 0.0085 |     - |     - |      80 B |     128 B |
