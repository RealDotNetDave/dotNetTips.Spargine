{noformat}

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1682 (21H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.300-preview.22204.3
  [Host]     : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
  Job-URPYHK : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 6.0  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests.Serialization  

{noformat}
||                          Method ||        Categories ||     Mean ||    Error ||   StdDev ||   StdErr ||      Min ||       Q1 ||   Median ||       Q3 ||      Max ||     Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline || Gen 0 ||Code Size || Gen 1 ||Allocated ||
| *'Deserialize: JSON-PersonProper'* |      *Serialization* |  *2.653 μs* | *0.0265 μs* | *0.0248 μs* | *0.0064 μs* |  *2.619 μs* |  *2.632 μs* |  *2.651 μs* |  *2.670 μs* |  *2.695 μs* | *376,877.5* |      *0.0265 μs* |      *15.00* |    *1.580* |  *2.000* |   *0.1498* |    *2* |            *** |       *No* | *0.0763* |     *297 B* |      *-* |     *712 B* |
| *'Deserialize: JSON-PersonRecord'* |      *Serialization* |  *7.665 μs* | *0.0810 μs* | *0.0758 μs* | *0.0196 μs* |  *7.545 μs* |  *7.608 μs* |  *7.643 μs* |  *7.726 μs* |  *7.796 μs* | *130,456.1* |      *0.0810 μs* |      *15.00* |    *1.733* |  *2.000* |   *0.3094* |    *4* |            *** |       *No* | *0.2747* |     *297 B* |      *-* |   *2,584 B* |
|  *'Deserialize: XML=PersonProper'* |  *XML,Serialization* | *19.439 μs* | *0.2309 μs* | *0.2160 μs* | *0.0558 μs* | *19.098 μs* | *19.253 μs* | *19.464 μs* | *19.606 μs* | *19.823 μs* |  *51,443.1* |      *0.2309 μs* |      *15.00* |    *1.616* |  *2.000* |  *-0.0680* |    *7* |            *** |       *No* | *1.9836* |     *679 B* | *0.0305* |  *18,412 B* |
|  *'Deserialize: XML=PersonRecord'* |  *XML,Serialization* | *15.210 μs* | *0.1313 μs* | *0.1228 μs* | *0.0317 μs* | *14.974 μs* | *15.146 μs* | *15.208 μs* | *15.311 μs* | *15.399 μs* |  *65,745.4* |      *0.1313 μs* |      *15.00* |    *1.950* |  *2.000* |  *-0.2412* |    *6* |            *** |       *No* | *1.9531* |     *679 B* | *0.0305* |  *18,180 B* |
|   *'Serialize: JSON=PersonProper'* | *JSON,Serialization* |  *1.570 μs* | *0.0157 μs* | *0.0139 μs* | *0.0037 μs* |  *1.544 μs* |  *1.563 μs* |  *1.568 μs* |  *1.581 μs* |  *1.596 μs* | *637,139.4* |      *0.0157 μs* |      *14.00* |    *2.184* |  *2.000* |   *0.0295* |    *1* |            *** |       *No* | *0.1259* |     *530 B* |      *-* |   *1,152 B* |
|   *'Serialize: JSON=PersonRecord'* | *JSON,Serialization* |  *2.830 μs* | *0.0498 μs* | *0.0466 μs* | *0.0120 μs* |  *2.746 μs* |  *2.798 μs* |  *2.833 μs* |  *2.859 μs* |  *2.917 μs* | *353,314.2* |      *0.0498 μs* |      *15.00* |    *2.083* |  *2.000* |  *-0.0184* |    *3* |            *** |       *No* | *0.2594* |     *530 B* |      *-* |   *2,392 B* |
|    *'Serialize: XML=PersonProper'* |  *XML,Serialization* | *15.167 μs* | *0.0910 μs* | *0.0760 μs* | *0.0211 μs* | *15.018 μs* | *15.141 μs* | *15.192 μs* | *15.217 μs* | *15.302 μs* |  *65,932.4* |      *0.0910 μs* |      *13.00* |    *2.597* |  *2.000* |  *-0.4603* |    *6* |            *** |       *No* | *2.2888* |     *724 B* |      *-* |  *20,798 B* |
|                *StringToXDocument* |  *XML,Serialization* |  *9.020 μs* | *0.0872 μs* | *0.0815 μs* | *0.0211 μs* |  *8.879 μs* |  *8.967 μs* |  *9.018 μs* |  *9.071 μs* |  *9.200 μs* | *110,865.7* |      *0.0872 μs* |      *15.00* |    *2.509* |  *2.000* |   *0.3572* |    *5* |            *** |       *No* | *1.7090* |     *231 B* | *0.0305* |  *15,888 B* |
