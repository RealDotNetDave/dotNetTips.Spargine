{noformat}

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.300
  [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  Job-XJCAYH : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 6.0  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests.Serialization  

{noformat}
||                          Method ||        Categories ||     Mean ||    Error ||   StdDev ||   StdErr ||      Min ||       Q1 ||   Median ||       Q3 ||      Max ||     Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline || Gen 0 ||Code Size || Gen 1 ||Allocated ||
| *'Deserialize: JSON-PersonProper'* |      *Serialization* |  *2.732 μs* | *0.0216 μs* | *0.0191 μs* | *0.0051 μs* |  *2.703 μs* |  *2.716 μs* |  *2.736 μs* |  *2.741 μs* |  *2.770 μs* | *366,068.1* |      *0.0216 μs* |      *14.00* |    *2.118* |  *2.000* |   *0.1035* |    *2* |            *** |       *No* | *0.0763* |     *260 B* |      *-* |     *712 B* |
| *'Deserialize: JSON-PersonRecord'* |      *Serialization* |  *7.797 μs* | *0.0882 μs* | *0.0825 μs* | *0.0213 μs* |  *7.691 μs* |  *7.730 μs* |  *7.776 μs* |  *7.861 μs* |  *7.968 μs* | *128,259.8* |      *0.0882 μs* |      *15.00* |    *1.904* |  *2.000* |   *0.4370* |    *4* |            *** |       *No* | *0.2899* |     *260 B* |      *-* |   *2,584 B* |
|  *'Deserialize: XML=PersonProper'* |  *XML,Serialization* | *20.424 μs* | *0.2196 μs* | *0.1947 μs* | *0.0520 μs* | *20.149 μs* | *20.264 μs* | *20.444 μs* | *20.532 μs* | *20.729 μs* |  *48,960.9* |      *0.2196 μs* |      *14.00* |    *1.602* |  *2.000* |  *-0.0120* |    *8* |            *** |       *No* | *1.9836* |     *652 B* | *0.0305* |  *18,412 B* |
|  *'Deserialize: XML=PersonRecord'* |  *XML,Serialization* | *15.752 μs* | *0.2698 μs* | *0.2253 μs* | *0.0625 μs* | *15.340 μs* | *15.572 μs* | *15.801 μs* | *15.924 μs* | *16.159 μs* |  *63,482.9* |      *0.2698 μs* |      *13.00* |    *1.998* |  *2.000* |  *-0.0883* |    *6* |            *** |       *No* | *1.9531* |     *652 B* |      *-* |  *18,180 B* |
|   *'Serialize: JSON=PersonProper'* | *JSON,Serialization* |  *1.696 μs* | *0.0199 μs* | *0.0186 μs* | *0.0048 μs* |  *1.664 μs* |  *1.683 μs* |  *1.694 μs* |  *1.711 μs* |  *1.733 μs* | *589,516.7* |      *0.0199 μs* |      *15.00* |    *2.041* |  *2.000* |   *0.2016* |    *1* |            *** |       *No* | *0.1259* |     *456 B* |      *-* |   *1,160 B* |
|   *'Serialize: JSON=PersonRecord'* | *JSON,Serialization* |  *3.046 μs* | *0.0432 μs* | *0.0383 μs* | *0.0102 μs* |  *2.976 μs* |  *3.028 μs* |  *3.056 μs* |  *3.079 μs* |  *3.087 μs* | *328,293.0* |      *0.0432 μs* |      *14.00* |    *1.733* |  *2.000* |  *-0.5418* |    *3* |            *** |       *No* | *0.2594* |     *456 B* |      *-* |   *2,368 B* |
|    *'Serialize: XML=PersonProper'* |  *XML,Serialization* | *16.158 μs* | *0.1870 μs* | *0.1561 μs* | *0.0433 μs* | *15.897 μs* | *16.109 μs* | *16.164 μs* | *16.256 μs* | *16.415 μs* |  *61,889.3* |      *0.1870 μs* |      *13.00* |    *1.918* |  *2.000* |  *-0.2923* |    *7* |            *** |       *No* | *2.2888* |     *611 B* | *0.0305* |  *20,814 B* |
|                *StringToXDocument* |  *XML,Serialization* |  *9.300 μs* | *0.1489 μs* | *0.1320 μs* | *0.0353 μs* |  *9.097 μs* |  *9.181 μs* |  *9.341 μs* |  *9.402 μs* |  *9.498 μs* | *107,522.2* |      *0.1489 μs* |      *14.00* |    *1.514* |  *2.000* |  *-0.3130* |    *5* |            *** |       *No* | *1.7090* |     *198 B* | *0.0305* |  *15,888 B* |
