
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.200-preview.21079.7
  [Host]     : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
  Job-MFTHIM : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 5.0  
Namespace=dotNetTips.Spargine.Core.BenchmarkTests  Categories=TypeHelper  

                                     Method |     Mean |    Error |   StdDev |   StdErr |      Min |       Q1 |   Median |       Q3 |      Max |     Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline |   Gen 0 |  Gen 1 | Gen 2 | Allocated | Code Size |
------------------------------------------- |---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |--------:|-------:|------:|----------:|----------:|
 'Looping Collection: Normal StringBuilder' | 42.88 μs | 0.100 μs | 0.094 μs | 0.024 μs | 42.77 μs | 42.80 μs | 42.87 μs | 42.94 μs | 43.05 μs | 23,318.2 |      0.1004 μs |      15.00 |    1.856 |  2.000 |   0.4509 |    1 |            * |       No | 10.8032 | 1.3428 |     - |  91.27 KB |   2.97 KB |
