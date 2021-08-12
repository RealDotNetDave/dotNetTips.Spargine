{noformat}

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Unknown processor
.NET SDK=6.0.100-preview.7.21379.14
  [Host]     : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
  Job-UTOYIO : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 5.0  
Namespace=dotNetTips.Spargine.Core.BenchmarkTests.Security  Categories=EncryptionHelper  

{noformat}
||       Method ||    Mean ||    Error ||   StdDev ||   StdErr ||     Min ||      Q1 ||  Median ||      Q3 ||     Max ||     Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline || Gen 0 ||Code Size || Gen 1 ||Allocated ||
|    *AesDecrypt* | *6.073 μs* | *0.0089 μs* | *0.0079 μs* | *0.0021 μs* | *6.063 μs* | *6.068 μs* | *6.070 μs* | *6.076 μs* | *6.091 μs* | *164,656.5* |      *0.0089 μs* |      *14.00* |    *2.905* |  *2.000* |    *1.017* |    *2* |            *** |       *No* | *1.5259* |      *1 KB* |      *-* |     *14 KB* |
|    *AesEncrypt* | *5.072 μs* | *0.0227 μs* | *0.0201 μs* | *0.0054 μs* | *5.007 μs* | *5.070 μs* | *5.075 μs* | *5.081 μs* | *5.095 μs* | *197,171.0* |      *0.0227 μs* |      *14.00* |    *7.703* |  *2.000* |   *-2.204* |    *1* |            *** |       *No* | *1.3962* |      *1 KB* | *0.0076* |     *12 KB* |
| *SimpleDecrypt* | *7.728 μs* | *0.0382 μs* | *0.0339 μs* | *0.0091 μs* | *7.615 μs* | *7.732 μs* | *7.737 μs* | *7.743 μs* | *7.748 μs* | *129,399.7* |      *0.0382 μs* |      *14.00* |    *8.994* |  *2.000* |   *-2.631* |    *4* |            *** |       *No* | *1.0681* |      *1 KB* |      *-* |     *10 KB* |
| *SimpleEncrypt* | *6.546 μs* | *0.0177 μs* | *0.0157 μs* | *0.0042 μs* | *6.497 μs* | *6.542 μs* | *6.551 μs* | *6.552 μs* | *6.562 μs* | *152,774.0* |      *0.0177 μs* |      *14.00* |    *6.959* |  *2.000* |   *-2.072* |    *3* |            *** |       *No* | *1.4801* |      *1 KB* | *0.0153* |     *13 KB* |
