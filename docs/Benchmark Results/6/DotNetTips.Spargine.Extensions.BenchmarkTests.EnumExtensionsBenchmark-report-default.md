
BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.3930/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.200-preview.23624.5
  [Host]     : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
  Job-NOURTH : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
  Job-UZHQTL : .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2

EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  
Categories=Collections  

 Method         | Runtime  | Mean     | Error    | StdDev   | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
--------------- |--------- |---------:|---------:|---------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
 **GetDescription** | **.NET 6.0** | **244.1 ns** |  **2.72 ns** |  **2.55 ns** | **0.66 ns** | **241.7 ns** | **242.2 ns** | **242.8 ns** | **245.3 ns** | **249.1 ns** | **4,096,806.0** |       **2.723 ns** |      **15.00** |    **2.236** |  **2.000** |   **0.9022** |    **2** | *****            | **No**       |     **357 B** |      **24 B** |
 GetDescription | .NET 7.0 | 161.5 ns |  1.12 ns |  1.10 ns | 0.27 ns | 160.0 ns | 160.9 ns | 161.4 ns | 161.6 ns | 163.8 ns | 6,190,933.0 |       1.118 ns |      16.00 |    2.600 |  2.000 |   0.8710 |    1 | *            | No       |     732 B |      24 B |
 **GetItems**       | **.NET 6.0** | **789.6 ns** | **15.71 ns** | **22.02 ns** | **4.24 ns** | **763.5 ns** | **768.0 ns** | **784.7 ns** | **812.6 ns** | **826.6 ns** | **1,266,443.0** |      **15.707 ns** |      **27.00** |    **1.229** |  **3.231** |   **0.1461** |    **4** | *****            | **No**       |     **526 B** |     **512 B** |
 GetItems       | .NET 7.0 | 622.6 ns |  3.06 ns |  2.86 ns | 0.74 ns | 617.5 ns | 620.3 ns | 623.3 ns | 624.4 ns | 627.7 ns | 1,606,146.0 |       3.058 ns |      15.00 |    1.839 |  2.000 |  -0.0366 |    3 | *            | No       |     931 B |     512 B |
