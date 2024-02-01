{noformat}

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.3930/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.200-preview.23624.5
  [Host]     : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
  Job-LJBPBB : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
  Job-GJRVUV : .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2

EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Core.BenchmarkTests.Security  
Categories=Encryption  

{noformat}
||Method              ||Runtime  ||Mean       ||Error    ||StdDev    ||StdErr   ||Min        ||Q1         ||Median     ||Q3         ||Max        ||Op/s      ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline ||Code Size ||Allocated ||
| *AesDecrypt*          | *.NET 6.0* | *5,523.6 ns* | *96.12 ns* |  *89.91 ns* | *23.21 ns* | *5,427.5 ns* | *5,446.9 ns* | *5,524.6 ns* | *5,559.6 ns* | *5,694.6 ns* | *181,042.6* |       *96.12 ns* |      *15.00* |    *1.844* |  *2.000* |   *0.5253* |    *5* | ***            | *No*       |   *2,163 B* |  *13.79 KB* |
| AesDecrypt          | .NET 7.0 | 4,930.0 ns | 58.76 ns |  49.07 ns | 13.61 ns | 4,875.3 ns | 4,903.6 ns | 4,910.6 ns | 4,961.4 ns | 5,044.8 ns | 202,840.7 |       58.76 ns |      13.00 |    2.773 |  2.000 |   0.8782 |    3 | *            | No       |   2,892 B |  13.75 KB |
| *AesEncrypt*          | *.NET 6.0* | *4,592.3 ns* | *88.29 ns* | *114.81 ns* | *23.44 ns* | *4,441.1 ns* | *4,493.1 ns* | *4,573.3 ns* | *4,681.9 ns* | *4,818.4 ns* | *217,755.0* |       *88.29 ns* |      *24.00* |    *1.863* |  *2.000* |   *0.3986* |    *2* | ***            | *No*       |   *2,160 B* |   *12.4 KB* |
| AesEncrypt          | .NET 7.0 | 4,239.0 ns | 54.61 ns |  45.60 ns | 12.65 ns | 4,153.5 ns | 4,223.8 ns | 4,232.1 ns | 4,255.6 ns | 4,324.2 ns | 235,905.0 |       54.61 ns |      13.00 |    2.607 |  2.000 |   0.1435 |    1 | *            | No       |   2,889 B |  12.36 KB |
| *SimpleSHA256Decrypt* | *.NET 6.0* | *5,423.0 ns* | *18.19 ns* |  *17.02 ns* |  *4.39 ns* | *5,396.4 ns* | *5,408.2 ns* | *5,426.9 ns* | *5,435.9 ns* | *5,446.3 ns* | *184,400.3* |       *18.19 ns* |      *15.00* |    *1.502* |  *2.000* |  *-0.1471* |    *5* | ***            | *No*       |     *608 B* |  *11.02 KB* |
| SimpleSHA256Decrypt | .NET 7.0 | 5,943.4 ns | 25.38 ns |  23.74 ns |  6.13 ns | 5,904.8 ns | 5,927.5 ns | 5,939.8 ns | 5,962.1 ns | 5,982.8 ns | 168,254.2 |       25.38 ns |      15.00 |    1.743 |  2.000 |  -0.0996 |    7 | *            | No       |     611 B |  10.98 KB |
| *SimpleSHA256Encrypt* | *.NET 6.0* | *5,698.2 ns* | *90.09 ns* |  *84.27 ns* | *21.76 ns* | *5,577.8 ns* | *5,621.1 ns* | *5,701.9 ns* | *5,749.3 ns* | *5,851.8 ns* | *175,494.5* |       *90.09 ns* |      *15.00* |    *1.875* |  *2.000* |   *0.2681* |    *6* | ***            | *No*       |     *605 B* |  *12.63 KB* |
| SimpleSHA256Encrypt | .NET 7.0 | 5,345.1 ns | 61.89 ns |  57.89 ns | 14.95 ns | 5,259.8 ns | 5,304.6 ns | 5,343.6 ns | 5,368.1 ns | 5,456.3 ns | 187,087.5 |       61.89 ns |      15.00 |    1.995 |  2.000 |   0.4190 |    4 | *            | No       |     608 B |  12.59 KB |
