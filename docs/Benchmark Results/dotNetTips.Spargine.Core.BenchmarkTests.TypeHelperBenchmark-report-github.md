``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.200-preview.21079.7
  [Host]     : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
  Job-FKHTBO : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 5.0  
Namespace=dotNetTips.Spargine.Core.BenchmarkTests  Categories=TypeHelper  

```
|                                     Method |     Mean |    Error |   StdDev |   StdErr |      Min |       Q1 |   Median |       Q3 |      Max |     Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|------------------------------------------- |---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|--------:|-------:|------:|----------:|
| &#39;Looping Collection: Normal StringBuilder&#39; | 43.36 μs | 0.093 μs | 0.087 μs | 0.023 μs | 43.20 μs | 43.30 μs | 43.33 μs | 43.42 μs | 43.52 μs | 23,064.4 |      0.0932 μs |      15.00 |    1.963 |  2.000 |   0.0881 |    1 |            * |       No |   2.97 KB | 10.7422 | 1.6479 |     - |  92.26 KB |
