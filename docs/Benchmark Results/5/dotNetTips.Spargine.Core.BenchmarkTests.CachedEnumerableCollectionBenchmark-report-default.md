
BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.985 (20H2/October2020Update)
Unknown processor
.NET SDK=5.0.300
  [Host]     : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
  Job-IWICPT : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 5.0  
Namespace=dotNetTips.Spargine.Core.BenchmarkTests  Categories=CachedEnumerable Class  

                               Method | Count |     Mean |    Error |   StdDev |   StdErr |      Min |       Q1 |   Median |       Q3 |      Max |         Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------------------------- |------ |---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-------:|------:|------:|----------:|
 'CachedEnumerable.Create: From List' |    10 | 14.64 ns | 0.025 ns | 0.020 ns | 0.006 ns | 14.59 ns | 14.64 ns | 14.65 ns | 14.65 ns | 14.67 ns | 68,289,719.3 |      0.0245 ns |      13.00 |    4.099 |  2.000 |  -1.1294 |    2 |            * |       No |     128 B | 0.0087 |     - |     - |      80 B |
 'CachedEnumerable.Create: From List' |    25 | 14.65 ns | 0.054 ns | 0.048 ns | 0.013 ns | 14.60 ns | 14.62 ns | 14.64 ns | 14.65 ns | 14.75 ns | 68,263,880.1 |      0.0536 ns |      14.00 |    2.711 |  2.000 |   0.9921 |    2 |            * |       No |     128 B | 0.0089 |     - |     - |      80 B |
 'CachedEnumerable.Create: From List' |    50 | 14.64 ns | 0.038 ns | 0.036 ns | 0.009 ns | 14.59 ns | 14.60 ns | 14.63 ns | 14.67 ns | 14.69 ns | 68,320,948.7 |      0.0383 ns |      15.00 |    1.417 |  2.000 |   0.2932 |    2 |            * |       No |     128 B | 0.0088 |     - |     - |      80 B |
 'CachedEnumerable.Create: From List' |   100 | 14.23 ns | 0.017 ns | 0.015 ns | 0.004 ns | 14.20 ns | 14.22 ns | 14.23 ns | 14.23 ns | 14.25 ns | 70,291,245.9 |      0.0166 ns |      14.00 |    1.992 |  2.000 |  -0.1335 |    1 |            * |       No |     128 B | 0.0087 |     - |     - |      80 B |
 'CachedEnumerable.Create: From List' |   250 | 14.23 ns | 0.030 ns | 0.025 ns | 0.007 ns | 14.16 ns | 14.23 ns | 14.23 ns | 14.24 ns | 14.25 ns | 70,279,793.1 |      0.0296 ns |      13.00 |    5.273 |  2.000 |  -1.6966 |    1 |            * |       No |     128 B | 0.0087 |     - |     - |      80 B |
 'CachedEnumerable.Create: From List' |   500 | 14.66 ns | 0.060 ns | 0.050 ns | 0.014 ns | 14.59 ns | 14.63 ns | 14.65 ns | 14.66 ns | 14.76 ns | 68,230,219.3 |      0.0596 ns |      13.00 |    2.970 |  2.000 |   1.0190 |    2 |            * |       No |     128 B | 0.0087 |     - |     - |      80 B |
 'CachedEnumerable.Create: From List' |  1000 | 14.74 ns | 0.101 ns | 0.094 ns | 0.024 ns | 14.65 ns | 14.67 ns | 14.69 ns | 14.80 ns | 14.91 ns | 67,839,283.2 |      0.1005 ns |      15.00 |    1.851 |  2.000 |   0.7519 |    2 |            * |       No |     128 B | 0.0086 |     - |     - |      80 B |
