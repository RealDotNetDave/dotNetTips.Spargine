
    BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
    Unknown processor
    .NET Core SDK=5.0.200-preview.21079.7
      [Host]     : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
      Job-HSBDIC : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

    EvaluateOverhead=True  Server=True  Toolchain=.NET Core 5.0  
    Namespace=dotNetTips.Spargine.Extensions.BenchmarkTests  Categories=ExceptionExtensions  

             Method |     Mean |   Error |  StdDev |  StdErr |      Min |       Q1 |   Median |       Q3 |      Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size |  Gen 0 | Gen 1 | Gen 2 | Allocated |
    --------------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-------:|------:|------:|----------:|
     GetAllMessages | 203.0 ns | 1.48 ns | 1.38 ns | 0.36 ns | 198.3 ns | 203.0 ns | 203.5 ns | 203.6 ns | 203.9 ns | 4,926,426.1 |       1.479 ns |      15.00 |    8.949 |  2.000 |   -2.568 |    1 |            * |       No |     381 B | 0.0305 |     - |     - |     280 B |
