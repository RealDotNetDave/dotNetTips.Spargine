
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.200-preview.21079.7
  [Host]     : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
  Job-MOYFHY : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 5.0  
Namespace=dotNetTips.Spargine.Core.BenchmarkTests  Categories=CachedEnumerable Class  

                               Method | Count |     Mean |    Error |   StdDev |   StdErr |   Median |      Min |       Q1 |       Q3 |      Max |         Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline |  Gen 0 | Gen 1 | Gen 2 | Allocated | Code Size |
------------------------------------- |------ |---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|------:|------:|----------:|----------:|
 'CachedEnumerable.Create: From List' |     2 | 18.61 ns | 0.363 ns | 0.789 ns | 0.105 ns | 18.42 ns | 17.56 ns | 18.13 ns | 18.99 ns | 21.40 ns | 53,747,332.4 |      0.3629 ns |      57.00 |    5.915 |  2.000 |   1.5665 |    1 |            * |       No | 0.0087 |     - |     - |      80 B |     128 B |
 'CachedEnumerable.Create: From List' |     5 | 26.31 ns | 2.702 ns | 7.753 ns | 0.795 ns | 22.01 ns | 20.77 ns | 21.63 ns | 29.46 ns | 46.38 ns | 38,012,090.2 |      2.7023 ns |      95.00 |    3.419 |  2.303 |   1.3991 |    6 |            * |       No | 0.0087 |     - |     - |      80 B |     128 B |
 'CachedEnumerable.Create: From List' |    10 | 21.03 ns | 0.227 ns | 0.212 ns | 0.055 ns | 21.01 ns | 20.63 ns | 20.88 ns | 21.20 ns | 21.44 ns | 47,543,406.5 |      0.2271 ns |      15.00 |    2.142 |  2.000 |   0.0794 |    4 |            * |       No | 0.0087 |     - |     - |      80 B |     128 B |
 'CachedEnumerable.Create: From List' |    25 | 20.49 ns | 0.292 ns | 0.228 ns | 0.066 ns | 20.53 ns | 20.01 ns | 20.41 ns | 20.61 ns | 20.76 ns | 48,816,112.1 |      0.2922 ns |      12.00 |    2.269 |  2.000 |  -0.6928 |    3 |            * |       No | 0.0087 |     - |     - |      80 B |     128 B |
 'CachedEnumerable.Create: From List' |    50 | 19.99 ns | 0.398 ns | 0.332 ns | 0.092 ns | 20.03 ns | 19.32 ns | 19.97 ns | 20.16 ns | 20.48 ns | 50,037,147.1 |      0.3976 ns |      13.00 |    2.847 |  2.000 |  -0.8371 |    3 |            * |       No | 0.0088 |     - |     - |      80 B |     128 B |
 'CachedEnumerable.Create: From List' |   100 | 18.65 ns | 0.404 ns | 0.592 ns | 0.110 ns | 18.51 ns | 17.85 ns | 18.16 ns | 19.08 ns | 20.31 ns | 53,618,467.8 |      0.4039 ns |      29.00 |    2.984 |  2.000 |   0.7029 |    1 |            * |       No | 0.0087 |     - |     - |      80 B |     128 B |
 'CachedEnumerable.Create: From List' |   250 | 19.31 ns | 0.327 ns | 0.306 ns | 0.079 ns | 19.20 ns | 18.92 ns | 19.07 ns | 19.48 ns | 19.94 ns | 51,799,295.3 |      0.3267 ns |      15.00 |    2.182 |  2.000 |   0.6433 |    2 |            * |       No | 0.0087 |     - |     - |      80 B |     128 B |
 'CachedEnumerable.Create: From List' |   500 | 20.30 ns | 0.448 ns | 1.218 ns | 0.131 ns | 20.59 ns | 17.40 ns | 19.85 ns | 21.09 ns | 22.87 ns | 49,262,958.9 |      0.4477 ns |      86.00 |    2.951 |  2.345 |  -0.6802 |    3 |            * |       No | 0.0086 |     - |     - |      80 B |     128 B |
 'CachedEnumerable.Create: From List' |  1000 | 21.46 ns | 0.255 ns | 0.213 ns | 0.059 ns | 21.51 ns | 20.95 ns | 21.36 ns | 21.60 ns | 21.75 ns | 46,605,366.0 |      0.2547 ns |      13.00 |    3.013 |  2.000 |  -0.8892 |    5 |            * |       No | 0.0087 |     - |     - |      80 B |     128 B |
