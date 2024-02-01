
    BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.3930/22H2/2022Update)
    Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
    .NET SDK 8.0.200-preview.23624.5
      [Host]     : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
      Job-NOURTH : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
      Job-UZHQTL : .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2

    EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  
    Categories=**FOR COMPARISON**  

     Method         | Runtime  | Mean     | Error     | StdDev    | StdErr    | Min      | Q1       | Median   | Q3       | Max      | Op/s          | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
    --------------- |--------- |---------:|----------:|----------:|----------:|---------:|---------:|---------:|---------:|---------:|--------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
     'Equals: Guid' | .NET 6.0 | 2.455 ns | 0.0171 ns | 0.0151 ns | 0.0040 ns | 2.436 ns | 2.447 ns | 2.450 ns | 2.461 ns | 2.487 ns | 407,348,383.3 |      0.0171 ns |      14.00 |    2.275 |  2.000 |   0.7678 |    2 | *            | No       |     117 B |         - |
     'Equals: Guid' | .NET 7.0 | 2.319 ns | 0.0196 ns | 0.0183 ns | 0.0047 ns | 2.298 ns | 2.303 ns | 2.315 ns | 2.335 ns | 2.351 ns | 431,286,511.1 |      0.0196 ns |      15.00 |    1.636 |  2.000 |   0.4950 |    1 | *            | No       |     105 B |         - |
