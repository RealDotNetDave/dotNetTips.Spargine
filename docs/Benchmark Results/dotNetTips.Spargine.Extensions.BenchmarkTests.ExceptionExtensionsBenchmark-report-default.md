
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.200-preview.21079.7
  [Host]     : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
  Job-JTTEDA : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 5.0  
Namespace=dotNetTips.Spargine.Extensions.BenchmarkTests  Categories=ExceptionExtensions  

         Method |     Mean |   Error |  StdDev |  StdErr |      Min |       Q1 |   Median |       Q3 |      Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline |  Gen 0 | Gen 1 | Gen 2 | Allocated | Code Size |
--------------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|------:|------:|----------:|----------:|
 GetAllMessages | 201.8 ns | 0.33 ns | 0.31 ns | 0.08 ns | 200.9 ns | 201.7 ns | 201.8 ns | 202.0 ns | 202.2 ns | 4,956,238.3 |      0.3313 ns |      15.00 |    4.032 |  2.000 |   -1.153 |    1 |            * |       No | 0.0305 |     - |     - |     280 B |     381 B |
